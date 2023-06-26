using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BASE_DATOS
{
    public class CONEXION
    {
        static SqlDataAdapter adaptador = new SqlDataAdapter();
        public SqlConnection con = new SqlConnection();
        static SqlCommand comando = new SqlCommand();
        public DataTable tabla = new DataTable();

        private string ConsultaSQL;

        private string Cadena_Conexion = ("Data source = (local);Initial Catalog = Proyecto ; Integrated Security = True");

        public void Set_Consulta_sql(string consulta)
        {
            ConsultaSQL = consulta;
        }

        public void Insertar_Datos()
        {
            try
            {
                comando = new SqlCommand(ConsultaSQL, con);
                comando.ExecuteNonQuery();
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Error al insertar");
                MessageBox.Show(ex.Message);
            }
        }
        /// Metodo para abrir base de datos

        public bool conectar()
        {
            bool Estado = true;

            try
            {
                con.ConnectionString = Cadena_Conexion;
                con.Open();
            }
            catch
            {
                Estado = false;
                MessageBox.Show("Error al conectar con el servidor");
            }
            return Estado;
        }
        // Metodo para cerrar la conexion
        public void Desconectar()
        {
            con.Close();
        }
        public SqlCommand Get_Command()
        {
            return comando = new SqlCommand(ConsultaSQL, con);
        }
    }
}
