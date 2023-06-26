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
    public partial class Factura_Venta_Empleado : Form
    {
        public Factura_Venta_Empleado()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Factura_Venta objemple = new LOGICA.Clase_Factura_Venta();
            objemple.Codigo_FactVentM = long.Parse(txt_Codigo_FV2.Text);
            objemple.Codigo_Empleado_FactVentM = long.Parse(txt_Empleado_FV2.Text);
            objemple.Codigo_Cliente_FactVentM = long.Parse(txt_Clientes_FV2.Text);
            objemple.Fecha_FactVentM = dtp_FeFactV2.Value;
            objemple.Valor_FactVentM = long.Parse(txt_Valor_FV2.Text);
            objemple.Estado_FactVentM = cmb_EstadoFV.Text;
            objemple.Insertar_Nueva_Factura_Venta();

        }

        private void txt_Codigo_FV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Empleado_FV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Clientes_FV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Valor_FV2_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txt_Codigo_FV2.Text == "")
            {
                LOGICA.Clase_Factura_Venta objmarca = new LOGICA.Clase_Factura_Venta();
                objmarca.Consultar_Factura_VentaG(ref Grilla_FactV2);
            }
            else
            {
                LOGICA.Clase_Factura_Venta objmarca = new LOGICA.Clase_Factura_Venta();
                objmarca.Codigo_FactVentM = long.Parse(txt_Codigo_FV2.Text);
                objmarca.ConsultarFactura_VentaEspecifico(ref Grilla_FactV2);
            }
        }
    }
}
