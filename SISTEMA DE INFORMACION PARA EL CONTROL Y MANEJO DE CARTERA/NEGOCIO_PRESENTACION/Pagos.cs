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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Pagos objemple = new LOGICA.Clase_Pagos();
            objemple.Valor_PagosM = long.Parse(txt_Valor_Pagos.Text);
            objemple.Codigo_FormaPG_Pagos_FKM = txt_Cod_FormaPago.Text;
            objemple.Fecha_PagosM = DateTime.Parse(dtp_Pagos.Text);
            objemple.Codigo_Empleado_Pagos_FKM = long.Parse(txt_Cod_Empleado.Text);
            objemple.Codigo_Cliente_Pagos_FKM = long.Parse(txt_Cod_Cliente.Text);
            objemple.Codigo_FactVent_Pagos_FKM = long.Parse(txt_Cod_FactV.Text);
            objemple.Codigo_FactComp_Pagos_FKM = long.Parse(txt_Cod_FactC.Text);
            objemple.Estado_PagosM = cmb_EstadoPagos.Text;
            objemple.Insertar_Nuevo_Pago();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPAL form = new MENU_PRINCIPAL();
            form.Show();
            this.Hide();
        }

        private void txt_Saldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Consultar_Modificar_Pagos form = new Consultar_Modificar_Pagos();
            form.Show();
            this.Hide();
        }

        private void txt_Valor_Pagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Cod_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Cod_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Cod_FactV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Cod_FactC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Cod_FormaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

        }

        private void txt_Valor_Pagos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Consultar_Modificar_Pagos form = new Consultar_Modificar_Pagos();
            form.Show();
            this.Hide();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            Consultar_Modificar_Pagos form = new Consultar_Modificar_Pagos();
            form.Show();
            this.Hide();
        }
    }
}
