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
        public string user { get; set; }
        public string Contraseña { get; set; }

    
    public Usuario()
    {
    }
    public Usuario(int Id ,string user, string contraseña, int v)
        {
            this.user = user;
            Contraseña = contraseña;
        }
    }
}
