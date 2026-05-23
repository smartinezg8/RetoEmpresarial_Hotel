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
    public partial class UCSolicitarServicios : UserControl
    {
        public UCSolicitarServicios()
        {
            InitializeComponent();
        }
        private Personal personal;
        private void UCSolicitarServicios_Load(object sender, EventArgs e)
        {
            personal = new Personal("Recepcionista", 2, Form1.hotel);

            ConfigurarTabla();
            ConfigurarCombos();
            CargarServicios();
        }


        private void ConfigurarTabla()
        {
            dgvServicios.AllowUserToAddRows = false;

            dgvServicios.Columns["colHabitacion"].ReadOnly = true;
            dgvServicios.Columns["colCosto"].ReadOnly = true;
            dgvServicios.Columns["colOrigen"].ReadOnly = true;
        }

        private void ConfigurarCombos()
        {
            DataGridViewComboBoxColumn colServicio = (DataGridViewComboBoxColumn)dgvServicios.Columns["colServicio"];
            colServicio.Items.Clear();

            foreach (var s in Servicio.Catalogo())
            {
                colServicio.Items.Add(s.nombre);
            }

            DataGridViewComboBoxColumn colEstado = (DataGridViewComboBoxColumn)dgvServicios.Columns["colEstado"];
            colEstado.Items.Clear();

            colEstado.Items.Add("Pendiente");
            colEstado.Items.Add("Entregado");
        }


        private void CargarServicios()
        {
            dgvServicios.Rows.Clear();
            foreach (Reserva r in Form1.hotel.Reservas.Listar())
            {
                foreach (Servicio s in r.Servicios)
                {
                    dgvServicios.Rows.Add(
                        r.IDReserva,
                        r.Habitacion.numero,
                        s.nombre,
                        s.costo,
                        r.origen,
                        "Pendiente"
                            );
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int fila = dgvServicios.Rows.Add();

            dgvServicios.Rows[fila].Cells["colEstado"].Value = "Pendiente";
            dgvServicios.Rows[fila].Cells["colOrigen"].Value = "Presencial";
        }



        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columna = dgvServicios.Columns[e.ColumnIndex].Name;

            if (columna == "colGuardar")
            {
                GuardarServicio(e.RowIndex);
            }
            if (columna == "colEliminar")
            {
                dgvServicios.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void GuardarServicio(int rowIndex)
        {
            DataGridViewRow fila = dgvServicios.Rows[rowIndex];

            if (fila.Cells["colID"].Value == null || fila.Cells["colServicio"].Value == null || fila.Cells["colEstado"].Value == null)
            {
                return;
            }
            if (!int.TryParse(fila.Cells["colID"].Value.ToString(),out int idReserva))
            {
                return;
            }
            string nombreServicio = fila.Cells["colServicio"].Value.ToString();


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

            if (indiceServicio == -1)
            {
                return;
            }

            Reserva reserva = Form1.hotel.Reservas.BuscarPorId(idReserva);

            if (reserva == null)
            {
                return;
            }

            foreach (Servicio s in reserva.Servicios)
            {
                if (s.nombre == nombreServicio)
                {
                    return;
                }
            }
            bool agregado = personal.RegistrarServicioAdicional(idReserva, indiceServicio);
            if (!agregado)
            {
                return;
            }

            fila.Cells["colHabitacion"].Value = reserva.Habitacion.numero;
            fila.Cells["colOrigen"].Value = reserva.origen;
            fila.Cells["colCosto"].Value =catalogo[indiceServicio].costo;
        }

        private void dgvServicios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvServicios.Rows[e.RowIndex];

            if (int.TryParse(fila.Cells["colID"].Value?.ToString(), out int idReserva))
            {
                Reserva reserva = Form1.hotel.Reservas.BuscarPorId(idReserva);

                if (reserva != null)
                {
                    fila.Cells["colHabitacion"].Value = reserva.Habitacion.numero;

                    if (fila.Cells["colOrigen"].Value == null)
                    {
                        fila.Cells["colOrigen"].Value = reserva.origen;
                    }
                }
            }
            if (dgvServicios.Columns[e.ColumnIndex].Name == "colServicio")
            {
                string nombreServicio = fila.Cells["colServicio"].Value?.ToString();

                foreach (var s in Servicio.Catalogo())
                {
                    if (s.nombre == nombreServicio)
                    {
                        fila.Cells["colCosto"].Value = s.costo;
                        break;
                    }
                }
            }
        }
    
    }
}
