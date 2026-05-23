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
    public partial class UCServicios : UserControl
    {
        public UCServicios()
        {
            InitializeComponent();
        }
        private Cliente cliente;
        private void UCServicios_Load(object sender, EventArgs e)
        {
            cliente = Form1.ClienteActual;
            if (cliente == null)
            {
                MessageBox.Show("Debe iniciar sesión");
                return;
            }
            CargarReservas();
            CargarServicios();
        }
        private void CargarReservas()
        {
            cmbReservas.Items.Clear();

            foreach (Reserva r in cliente.historial)
            {
                if (!r.Estado) continue;

                cmbReservas.Items.Add("Reserva #" + r.IDReserva + " - Habitación " + r.Habitacion.numero);
            }
        }
        private void CargarServicios()
        {
            cmbServicio.Items.Clear();

            foreach (Servicio s in Servicio.Catalogo())
            {
                cmbServicio.Items.Add(s.nombre);
            }
        }
        private Reserva ObtenerReservaSeleccionada()
        {
            if (cmbReservas.SelectedIndex < 0)
                return null;

            List<Reserva> activas = cliente.historial.FindAll(r => r.Estado);

            return activas[cmbReservas.SelectedIndex];
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedItem == null) return;
            string nombre = cmbServicio.SelectedItem.ToString();
            foreach (Servicio s in Servicio.Catalogo())
            {
                if (s.nombre == nombre)
                {
                    lblCosto.Text = "Costo: " + s.costo.ToString("C2");
                    break;
                }
            }
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (cmbReservas.SelectedItem == null || cmbServicio.SelectedItem == null)
            {
                lblError.Text = "Debe completar todos los campos";
                return;
            }

            Reserva reserva = ObtenerReservaSeleccionada();
            string nombreServicio = cmbServicio.SelectedItem.ToString();
            int indiceServicio = -1;
            List<Servicio> catalogo = Servicio.Catalogo();

            for (int i = 0; i < catalogo.Count; i++)
            {
                if (catalogo[i].nombre == nombreServicio)
                {
                    indiceServicio = i;
                    break;
                }
            }
            bool agregado = cliente.SolicitarServicio(reserva.IDReserva, indiceServicio);

            if (!agregado)
            {
                lblError.Text = "No se pudo solicitar el servicio";
                return;
            }
            
            lblError.Text = "Servicio solicitado exitosamente";
            cmbServicio.SelectedIndex = -1;
        }
    }
}
