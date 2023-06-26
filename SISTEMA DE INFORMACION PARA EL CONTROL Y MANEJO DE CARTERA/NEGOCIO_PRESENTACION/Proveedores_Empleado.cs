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
    public partial class Proveedores_Empleado : Form
    {
        public Proveedores_Empleado()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Proveedores objemple = new LOGICA.Clase_Proveedores();
            objemple.Codigo_ProveedoresM = long.Parse(txt_Codigo_Proveedores2.Text);
            objemple.Direccion_ProveedoresM = txt_Direccion_Proveedores2.Text;
            objemple.Telefono_ProveedoresM = long.Parse(txt_Telefono_Proveedores2.Text);
            objemple.Nombre_ProveedoresM = txt_Nombre_Proveedores2.Text;
            objemple.Razon_Comprobante_Proveedores_FKM = txt_Razon_Proveedores2.Text;
            objemple.Estado_ProveedoresM = cmb_EstadoProve2.Text;
            objemple.Insertar_nuevo_Proveedor();
            limpiar();

        }

        private void txt_Codigo_Proveedores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Direccion_Proveedores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 34) || (e.KeyChar >= 36 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros a ecepcion del #", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Telefono_Proveedores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_Proveedores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Razon_Proveedores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPALEM form = new MENU_PRINCIPALEM();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Grilla_Proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Proveedores2.Text == "")
            {
                LOGICA.Clase_Proveedores objmarca = new LOGICA.Clase_Proveedores();
                objmarca.Consultar_ProveerdorG(ref Grilla_Proveedores);
            }
            else
            {
                LOGICA.Clase_Proveedores objmarca = new LOGICA.Clase_Proveedores();
                objmarca.Codigo_ProveedoresM = long.Parse(txt_Codigo_Proveedores2.Text);
                objmarca.ConsultarProveerdorEspecifico(ref Grilla_Proveedores);
            }
        }
        private void limpiar()
        {
            txt_Codigo_Proveedores2.Clear();
            txt_Direccion_Proveedores2.Clear();
            txt_Telefono_Proveedores2.Clear();
            txt_Nombre_Proveedores2.Clear();
            txt_Razon_Proveedores2.Clear();
            cmb_EstadoProve2.Text = "";
            txt_Codigo_Proveedores2.Focus();
        }
    }
}
