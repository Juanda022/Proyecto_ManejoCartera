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
    public class Clase_Inicio_Sesion : BASE_DATOS.CONEXION
    {
        private string USUARIO_USUARIO;
        private string CONTRASEÑA_USUARIO;
        private string NOMBRE_USUARIO;
        private string ROL_USUARIO;
        private string ESTADO_USUARIO;

        public string Usuario_UsuarioM
        {
            get { return USUARIO_USUARIO; }
            set { USUARIO_USUARIO = value; }
        }
        public string Contraseña_UsuarioM
        {
            get { return CONTRASEÑA_USUARIO; }
            set { CONTRASEÑA_USUARIO = value; }
        }
        public string Nombre_UsuarioM
        {
            get { return NOMBRE_USUARIO; }
            set { NOMBRE_USUARIO = value; }
        }
        public string Rol_UsuarioM
        {
            get { return ROL_USUARIO; }
            set { ROL_USUARIO = value; }
        }
        public string Estado_UsuarioM
        {
            get { return ESTADO_USUARIO; }
            set { ESTADO_USUARIO = value; }
        }
        public void Datos_usuario(string usu, string cont, string Nom, string Rol, string EstaI)
        {
            this.Usuario_UsuarioM = usu;
            this.Contraseña_UsuarioM = cont;
            this.Nombre_UsuarioM = Nom;
            this.Rol_UsuarioM = Rol;
            this.Estado_UsuarioM = EstaI;
        }
        public void Datos_eleminar_Inisesion(string Id, string Estado)
        {
            this.Usuario_UsuarioM = Id;
            this.Estado_UsuarioM = Estado;
        }
        public void Insertar_nuevo_Usuario()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "AGREGAR_USUARIO";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@USUARIO_USUARIO", Usuario_UsuarioM);
                cmm.Parameters.AddWithValue("@CONTRASEÑA_USUARIO", Contraseña_UsuarioM);
                cmm.Parameters.AddWithValue("@NOMBRE_USUARIO", Nombre_UsuarioM);
                cmm.Parameters.AddWithValue("@ROL_USUARIO", Rol_UsuarioM);
                cmm.Parameters.AddWithValue("@ESTADO_USUARIO", Estado_UsuarioM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha insertado correctamente un nuevo usuario");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar nuevo usuario" + e);
            }
        }
        public void Modificar_Ini_Sesion()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;
                conectar();

                cmm.CommandType = System.Data.CommandType.StoredProcedure;// se establece que va a trabajar 
                cmm.CommandText = "MODIFICAR_INI_SESION";//se asigna un procedimiento que permite insertar
                cmm.Parameters.AddWithValue("@MOUSUARIOSESION", Usuario_UsuarioM);
                cmm.Parameters.AddWithValue("@MOCONTRASEÑASESION", Contraseña_UsuarioM);
                cmm.Parameters.AddWithValue("@MONOMBRESESION", Nombre_UsuarioM);
                cmm.Parameters.AddWithValue("@MOROLUSUARIO", Rol_UsuarioM);
                cmm.Parameters.AddWithValue("@MOESTADOSESION", Estado_UsuarioM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("Se ha modificado un usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un usuario" + ex);
            }
        }
        public void Validacion_LoginM(ref TextBox usuario, ref TextBox contraseña, ref TextBox nombre, ref TextBox Rol, ref TextBox EstadoIn)
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand("VALIDAR_USUARIO", con);
                cmm.Connection = con;
                conectar();
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@USUARIO", Usuario_UsuarioM);
                cmm.Parameters.AddWithValue("@CONTRASEÑA", Contraseña_UsuarioM);
                cmm.Parameters.AddWithValue("@NOMBRE", Nombre_UsuarioM);
                cmm.Parameters.AddWithValue("@ROL", Rol_UsuarioM);
                cmm.Parameters.AddWithValue("@ESTADO", Estado_UsuarioM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Desconectar();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bienvenido:  "   +   Nombre_UsuarioM);
                    foreach (DataRow filas in dt.Rows)
                    {
                        usuario.Text = filas["Usuario_Usuario"].ToString();
                        contraseña.Text = filas["Contraseña_Usuario"].ToString();
                        nombre.Text = filas["Nombre_Usuario"].ToString();
                        Rol.Text = filas["Rol_Usuario"].ToString();
                        EstadoIn.Text = filas["Estado_Usuario"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ese usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
                Desconectar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se encontro el usuario" + ex);
            }
        }
        public void Consultar_IniSesionG(ref DataGridView Grilla)
        {
            try
            {
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_USUARIO";
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
        public void ConsultarIni_SesionEspecifico(ref DataGridView Grilla)
        {
            try
            {
                Desconectar();
                DataTable tabla = new DataTable();
                SqlCommand cmm = new SqlCommand();
                DataSet dset = new DataSet();
                conectar();
                string nomproce;
                nomproce = "CONSULTAR_INIUSUARIO_ESPECIFICO";
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = nomproce;
                cmm.Parameters.AddWithValue("@CONUSUARIO_INISESION", Usuario_UsuarioM);
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
        public void Eliminar_Ini_Sesion()
        {
            try
            {
                Desconectar();
                SqlCommand cmm = new SqlCommand();
                conectar();
                cmm.Connection = con;
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = "ELIMINAR_INISESION";
                cmm.Parameters.AddWithValue("@USUARIOINISESION", Usuario_UsuarioM);
                cmm.Parameters.AddWithValue("@ESTADOINISESION", Estado_UsuarioM);
                SqlDataReader reader = cmm.ExecuteReader();
                reader.Close();
                Desconectar();
                MessageBox.Show("SE HA ELIMINADO UN USUARIO");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR ESTE REGISTRO, CAMPO VACIO" + e);
            }
        }
    }
}
