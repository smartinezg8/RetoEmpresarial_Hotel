using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velisse.Core;

namespace RetoEmpresarial_Hotel
{
    public partial class UCPrecioEstancia : UserControl
    {
        public UCPrecioEstancia()
        {
            InitializeComponent();
        }
        private Personal personal;
        private Reserva reservaActual;
        private void UCPrecioEstancia_Load(object sender, EventArgs e)
        {
            personal = new Personal("Recepcionista",2,Form1.hotel);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (!int.TryParse(txtReserva.Text, out int id))
            {
                lblError.Text = "Código inválido";
                return;
            }

            Reserva reserva = personal.CalcularCostoEstancia(id);

            if (reserva == null)
            {
                lblError.Text = "No se encontró una reserva activa";
                return;
            }
            reservaActual = reserva;

            lblHabitacion.Text = reserva.Habitacion.numero;
            lblNoches.Text = reserva.NumNoches.ToString();
            lblEstado.Text = reserva.Estado ? "Activa" : "Finalizada";
            lblPromocion.Text = reserva.promocionAplicada != null
                ? reserva.promocionAplicada.nombre
                : "Sin promoción";

            lblServicios.Text = "";

            foreach (var s in reserva.Servicios)
            {
                lblServicios.Text += s.nombre + "\n";
            }

            lblTotal.Text = "$" + reserva.CalcularCosto();
            btnFinalizar.Enabled = reserva.Estado;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (reservaActual == null)
                return;

            bool finalizada = personal.FinalizarEstancia(reservaActual.IDReserva);

            if (!finalizada)
            {
                return;
            }

            lblEstado.Text = "Finalizada";
            btnFinalizar.Enabled = false;
        }
    }
}
