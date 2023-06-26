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
    public partial class Factura_Compra : Form
    {
        public Factura_Compra()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Factura_Compra objemple = new LOGICA.Clase_Factura_Compra();
            objemple.Codigo_FactCompM = long.Parse(txt_Codigo_FC.Text);
            objemple.Codigo_Empleado_FactCompM = long.Parse(txt_Empleado_FC.Text);
            objemple.Codigo_Proveedores_FactCompM = long.Parse(txt_Proveedores_FC.Text);
            objemple.Fecha_FactCompM = dtp_FeFactC.Value;
            objemple.Valor_FactCompM = long.Parse(txt_Valor_FC.Text);
            objemple.Estado_FactCompM = cmb_EstadoFC.Text;
            objemple.Insertar_Nueva_Factura_Compra();
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

        private void txt_Codigo_FC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Empleado_FC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Proveedores_FC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Valor_FC_KeyPress(object sender, KeyPressEventArgs e)
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
            LOGICA.Clase_Factura_Compra objemple = new LOGICA.Clase_Factura_Compra();
            objemple.Codigo_FactCompM = long.Parse(txt_Codigo_FC.Text);
            objemple.Codigo_Empleado_FactCompM = long.Parse(txt_Empleado_FC.Text);
            objemple.Codigo_Proveedores_FactCompM = long.Parse(txt_Proveedores_FC.Text);
            objemple.Fecha_FactCompM = dtp_FeFactC.Value;
            objemple.Valor_FactCompM = long.Parse(txt_Valor_FC.Text);
            objemple.Estado_FactCompM = cmb_EstadoFC.Text;
            objemple.Modificar_Factura_Compra();
            limpiar();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_FC.Text == "")
            {
                LOGICA.Clase_Factura_Compra objmarca = new LOGICA.Clase_Factura_Compra();
                objmarca.Consultar_Factura_CompraG(ref Grilla_FactC);
            }
            else
            {
                LOGICA.Clase_Factura_Compra objmarca = new LOGICA.Clase_Factura_Compra();
                objmarca.Codigo_FactCompM = long.Parse(txt_Codigo_FC.Text);
                objmarca.ConsultarFactura_CompraEspecifico(ref Grilla_FactC);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo_FC.Text == "") && (cmb_EstadoFC.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Factura_Compra objCargo = new LOGICA.Clase_Factura_Compra();
                    objCargo.Datos_eleminar_FactCompM(long.Parse(txt_Codigo_FC.Text), cmb_EstadoFC.Text);
                    objCargo.Eliminar_Factura_Compra();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Codigo_FC.Clear();
            txt_Empleado_FC.Clear();
            txt_Proveedores_FC.Clear();
            dtp_FeFactC.Text = "";
            txt_Valor_FC.Clear();
            cmb_EstadoFC.Text = "";
            txt_Codigo_FC.Focus();
        }
        
    }
}
