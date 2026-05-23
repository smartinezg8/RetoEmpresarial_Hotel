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
    public partial class UCHuespedes : UserControl
    {
        public UCHuespedes()
        {
            InitializeComponent();
        }

        private void UCHuespedes_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarHuespedes();
        }
        private void ConfigurarTabla()
        {
            dgvHuespedes.AutoGenerateColumns = false;

            colGuardar.UseColumnTextForButtonValue = true;
            colGuardar.Text = "Guardar";

            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Text = "Eliminar";
        }
        private void CargarHuespedes()
        {
            dgvHuespedes.Rows.Clear();

            foreach (Cliente c in Form1.hotel.Clientes.Listar())
            {
                int fila = dgvHuespedes.Rows.Add(
                    c.GetId(),
                    c.GetNombre(),
                    "",
                    ""
                );
            
                dgvHuespedes.Rows[fila].Cells["colIdentificacion"].ReadOnly = true;
                dgvHuespedes.Rows[fila].Cells["colNombre"].ReadOnly = true;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvHuespedes.Rows.Add();
        }
        private void dgvHuespedes_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvHuespedes.Columns["colGuardar"].Index)
            {
                GuardarFila(e.RowIndex);
            }

            if (e.ColumnIndex == dgvHuespedes.Columns["colEliminar"].Index)
            {
                EliminarFila(e.RowIndex);
            }
        }
        private void GuardarFila(int fila)
        {
            string idTexto = dgvHuespedes.Rows[fila].Cells["colIdentificacion"].Value?.ToString();
            string nombre = dgvHuespedes.Rows[fila].Cells["colNombre"].Value?.ToString();

            if (!int.TryParse(idTexto, out int id) || string.IsNullOrWhiteSpace(nombre))
            {
                return;
            }

            Cliente existente = Form1.hotel.Clientes.BuscarPorDocumento(id);

            if (existente == null)
            {
                Cliente nuevo = new Cliente(
                    nombre,
                    id,
                    Form1.hotel
                );

                Form1.hotel.Clientes.Registrar(nuevo);

                dgvHuespedes.Rows[fila].Cells["colIdentificacion"].ReadOnly = true;
                dgvHuespedes.Rows[fila].Cells["colNombre"].ReadOnly = true;
            }
        }
        private void EliminarFila(int fila)
        {
            if (fila < 0 || fila >= dgvHuespedes.Rows.Count) return;
            if (dgvHuespedes.Rows[fila].IsNewRow) return;

            dgvHuespedes.Rows.RemoveAt(fila);
        }

    }
}
