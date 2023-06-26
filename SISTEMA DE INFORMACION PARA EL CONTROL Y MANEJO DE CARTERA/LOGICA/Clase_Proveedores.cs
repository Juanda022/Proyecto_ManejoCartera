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
    public class Clase_Proveedores : BASE_DATOS.CONEXION
    {
        private long CODIGO_PROVEEDORES;
        private string DIRECCION_PROVEEDORES;
        private long TELEFONO_PROVEEDORES;
        private string NOMBRE_PROVEEDORES;
        private string RAZON_COMPROBANTE_PROVEEDORES_FK;
        private string ESTADO_PROVEEDORES;

        public long Codigo_ProveedoresM
        {
            get { return CODIGO_PROVEEDORES; }
            set { CODIGO_PROVEEDORES = value; }
        }
        public string Direccion_ProveedoresM
        {
            get { return DIRECCION_PROVEEDORES; }
            set { DIRECCION_PROVEEDORES = value; }
        }
        public long Telefono_ProveedoresM
        {
            get { return TELEFONO_PROVEEDORES; }
            set { TELEFONO_PROVEEDORES = value; }
        }
        public string Nombre_ProveedoresM
        {
            get { return NOMBRE_PROVEEDORES; }
            set { NOMBRE_PROVEEDORES = value; }
        }
        public string Razon_Comprobante_Proveedores_FKM
        {
            get { return RAZON_COMPROBANTE_PROVEEDORES_FK; }
            set { RAZON_COMPROBANTE_PROVEEDORES_FK = value; }
        }
        public string Estado_ProveedoresM
        {
            get { return ESTADO_PROVEEDORES; }
            set { ESTADO_PROVEEDORES = value; }
        }
        public void Datos_eleminar_ProveedoresM(long Id, string Estado)
        {
            this.Codigo_ProveedoresM = Id;
            this.Estado_ProveedoresM = Estado;
        }
        public void Insertar_nuevo_Proveedor()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_PROVEEDORES";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_PROVEEDORES",Codigo_ProveedoresM);
                cmm.Parameters.AddWithValue("@DIRECCION_PROVEEDORES", Direccion_ProveedoresM);
                cmm.Parameters.AddWithValue("@TELEFONO_PROVEEDORES", Telefono_ProveedoresM);
                cmm.Parameters.AddWithValue("@NOMBRE_PROVEEDORES", Nombre_ProveedoresM);
                cmm.Parameters.AddWithValue("@RAZON_COMPROBANTE_PROVEEDORES_FK", Razon_Comprobante_Proveedores_FKM);
                cmm.Parameters.AddWithValue("@ESTADO_PROVEEDORES", Estado_ProveedoresM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo proveedor");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo empleado" + e);
            }
        }
        public void Modificar_Proveerdor()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_PROVEEDORES";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGO_PROVEEDORES", Codigo_ProveedoresM);
                cmm.Parameters.AddWithValue("@MODIRECCION_PROVEEDORES", Direccion_ProveedoresM);
                cmm.Parameters.AddWithValue("@MOTELEFONO_PROVEEDORES", Telefono_ProveedoresM);
                cmm.Parameters.AddWithValue("@MONOMBRE_PROVEEDORES", Nombre_ProveedoresM);
                cmm.Parameters.AddWithValue("@MORAZON_COMPROBANTE_PROVEEDORES_FK", Razon_Comprobante_Proveedores_FKM);
                cmm.Parameters.AddWithValue("@MOESTADO_PROVEEDORES", Estado_ProveedoresM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado un proveedor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un proveedor" + ex);
            }
        }
        public void Consultar_ProveerdorG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_PROVEEDORES";
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
        public void ConsultarProveerdorEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_PROVEEDORES_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_PROVEEDORES", Codigo_ProveedoresM);
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
        public void Eliminar_Proveerdor()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_PROVEEDORES";
                cmm.Parameters.AddWithValue("@CODIGOPROVEEDORES", Codigo_ProveedoresM);
                cmm.Parameters.AddWithValue("@ESTADOPROVEEDORES", Estado_ProveedoresM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN PROVEEDOR");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
