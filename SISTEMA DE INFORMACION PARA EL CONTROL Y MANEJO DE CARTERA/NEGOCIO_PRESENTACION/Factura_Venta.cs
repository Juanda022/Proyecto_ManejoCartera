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
    public partial class Factura_Venta : Form
    {
        public Factura_Venta()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Factura_Venta objemple = new LOGICA.Clase_Factura_Venta();
            objemple.Codigo_FactVentM = long.Parse(txt_Codigo_FV.Text);
            objemple.Codigo_Empleado_FactVentM = long.Parse(txt_Empleado_FV.Text);
            objemple.Codigo_Cliente_FactVentM = long.Parse(txt_Clientes_FV.Text);
            objemple.Fecha_FactVentM = dtp_FeFactV.Value;
            objemple.Valor_FactVentM = long.Parse(txt_Valor_FV.Text);
            objemple.Estado_FactVentM = cmb_EstadoFV.Text;
            objemple.Insertar_Nueva_Factura_Venta();
            limpiar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPAL form = new MENU_PRINCIPAL();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Codigo_FV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Empleado_FV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Clientes_FV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Valor_FV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Factura_Venta objemple = new LOGICA.Clase_Factura_Venta();
            objemple.Codigo_FactVentM = long.Parse(txt_Codigo_FV.Text);
            objemple.Codigo_Empleado_FactVentM = long.Parse(txt_Empleado_FV.Text);
            objemple.Codigo_Cliente_FactVentM = long.Parse(txt_Clientes_FV.Text);
            objemple.Fecha_FactVentM = dtp_FeFactV.Value;
            objemple.Valor_FactVentM = long.Parse(txt_Valor_FV.Text);
            objemple.Estado_FactVentM = cmb_EstadoFV.Text;
            objemple.Modificar_Factura_Venta();
            limpiar();
        }

        private void Factura_Venta_Load(object sender, EventArgs e)
        {

        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_FV.Text == "")
            {
                LOGICA.Clase_Factura_Venta objmarca = new LOGICA.Clase_Factura_Venta();
                objmarca.Consultar_Factura_VentaG(ref Grilla_FactV);
            }
            else
            {
                LOGICA.Clase_Factura_Venta objmarca = new LOGICA.Clase_Factura_Venta();
                objmarca.Codigo_FactVentM = long.Parse(txt_Codigo_FV.Text);
                objmarca.ConsultarFactura_VentaEspecifico(ref Grilla_FactV);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo_FV.Text == "") && (cmb_EstadoFV.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Factura_Venta objCargo = new LOGICA.Clase_Factura_Venta();
                    objCargo.Datos_eleminar_FactVentM(long.Parse(txt_Codigo_FV.Text), cmb_EstadoFV.Text);
                    objCargo.Eliminar_Factura_Venta();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Codigo_FV.Clear();
            txt_Empleado_FV.Clear();
            txt_Clientes_FV.Clear();
            dtp_FeFactV.Text = "";
            txt_Valor_FV.Clear();
            cmb_EstadoFV.Text = "";
            txt_Codigo_FV.Focus();
        }
        
    }
}
