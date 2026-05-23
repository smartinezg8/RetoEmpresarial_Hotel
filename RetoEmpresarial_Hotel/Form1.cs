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
    //Cliente web Form

    public partial class Form1 : Form
    {

        public static Hotel hotel = new Hotel("Velisse");
        public static Cliente ClienteActual = null;

        public Form1()
        {
            InitializeComponent();
            hotel.CargarDatosIniciales();
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            MostrarVista(ucInicio);
        }
        UCInicio ucInicio = new UCInicio();
        UCHabitaciones ucHabitaciones = new UCHabitaciones();
        UCServicios ucServicios = new UCServicios();
        UCMiReserva ucMiReserva = new UCMiReserva();
        UCReservaWeb ucReservaWeb = new UCReservaWeb();

        
        public void MostrarVista(UserControl vista)
        {
            panelContenedor.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(vista);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarVista(ucInicio);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MostrarVista(ucHabitaciones);
        }
        private void btnServicios_Click(object sender, EventArgs e)
        {
            MostrarVista(ucServicios);
        }

        private void btnMiReserva_Click(object sender, EventArgs e)
        {
            if (ClienteActual != null)
                ucMiReserva.CargarReservas(ClienteActual.historial.FindAll(r => r.Estado));

            else
                ucMiReserva.CargarReservas(new List<Reserva>());

            MostrarVista(ucMiReserva);
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            MostrarVista(ucReservaWeb);
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            FormLogIn login = new FormLogIn();
            login.Show();
        }  
    }
}
