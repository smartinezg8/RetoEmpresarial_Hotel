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

        bool expandReservas = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expandReservas == false)
            {
                contenedorReservas.Height += 15;
                if (contenedorReservas.Height >= contenedorReservas.MaximumSize.Height)
                {
                    timer1.Stop();
                    expandReservas = true;
                }
            }
            else
            {
                contenedorReservas.Height -= 15;
                if (contenedorReservas.Height <= contenedorReservas.MinimumSize.Height)
                {
                    timer1.Stop();
                    expandReservas = false;
                }
            }
        }

        private void botonReservas_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

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
    }
}

