using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using


using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Need4Sprint.Clases
{

    internal class ConexionBD
    {
        private readonly string cadenaDeConexion;
        //fixme
        /*
         * Aca se modifica los valores una vez implementados los cambios
         */
        public ConexionBD(string baseDatos, string contraseña = "")
        {
            string servidor = "localhost";
            string usuario = "root";

            cadenaDeConexion = $"Server={servidor};Database={baseDatos};User ID={usuario};Password={contraseña};" +
                               "Pooling=true;SslMode=none;";
        }
        public bool ValidarConexion()
        {
            using(MySqlConnection conexion = new MySqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base datos");
                    return true;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    string query = $"SELECT COUNT(*) FROM Usuarios WHERE nombre = {usuario} AND contrasena = {contrasena} ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                        return resultado > 0 && resultado < 2;
                    }
                    
                }
                catch (MySqlException e)
                {
                    Console.WriteLine($"Error al verificar el usuario: {e.Message}");
                    return false;
                }
            }
        }

    }

}
