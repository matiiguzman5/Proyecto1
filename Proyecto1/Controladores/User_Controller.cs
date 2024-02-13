using Proyecto1.Controladores;
using Proyecto1.Modelo;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto1.Controladores
{
    class User_controller
    {
        public static bool autenticar(string usuario, string pass)
        {
            Usuario user = new Usuario();
            string query = "select * from dbo.usuario where correo = @correo and contrasena = @contrasena;\r\n";

            SqlCommand cmd = new SqlCommand(query, Db_Controller.connection);
            cmd.Parameters.AddWithValue("@correo", usuario);
            
            cmd.Parameters.AddWithValue("@contrasena", pass);

            
        

            try
            {
                Db_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Id = reader.GetInt32(0);
                    user.correo = reader.GetString(1);
                    user.contrasena = reader.GetString(2);
                    user.sector = reader.GetString(3);

                    Program.logueado = user;
                }
                reader.Close();
                Db_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la Query: " + ex.Message);
                
            }

        }
        public static bool crearUsuario(Usuario users)
        {
            string query = "INSERT INTO dbo.usuario (correo, contrasena, sector) VALUES (@correo, @contrasena, @sector);";

            SqlCommand cmd = new SqlCommand(query, Db_Controller.connection);
            cmd.Parameters.AddWithValue("@correo", users.correo);
            cmd.Parameters.AddWithValue("@contrasena", users.contrasena);
            cmd.Parameters.AddWithValue("@sector", users.sector);

            try
            {
                Db_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la Query" + ex.Message);
            }
            finally
            {
                Db_Controller.connection.Close();
            }
        }

        public static int obtMaxId()
        {
            int MaxId = 0;
            string query = "select Max(id) from dbo.usuario;";

            SqlCommand cmd = new SqlCommand(query, Db_Controller.connection);

            try
            {
                Db_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }
                reader.Close();
                Db_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la Query: " + ex.Message);
            }
        }
        public static Usuario obtenerinfoUser(string correo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Db_Controller.connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM dbo.usuario WHERE correo = @correo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@correo", correo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                int id = Convert.ToInt32(reader["id"]);
                                string user = Convert.ToString(reader["correo"]);
                                string contrasena = Convert.ToString(reader["contrasena"]);
                                string sector = Convert.ToString(reader["sector"]);

                                return new Usuario (id, user , contrasena, sector);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Usuario o contraseña incorrecta : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
            return null;
        }
        public static bool EliminarUser(int id)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Db_Controller.connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM dbo.usuario WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el Usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
