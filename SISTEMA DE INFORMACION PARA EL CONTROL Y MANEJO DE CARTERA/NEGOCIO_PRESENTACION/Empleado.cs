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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Empleado objemple = new LOGICA.Clase_Empleado();
            objemple.Codigo_EmpleadoM = long.Parse(txt_Codigo_Emple.Text);
            objemple.Id_EmpleadoM = long.Parse(txt_identificacion.Text);
            objemple.Nombre_EmpleadoM = txt_nombre.Text;
            objemple.Direccion_EmpleadoM = txt_direccion.Text;
            objemple.Telefono_EmpleadoM = long.Parse(txt_Telefono_Emple.Text);
            objemple.FechaNaci_EmpleadoM = dtp_FeNacimiento.Value;
            objemple.Salario_EmpleadoM = long.Parse(txt_Salario_Emple.Text);
            objemple.Usuario_IniSesion_Empleado_FKM = txt_Usuario_Emple.Text;
            objemple.Genero_EmpleadoM = cbm_Genero.Text;
            objemple.Codigo_Cargo_Empleado_FKM = txt_Cargo_Emple.Text;
            objemple.Estado_EmpleadoM = cbm_Estado_Empleado.Text;
            objemple.Codigo_Proveedores_Empleado_FKM = long.Parse(txt_Cod_Proveedores.Text);
            objemple.Insertar_nuevo_Empleado();
            limpiar();
        }

        private void txt_Nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_FeNacimiento_ValueChanged(object sender, EventArgs e)
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

        private void lbl_TelefonoM_Click(object sender, EventArgs e)
        {

        }

        private void Grilla_Empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void txt_Cod_Proveedores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Codigo_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar<= 47)|| (e.KeyChar >= 58 && e.KeyChar <=255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Telefono_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Salario_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Cod_Proveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 34) || (e.KeyChar >= 36 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros a ecepcion del #", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Telefono_Emple_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Empleado objemple = new LOGICA.Clase_Empleado();
            objemple.Codigo_EmpleadoM = long.Parse(txt_Codigo_Emple.Text);
            objemple.Id_EmpleadoM = long.Parse(txt_identificacion.Text);
            objemple.Nombre_EmpleadoM = txt_nombre.Text;
            objemple.Direccion_EmpleadoM = txt_direccion.Text;
            objemple.Telefono_EmpleadoM = long.Parse(txt_Telefono_Emple.Text);
            objemple.FechaNaci_EmpleadoM = dtp_FeNacimiento.Value;
            objemple.Salario_EmpleadoM = long.Parse(txt_Salario_Emple.Text);
            objemple.Usuario_IniSesion_Empleado_FKM = txt_Usuario_Emple.Text;
            objemple.Genero_EmpleadoM = cbm_Genero.Text;
            objemple.Codigo_Cargo_Empleado_FKM = txt_Cargo_Emple.Text;
            objemple.Estado_EmpleadoM = cbm_Estado_Empleado.Text;
            objemple.Codigo_Proveedores_Empleado_FKM = long.Parse(txt_Cod_Proveedores.Text);
            objemple.Modificar_Empleado();
            limpiar();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Emple.Text == "")
            {
                LOGICA.Clase_Empleado objmarca = new LOGICA.Clase_Empleado();
                objmarca.Consultar_EmpleadoG(ref Grilla_Empleado);
            }
            else
            {
                LOGICA.Clase_Empleado objmarca = new LOGICA.Clase_Empleado();
                objmarca.Codigo_EmpleadoM = long.Parse(txt_Codigo_Emple.Text);
                objmarca.ConsultarEmpleadoEspecifico(ref Grilla_Empleado);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo_Emple.Text == "") && (cbm_Estado_Empleado.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Empleado objCargo = new LOGICA.Clase_Empleado();
                    objCargo.Datos_eleminar_EmpleadoM(long.Parse(txt_Codigo_Emple.Text), cbm_Estado_Empleado.Text);
                    objCargo.Eliminar_Empleado();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Codigo_Emple.Clear();
            txt_identificacion.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_Telefono_Emple.Clear();
            dtp_FeNacimiento.Text = "";
            txt_Salario_Emple.Clear();
            txt_Usuario_Emple.Clear();
            cbm_Genero.Text = "";
            cbm_Estado_Empleado.Text = "";
            txt_Cargo_Emple.Clear();
            txt_Cod_Proveedores.Clear();
            txt_Codigo_Emple.Focus();
        }

        private void txt_Cargo_Emple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No puede ingresar signos, solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
    }
}
