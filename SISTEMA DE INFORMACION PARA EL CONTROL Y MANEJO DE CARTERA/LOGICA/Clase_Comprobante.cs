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
    public class Clase_Comprobante : BASE_DATOS.CONEXION
    {
        private string RAZON_COMPROBANTE;
        private DateTime FECHA_COMPROBANTE;
        private string NOMBRE_COMPROBANTE;
        private string ESTADO_COMPROBANTE;

        public string Razon_ComprobanteM
        {
            get { return RAZON_COMPROBANTE; }
            set { RAZON_COMPROBANTE = value; }
        }
        public DateTime Fecha_ComprobanteM
        {
            get { return FECHA_COMPROBANTE; }
            set { FECHA_COMPROBANTE = value; }
        }
        public string Nombre_ComprobanteM
        {
            get { return NOMBRE_COMPROBANTE; }
            set { NOMBRE_COMPROBANTE = value; }
        }
        public string Estado_ComprobanteM
        {
            get { return ESTADO_COMPROBANTE; }
            set { ESTADO_COMPROBANTE = value; }
        }
        public void Datos_eleminar_Comprobante(string Id, string Estado)
        {
            this.Razon_ComprobanteM = Id;
            this.Estado_ComprobanteM = Estado;
        }
        public void Insertar_nuevo_Comprobante()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_COMPROBANTE";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@RAZON_COMPROBANTE", Razon_ComprobanteM);
                cmm.Parameters.AddWithValue("@FECHA_COMPROBANTE", Fecha_ComprobanteM);
                cmm.Parameters.AddWithValue("@NOMBRE_COMPROBANTE", Nombre_ComprobanteM);
                cmm.Parameters.AddWithValue("@ESTADO_COMPROBANTE", Estado_ComprobanteM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo comprobante");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo comprobante" + e);
            }
        }
        public void Modificar_Comprobante()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_COMPROBANTE";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MORAZON_COMPROBANTE", Razon_ComprobanteM);
                cmm.Parameters.AddWithValue("@MOFECHA_COMPROBANTE", Fecha_ComprobanteM);
                cmm.Parameters.AddWithValue("@MONOMBRE_COMPROBANTE", Nombre_ComprobanteM);
                cmm.Parameters.AddWithValue("@MOESTADO_COMPROBANTE", Estado_ComprobanteM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado correctamente un comprobante");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un comprobante" + ex);
            }
        }
        public void Consultar_ComprobanteG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_COMPROBANTE";
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
        public void ConsultarComprobanteEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_COMPROBANTE_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONRAZON_COMPROBANTE", Razon_ComprobanteM);
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
        public void Eliminar_Comprobante()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_COMPROBANTE";
                cmm.Parameters.AddWithValue("@RAZONCOMPROBANTE", Razon_ComprobanteM);
                cmm.Parameters.AddWithValue("@ESTADOCOMPROBANTE", Estado_ComprobanteM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN COMPROBANTE");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
