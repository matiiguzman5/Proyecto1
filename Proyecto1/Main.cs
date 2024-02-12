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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            label5.Text = "Bienvenido " + Program.logueado.correo;

            label6.Text = "Sector : " + Program.logueado.sector;

            //if(Program.logueado == 1)
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        List<String> tareas = new List<String>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void InProgressBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FinishedBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            string tareass;

            tareass = txtTaskBox.Text;
            tareas.Add(tareass);

            PendingBox.DataSource = null;
            PendingBox.DataSource = tareas;
            
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            tareas.Remove(PendingBox.Text);
            tareas.Remove(InProgressBox.Text);
            tareas.Remove(FinishedBox.Text);
            PendingBox.DataSource = null;
            PendingBox.DataSource = tareas;
            
        }

        private void btnMoveProgress_Click(object sender, EventArgs e)
        {
            
            InProgressBox.Items.Add(PendingBox.SelectedItem);
            tareas.Remove(PendingBox.Text);

            PendingBox.DataSource = null;
            PendingBox.DataSource = tareas;
            
        }

        private void BtnMovePending_Click(object sender, EventArgs e)
        {
            PendingBox.Items.Add(InProgressBox.SelectedItem);
            tareas.Remove(InProgressBox.Text);
            InProgressBox.DataSource = null;
            InProgressBox.DataSource = tareas;
            
        }

        private void BtnMoveFinished_Click(object sender, EventArgs e)
        {
            FinishedBox.Items.Add(InProgressBox.SelectedItem);
            
            tareas.Remove(InProgressBox.Text);
            FinishedBox.DataSource = null;
            FinishedBox.DataSource = tareas;
        }

        private void BtnMoveProgress1_Click(object sender, EventArgs e)
        {
            InProgressBox.Items.Add(FinishedBox.SelectedItem);

            tareas.Remove(FinishedBox.Text);
            FinishedBox.DataSource = null;
            FinishedBox.DataSource = tareas;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}


