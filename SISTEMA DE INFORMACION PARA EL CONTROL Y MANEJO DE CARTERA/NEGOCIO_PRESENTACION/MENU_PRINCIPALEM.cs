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
    public partial class MENU_PRINCIPALEM : Form
    {
        public MENU_PRINCIPALEM()
        {
            InitializeComponent();
        }

        private void ptb_Facturacion_Click(object sender, EventArgs e)
        {
            Comprobante_Empleado form = new Comprobante_Empleado();
            form.Show();
            this.Hide();
        }

        private void ptb_Factura_Compra_Click(object sender, EventArgs e)
        {
            Factura_Compra_Empleado form = new Factura_Compra_Empleado();
            form.Show();
            this.Hide();
        }

        private void ptb_Factura_Venta_Click(object sender, EventArgs e)
        {
            Factura_Venta_Empleado form = new Factura_Venta_Empleado();
            form.Show();
            this.Hide();
        }

        private void ptb_Cliente_Click(object sender, EventArgs e)
        {
            Cliente_Empleado form = new Cliente_Empleado();
            form.Show();
            this.Hide();
        }

        private void ptb_Proveedores_Click(object sender, EventArgs e)
        {
            Proveedores_Empleado form = new Proveedores_Empleado();
            form.Show();
            this.Hide();
        }

        private void ptb_Forma_Pago_Click(object sender, EventArgs e)
        {
            Forma_Pago_Empleado form = new Forma_Pago_Empleado();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pagos_Empleado form = new Pagos_Empleado();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Recibo_Caja_Empleado form = new Recibo_Caja_Empleado();
            form.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            LOGIN form = new LOGIN();
            form.Show();
            this.Hide();
        }
    }
}
