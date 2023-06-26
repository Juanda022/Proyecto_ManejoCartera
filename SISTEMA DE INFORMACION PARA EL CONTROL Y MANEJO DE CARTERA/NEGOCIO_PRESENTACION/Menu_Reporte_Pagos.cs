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
    public partial class Menu_Reporte_Pagos : Form
    {
        public Menu_Reporte_Pagos()
        {
            InitializeComponent();
        }

        private void btn_ReporteGeneral_Click(object sender, EventArgs e)
        {
            Reporte_General_Pagos RGP = new Reporte_General_Pagos();
            RGP.Show();
            this.Hide();
        }

        private void btn_ReporteEspecifico_Click(object sender, EventArgs e)
        {
            Reporte_Especifico_Pagos REP = new Reporte_Especifico_Pagos();
            REP.Show();
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
