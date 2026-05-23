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
    public partial class UCModificarPrecios : UserControl
    {
        public UCModificarPrecios()
        {
            InitializeComponent();
        }

        private void UCModificarPrecios_Load(object sender, EventArgs e)
        {
            RefrescarPrecios();
        }

        //Colocarle a los label los precios actuales de cada tipo de habitación
        private void RefrescarPrecios()
        {
            foreach (var h in Form1.hotel.Habitaciones.ListarTodas())
            {
                if (h.tipo == 1) lblActualSimple.Text = $"Actual: ${h.precioPorNoche:F2}";
                else if (h.tipo == 2) lblActualDoble.Text = $"Actual: ${h.precioPorNoche:F2}";
                else if (h.tipo == 3) lblActualMatrimonial.Text = $"Actual: ${h.precioPorNoche:F2}";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            Administrador admin = new Administrador("Admin", 1, Form1.hotel);

            if (double.TryParse(txtSimple.Text, out double simple))
            {
                admin.ModificarCostoHabitacion(1, simple);
            }

            if (double.TryParse(txtDoble.Text, out double doble))
            {
                admin.ModificarCostoHabitacion(2, doble);
            }

            if (double.TryParse(txtMatrimonial.Text, out double matri))
            {
                admin.ModificarCostoHabitacion(3, matri);
            }


            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Text = "Precios actualizados";
            txtSimple.Clear();
            txtDoble.Clear();
            txtMatrimonial.Clear();
            RefrescarPrecios();
        }
    }
}
