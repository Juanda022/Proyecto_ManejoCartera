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
    public class Clase_Cliente : BASE_DATOS.CONEXION
    {
        private long CODIGO_CLIENTE;
        private long ID_CLIENTE;
        private string NOMBRE_CLIENTE;
        private string DIRECCION_CLIENTE;
        private long TELEFONO_CLIENTE;
        private string GENERO_CLIENTE;
        private long CODIGO_EMPLEADO_CLIENTE_FK;
        private string ESTADO_CLIENTE;

        public long Codigo_ClienteM
        {
            get { return CODIGO_CLIENTE; }
            set { CODIGO_CLIENTE = value; }
        }
        public long Id_ClienteM
        {
            get { return ID_CLIENTE; }
            set { ID_CLIENTE = value; }
        }
        public string Nombre_ClienteM
        {
            get { return NOMBRE_CLIENTE; }
            set { NOMBRE_CLIENTE = value; }
        }
        public string Direccion_ClienteM
        {
            get { return DIRECCION_CLIENTE; }
            set { DIRECCION_CLIENTE = value; }
        }
        public long Telefono_ClienteM
        {
            get { return TELEFONO_CLIENTE; }
            set { TELEFONO_CLIENTE = value; }
        }
        public string Genero_ClienteM
        {
            get { return GENERO_CLIENTE; }
            set { GENERO_CLIENTE = value; }
        }
        public long Codigo_Empleado_Cliente_FKM
        {
            get { return CODIGO_EMPLEADO_CLIENTE_FK; }
            set { CODIGO_EMPLEADO_CLIENTE_FK = value; }
        }
        public string Estado_ClienteM
        {
            get { return ESTADO_CLIENTE; }
            set { ESTADO_CLIENTE = value; }
        }
        public void Datos_eleminar_Cliente(long Id, string Estado)
        {
            this.Codigo_ClienteM = Id;
            this.Estado_ClienteM = Estado;
        }
        public void Insertar_Nuevo_Cliente()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_CLIENTE";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_CLIENTE", Codigo_ClienteM);
                cmm.Parameters.AddWithValue("@ID_CLIENTE", Id_ClienteM);
                cmm.Parameters.AddWithValue("@NOMBRE_CLIENTE", Nombre_ClienteM);
                cmm.Parameters.AddWithValue("@DIRECCION_CLIENTE", Direccion_ClienteM);
                cmm.Parameters.AddWithValue("@TELEFONO_CLIENTE", Telefono_ClienteM);
                cmm.Parameters.AddWithValue("@GENERO_CLIENTE", Genero_ClienteM);
                cmm.Parameters.AddWithValue("@CODIGO_EMPLEADO_CLIENTE_FK", Codigo_Empleado_Cliente_FKM);
                cmm.Parameters.AddWithValue("@ESTADO_CLIENTE", Estado_ClienteM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo cliente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo cliente" + e);
            }
        }
        public void Modificar_Cliente()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_CLIENTE";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGO_CLIENTE", Codigo_ClienteM);
                cmm.Parameters.AddWithValue("@MOID_CLIENTE", Id_ClienteM);
                cmm.Parameters.AddWithValue("@MONOMBRE_CLIENTE", Nombre_ClienteM);
                cmm.Parameters.AddWithValue("@MODIRECCION_CLIENTE", Direccion_ClienteM);
                cmm.Parameters.AddWithValue("@MOTELEFONO_CLIENTE", Telefono_ClienteM);
                cmm.Parameters.AddWithValue("@MOGENERO_CLIENTE", Genero_ClienteM);
                cmm.Parameters.AddWithValue("@MOCODIGO_EMPLEADO_CLIENTE_FK", Codigo_Empleado_Cliente_FKM);
                cmm.Parameters.AddWithValue("@MOESTADO_CLIENTE", Estado_ClienteM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado correctamente un cliente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente" + ex);
            }
        }
        public void Consultar_ClienteG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_CLIENTE";
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
        public void ConsultarClienteEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_CLIENTE_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_CLIENTE", Codigo_ClienteM);
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
        public void Eliminar_Cliente()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_CLIENTE";
                cmm.Parameters.AddWithValue("@CODIGOCLIENTE", Codigo_ClienteM);
                cmm.Parameters.AddWithValue("@ESTADOCLIENTE", Estado_ClienteM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN CLIENTE");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
