using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LOGICA
{
    public class Clase_Forma_pago : BASE_DATOS.CONEXION
    {
        private string CODIGO_FORMA_PAGOS;
        private string NOMBRE_FORMA_PAGOS;
        private string ESTADO_FORMA_PAGOS;

        public string Codigo_FormaPGM
        {
            get { return CODIGO_FORMA_PAGOS; }
            set { CODIGO_FORMA_PAGOS = value; }
        }
        public string Nombre_FormaPGM
        {
            get { return NOMBRE_FORMA_PAGOS; }
            set { NOMBRE_FORMA_PAGOS = value; }
        }
        public string Estado_FormaPGM
        {
            get { return ESTADO_FORMA_PAGOS; }
            set { ESTADO_FORMA_PAGOS = value; }
        }
        public void Datos_eleminar_FormaPGM(string Id, string Estado)
        {
            this.Codigo_FormaPGM = Id;
            this.Estado_FormaPGM = Estado;
        }
        public void Insertar_nueva_Forma_Pagos()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_FORMAS_PAGOS";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_FORMAPG", Codigo_FormaPGM);
                cmm.Parameters.AddWithValue("@NOMBRE_FORMAPG", Nombre_FormaPGM);
                cmm.Parameters.AddWithValue("@ESTADO_FORMAPG", Estado_FormaPGM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente una nueva forma de pago ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar una nueva forma de pago " + e);
            }
        }
        public void Modificar_Forma_Pagos()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_FORMAS_PAGOS";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGO_FORMAPG", Codigo_FormaPGM);
                cmm.Parameters.AddWithValue("@MONOMBRE_FORMAPG", Nombre_FormaPGM);
                cmm.Parameters.AddWithValue("@MOESTADO_FORMAPG", Estado_FormaPGM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado una forma de pago");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar una forma de pago" + ex);
            }
        }
        public void Consultar_Forma_PagosG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_FORMAS_PAGOS";
                SqlDataAdapter da = new SqlDataAdapter(nomproce, con);
                DataSet dset = new DataSet();
                da.Fill(dset, nomproce);
                Grilla.DataSource = dset;
                Grilla.DataMember = nomproce;
                Desconectar();
                MessageBox.Show("Consulta general realizada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar generalmente" + ex);
            }
        }
        public void ConsultarForma_PagosEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_FORMAS_PAGOS_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_FORMAPG", Codigo_FormaPGM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                SqlDataAdapter ad = new SqlDataAdapter(cmm);
                ad.Fill(dset, nomproce);
                Grilla.DataSource = dset;
                Grilla.DataMember = nomproce;
                Desconectar();
                MessageBox.Show("Consulta realizada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar" + ex);
            }
        }
        public void Eliminar_Forma_Pagos()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_FORMAPG";
                cmm.Parameters.AddWithValue("@CODIGOFORMAPG", Codigo_FormaPGM);
                cmm.Parameters.AddWithValue("@ESTADOFORMAPG", Estado_FormaPGM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN FORMA DE PAGO");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
