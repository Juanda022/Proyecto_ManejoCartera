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
    public partial class MENU_PRINCIPAL : Form
    {
        public MENU_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void ptb_Cargo_Click(object sender, EventArgs e)
        {

        }

        private void ptb_Proveedores_Click(object sender, EventArgs e)
        {
            Proveedores form = new Proveedores();
            form.Show();
            this.Hide();
        }

        private void ptb_Empleado_Click(object sender, EventArgs e)
        {
            Empleado form = new Empleado();
            form.Show();
            this.Hide();
        }

        private void ptb_Cargo_Click_1(object sender, EventArgs e)
        {
            Cargo form = new Cargo();
            form.Show();
            this.Hide();
        }

        private void ptb_Forma_Pago_Click(object sender, EventArgs e)
        {
            Forma_Pago form = new Forma_Pago();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Pagos form = new Pagos();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Recibo_Caja form = new Recibo_Caja();
            form.Show();
            this.Hide();
        }

        private void ptb_Facturacion_Click(object sender, EventArgs e)
        {
            Comprobante form = new Comprobante();
            form.Show();
            this.Hide();
        }

        private void ptb_Factura_Compra_Click(object sender, EventArgs e)
        {
            Factura_Compra form = new Factura_Compra();
            form.Show();
            this.Hide();
        }

        private void ptb_Factura_Venta_Click(object sender, EventArgs e)
        {
            Factura_Venta form = new Factura_Venta();
            form.Show();
            this.Hide();
        }

        private void ptb_Cliente_Click(object sender, EventArgs e)
        {
            Cliente form = new Cliente();
            form.Show();
            this.Hide();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            LOGIN form = new LOGIN();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click_3(object sender, EventArgs e)
        {
            Inicio_Sesion form = new Inicio_Sesion();
            form.Show();
            this.Hide();
        }

        private void MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu_Reportes Menr = new Menu_Reportes();
            Menr.Show();
            this.Hide();
        }
    }
}
