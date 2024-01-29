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




namespace TinderFut1.Controladores
{
    class User_controller
    {
        public static bool autenticar(string usuario, string pass, bool hasheado)
        {
            Usuario user = new Usuario();
            string query = "select * from dbo.usuario where Usuario = @usuario and contraseña = @contraseña ; ";

            SqlCommand cmd = new SqlCommand(query, Db_Controller.connection);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            if (hasheado)
            {
                cmd.Parameters.AddWithValue("@contraseña", pass);
            }
            else
            {
                //cmd.Parameters.AddWithValue("@contraseña", hc.PassHash(pass));
            }

            try
            {
                Db_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Trace.WriteLine("Usuario encontrado, nombre " + reader.GetString(1));
                    user = new Usuario(reader.GetInt32(0), reader.GetString(1), "", reader.GetInt32(3));
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
            string query = "insert into dbo.Usuario values" +
                "(@usuario, " +
                "@contraseña, " +
                "@rol);";

            SqlCommand cmd = new SqlCommand(query, Db_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtMaxId() + 1);
            cmd.Parameters.AddWithValue("@usuario", users.user);
            cmd.Parameters.AddWithValue("@contraseña", users.Contraseña);
            
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
            string query = "select Max(id) from dbo.Usuario;";

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
