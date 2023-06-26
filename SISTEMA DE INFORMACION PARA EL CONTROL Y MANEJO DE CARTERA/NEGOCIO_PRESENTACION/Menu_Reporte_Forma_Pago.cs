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
    public partial class Menu_Reporte_Forma_Pago : Form
    {
        public Menu_Reporte_Forma_Pago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_General_Forma_Pago RGFP = new Reporte_General_Forma_Pago();
            RGFP.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte_Especifico_Forma_Pago REFP = new Reporte_Especifico_Forma_Pago();
            REFP.Show();
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
