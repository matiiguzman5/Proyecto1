namespace Proyecto1
{
    partial class AdmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuariosDataSet = new Proyecto1.UsuariosDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Proyecto1.UsuariosDataSetTableAdapters.UsuarioTableAdapter();
            this.btn_crearUser = new System.Windows.Forms.Button();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataSet1 = new Proyecto1.UsuariosDataSet1();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter1 = new Proyecto1.UsuariosDataSet1TableAdapters.usuarioTableAdapter();
            this.Vlvbtn = new System.Windows.Forms.Button();
            this.modUser = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.sectorDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dataGridView1.DataSource = this.usuarioBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usuariosDataSet
            // 
            this.usuariosDataSet.DataSetName = "UsuariosDataSet";
            this.usuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.usuariosDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btn_crearUser
            // 
            this.btn_crearUser.Location = new System.Drawing.Point(573, 29);
            this.btn_crearUser.Name = "btn_crearUser";
            this.btn_crearUser.Size = new System.Drawing.Size(93, 37);
            this.btn_crearUser.TabIndex = 1;
            this.btn_crearUser.Text = "Crear Usuario";
            this.btn_crearUser.UseVisualStyleBackColor = true;
            this.btn_crearUser.Click += new System.EventHandler(this.btn_crearUser_Click);
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.usuariosDataSet;
            // 
            // usuariosDataSet1
            // 
            this.usuariosDataSet1.DataSetName = "UsuariosDataSet1";
            this.usuariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "usuario";
            this.usuarioBindingSource2.DataSource = this.usuariosDataSet1;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // Vlvbtn
            // 
            this.Vlvbtn.Location = new System.Drawing.Point(672, 29);
            this.Vlvbtn.Name = "Vlvbtn";
            this.Vlvbtn.Size = new System.Drawing.Size(93, 37);
            this.Vlvbtn.TabIndex = 2;
            this.Vlvbtn.Text = "Volver";
            this.Vlvbtn.UseVisualStyleBackColor = true;
            this.Vlvbtn.Click += new System.EventHandler(this.Vlvbtn_Click);
            // 
            // modUser
            // 
            this.modUser.Location = new System.Drawing.Point(448, 29);
            this.modUser.Name = "modUser";
            this.modUser.Size = new System.Drawing.Size(105, 37);
            this.modUser.TabIndex = 4;
            this.modUser.Text = "Modificar Usuario";
            this.modUser.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "contrasena";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            // 
            // sectorDataGridViewTextBoxColumn
            // 
            this.sectorDataGridViewTextBoxColumn.DataPropertyName = "sector";
            this.sectorDataGridViewTextBoxColumn.HeaderText = "sector";
            this.sectorDataGridViewTextBoxColumn.Name = "sectorDataGridViewTextBoxColumn";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // AdmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modUser);
            this.Controls.Add(this.Vlvbtn);
            this.Controls.Add(this.btn_crearUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdmUsers";
            this.Text = "AdmUsers";
            this.Load += new System.EventHandler(this.AdmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UsuariosDataSet usuariosDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private UsuariosDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Button btn_crearUser;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private UsuariosDataSet1 usuariosDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private UsuariosDataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.Button Vlvbtn;
        private System.Windows.Forms.Button modUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}