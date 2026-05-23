using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoEmpresarial_Hotel
{
    public partial class UCReportes : UserControl
    {
        public UCReportes()
        {
            InitializeComponent();
        }

        private void UCReportes_Load(object sender, EventArgs e)
        {
            CargarReporteOcupacion();
            CargarReporteWebVsPresencial();

            pnlIngresosPeriodo.Visible = false;
            
        }
        private void CargarReporteOcupacion()
        {
            //Aquí ya muestra el resultado
            lblOcupacion.Text = Form1.hotel.Reportes.OcupacionPorTipo();

            //Para llenar el chart
            int simples = 0;
            int dobles = 0;
            int matrimoniales = 0;

            foreach(var h in Form1.hotel.Habitaciones.ListarTodas())
            {
                if(!h.EstaDisponible())
                {
                    if (h.tipo == 1) simples++;
                    else if (h.tipo == 2) dobles++;
                    else if (h.tipo == 3) matrimoniales++;
                }     
            }
            chartOcupacion.Series[0].Points.Clear();
            chartOcupacion.Series[0].Points.AddXY("Simple", simples);
            chartOcupacion.Series[0].Points.AddXY("Doble", dobles);
            chartOcupacion.Series[0].Points.AddXY("Matrimonial", matrimoniales);
        }

        private void CargarReporteWebVsPresencial()
        {
            //Resultado del reporte
            lblWebPresencial.Text = Form1.hotel.Reportes.WebVsPresencial();

            //Chart
            int web = 0;
            int presencial = 0;

            foreach(var r in Form1.hotel.Reservas.Listar())
            {
                if (r.origen == "Web") web++;
                else if (r.origen == "Presencial") presencial++;
            }
            chartWeb.Series[0].Points.Clear();

            chartWeb.Series[0].Points.AddXY("Web", web);

            chartWeb.Series[0].Points.AddXY("Presencial", presencial);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpIni.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            double ingresos = Form1.hotel.Reportes.IngresosPorPeriodo(inicio, fin);
            pnlIngresosPeriodo.Visible = true;

            lblIngresosPeriodo.Text = $"Ingresos del período: \n${ingresos:F2}";

            //Chart
            chartIngresos.Series[0].Points.Clear();
            chartIngresos.Series[0].Points.AddXY(inicio.ToShortDateString(),ingresos);
            chartIngresos.Series[0].Points.AddXY(fin.ToShortDateString(),ingresos);

        }
    }
}
