using MySql.Data.MySqlClient;
using System.Data;

    public class Conexion
    {
        private string cadenaConexion;
        private MySqlConnection conexion;
        private string user;
        private string password;

        public Conexion(string user, string password)
        {
            cadenaConexion = "Server=s18120163.mysql.database.azure.com;Database=mydb;User=" + user+";Password="+password+";";
            conexion = new MySqlConnection(cadenaConexion);
        }
        public MySqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {

                MessageBox.Show("se armo");
                    conexion.Open();
                }
            }
            catch (MySqlException ex)
            {
            // Manejar excepciones en caso de problemas de conexión
                MessageBox.Show("Error de conexión: " + ex.Message);
            }

            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
