using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }

    
    public Usuario(int Id, string correo, string Contrasena)
    {
            this.correo = correo;
            contrasena = Contrasena;
        }
    public Usuario()
        {
            
        }
    }
}
