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
            string query = "insert into dbo.usuario values" +
                "(@correo, " +
                "@contrasena, " +
                "@rol);";

            SqlCommand cmd = new SqlCommand(query, Db_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtMaxId() + 1);
            cmd.Parameters.AddWithValue("@usuario", users.correo);
            cmd.Parameters.AddWithValue("@contraseña", users.contrasena);
            
            try
            {
                Db_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                Db_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Hay un error en la Query" + ex.Message);

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
    }
}
