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
    public class Clase_Pagos : BASE_DATOS.CONEXION
    {
        private long NUMERO_PAGOS;
        private long VALOR_PAGOS;
        private string CODIGO_FORMAPG_PAGOS_FK;
        private DateTime FECHA_PAGOS;
        private long CODIGO_EMPLEADO_PAGOS_FK;
        private long CODIGO_CLIENTE_PAGOS_FK;
        private long CODIGO_FACTVENT_PAGOS_FK;
        private long CODIGO_FACTCOMP_PAGOS_FK;
        private string ESTADO_PAGOS;

        public long Numero_PagosM
        {
            get { return NUMERO_PAGOS; }
            set { NUMERO_PAGOS = value; }
        }
        public long Valor_PagosM
        {
            get { return VALOR_PAGOS; }
            set { VALOR_PAGOS = value; }
        }
        public string Codigo_FormaPG_Pagos_FKM
        {
            get { return CODIGO_FORMAPG_PAGOS_FK; }
            set { CODIGO_FORMAPG_PAGOS_FK = value; }
        }
        public DateTime Fecha_PagosM
        {
            get { return FECHA_PAGOS; }
            set { FECHA_PAGOS = value; }
        }
        public long Codigo_Empleado_Pagos_FKM
        {
            get { return CODIGO_EMPLEADO_PAGOS_FK; }
            set { CODIGO_EMPLEADO_PAGOS_FK = value; }
        }
        public long Codigo_Cliente_Pagos_FKM
        {
            get { return CODIGO_CLIENTE_PAGOS_FK; }
            set { CODIGO_CLIENTE_PAGOS_FK = value; }
        }
        public long Codigo_FactVent_Pagos_FKM
        {
            get { return CODIGO_FACTVENT_PAGOS_FK; }
            set { CODIGO_FACTVENT_PAGOS_FK = value; }
        }
        public long Codigo_FactComp_Pagos_FKM
        {
            get { return CODIGO_FACTCOMP_PAGOS_FK; }
            set { CODIGO_FACTCOMP_PAGOS_FK = value; }
        }
        public string Estado_PagosM
        {
            get { return ESTADO_PAGOS; }
            set { ESTADO_PAGOS = value; }
        }
        public void Datos_eleminar_ProveedoresM(long Id, string Estado)
        {
            this.Numero_PagosM = Id;
            this.Estado_PagosM = Estado;
        }
        public void Insertar_Nuevo_Pago()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_PAGOS";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@VALOR_PAGOS", Valor_PagosM);
                cmm.Parameters.AddWithValue("@CODIGO_FORMAPG_PAGOS_FK", Codigo_FormaPG_Pagos_FKM);
                cmm.Parameters.AddWithValue("@FECHA_PAGOS", Fecha_PagosM);
                cmm.Parameters.AddWithValue("@CODIGO_EMPLEADO_PAGOS_FK", Codigo_Empleado_Pagos_FKM);
                cmm.Parameters.AddWithValue("@CODIGO_CLIENTE_PAGOS_FK", Codigo_Cliente_Pagos_FKM);
                cmm.Parameters.AddWithValue("@CODIGO_FACTVENT_PAGOS_FK", Codigo_FactVent_Pagos_FKM);
                cmm.Parameters.AddWithValue("@CODIGO_FACTCOMP_PAGOS_FK", Codigo_FactComp_Pagos_FKM);
                cmm.Parameters.AddWithValue("@ESTADO_PAGOS", Estado_PagosM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo pago");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo pago" + e);
            }
        }
        public void Modificar_Pago()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_PAGOS";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MONUMERO_PAGOS", Numero_PagosM);
                cmm.Parameters.AddWithValue("@MOVALOR_PAGOS", Valor_PagosM);
                cmm.Parameters.AddWithValue("@MOCODIGO_FORMAPG_PAGOS_FK", Codigo_FormaPG_Pagos_FKM);
                cmm.Parameters.AddWithValue("@MOFECHA_PAGOS", Fecha_PagosM);
                cmm.Parameters.AddWithValue("@MOCODIGO_EMPLEADO_PAGOS_FK", Codigo_Empleado_Pagos_FKM);
                cmm.Parameters.AddWithValue("@MOCODIGO_CLIENTE_PAGOS_FK", Codigo_Cliente_Pagos_FKM);
                cmm.Parameters.AddWithValue("@MOCODIGO_FACTVENT_PAGOS_FK", Codigo_FactVent_Pagos_FKM);
                cmm.Parameters.AddWithValue("@MOCODIGO_FACTCOMP_PAGOS_FK", Codigo_FactComp_Pagos_FKM);
                cmm.Parameters.AddWithValue("@MOESTADO_PAGOS", Estado_PagosM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado un pago");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un pago" + ex);
            }
        }
        public void Consultar_PagosG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_PAGOS";
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
        public void ConsultarPagosEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_PAGOS_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONNUMERO_PAGOS", Numero_PagosM);
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
        public void Eliminar_Pagos()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_PAGOS";
                cmm.Parameters.AddWithValue("@NUMEROPAGOS", Numero_PagosM);
                cmm.Parameters.AddWithValue("@ESTADOPAGOS", Estado_PagosM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN PAGO");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
