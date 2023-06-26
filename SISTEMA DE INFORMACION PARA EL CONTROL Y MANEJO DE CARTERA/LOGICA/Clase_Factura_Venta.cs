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
    public class Clase_Factura_Venta : BASE_DATOS.CONEXION
    {
        private long CODIGO_FACTVENT;
        private long CODIGO_EMPLEADO_FACTVENT_FK;
        private long CODIGO_CLIENTE_FACTVENT_FK;
        private DateTime FECHA_FACTVENT;
        private long VALOR_FACTVENT;
        private string ESTADO_FACTVENT;

        public long Codigo_FactVentM
        {
            get { return CODIGO_FACTVENT; }
            set { CODIGO_FACTVENT = value; }
        }
        public long Codigo_Empleado_FactVentM
        {
            get { return CODIGO_EMPLEADO_FACTVENT_FK; }
            set { CODIGO_EMPLEADO_FACTVENT_FK = value; }
        }
        public long Codigo_Cliente_FactVentM
        {
            get { return CODIGO_CLIENTE_FACTVENT_FK; }
            set { CODIGO_CLIENTE_FACTVENT_FK = value; }
        }
        public DateTime Fecha_FactVentM
        {
            get { return FECHA_FACTVENT; }
            set { FECHA_FACTVENT = value; }
        }
        public long Valor_FactVentM
        {
            get { return VALOR_FACTVENT; }
            set { VALOR_FACTVENT = value; }
        }
        public string Estado_FactVentM
        {
            get { return ESTADO_FACTVENT; }
            set { ESTADO_FACTVENT = value; }
        }
        public void Datos_eleminar_FactVentM(long Id, string Estado)
        {
            this.Codigo_FactVentM = Id;
            this.Estado_FactVentM = Estado;
        }
        public void Insertar_Nueva_Factura_Venta()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_FACTVENTA";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_FACTVENT", Codigo_FactVentM);
                cmm.Parameters.AddWithValue("@CODIGO_EMPLEADO_FACTVENT_FK", Codigo_Empleado_FactVentM);
                cmm.Parameters.AddWithValue("@CODIGO_CLIENTE_FACTVENT_FK", Codigo_Cliente_FactVentM);
                cmm.Parameters.AddWithValue("@FECHA_FACTVENT", Fecha_FactVentM);
                cmm.Parameters.AddWithValue("@VALOR_FACTVENT", Valor_FactVentM);
                cmm.Parameters.AddWithValue("@ESTADO_FACTVENT", Estado_FactVentM);

                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente una nueva factura de venta");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar una nueva factura de venta" + e);
            }
        }
        public void Modificar_Factura_Venta()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_FACTURA_VENTA";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGO_FACTVENT", Codigo_FactVentM);
                cmm.Parameters.AddWithValue("@MOCODIGO_EMPLEADO_FACTVENT_FK", Codigo_Empleado_FactVentM);
                cmm.Parameters.AddWithValue("@MOCODIGO_CLIENTE_FACTVENT_FK", Codigo_Cliente_FactVentM);
                cmm.Parameters.AddWithValue("@MOFECHA_FACTVENT", Fecha_FactVentM);
                cmm.Parameters.AddWithValue("@MOVALOR_FACTVENT", Valor_FactVentM);
                cmm.Parameters.AddWithValue("@MOESTADO_FACTVENT", Estado_FactVentM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado una factura de venta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar una factura de venta" + ex);
            }
        }
        public void Consultar_Factura_VentaG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_FACTURA_VENTA";
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
        public void ConsultarFactura_VentaEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_FACTURA_VENTA_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_FACTV", Codigo_FactVentM);
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
        public void Eliminar_Factura_Venta()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_FACTURA_VENTA";
                cmm.Parameters.AddWithValue("@CODIGOFACVENTA", Codigo_FactVentM);
                cmm.Parameters.AddWithValue("@ESTADOFACVENTA", Estado_FactVentM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UNA FACTURA VENTA");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
