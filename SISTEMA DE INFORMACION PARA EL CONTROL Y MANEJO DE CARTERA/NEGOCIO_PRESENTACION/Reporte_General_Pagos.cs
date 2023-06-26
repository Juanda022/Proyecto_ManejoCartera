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
    public partial class Reporte_General_Pagos : Form
    {
        public Reporte_General_Pagos()
        {
            InitializeComponent();
        }

        private void Reporte_General_Pagos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Pagos MRRC = new Menu_Reporte_Pagos();
            MRRC.Show();
            this.Hide();
        }
    }
}
