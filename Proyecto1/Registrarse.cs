using Proyecto1.Controladores;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            Usuario usr = new Usuario(0, txtNomUser.Text, txtPass.Text, boxArea.Text);

            if (User_controller.crearUsuario(usr))
            {
                MessageBox.Show("Usuario creado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("No se pudo crear el Usuario." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                     
            

            
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
