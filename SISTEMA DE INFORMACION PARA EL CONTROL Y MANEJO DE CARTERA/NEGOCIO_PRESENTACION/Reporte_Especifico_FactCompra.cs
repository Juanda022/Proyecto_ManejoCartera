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
    public partial class Reporte_Especifico_FactCompra : Form
    {
        public Reporte_Especifico_FactCompra()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Reporte_FacturaCompra MRRC = new Menu_Reporte_FacturaCompra();
            MRRC.Show();
            this.Hide();
        }
    }
}
