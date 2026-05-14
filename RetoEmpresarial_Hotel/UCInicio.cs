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
    public partial class UCInicio : UserControl
    {
        public UCInicio()
        {
            InitializeComponent();
        }

        private void UCInicio_Load(object sender, EventArgs e)
        {
            fraseHotel.Parent = fotoHotel;
            fraseHotel.BackColor = Color.Transparent;
            hotelNombre.Parent = fotoHotel;
            hotelNombre.BackColor = Color.Transparent;
            
        }

        private void fotoHotel_Click(object sender, EventArgs e)
        {

        }
    }
}
