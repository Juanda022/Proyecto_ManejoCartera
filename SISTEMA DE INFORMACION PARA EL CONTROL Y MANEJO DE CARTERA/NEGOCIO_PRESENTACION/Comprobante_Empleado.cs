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
    public partial class Comprobante_Empleado : Form
    {
        public Comprobante_Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Comprobante objemple = new LOGICA.Clase_Comprobante();
            objemple.Razon_ComprobanteM = txt_Razon_Comprobante2.Text;
            objemple.Fecha_ComprobanteM = dtp_Fecha_Comprobante2.Value;
            objemple.Nombre_ComprobanteM = txt_Nombre_Comprobante2.Text;
            objemple.Estado_ComprobanteM = cmb_Comprobante2.Text;
            objemple.Insertar_nuevo_Comprobante();
            limpiar();
        }

        private void txt_Razon_Comprobante2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 97) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_Comprobante2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 31 && e.KeyChar <= 33) || (e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ptb_Regresar_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPALEM form = new MENU_PRINCIPALEM();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (txt_Razon_Comprobante2.Text == "")
            {
                LOGICA.Clase_Comprobante objmarca = new LOGICA.Clase_Comprobante();
                objmarca.Consultar_ComprobanteG(ref Grilla_Comprobante);
            }
            else
            {
                LOGICA.Clase_Comprobante objmarca = new LOGICA.Clase_Comprobante();
                objmarca.Razon_ComprobanteM = txt_Razon_Comprobante2.Text;
                objmarca.ConsultarComprobanteEspecifico(ref Grilla_Comprobante);
            }
        }
        private void limpiar()
        {
            txt_Razon_Comprobante2.Clear();
            dtp_Fecha_Comprobante2.Text = "";
            txt_Nombre_Comprobante2.Clear();
            cmb_Comprobante2.Text = "";
            txt_Razon_Comprobante2.Focus();
        }
    }
}
