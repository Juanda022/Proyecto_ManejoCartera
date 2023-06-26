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
    public class Clase_Empleado : BASE_DATOS.CONEXION
    {
        private long CODIGO_EMPLEADO;
        private long ID_EMPLEADO;
        private string NOMBRE_EMPLEADO;
        private string DIRECCION_EMPLEADO;
        private long TELEFONO_EMPLEADO;
        private DateTime FECHANACI_EMPLEADO;
        private string USUARIO_INISESION_EMPLEADO_FK;
        private long SALARIO_EMPLEADO;
        private string GENERO_EMPLEADO;
        private string CODIGO_CARGO_EMPLEADO_FK;
        private string ESTADO_EMPLEADO;
        private long CODIGO_PROVEEDORES_EMPLEADO_FK;
      
        public long Codigo_EmpleadoM
        {
            get { return CODIGO_EMPLEADO; }
            set { CODIGO_EMPLEADO = value; }
        }
        public long Id_EmpleadoM
        {
            get { return ID_EMPLEADO; }
            set { ID_EMPLEADO = value; }
        }
        public string Nombre_EmpleadoM
        {
            get { return NOMBRE_EMPLEADO; }
            set { NOMBRE_EMPLEADO = value; }
        }
        public string Direccion_EmpleadoM
        {
            get { return DIRECCION_EMPLEADO; }
            set { DIRECCION_EMPLEADO = value; }
        }
        public long Telefono_EmpleadoM
        {
            get { return TELEFONO_EMPLEADO; }
            set { TELEFONO_EMPLEADO = value; }
        }
        public DateTime FechaNaci_EmpleadoM
        {
            get { return FECHANACI_EMPLEADO; }
            set { FECHANACI_EMPLEADO = value; }
        }
        public string Usuario_IniSesion_Empleado_FKM
        {
            get { return USUARIO_INISESION_EMPLEADO_FK; }
            set { USUARIO_INISESION_EMPLEADO_FK = value; }
        }
        public long Salario_EmpleadoM
        {
            get { return SALARIO_EMPLEADO; }
            set { SALARIO_EMPLEADO = value; }
        }
        public string Genero_EmpleadoM
        {
            get { return GENERO_EMPLEADO; }
            set { GENERO_EMPLEADO = value; }
        }
        public string Codigo_Cargo_Empleado_FKM
        {
            get { return CODIGO_CARGO_EMPLEADO_FK; }
            set { CODIGO_CARGO_EMPLEADO_FK = value; }
        }
        public string Estado_EmpleadoM
        {
            get { return ESTADO_EMPLEADO; }
            set { ESTADO_EMPLEADO = value; }
        }
        public long Codigo_Proveedores_Empleado_FKM
        {
            get { return CODIGO_PROVEEDORES_EMPLEADO_FK; }
            set { CODIGO_PROVEEDORES_EMPLEADO_FK = value; }
        }
        public void Datos_eleminar_EmpleadoM(long Id, string Estado)
        {
            this.Codigo_EmpleadoM = Id;
            this.Estado_EmpleadoM = Estado;
        }
        public void Insertar_nuevo_Empleado()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_EMPLEADO";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@CODIGO_EMPLEADO", Codigo_EmpleadoM);
                cmm.Parameters.AddWithValue("@ID_EMPLEADO", Id_EmpleadoM);
                cmm.Parameters.AddWithValue("@NOMBRE_EMPLEADO", Nombre_EmpleadoM);
                cmm.Parameters.AddWithValue("@DIRECCION_EMPLEADO", Direccion_EmpleadoM);
                cmm.Parameters.AddWithValue("@TELEFONO_EMPLEADO", Telefono_EmpleadoM);
                cmm.Parameters.AddWithValue("@FECHANACI_EMPLEADO", FechaNaci_EmpleadoM);
                cmm.Parameters.AddWithValue("@USUARIO_USUARIO_EMPLEADO_FK", Usuario_IniSesion_Empleado_FKM);
                cmm.Parameters.AddWithValue("@SALARIO_EMPLEADO", Salario_EmpleadoM);
                cmm.Parameters.AddWithValue("@GENERO_EMPLEADO", Genero_EmpleadoM);
                cmm.Parameters.AddWithValue("@CODIGO_CARGO_EMPLEADO_FK", Codigo_Cargo_Empleado_FKM);
                cmm.Parameters.AddWithValue("@ESTADO_EMPLEADO", Estado_EmpleadoM);
                cmm.Parameters.AddWithValue("@CODIGO_PROVEEDORES_EMPLEADO_FK ", Codigo_Proveedores_Empleado_FKM);
                
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo empleado");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo empleado" + e);
            }
        }
        public void Modificar_Empleado()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_EMPLEADO";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOCODIGO_EMPLEADO", Codigo_EmpleadoM);
                cmm.Parameters.AddWithValue("@MOID_EMPLEADO", Id_EmpleadoM);
                cmm.Parameters.AddWithValue("@MONOMBRE_EMPLEADO", Nombre_EmpleadoM);
                cmm.Parameters.AddWithValue("@MODIRECCION_EMPLEADO", Direccion_EmpleadoM);
                cmm.Parameters.AddWithValue("@MOTELEFONO_EMPLEADO", Telefono_EmpleadoM);
                cmm.Parameters.AddWithValue("@MOFECHANACI_EMPLEADO", FechaNaci_EmpleadoM);
                cmm.Parameters.AddWithValue("@MOUSUARIO_INISESION_EMPLEADO_FK", Usuario_IniSesion_Empleado_FKM);
                cmm.Parameters.AddWithValue("@MOSALARIO_EMPLEADO", Salario_EmpleadoM);
                cmm.Parameters.AddWithValue("@MOGENERO_EMPLEADO", Genero_EmpleadoM);
                cmm.Parameters.AddWithValue("@MOCODIGO_CARGO_EMPLEADO_FK", Codigo_Cargo_Empleado_FKM);
                cmm.Parameters.AddWithValue("@MOESTADO_EMPLEADO", Estado_EmpleadoM);
                cmm.Parameters.AddWithValue("@MOCODIGO_PROVEEDORES_EMPLEADO_FK ", Codigo_Proveedores_Empleado_FKM);

                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado correctamente un empleado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un empleado" + ex);
            }
        }
        public void Consultar_EmpleadoG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_EMPLEADO";
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
        public void ConsultarEmpleadoEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_EMPLEADO_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONCODIGO_EMPLEADO", Codigo_EmpleadoM);
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
        public void Eliminar_Empleado()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_EMPLEADO";
                cmm.Parameters.AddWithValue("@CODIGOEMPLEADO", Codigo_EmpleadoM);
                cmm.Parameters.AddWithValue("@ESTADOEMPLEADO", Estado_EmpleadoM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN EMPLEADO");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
