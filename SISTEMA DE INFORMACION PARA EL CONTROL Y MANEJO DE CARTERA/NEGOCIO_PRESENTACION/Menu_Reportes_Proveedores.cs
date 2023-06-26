using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEGOCIO_PRESENTACION
{
    public partial class Menu_Reportes_Proveedores : Form
    {
        public Menu_Reportes_Proveedores()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Reportes MR = new Menu_Reportes();
            MR.Show();
            this.Hide();
        }
    }
}
