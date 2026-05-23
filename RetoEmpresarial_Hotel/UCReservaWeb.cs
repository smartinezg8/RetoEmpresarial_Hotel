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
    public partial class UCReservaWeb : UserControl
    {
        Cliente clienteActual;
        int tipoSeleccionado;
        DateTime fechaEntrada;
        int noches;
        Promocion promocionAplicada = null;

        public UCReservaWeb()
        {
            InitializeComponent();
            cmbTipoHabitacion.Items.Add("Simple");
            cmbTipoHabitacion.Items.Add("Doble");
            cmbTipoHabitacion.Items.Add("Matrimonial");

            panelReserva.Visible = false;
            panelCodigo.Visible = false;
        }

        private void UCReservaWeb_Load(object sender, EventArgs e)
        {           
            dtpFechaEntrada.MinDate = DateTime.Today;
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            // Reiniciar estado de paneles
            panelReserva.Visible = false;
            panelCodigo.Visible = false;
            promocionAplicada = null;
            txtPromo.Clear();
            lblMensajePromo.Text = "";

            //Mensaje error
            if (txtNombre.Text == "" || txtID.Text == "" || cmbTipoHabitacion.SelectedIndex == -1)
            {
                lblEstado.Text = "Debe completar todos los campos";
                return;
            }

            //El ID debe ser numérico
            if (!int.TryParse(txtID.Text, out int documento))
            {
                lblEstado.Text = "El ID debe ser un número";
                return;
            }

            // Obtener datos seleccionados
            tipoSeleccionado = cmbTipoHabitacion.SelectedIndex + 1;
            fechaEntrada = dtpFechaEntrada.Value.Date;
            noches = (int)nudNoches.Value;

            
            List<Habitacion> disponibles = Form1.hotel.Habitaciones.ListarDisponiblesPorTipo(tipoSeleccionado);

            if (disponibles.Count == 0)
            {
                lblEstado.Text = "No hay habitaciones disponibles";
                return;
            }
            panelReserva.Visible = true;

        
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            int documento = Convert.ToInt32(txtID.Text);
            Cliente existente = Form1.hotel.Clientes.BuscarPorDocumento(documento);

            if (existente != null)
            {
                clienteActual = existente;
            }
            else
            {
                clienteActual = new Cliente(txtNombre.Text, documento, Form1.hotel);
                Form1.hotel.Clientes.Registrar(clienteActual);
            }

            bool aplicarPromo = promocionAplicada != null;

            Reserva reserva = clienteActual.RealizarReservaWeb(tipoSeleccionado,fechaEntrada,noches,aplicarPromo);

           
            if (reserva == null)
            {
                lblEstado.Text = "No se pudo crear la reserva.";
                return;
            }
            Form1.ClienteActual = clienteActual;
           
            lblCodigo.Text = reserva.IDReserva.ToString();
            panelCodigo.Visible = true;

            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtID.Clear();
            cmbTipoHabitacion.SelectedIndex = -1;
            nudNoches.Value = 1;
            panelReserva.Visible = false;
            lblEstado.Text = "";
        }

        private void btnAplicarPromo_Click(object sender, EventArgs e)
        {
            lblMensajePromo.Text = "";
            if (string.IsNullOrEmpty(txtPromo.Text))
            {
                lblMensajePromo.Text = "Debe ingresar un ID de promoción";
                return;
            }
            if (!int.TryParse(txtPromo.Text, out int idPromo))
            {
                lblMensajePromo.Text = "El ID debe ser un número";
                return;
            }
            if (idPromo >= 1 && idPromo <= Form1.hotel.Promociones.Count)
            {
                Promocion promo = Form1.hotel.Promociones[idPromo - 1]; 

                if (promo.EsAplicable(tipoSeleccionado, fechaEntrada))
                {
                    promocionAplicada = promo;
                    lblMensajePromo.Text = $"Promoción '{promo.nombre}' aplicada: {promo.descuento}% de descuento";
                    lblMensajePromo.ForeColor = Color.Green;
                }
                else
                {
                    lblMensajePromo.Text = "La promoción no es aplicable la habitación o fecha";
                    lblMensajePromo.ForeColor = Color.Red;
                    promocionAplicada = null;
                }
            }
            else
            {
                lblMensajePromo.Text = "No se encontró una promoción con ese ID";
                lblMensajePromo.ForeColor = Color.Red;
                promocionAplicada = null;
            }
            
        }
    }
}
