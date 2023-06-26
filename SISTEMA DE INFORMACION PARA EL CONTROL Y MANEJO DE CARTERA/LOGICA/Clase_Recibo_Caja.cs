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
    public class Clase_Recibo_Caja : BASE_DATOS.CONEXION
    {
        private long CODIGO_RECIBO_CAJA;
        private long CODIGO_CLIENTE_RECICAJA_FK;
        private long CODIGO_FACTVENT_RECICAJA_FK;
        private DateTime FECHA_RECICAJA;
        private long VALOR_RECICAJA;
        private string DESCRIPCION_RECICAJA;
        private string ESTADO_RECICAJA;

        public long Codigo_ReciCajaM
        {
            get { return CODIGO_RECIBO_CAJA; }
            set { CODIGO_RECIBO_CAJA = value; }
        }
        public long Codigo_Cliente_ReciCaja_FKM
        {
            get { return CODIGO_CLIENTE_RECICAJA_FK; }
            set { CODIGO_CLIENTE_RECICAJA_FK = value; }
        }
        public long Codigo_FactVent_ReciCaja_FKM
        {
            get { return CODIGO_FACTVENT_RECICAJA_FK; }
            set { CODIGO_FACTVENT_RECICAJA_FK = value; }
        }
        public DateTime Fecha_ReciCajaM
        {
            get { return FECHA_RECICAJA; }
            set { FECHA_RECICAJA = value; }
        }
        public long Valor_ReciCajaM
        {
            get { return VALOR_RECICAJA; }
            set { VALOR_RECICAJA = value; }
        }
        public string Descripcion_ReciCajaM
        {
            get { return DESCRIPCION_RECICAJA; }
            set { DESCRIPCION_RECICAJA = value; }
        }
        public string Estado_ReciCajaM
        {
            get { return ESTADO_RECICAJA; }
            set { ESTADO_RECICAJA = value; }
        }
        public void Datos_eleminar_ReciCajaM(long Id, string Estado)
        {
            this.Codigo_ReciCajaM = Id;
            this.Estado_ReciCajaM = Estado;
        }
        public void Insertar_Nuevo_Recibo_Caja()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_RECIBO_CAJA";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_CLIENTE_RECICAJA_FK", Codigo_Cliente_ReciCaja_FKM);
                cmm.Parameters.AddWithValue("@CODIGO_FACTVENT_RECICAJA_FK", Codigo_FactVent_ReciCaja_FKM);
                cmm.Parameters.AddWithValue("@FECHA_RECICAJA", Fecha_ReciCajaM);
                cmm.Parameters.AddWithValue("@VALOR_RECICAJA", Valor_ReciCajaM);
                cmm.Parameters.AddWithValue("@DESCRIPCION_RECICAJA", Descripcion_ReciCajaM);
                cmm.Parameters.AddWithValue("@ESTADO_RECICAJA", Estado_ReciCajaM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo recibo de caja");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo recibo de caja" + e);
            }
        }
        public void Modificar_Recibo_Caja()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_RECIBO_CAJA";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGO_RECICAJA", Codigo_ReciCajaM);
                cmm.Parameters.AddWithValue("@MOCODIGO_CLIENTE_RECICAJA_FK", Codigo_Cliente_ReciCaja_FKM);
                cmm.Parameters.AddWithValue("@MOCODIGO_FACTVENT_RECICAJA_FK", Codigo_FactVent_ReciCaja_FKM);
                cmm.Parameters.AddWithValue("@MOFECHA_RECICAJA", Fecha_ReciCajaM);
                cmm.Parameters.AddWithValue("@MOVALOR_RECICAJA", Valor_ReciCajaM);
                cmm.Parameters.AddWithValue("@MODESCRIPCION_RECICAJA", Descripcion_ReciCajaM);
                cmm.Parameters.AddWithValue("@MOESTADO_RECICAJA", Estado_ReciCajaM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado un recibo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un recibo" + ex);
            }
        }
        public void Consultar_Recibo_CajaG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_RECIBO_CAJA";
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
        public void ConsultarRecibo_CajaEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_RECIBO_CAJA_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_RECICAJA", Codigo_ReciCajaM);
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
        public void Eliminar_Recibo_Caja()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_RECIBO_CAJA";
                cmm.Parameters.AddWithValue("@CODIGORECIBOCAJA", Codigo_ReciCajaM);
                cmm.Parameters.AddWithValue("@ESTADORECICAJA", Estado_ReciCajaM);
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
