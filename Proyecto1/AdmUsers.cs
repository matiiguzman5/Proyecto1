using Proyecto1.Controladores;
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
    public partial class AdmUsers : Form
    {
        public AdmUsers()
        {
            InitializeComponent();
        }

        private void AdmUsers_Load(object sender, EventArgs e)
        {
         
            this.usuarioTableAdapter1.Fill(this.usuariosDataSet1.usuario);
            
        }

        private void btn_crearUser_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este Usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool estaeli = User_controller.EliminarUser(id);
                    if (estaeli)
                    {
                        this.usuarioTableAdapter1.Fill(this.usuariosDataSet1.usuario);

                        
                        
                        MessageBox.Show("Usuario eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Vlvbtn_Click(object sender, EventArgs e)
        {
            Main volver = new Main();
            volver.Show();
            this.Hide();
        }
    }
}
