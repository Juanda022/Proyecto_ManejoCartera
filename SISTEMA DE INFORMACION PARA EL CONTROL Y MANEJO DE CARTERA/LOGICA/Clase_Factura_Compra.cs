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
    public class Clase_Factura_Compra : BASE_DATOS.CONEXION
    {
        private long CODIGO_FACTCOMP;
        private long CODIGO_EMPLEADO_FACTCOMP_FK;
        private long CODIGO_PROVEEDORES_FACTCOMP_FK;
        private DateTime FECHA_FACTCOMP;
        private long VALOR_FACTCOMP;
        private string ESTADO_FACTCOMP;

        public long Codigo_FactCompM
        {
            get { return CODIGO_FACTCOMP; }
            set { CODIGO_FACTCOMP = value; }
        }
        public long Codigo_Empleado_FactCompM
        {
            get { return CODIGO_EMPLEADO_FACTCOMP_FK; }
            set { CODIGO_EMPLEADO_FACTCOMP_FK = value; }
        }
        public long Codigo_Proveedores_FactCompM
        {
            get { return CODIGO_PROVEEDORES_FACTCOMP_FK; }
            set { CODIGO_PROVEEDORES_FACTCOMP_FK = value; }
        }
        public DateTime Fecha_FactCompM
        {
            get { return FECHA_FACTCOMP; }
            set { FECHA_FACTCOMP = value; }
        }
        public long Valor_FactCompM
        {
            get { return VALOR_FACTCOMP; }
            set { VALOR_FACTCOMP = value; }
        }
        public string Estado_FactCompM
        {
            get { return ESTADO_FACTCOMP; }
            set { ESTADO_FACTCOMP = value; }
        }
        public void Datos_eleminar_FactCompM(long Id, string Estado)
        {
            this.Codigo_FactCompM = Id;
            this.Estado_FactCompM = Estado;
        }

        public void Insertar_Nueva_Factura_Compra()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_FACTCOMPRA";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_FACTCOMP", Codigo_FactCompM);
                cmm.Parameters.AddWithValue("@CODIGO_EMPLEADO_FACTCOMP_FK", Codigo_Empleado_FactCompM);
                cmm.Parameters.AddWithValue("@CODIGO_PROVEEDORES_FACTCOMP_FK", Codigo_Proveedores_FactCompM);
                cmm.Parameters.AddWithValue("@FECHA_FACTCOMP", Fecha_FactCompM);
                cmm.Parameters.AddWithValue("@VALOR_FACTCOMP", Valor_FactCompM);
                cmm.Parameters.AddWithValue("@ESTADO_FACTCOMP", Estado_FactCompM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente una nueva factura de compra");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar una nueva factura de compra" + e);
            }
        }
        public void Modificar_Factura_Compra()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_CARGO";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGO_FACTCOMP", Codigo_FactCompM);
                cmm.Parameters.AddWithValue("@MOCODIGO_EMPLEADO_FACTCOMP_FK", Codigo_Empleado_FactCompM);
                cmm.Parameters.AddWithValue("@MOCODIGO_PROVEEDORES_FACTCOMP_FK", Codigo_Proveedores_FactCompM);
                cmm.Parameters.AddWithValue("@MOFECHA_FACTCOMP", Fecha_FactCompM);
                cmm.Parameters.AddWithValue("@MOVALOR_FACTCOMP", Valor_FactCompM);
                cmm.Parameters.AddWithValue("@MOESTADO_FACTCOMP", Estado_FactCompM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado correctamente una factura de compra");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar una factura de compra" + ex);
            }
        }
        public void Consultar_Factura_CompraG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_FACTURA_COMPRA";
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
        public void ConsultarFactura_CompraEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_FACTURA_COMPRA_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_FACTC", Codigo_FactCompM);
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
        public void Eliminar_Factura_Compra()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_FACTCOMPRA";
                cmm.Parameters.AddWithValue("@CODIGOFACCOMPRA", Codigo_FactCompM);
                cmm.Parameters.AddWithValue("@ESTADOFACTCOMPRA", Estado_FactCompM);
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
