using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velisse.Core;

namespace RetoEmpresarial_Hotel
{
    public partial class UCProyeccion : UserControl
    {
        public UCProyeccion()
        {
            InitializeComponent();
        }
        private Administrador admin;
        private void UCProyeccion_Load(object sender, EventArgs e)
        {
            admin = new Administrador("Admin", 1, Form1.hotel);

            //Llenamos el comboBox con los meses del año
            cmbMes.Items.AddRange(new string[] 
            { 
                "Enero", 
                "Febrero", 
                "Marzo", 
                "Abril", 
                "Mayo", 
                "Junio", 
                "Julio", 
                "Agosto", 
                "Septiembre", 
                "Octubre", 
                "Noviembre", 
                "Diciembre" 
            });
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = admin.CalcularIngresosProyectados();
            lblResultado.Text = $"Ingresos proyectados: \n${total:F2}";
        }
    }
}
