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
    public partial class Menu_Reporte_Comprobante : Form
    {
        public Menu_Reporte_Comprobante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_General_Comprobante RGC = new Reporte_General_Comprobante();
            RGC.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte_Especifico_Comprobante REC = new Reporte_Especifico_Comprobante();
            REC.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Reportes MR = new Menu_Reportes();
            MR.Show();
            this.Hide();
        }
    }
}
