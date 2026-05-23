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
    public partial class UCVerReservas : UserControl
    {
        public UCVerReservas()
        {
            InitializeComponent();
        }

        private Personal personal;
        private void UCVerReservas_Load(object sender, EventArgs e)
        {
            personal = new Personal("Recepcionista", 2, Form1.hotel);
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Simple");
            cmbTipo.Items.Add("Doble");
            cmbTipo.Items.Add("Matrimonial");
            dtpFechaEntrada.MinDate = DateTime.Today;

            CargarReservas();
        }

        //Llenar el comboBox de habitaciones disponibles según el tipo seleccionado
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHabitacion.Items.Clear();
            int tipo = cmbTipo.SelectedIndex + 1;

            var disponibles = Form1.hotel.Habitaciones.ListarDisponiblesPorTipo(tipo);

            foreach(var h in disponibles)
            {
                cmbHabitacion.Items.Add(h.numero);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDocumento.Text, out int documento))
            {
                MessageBox.Show("Documento inválido");
                return;
            }

            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbHabitacion.Text))
            {
                MessageBox.Show("Seleccione una habitación");
                return;
            }

            Reserva r = personal.RegistrarReservaPresencial(
                documento,
                txtNombre.Text,
                cmbTipo.SelectedIndex + 1,
                cmbHabitacion.Text,
                dtpFechaEntrada.Value.Date,
                (int)nudNoches.Value
                );

            if ( r == null )
            {
                return;
            }
            ConfigurarTabla();
            CargarReservas();
            LimpiarCampos();
        }

        private void ConfigurarTabla()
        {
            dgvReservas.AllowUserToAddRows = false;
            DataGridViewComboBoxColumn colTipo = (DataGridViewComboBoxColumn)dgvReservas.Columns["colTipo"];

            colTipo.Items.Clear();
            colTipo.Items.Add("Simple");
            colTipo.Items.Add("Doble");
            colTipo.Items.Add("Matrimonial");

            DataGridViewComboBoxColumn colHabitacion = (DataGridViewComboBoxColumn)dgvReservas.Columns["colHabitacion"];
            colHabitacion.Items.Clear();
            foreach (Habitacion h in Form1.hotel.Habitaciones.ListarTodas())
            {
                colHabitacion.Items.Add(h.numero);
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string columna = dgvReservas.Columns[e.ColumnIndex].Name;

            if (columna == "colEliminar")
            {
                int idReserva = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["colID"].Value);
                personal.CancelarReserva(idReserva);
                CargarReservas();
            }

            if (columna == "colGuardar")
            {
                int idReserva = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["colID"].Value);
                string nuevaHabitacion = dgvReservas.Rows[e.RowIndex].Cells["colHabitacion"].Value?.ToString();
                bool modificado = personal.ModificarHabitacion(idReserva, nuevaHabitacion);

                if (modificado)
                {
                    CargarReservas();
                }
            }
        }

        private void CargarReservas()
        {
            dgvReservas.Rows.Clear();

            foreach(Reserva r in Form1.hotel.Reservas.Listar())
            {
                dgvReservas.Rows.Add(
                    r.IDReserva,
                    r.cliente.GetNombre(),
                    r.cliente.GetId(),
                    r.Habitacion.numero,
                    ObtenerNombreTipo(r.Habitacion.tipo),
                    r.FechaEntrada.ToString("yyyy-MM-dd"),
                    r.FechaSalida.ToString("yyyy-MM-dd"),
                    r.NumNoches,
                    r.Estado ? "Activa" : "Cancelada",
                    r.origen
                    );
            }
        }

        private string ObtenerNombreTipo(int tipo)
        {
            switch (tipo)
            {
                case 1: return "Simple";
                case 2: return "Doble";
                case 3: return "Matrimonial";
                default: return "Desconocido";
            }
        }
        private void LimpiarCampos()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            cmbTipo.SelectedIndex = -1;
            cmbHabitacion.Items.Clear();
            nudNoches.Value = 1;
            dtpFechaEntrada.Value = DateTime.Today;
        }

        private void dgvReservas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
