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
    public partial class Recibo_Caja_Empleado : Form
    {
        public Recibo_Caja_Empleado()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Recibo_Caja objemple = new LOGICA.Clase_Recibo_Caja();
            objemple.Codigo_Cliente_ReciCaja_FKM = long.Parse(txt_Cod_Cliente_ReciCaja2.Text);
            objemple.Codigo_FactVent_ReciCaja_FKM = long.Parse(txt_Cod_FactV_ReciCaja2.Text);
            objemple.Fecha_ReciCajaM = dtp_FReciCaja2.Value;
            objemple.Valor_ReciCajaM = long.Parse(txt_Valor_ReciCaja2.Text);
            objemple.Descripcion_ReciCajaM = txt_Descripcion_ReciCaja2.Text;
            objemple.Estado_ReciCajaM = cmb_EstadoReciC.Text;
            objemple.Insertar_Nuevo_Recibo_Caja();


        }

        private void txt_Cod_Cliente_ReciCaja2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Cod_FactV_ReciCaja2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Valor_ReciCaja2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Descripcion_ReciCaja2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 97) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Recibo_Caja_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            Consultar_Reci_Caja_Emple form = new Consultar_Reci_Caja_Emple();
            form.Show();
            this.Hide();
        }
    }
}
