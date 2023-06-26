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
    public partial class Menu_Reportes : Form
    {
        public Menu_Reportes()
        {
            InitializeComponent();
        }

        private void ptb_Comprobante_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Comprobante MRC = new Menu_Reporte_Comprobante();
            MRC.Show();
            this.Hide();
        }

        private void ptb_Factura_Compra_Click(object sender, EventArgs e)
        {
            Menu_Reporte_FacturaCompra MRFC = new Menu_Reporte_FacturaCompra();
            MRFC.Show();
            this.Hide();
        }

        private void ptb_Factura_Venta_Click(object sender, EventArgs e)
        {
            Menu_Reporte_FactVenta MRFV = new Menu_Reporte_FactVenta();
            MRFV.Show();
            this.Hide();
        }

        private void ptb_Cliente_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Cliente MRC = new Menu_Reporte_Cliente();
            MRC.Show();
            this.Hide();
        }

        private void ptb_Proveedores_Click(object sender, EventArgs e)
        {
            Menu_Reportes_Proveedores MRP = new Menu_Reportes_Proveedores();
            MRP.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPAL Menu = new MENU_PRINCIPAL();
            Menu.Show();
            this.Hide();
        }

        private void ptb_Empleado_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Empleado mre = new Menu_Reporte_Empleado();
            mre.Show();
            this.Hide();
        }

        private void ptb_Cargo_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Cargo MRC = new Menu_Reporte_Cargo();
            MRC.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Pagos MRP = new Menu_Reporte_Pagos();
            MRP.Show();
            this.Hide();
        }

        private void ptb_Forma_Pago_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Forma_Pago MRFP = new Menu_Reporte_Forma_Pago();
            MRFP.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Reporte_Recibo_Caja  MRCJ= new Menu_Reporte_Recibo_Caja();
            MRCJ.Show();
            this.Hide();
        }
    }
}
