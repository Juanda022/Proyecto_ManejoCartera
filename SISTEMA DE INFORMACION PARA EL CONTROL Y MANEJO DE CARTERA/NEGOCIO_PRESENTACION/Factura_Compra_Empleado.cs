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
    public partial class Factura_Compra_Empleado : Form
    {
        public Factura_Compra_Empleado()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Factura_Compra objemple = new LOGICA.Clase_Factura_Compra();
            objemple.Codigo_FactCompM = long.Parse(txt_Codigo_FC2.Text);
            objemple.Codigo_Empleado_FactCompM = long.Parse(txt_Empleado_FC2.Text);
            objemple.Codigo_Proveedores_FactCompM = long.Parse(txt_Proveedores_FC2.Text);
            objemple.Fecha_FactCompM = dtp_FeFactC2.Value;
            objemple.Valor_FactCompM = long.Parse(txt_Valor_FC2.Text);
            objemple.Estado_FactCompM = cmb_EstadoFC.Text;
            objemple.Insertar_Nueva_Factura_Compra();

        }

        private void txt_Codigo_FC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Empleado_FC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Proveedores_FC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPALEM form = new MENU_PRINCIPALEM();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_FC2.Text == "")
            {
                LOGICA.Clase_Factura_Compra objmarca = new LOGICA.Clase_Factura_Compra();
                objmarca.Consultar_Factura_CompraG(ref Grilla_FactC2);
            }
            else
            {
                LOGICA.Clase_Factura_Compra objmarca = new LOGICA.Clase_Factura_Compra();
                objmarca.Codigo_FactCompM = long.Parse(txt_Codigo_FC2.Text);
                objmarca.ConsultarFactura_CompraEspecifico(ref Grilla_FactC2);
            }
        }
    }
}
