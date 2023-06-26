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
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Cargo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Cargo objemple = new LOGICA.Clase_Cargo();
            objemple.Codigo_CargoM = txt_Codigo_Cargo.Text;
            objemple.Nombre_CargoM = txt_Nombre_Cargo.Text;
            objemple.Estado_CargoM = cmb_Cargo.Text;
            objemple.Insertar_nuevo_Cargo();
            limpiar();
        }

        private void txt_Codigo_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 31 && e.KeyChar <= 33) || (e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Codigo_Cargo_TextChanged(object sender, EventArgs e)
        {

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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Cargo objmarca = new LOGICA.Clase_Cargo();
            objmarca.Codigo_CargoM = txt_Codigo_Cargo.Text;
            objmarca.Nombre_CargoM = txt_Nombre_Cargo.Text;
            objmarca.Estado_CargoM = cmb_Cargo.Text;
            objmarca.Modificar_Cargo();
            limpiar();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Cargo.Text == "")
            {
                LOGICA.Clase_Cargo objmarca = new LOGICA.Clase_Cargo();
                objmarca.Consultar_CargoG(ref Grilla_Cargo);
            }
            else
            {
                LOGICA.Clase_Cargo objmarca = new LOGICA.Clase_Cargo();
                objmarca.Codigo_CargoM = txt_Codigo_Cargo.Text;
                objmarca.ConsultarCargoEspecifico(ref Grilla_Cargo);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo_Cargo.Text == "") && (cmb_Cargo.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Cargo objCargo = new LOGICA.Clase_Cargo();
                    objCargo.Datos_eleminar_Cargo(txt_Codigo_Cargo.Text, cmb_Cargo.Text);
                    objCargo.Eliminar_Cargo();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Codigo_Cargo.Clear();
            txt_Nombre_Cargo.Clear();
            cmb_Cargo.Text = "";
            txt_Codigo_Cargo.Focus();
        }
        
    }
}
