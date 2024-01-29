namespace Proyecto1
{
    partial class Registrarse
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
            this.btnRegis1 = new System.Windows.Forms.Button();
            this.btnVolverigis = new System.Windows.Forms.Button();
            this.txtNomUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegis1
            // 
            this.btnRegis1.Location = new System.Drawing.Point(296, 259);
            this.btnRegis1.Name = "btnRegis1";
            this.btnRegis1.Size = new System.Drawing.Size(75, 23);
            this.btnRegis1.TabIndex = 0;
            this.btnRegis1.Text = "Crear";
            this.btnRegis1.UseVisualStyleBackColor = true;
            this.btnRegis1.Click += new System.EventHandler(this.btnRegis1_Click);
            // 
            // btnVolverigis
            // 
            this.btnVolverigis.Location = new System.Drawing.Point(396, 259);
            this.btnVolverigis.Name = "btnVolverigis";
            this.btnVolverigis.Size = new System.Drawing.Size(75, 23);
            this.btnVolverigis.TabIndex = 1;
            this.btnVolverigis.Text = "Volver";
            this.btnVolverigis.UseVisualStyleBackColor = true;
            this.btnVolverigis.Click += new System.EventHandler(this.btnVolverigis_Click);
            // 
            // txtNomUser
            // 
            this.txtNomUser.Location = new System.Drawing.Point(331, 148);
            this.txtNomUser.Name = "txtNomUser";
            this.txtNomUser.Size = new System.Drawing.Size(124, 20);
            this.txtNomUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(331, 205);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(124, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crear Usuario";
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNomUser);
            this.Controls.Add(this.btnVolverigis);
            this.Controls.Add(this.btnRegis1);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegis1;
        private System.Windows.Forms.Button btnVolverigis;
        private System.Windows.Forms.TextBox txtNomUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}