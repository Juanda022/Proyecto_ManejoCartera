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
    public partial class Forma_Pago_Empleado : Form
    {
        public Forma_Pago_Empleado()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_FormaPG_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Forma_pago objemple = new LOGICA.Clase_Forma_pago();
            objemple.Codigo_FormaPGM = txt_Codigo_FormaPG2.Text;
            objemple.Nombre_FormaPGM = txt_Nombre_FormaPG2.Text;
            objemple.Estado_FormaPGM = cmb_EstadoFP2.Text;
            objemple.Insertar_nueva_Forma_Pagos();
            limpiar();

        }

        private void txt_Codigo_FormaPG2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 97) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_FormaPG2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 31 && e.KeyChar <= 33) || (e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btn_Consulta_FormaPG_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_FormaPG2.Text == "")
            {
                LOGICA.Clase_Forma_pago objmarca = new LOGICA.Clase_Forma_pago();
                objmarca.Consultar_Forma_PagosG(ref Grilla_FormaPG);
            }
            else
            {
                LOGICA.Clase_Forma_pago objmarca = new LOGICA.Clase_Forma_pago();
                objmarca.Codigo_FormaPGM = txt_Codigo_FormaPG2.Text;
                objmarca.ConsultarForma_PagosEspecifico(ref Grilla_FormaPG);
            }
        }
        private void limpiar()
        {
            txt_Codigo_FormaPG2.Clear();
            txt_Nombre_FormaPG2.Clear();
            cmb_EstadoFP2.Text = "";
            txt_Codigo_FormaPG2.Focus();
        }
    }
}
