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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Cliente objemple = new LOGICA.Clase_Cliente();
            objemple.Codigo_ClienteM = long.Parse(txt_Codigo_Cliente.Text);
            objemple.Id_ClienteM = long.Parse(txt_Identificacion_Cliente.Text);
            objemple.Nombre_ClienteM = txt_Nombre_Cliente.Text;
            objemple.Direccion_ClienteM = txt_Direccion_Cliente.Text;
            objemple.Telefono_ClienteM = long.Parse(txt_Telefono_Cliente.Text);
            objemple.Genero_ClienteM = cbm_Genero_Clien.Text;
            objemple.Codigo_Empleado_Cliente_FKM = long.Parse(txt_Codigo_Empleado_Cliente.Text);
            objemple.Estado_ClienteM = cmb_Cliente.Text;
            objemple.Insertar_Nuevo_Cliente();
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

        private void txt_Codigo_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Identificacion_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Direccion_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 34) || (e.KeyChar >= 36 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros a ecepcion del #", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Telefono_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Codigo_Empleado_Cliente_KeyPress(object sender, KeyPressEventArgs e)
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
            LOGICA.Clase_Cliente objemple = new LOGICA.Clase_Cliente();
            objemple.Codigo_ClienteM = long.Parse(txt_Codigo_Cliente.Text);
            objemple.Id_ClienteM = long.Parse(txt_Identificacion_Cliente.Text);
            objemple.Nombre_ClienteM = txt_Nombre_Cliente.Text;
            objemple.Direccion_ClienteM = txt_Direccion_Cliente.Text;
            objemple.Telefono_ClienteM = long.Parse(txt_Telefono_Cliente.Text);
            objemple.Genero_ClienteM = cbm_Genero_Clien.Text;
            objemple.Codigo_Empleado_Cliente_FKM = long.Parse(txt_Codigo_Empleado_Cliente.Text);
            objemple.Estado_ClienteM = cmb_Cliente.Text;
            objemple.Modificar_Cliente();
            limpiar();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Cliente.Text == "")
            {
                LOGICA.Clase_Cliente objmarca = new LOGICA.Clase_Cliente();
                objmarca.Consultar_ClienteG(ref Grilla_Cliente);
            }
            else
            {
                LOGICA.Clase_Cliente objmarca = new LOGICA.Clase_Cliente();
                objmarca.Codigo_ClienteM = long.Parse(txt_Codigo_Cliente.Text);
                objmarca.ConsultarClienteEspecifico(ref Grilla_Cliente);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo_Cliente.Text == "") && (cmb_Cliente.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Cliente objCargo = new LOGICA.Clase_Cliente();
                    objCargo.Datos_eleminar_Cliente(long.Parse(txt_Codigo_Cliente.Text), cmb_Cliente.Text);
                    objCargo.Eliminar_Cliente();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Codigo_Cliente.Clear();
            txt_Identificacion_Cliente.Clear();
            txt_Nombre_Cliente.Clear();
            txt_Direccion_Cliente.Clear();
            txt_Telefono_Cliente.Clear();
            cbm_Genero_Clien.Text = "";
            txt_Codigo_Empleado_Cliente.Clear();
            cmb_Cliente.Text = "";
            txt_Codigo_Cliente.Focus();
        }
        
    }
}
