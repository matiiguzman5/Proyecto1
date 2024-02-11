using Proyecto1.Controladores;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        public static int debug_mode = 0;

        public static Usuario logueado;
         
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Db_Controller.initialize();

            if (connectionIsValid())
            {
                if(debug_mode == 1)
                {
                    Trace.WriteLine("Conexion creada con exito");
                }
            }

            Application.Run(new Login());
        }

        public static bool connectionIsValid()
        {
            try
            {
                Db_Controller.connection.Open();
                Db_Controller.connection.Close();
                return true;
            } catch (Exception e)
            {
                if(debug_mode == 1) 
                {
                    Trace.WriteLine("Conexion a la DB con error " + e.Message);
                }
                
                return false;
            }
        }
    }
}
