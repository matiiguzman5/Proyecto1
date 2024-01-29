using Proyecto1.Controladores;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto1
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverigis_Click(object sender, EventArgs e)
        {
            Login volver= new Login();
            volver.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegis1_Click(object sender, EventArgs e)
        {
            string usuario = txtNomUser.Text;
            string contraseña = txtPass.Text;

            
            Usuario nuevoUsuario = new Usuario
            {
                user = usuario,
                Contraseña = contraseña
            };

            
           
        }
    }
}
