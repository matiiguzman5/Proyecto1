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
            this.addTask = new System.Windows.Forms.Button();
            this.txtTaskBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDeleteTask = new System.Windows.Forms.Button();
            this.BtnMoveProgress1 = new System.Windows.Forms.Button();
            this.BtnMoveFinished = new System.Windows.Forms.Button();
            this.btnMoveProgress = new System.Windows.Forms.Button();
            this.BtnMovePending = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PendingBox
            // 
            this.PendingBox.FormattingEnabled = true;
            this.PendingBox.Location = new System.Drawing.Point(0, 87);
            this.PendingBox.Name = "PendingBox";
            this.PendingBox.Size = new System.Drawing.Size(239, 238);
            this.PendingBox.TabIndex = 0;
            this.PendingBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // InProgressBox
            // 
            this.InProgressBox.FormattingEnabled = true;
            this.InProgressBox.Location = new System.Drawing.Point(277, 87);
            this.InProgressBox.Name = "InProgressBox";
            this.InProgressBox.Size = new System.Drawing.Size(239, 238);
            this.InProgressBox.TabIndex = 1;
            this.InProgressBox.SelectedIndexChanged += new System.EventHandler(this.InProgressBox_SelectedIndexChanged);
            // 
            // FinishedBox
            // 
            this.FinishedBox.FormattingEnabled = true;
            this.FinishedBox.Location = new System.Drawing.Point(555, 87);
            this.FinishedBox.Name = "FinishedBox";
            this.FinishedBox.Size = new System.Drawing.Size(243, 238);
            this.FinishedBox.TabIndex = 2;
            this.FinishedBox.SelectedIndexChanged += new System.EventHandler(this.FinishedBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(60, 67);
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
            this.label3.Location = new System.Drawing.Point(642, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Finalizado";
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(284, 345);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(158, 36);
            this.addTask.TabIndex = 6;
            this.addTask.Text = "Agregar Tarea";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // txtTaskBox
            // 
            this.txtTaskBox.Location = new System.Drawing.Point(12, 345);
            this.txtTaskBox.Multiline = true;
            this.txtTaskBox.Name = "txtTaskBox";
            this.txtTaskBox.Size = new System.Drawing.Size(252, 102);
            this.txtTaskBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Escriba la nueva tarea :";
            // 
            // BtnDeleteTask
            // 
            this.BtnDeleteTask.Location = new System.Drawing.Point(284, 402);
            this.BtnDeleteTask.Name = "BtnDeleteTask";
            this.BtnDeleteTask.Size = new System.Drawing.Size(158, 36);
            this.BtnDeleteTask.TabIndex = 9;
            this.BtnDeleteTask.Text = "Eliminar Tarea";
            this.BtnDeleteTask.UseVisualStyleBackColor = true;
            this.BtnDeleteTask.Click += new System.EventHandler(this.BtnDeleteTask_Click);
            // 
            // BtnMoveProgress1
            // 
            this.BtnMoveProgress1.Location = new System.Drawing.Point(522, 215);
            this.BtnMoveProgress1.Name = "BtnMoveProgress1";
            this.BtnMoveProgress1.Size = new System.Drawing.Size(27, 27);
            this.BtnMoveProgress1.TabIndex = 10;
            this.BtnMoveProgress1.Text = "<";
            this.BtnMoveProgress1.UseVisualStyleBackColor = true;
            this.BtnMoveProgress1.Click += new System.EventHandler(this.BtnMoveProgress1_Click);
            // 
            // BtnMoveFinished
            // 
            this.BtnMoveFinished.Location = new System.Drawing.Point(522, 161);
            this.BtnMoveFinished.Name = "BtnMoveFinished";
            this.BtnMoveFinished.Size = new System.Drawing.Size(27, 27);
            this.BtnMoveFinished.TabIndex = 11;
            this.BtnMoveFinished.Text = ">";
            this.BtnMoveFinished.UseVisualStyleBackColor = true;
            this.BtnMoveFinished.Click += new System.EventHandler(this.BtnMoveFinished_Click);
            // 
            // btnMoveProgress
            // 
            this.btnMoveProgress.Location = new System.Drawing.Point(245, 161);
            this.btnMoveProgress.Name = "btnMoveProgress";
            this.btnMoveProgress.Size = new System.Drawing.Size(27, 27);
            this.btnMoveProgress.TabIndex = 12;
            this.btnMoveProgress.Text = ">";
            this.btnMoveProgress.UseVisualStyleBackColor = true;
            this.btnMoveProgress.Click += new System.EventHandler(this.btnMoveProgress_Click);
            // 
            // BtnMovePending
            // 
            this.BtnMovePending.Location = new System.Drawing.Point(245, 215);
            this.BtnMovePending.Name = "BtnMovePending";
            this.BtnMovePending.Size = new System.Drawing.Size(27, 27);
            this.BtnMovePending.TabIndex = 13;
            this.BtnMovePending.Text = "<";
            this.BtnMovePending.UseVisualStyleBackColor = true;
            this.BtnMovePending.Click += new System.EventHandler(this.BtnMovePending_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnMovePending);
            this.Controls.Add(this.btnMoveProgress);
            this.Controls.Add(this.BtnMoveFinished);
            this.Controls.Add(this.BtnMoveProgress1);
            this.Controls.Add(this.BtnDeleteTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTaskBox);
            this.Controls.Add(this.addTask);
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
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.TextBox txtTaskBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDeleteTask;
        private System.Windows.Forms.Button BtnMoveProgress1;
        private System.Windows.Forms.Button BtnMoveFinished;
        private System.Windows.Forms.Button btnMoveProgress;
        private System.Windows.Forms.Button BtnMovePending;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}