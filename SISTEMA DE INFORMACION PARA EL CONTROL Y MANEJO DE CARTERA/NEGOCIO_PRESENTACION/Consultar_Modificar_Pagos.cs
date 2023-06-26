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
    public partial class Consultar_Modificar_Pagos : Form
    {
        public Consultar_Modificar_Pagos()
        {
            InitializeComponent();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_Numero_Pagos.Text == "")
            {
                LOGICA.Clase_Pagos objmarca = new LOGICA.Clase_Pagos();
                objmarca.Consultar_PagosG(ref Grilla_Pagos);
            }
            else
            {
                LOGICA.Clase_Pagos objmarca = new LOGICA.Clase_Pagos();
                objmarca.Numero_PagosM = long.Parse(txt_Numero_Pagos.Text);
                objmarca.ConsultarPagosEspecifico(ref Grilla_Pagos);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Pagos objemple = new LOGICA.Clase_Pagos();
            objemple.Numero_PagosM = long.Parse(txt_Numero_Pagos.Text);
            objemple.Valor_PagosM = long.Parse(txt_Valor_Pagos.Text);
            objemple.Codigo_FormaPG_Pagos_FKM = txt_Cod_FormaPago.Text;
            objemple.Fecha_PagosM = DateTime.Parse(dtp_Pagos.Text);
            objemple.Codigo_Empleado_Pagos_FKM = long.Parse(txt_Cod_Empleado.Text);
            objemple.Codigo_Cliente_Pagos_FKM = long.Parse(txt_Cod_Cliente.Text);
            objemple.Codigo_FactVent_Pagos_FKM = long.Parse(txt_Cod_FactV.Text);
            objemple.Codigo_FactComp_Pagos_FKM = long.Parse(txt_Cod_FactC.Text);
            objemple.Estado_PagosM = cmb_EstadoPagos.Text;
            objemple.Modificar_Pago();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_Numero_Pagos.Text == "") && (cmb_EstadoPagos.Text == ""))
            {
                MessageBox.Show("Digite el codigo del usuario que desea eliminar");
                MessageBox.Show("Digite el codigo o numero del estado");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LOGICA.Clase_Pagos objCargo = new LOGICA.Clase_Pagos();
                    objCargo.Datos_eleminar_ProveedoresM(long.Parse(txt_Numero_Pagos.Text), cmb_EstadoPagos.Text);
                    objCargo.Eliminar_Pagos();
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            txt_Numero_Pagos.Clear();
            txt_Valor_Pagos.Clear();
            txt_Cod_FormaPago.Clear();
            dtp_Pagos.Text = "";
            txt_Cod_Empleado.Clear();
            txt_Cod_Cliente.Clear();
            txt_Cod_FactV.Clear();
            txt_Cod_FactC.Clear();
            cmb_EstadoPagos.Text = "";
            txt_Numero_Pagos.Focus();
        }
        
    }
}
