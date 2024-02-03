namespace Proyecto1
{
    partial class Main
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
            this.PendingBox = new System.Windows.Forms.ListBox();
            this.InProgressBox = new System.Windows.Forms.ListBox();
            this.FinishedBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PendingBox
            // 
            this.PendingBox.FormattingEnabled = true;
            this.PendingBox.Location = new System.Drawing.Point(12, 87);
            this.PendingBox.Name = "PendingBox";
            this.PendingBox.Size = new System.Drawing.Size(239, 277);
            this.PendingBox.TabIndex = 0;
            this.PendingBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // InProgressBox
            // 
            this.InProgressBox.FormattingEnabled = true;
            this.InProgressBox.Location = new System.Drawing.Point(284, 87);
            this.InProgressBox.Name = "InProgressBox";
            this.InProgressBox.Size = new System.Drawing.Size(239, 277);
            this.InProgressBox.TabIndex = 1;
            this.InProgressBox.SelectedIndexChanged += new System.EventHandler(this.InProgressBox_SelectedIndexChanged);
            // 
            // FinishedBox
            // 
            this.FinishedBox.FormattingEnabled = true;
            this.FinishedBox.Location = new System.Drawing.Point(545, 87);
            this.FinishedBox.Name = "FinishedBox";
            this.FinishedBox.Size = new System.Drawing.Size(243, 277);
            this.FinishedBox.TabIndex = 2;
            this.FinishedBox.SelectedIndexChanged += new System.EventHandler(this.FinishedBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(70, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pendientes :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(360, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "En Proceso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(628, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Finalizado";
            // 
            // AddTask
            // 
            this.AddTask.Location = new System.Drawing.Point(336, 393);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(139, 45);
            this.AddTask.TabIndex = 6;
            this.AddTask.Text = "Agregar Tarea";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishedBox);
            this.Controls.Add(this.InProgressBox);
            this.Controls.Add(this.PendingBox);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PendingBox;
        private System.Windows.Forms.ListBox InProgressBox;
        private System.Windows.Forms.ListBox FinishedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddTask;
    }
}