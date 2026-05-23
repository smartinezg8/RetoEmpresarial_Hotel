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
    public partial class UCMiReserva : UserControl
    {
        private Reserva reservaSeleccionada;
        private List<Reserva> reservasActuales = new List<Reserva>();
        public UCMiReserva()
        {
            InitializeComponent();
            panelDetalles.Visible = false;    
        }
        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            panelDetalles.Visible = false;
            reservaSeleccionada = null;

            //Manejo de errores con el label
            if (string.IsNullOrEmpty(txtCodigoReserva.Text))
            {
                lblMensaje.Text = "Debe ingresar el dato solicitado";
                return;
            }
            if (!int.TryParse(txtCodigoReserva.Text, out int codigo))
            {
                lblMensaje.Text = "El valor ingresado no es válido";
                return;
            }
            //Primero busca por documento de identificación
            Cliente cliente = Form1.hotel.Clientes.BuscarPorDocumento(codigo);
            if (cliente != null)
            {
                reservasActuales = cliente.historial.FindAll(r => r.Estado);
                CargarReservas(reservasActuales);
                return;
            }
            //En caso de que no haya encontrado documento, busca por el código de reserva
            Reserva reserva = Form1.hotel.Reservas.BuscarPorId(codigo);
            if (reserva != null && reserva.Estado)
            {
                reservasActuales = new List<Reserva> { reserva };
                CargarReservas(reservasActuales);
                return;
            }
            dgvReservas.Rows.Clear();
            lblMensaje.Text = "No se encontraron reservas activas";

        }
        public void CargarReservas(List<Reserva> reservas)
        {
            dgvReservas.Rows.Clear();
            foreach (Reserva r in reservas)
            {
                dgvReservas.Rows.Add(
                    r.IDReserva,
                    r.Habitacion.numero,
                    ObtenerNombreTipo(r.Habitacion.tipo),
                    r.FechaEntrada.ToString("yyyy-MM-dd"),
                    r.NumNoches,
                    "$" + r.CalcularCosto()
                );
            }
        }
        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells[0].Value);
            Reserva reserva = Form1.hotel.Reservas.BuscarPorId(id);
            if (reserva == null) return;

            reservaSeleccionada = reserva;

            lblCodigo.Text = reserva.IDReserva.ToString();
            lblHabitacion.Text = reserva.Habitacion.numero;
            lblTipo.Text = ObtenerNombreTipo(reserva.Habitacion.tipo);
            lblFechas.Text = reserva.FechaEntrada.ToString("yyyy-MM-dd") + " - " + reserva.FechaSalida.ToString("yyyy-MM-dd");
            lblTotal.Text = "$" + reserva.CalcularCosto();
            lblServicios.Text = "";

            foreach (Servicio s in reserva.Servicios)
            {
                lblServicios.Text += "- " + s.nombre + "\n";
            }

            if (reserva.promocionAplicada != null)
            {
                lblPromocion.Text = reserva.promocionAplicada.nombre;
            }
            else
            {
                lblPromocion.Text = "Sin promoción";
            }
            panelDetalles.Visible = true;
        }
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            lblErrorCancelar.Text = "";
            if (reservaSeleccionada == null) return;

            if (DateTime.Now.Date >= reservaSeleccionada.FechaEntrada.Date)
            {
                lblErrorCancelar.Text = "No se puede cancelar una reserva en curso";
                return;
            }
            reservaSeleccionada.Cancelar();

            // Eliminar fila
            dgvReservas.Rows.RemoveAt(dgvReservas.SelectedRows[0].Index);
            panelDetalles.Visible = false;
            reservaSeleccionada = null;

        }
        private string ObtenerNombreTipo(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return "Simple";

                case 2:
                    return "Doble";

                case 3:
                    return "Matrimonial";

                default:
                    return "Desconocido";
            }
        }      
    }
}
