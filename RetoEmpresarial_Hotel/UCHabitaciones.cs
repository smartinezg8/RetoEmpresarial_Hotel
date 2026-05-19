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
    }
}
