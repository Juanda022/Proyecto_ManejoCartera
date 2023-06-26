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
    public class Clase_Cargo : BASE_DATOS.CONEXION
    {
        private string CODIGO_CARGO;
        private string NOMBRE_CARGO;
        private string ESTADO_CARGO;

        public string Codigo_CargoM
        {
            get { return CODIGO_CARGO; }
            set { CODIGO_CARGO = value; }
        }
        public string Nombre_CargoM
        {
            get { return NOMBRE_CARGO; }
            set { NOMBRE_CARGO = value; }
        }
        public string Estado_CargoM
        {
            get { return ESTADO_CARGO; }
            set { ESTADO_CARGO = value; }
        }
        public void Datos_eleminar_Cargo(string Id, string Estado)
        {
            this.Codigo_CargoM = Id;
            this.Estado_CargoM = Estado;
        }
        public void Insertar_nuevo_Cargo()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_CARGO";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_CARGO", Codigo_CargoM);
                cmm.Parameters.AddWithValue("@NOMBRE_CARGO", Nombre_CargoM);
                cmm.Parameters.AddWithValue("@ESTADO_CARGO", Estado_CargoM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo cargo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo cargo" + e);
            }
        }
        public void Modificar_Cargo()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_CARGO";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGOCARGO", Codigo_CargoM);
                cmm.Parameters.AddWithValue("@MONOMBRECARGO", Nombre_CargoM);
                cmm.Parameters.AddWithValue("@MOESTADOCARGO", Estado_CargoM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado un cargo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un cargo" + ex);
            }
        }
        public void Consultar_CargoG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_CARGO";
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
        public void ConsultarCargoEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_CARGO_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_CARGO", Codigo_CargoM);
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
        public void Eliminar_Cargo()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_CARGO";
                cmm.Parameters.AddWithValue("@CODIGOCARGO", Codigo_CargoM);
                cmm.Parameters.AddWithValue("@ESTADOCARGO", Estado_CargoM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN CARGO");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
