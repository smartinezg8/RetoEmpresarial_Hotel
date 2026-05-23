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
    public partial class Form2Recepcion : Form
    {
        public Form2Recepcion()
        {
            InitializeComponent();
        }

        private void AbrirUC(UserControl UC)
        {
            panelContenedorRecep.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            panelContenedorRecep.Controls.Add(UC);
        }
        

        //Panel expandible para clientes
        bool expandClientes = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expandClientes == false)
            {
                contenedorHuesped.Height += 15;
                if (contenedorHuesped.Height >= contenedorHuesped.MaximumSize.Height)
                {
                    timer2.Stop();
                    expandClientes = true;
                }
            }
            else
            {
                contenedorHuesped.Height -= 15;
                if (contenedorHuesped.Height <= contenedorHuesped.MinimumSize.Height)
                {
                    timer2.Stop();
                    expandClientes = false;
                }
            }
        }

        private void btnHuesped_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Form2Recepcion_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirUC(new UCVerReservas());
        }

        private void btnDatosHuesped_Click(object sender, EventArgs e)
        {
            AbrirUC(new UCHuespedes());
        }

        private void btnSolicitarServicios_Click(object sender, EventArgs e)
        {
            AbrirUC (new UCSolicitarServicios());
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            AbrirUC (new UCPrecioEstancia());
        }
    }
}

