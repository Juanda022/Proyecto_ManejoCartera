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
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Inicio_Sesion objemple = new LOGICA.Clase_Inicio_Sesion();
            objemple.Usuario_UsuarioM = txt_Usuario.Text;
            objemple.Contraseña_UsuarioM = txt_Contraseña.Text;
            objemple.Nombre_UsuarioM = txt_Nombre.Text;
            objemple.Rol_UsuarioM = cmb_Rol.Text;
            objemple.Estado_UsuarioM = cmb_EstadoIniSe.Text;
            objemple.Insertar_nuevo_Usuario();
            limpiar();
           
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 31 && e.KeyChar <= 33) || (e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LOGIN form = new LOGIN();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Inicio_Sesion objemple = new LOGICA.Clase_Inicio_Sesion();
            objemple.Usuario_UsuarioM = txt_Usuario.Text;
            objemple.Contraseña_UsuarioM = txt_Contraseña.Text;
            objemple.Nombre_UsuarioM = txt_Nombre.Text;
            objemple.Rol_UsuarioM = cmb_Rol.Text;
            objemple.Estado_UsuarioM = cmb_EstadoIniSe.Text;
            objemple.Modificar_Ini_Sesion();
            limpiar();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_MosContra.Checked == true)
                {
                    if (txt_Contraseña.PasswordChar == '•')
                    {
                        txt_Contraseña.PasswordChar = '\0';
                    }
                }
            else
            {
              txt_Contraseña.PasswordChar = '•';
            }
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                LOGICA.Clase_Inicio_Sesion objmarca = new LOGICA.Clase_Inicio_Sesion();
                objmarca.Consultar_IniSesionG(ref Grilla_IniSesion);
            }
            else
            {
                LOGICA.Clase_Inicio_Sesion objmarca = new LOGICA.Clase_Inicio_Sesion();
                objmarca.Usuario_UsuarioM = txt_Usuario.Text;
                objmarca.ConsultarIni_SesionEspecifico(ref Grilla_IniSesion);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Usuario.Text == "") && (cmb_EstadoIniSe.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Inicio_Sesion objCargo = new LOGICA.Clase_Inicio_Sesion();
                    objCargo.Datos_eleminar_Inisesion(txt_Usuario.Text, cmb_EstadoIniSe.Text);
                    objCargo.Eliminar_Ini_Sesion();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Usuario.Clear();
            txt_Contraseña.Clear();
            txt_Nombre.Clear();
            cmb_EstadoIniSe.Text = "";
            txt_Usuario.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
   }
}

