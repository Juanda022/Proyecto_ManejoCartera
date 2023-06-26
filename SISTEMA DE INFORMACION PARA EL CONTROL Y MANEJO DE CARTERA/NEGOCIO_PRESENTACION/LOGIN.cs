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
    public partial class LOGIN : Form
    {
        LOGICA.Clase_Inicio_Sesion objlogin = new LOGICA.Clase_Inicio_Sesion();

        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            txt_Usu.Visible = false;
            txt_Contra.Visible = false;
            txt_Nom.Visible = false;
            txt_Rol.Visible = false;
            txt_Estado.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if ((txt_Usuario.Text == "") && (txt_Contraseña.Text == "") && (txt_Nombre.Text == "") && (cmb_Rol.Text == "")&&(cmb_Estado.Text == ""))
            {
                MessageBox.Show("DIGITE POR FAVOR USUARIO Y CONTRASEÑA", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                objlogin.Datos_usuario(txt_Usuario.Text, txt_Contraseña.Text, txt_Nombre.Text, cmb_Rol.Text, cmb_Estado.Text);
                objlogin.Validacion_LoginM(ref txt_Usu, ref txt_Contra, ref txt_Nom, ref txt_Rol,ref txt_Estado);
            }


            if ((txt_Usu.Text != "") && (txt_Contra.Text != "") && (txt_Nom.Text != "") && (txt_Rol.Text != "Administrador del sistema") && (txt_Estado.Text != ""))
            {
                MENU_PRINCIPALEM menu = new MENU_PRINCIPALEM();
                menu.Show();
                this.Hide();
            }
            if ((txt_Usu.Text != "") && (txt_Contra.Text != "") && (txt_Nom.Text != "") && (txt_Rol.Text != "Empleado") && (txt_Estado.Text != ""))
            {
                MENU_PRINCIPAL marc = new MENU_PRINCIPAL();
                marc.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Intente nuevamente, usuario o contraseña errada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
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

        private void btn_Nuevo_FormaPG_Click(object sender, EventArgs e)
        {
            Inicio_Sesion Regis = new Inicio_Sesion();
            Regis.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
    

