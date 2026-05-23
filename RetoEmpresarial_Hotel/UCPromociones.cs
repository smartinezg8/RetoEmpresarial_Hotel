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
    public partial class UCPromociones : UserControl
    {
        public UCPromociones()
        {
            InitializeComponent();
        }
        private Administrador admin;

        //Cargar elementos del combobox
        private void UCPromociones_Load(object sender, EventArgs e)
        {
            admin = new Administrador("Admin", 1, Form1.hotel);
            cmbTipo.Items.Add("Todas");
            cmbTipo.Items.Add("Simple");
            cmbTipo.Items.Add("Doble");
            cmbTipo.Items.Add("Matrimonial");

            CargarPromociones();
        }

        private void CargarPromociones()
        {
            dgvPromo.Rows.Clear();
            int i = 1;
            foreach (var p in admin.ListarPromociones())
            {
                dgvPromo.Rows.Add(
                    i,
                    p.nombre,
                    p.descuento + "%",
                    p.fechaInicio.ToShortDateString(),
                    p.fechaFin.ToShortDateString(),
                    p.tipoHabitacionAplica
                );
                i++;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (!double.TryParse(txtDesc.Text, out double descuento))
            {
                lblError.Text = "Descuento debe ser un número";
                return;
            }

            int tipo = cmbTipo.SelectedIndex;

            string error = admin.ValidarCrearPromocion(nombre, descuento, dtpIni.Value.Date, dtpFin.Value.Date, tipo);
            if (error != "")
            {
                lblError.Text = error;
                return;
            }

            admin.CrearPromocion(nombre, descuento, dtpIni.Value.Date, dtpFin.Value.Date, tipo);
            CargarPromociones();
        }

        private void dgvPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                admin.EliminarPromocion(e.RowIndex);
                CargarPromociones();
            }
        }
    }
}
