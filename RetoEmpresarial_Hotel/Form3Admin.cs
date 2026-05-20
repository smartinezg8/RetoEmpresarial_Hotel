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
    public partial class Form3Admin : Form
    {
        public Form3Admin()
        {
            InitializeComponent();
        }

        private void Form3Admin_Load(object sender, EventArgs e)
        {

        }

        private void AbrirUC(UserControl UC)
        {
                panelContenedorAdmin.Controls.Clear();
                UC.Dock = DockStyle.Fill;
                panelContenedorAdmin.Controls.Add(UC);
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            AbrirUC(new UCModificarPrecios());
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            AbrirUC(new UCProyeccion());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirUC(new UCReportes());
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            AbrirUC(new UCPromociones());
        }
    }
}
