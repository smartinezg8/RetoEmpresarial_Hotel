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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string usuario = txtboxUsuario.Text;
            string contrasena = txtboxContrasena.Text;


            if (usuario == "admin" && contrasena == "admin")
            {
                
            }
            else if (usuario == "recepcion" && contrasena == "recepcion")
            {
                Form2Recepcion formRecepcion = new Form2Recepcion();
                formRecepcion.Show();
                this.Close();
            }
            else if (usuario == "cliente" && contrasena == "cliente")
            {
                Form1 formPrincipal = new Form1();
                formPrincipal.Show();
                this.Close();
            }
            else
            {
                lblError.Visible = true;
                return;
            }

        }
    }
}
