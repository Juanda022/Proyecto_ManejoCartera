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
    public partial class Forma_Pago : Form
    {
        public Forma_Pago()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_FormaPG_Click(object sender, EventArgs e)
        {

            LOGICA.Clase_Forma_pago objemple = new LOGICA.Clase_Forma_pago();
            objemple.Codigo_FormaPGM = txt_Codigo_FormaPG.Text;
            objemple.Nombre_FormaPGM = txt_Nombre_FormaPG.Text;
            objemple.Estado_FormaPGM = cmb_EstadoFP.Text;
            objemple.Insertar_nueva_Forma_Pagos();
            limpiar();
            
        }

        private void txt_Codigo_FormaPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 97) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_FormaPG_KeyPress(object sender, KeyPressEventArgs e)
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
            MENU_PRINCIPAL form = new MENU_PRINCIPAL();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_FormaPG_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Forma_pago objemple = new LOGICA.Clase_Forma_pago();
            objemple.Codigo_FormaPGM = txt_Codigo_FormaPG.Text;
            objemple.Nombre_FormaPGM = txt_Nombre_FormaPG.Text;
            objemple.Estado_FormaPGM = cmb_EstadoFP.Text;
            objemple.Modificar_Forma_Pagos();
            limpiar();

        }

        private void btn_Consulta_FormaPG_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_FormaPG.Text == "")
            {
                LOGICA.Clase_Forma_pago objmarca = new LOGICA.Clase_Forma_pago();
                objmarca.Consultar_Forma_PagosG(ref Grilla_FormaPG);
            }
            else
            {
                LOGICA.Clase_Forma_pago objmarca = new LOGICA.Clase_Forma_pago();
                objmarca.Codigo_FormaPGM = txt_Codigo_FormaPG.Text;
                objmarca.ConsultarForma_PagosEspecifico(ref Grilla_FormaPG);
            }
        }

        private void btn_Eliminar_FormaPG_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo_FormaPG.Text == "") && (cmb_EstadoFP.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Forma_pago objCargo = new LOGICA.Clase_Forma_pago();
                    objCargo.Datos_eleminar_FormaPGM(txt_Codigo_FormaPG.Text, cmb_EstadoFP.Text);
                    objCargo.Eliminar_Forma_Pagos();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Codigo_FormaPG.Clear();
            txt_Nombre_FormaPG.Clear();
            cmb_EstadoFP.Text = "";
            txt_Codigo_FormaPG.Focus();
        }
        
    }
}
