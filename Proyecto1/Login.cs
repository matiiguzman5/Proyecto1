﻿using Proyecto1.Controladores;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                String correo = txtUser.Text;
                String contrasena = txtPass.Text;

                if (User_controller.autenticar(correo, contrasena))
                {
                    Main ingresar = new Main();
                    ingresar.Show();
                    this.Hide();
                }
                else
                {

                }


            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
