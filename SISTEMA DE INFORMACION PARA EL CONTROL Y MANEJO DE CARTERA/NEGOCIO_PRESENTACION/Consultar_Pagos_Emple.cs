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
    public partial class Consultar_Pagos_Emple : Form
    {
        public Consultar_Pagos_Emple()
        {
            InitializeComponent();
        }

        private void Consultar_Modificar_Pagos_Emple_Load(object sender, EventArgs e)
        {

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
    }
}
