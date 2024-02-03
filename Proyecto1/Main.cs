using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newTask = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva tarea:", "Agregar Tarea", "");
        }

        private void InProgressBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FinishedBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
