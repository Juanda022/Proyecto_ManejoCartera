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
    public partial class Cliente_Empleado : Form
    {
        public Cliente_Empleado()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Cliente objemple = new LOGICA.Clase_Cliente();
            objemple.Codigo_ClienteM = long.Parse(txt_Codigo_Cliente2.Text);
            objemple.Id_ClienteM = long.Parse(txt_Identificacion_Cliente2.Text);
            objemple.Nombre_ClienteM = txt_Nombre_Cliente2.Text;
            objemple.Direccion_ClienteM = txt_Direccion_Cliente2.Text;
            objemple.Telefono_ClienteM = long.Parse(txt_Telefono_Cliente2.Text);
            objemple.Genero_ClienteM = cbm_Genero_Clien2.Text;
            objemple.Codigo_Empleado_Cliente_FKM = long.Parse(txt_Codigo_Empleado_Cliente2.Text);
            objemple.Estado_ClienteM = cmb_Cliente.Text;
            objemple.Insertar_Nuevo_Cliente();

        }

        private void txt_Codigo_Cliente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Identificacion_Cliente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_Cliente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Direccion_Cliente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 34) || (e.KeyChar >= 36 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros a ecepcion del #", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Telefono_Cliente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Codigo_Empleado_Cliente2_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txt_Codigo_Cliente2.Text == "")
            {
                LOGICA.Clase_Cliente objmarca = new LOGICA.Clase_Cliente();
                objmarca.Consultar_ClienteG(ref Grilla_Cliente);
            }
            else
            {
                LOGICA.Clase_Cliente objmarca = new LOGICA.Clase_Cliente();
                objmarca.Codigo_ClienteM = long.Parse(txt_Codigo_Cliente2.Text);
                objmarca.ConsultarClienteEspecifico(ref Grilla_Cliente);
            }
        }
    }
}
