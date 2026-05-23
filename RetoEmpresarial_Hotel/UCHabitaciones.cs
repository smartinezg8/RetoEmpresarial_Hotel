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
    public partial class UCHabitaciones : UserControl
    {
        public UCHabitaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            UCHabitacionesDetallescs detalles = new UCHabitacionesDetallescs();
            Form1 form = (Form1)this.FindForm();
            form.MostrarVista(detalles);
            
        }

        private void UCHabitaciones_Load(object sender, EventArgs e)
        {
            double precioSimple = 0;
            double precioDoble = 0;
            double precioMatrimonial = 0;

            foreach (var h in Form1.hotel.Habitaciones.ListarTodas())
            {
                if (h.tipo == 1 && precioSimple == 0) precioSimple = h.precioPorNoche;
                if (h.tipo == 2 && precioDoble == 0) precioDoble = h.precioPorNoche;
                if (h.tipo == 3 && precioMatrimonial == 0) precioMatrimonial = h.precioPorNoche;
            }

            lblPrecioSimple.Text = $"${precioSimple} por noche";
            lblPrecioDoble.Text = $"${precioDoble} por noche";
            lblPrecioMatr.Text = $"${precioMatrimonial} por noche";
        }
    }
}
