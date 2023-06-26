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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Grilla_Empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPAL form = new MENU_PRINCIPAL();
            form.Show();
            this.Hide();
        }

        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            LOGICA.Clase_Proveedores objemple = new LOGICA.Clase_Proveedores();
            objemple.Codigo_ProveedoresM = long.Parse(txt_Codigo_Proveedores.Text);
            objemple.Direccion_ProveedoresM = txt_Direccion_Proveedores.Text;
            objemple.Telefono_ProveedoresM = long.Parse(txt_Telefono_Proveedores.Text);
            objemple.Nombre_ProveedoresM = txt_Nombre_Proveedores.Text;
            objemple.Razon_Comprobante_Proveedores_FKM = txt_Razon_Proveedores.Text;
            objemple.Estado_ProveedoresM = cmb_EstadoProve.Text;
            objemple.Insertar_nuevo_Proveedor();
            limpiar();
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Codigo_Proveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Direccion_Proveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 34) || (e.KeyChar >= 36 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros a ecepcion del #", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Telefono_Proveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_Proveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Razon_Proveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Proveedores objemple = new LOGICA.Clase_Proveedores();
            objemple.Codigo_ProveedoresM = long.Parse(txt_Codigo_Proveedores.Text);
            objemple.Direccion_ProveedoresM = txt_Direccion_Proveedores.Text;
            objemple.Telefono_ProveedoresM = long.Parse(txt_Telefono_Proveedores.Text);
            objemple.Nombre_ProveedoresM = txt_Nombre_Proveedores.Text;
            objemple.Razon_Comprobante_Proveedores_FKM = txt_Razon_Proveedores.Text;
            objemple.Estado_ProveedoresM = cmb_EstadoProve.Text;
            objemple.Modificar_Proveerdor();
            limpiar();

        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Proveedores.Text == "")
            {
                LOGICA.Clase_Proveedores objmarca = new LOGICA.Clase_Proveedores();
                objmarca.Consultar_ProveerdorG(ref Grilla_Proveedores);
            }
            else
            {
                LOGICA.Clase_Proveedores objmarca = new LOGICA.Clase_Proveedores();
                objmarca.Codigo_ProveedoresM = long.Parse(txt_Codigo_Proveedores.Text);
                objmarca.ConsultarProveerdorEspecifico(ref Grilla_Proveedores);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo_Proveedores.Text == "") && (cmb_EstadoProve.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Proveedores objCargo = new LOGICA.Clase_Proveedores();
                    objCargo.Datos_eleminar_ProveedoresM(long.Parse(txt_Codigo_Proveedores.Text), cmb_EstadoProve.Text);
                    objCargo.Eliminar_Proveerdor();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Codigo_Proveedores.Clear();
            txt_Direccion_Proveedores.Clear();
            txt_Telefono_Proveedores.Clear();
            txt_Nombre_Proveedores.Clear();
            txt_Razon_Proveedores.Clear();
            cmb_EstadoProve.Text = "";
            txt_Codigo_Proveedores.Focus();
        }
    }
}
