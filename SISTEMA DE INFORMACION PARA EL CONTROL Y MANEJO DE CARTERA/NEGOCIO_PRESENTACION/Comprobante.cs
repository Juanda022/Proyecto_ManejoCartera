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
    public partial class Comprobante : Form
    {
        public Comprobante()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPAL form = new MENU_PRINCIPAL();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MENU_PRINCIPAL form = new MENU_PRINCIPAL();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (txt_Razon_Comprobante.Text == "")
            {
                LOGICA.Clase_Comprobante objmarca = new LOGICA.Clase_Comprobante();
                objmarca.Consultar_ComprobanteG(ref Grilla_Comprobante);
            }
            else
            {
                LOGICA.Clase_Comprobante objmarca = new LOGICA.Clase_Comprobante();
                objmarca.Razon_ComprobanteM = txt_Razon_Comprobante.Text;
                objmarca.ConsultarComprobanteEspecifico(ref Grilla_Comprobante);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Comprobante objemple = new LOGICA.Clase_Comprobante();
            objemple.Razon_ComprobanteM = txt_Razon_Comprobante.Text;
            objemple.Fecha_ComprobanteM = dtp_Fecha_Comprobante.Value;
            objemple.Nombre_ComprobanteM = txt_Nombre_Comprobante.Text;
            objemple.Estado_ComprobanteM = cmb_Comprobante.Text;
            objemple.Insertar_nuevo_Comprobante();
            limpiar();
        }

        private void txt_Razon_Comprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_Comprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 31 && e.KeyChar <= 33) || (e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Comprobante objemple = new LOGICA.Clase_Comprobante();
            objemple.Razon_ComprobanteM = txt_Razon_Comprobante.Text;
            objemple.Fecha_ComprobanteM = dtp_Fecha_Comprobante.Value;
            objemple.Nombre_ComprobanteM = txt_Nombre_Comprobante.Text;
            objemple.Estado_ComprobanteM = cmb_Comprobante.Text;
            objemple.Modificar_Comprobante();
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txt_Razon_Comprobante.Text == "") && (cmb_Comprobante.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Comprobante objCargo = new LOGICA.Clase_Comprobante();
                    objCargo.Datos_eleminar_Comprobante(txt_Razon_Comprobante.Text, cmb_Comprobante.Text);
                    objCargo.Eliminar_Comprobante();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Razon_Comprobante.Clear();
            dtp_Fecha_Comprobante.Text = "";
            txt_Nombre_Comprobante.Clear();
            cmb_Comprobante.Text = "";
            txt_Razon_Comprobante.Focus();
        }

        private void txt_Razon_Comprobante_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
