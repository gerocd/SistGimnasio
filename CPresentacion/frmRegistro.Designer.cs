namespace SistGimnasio.CPresentacion
{
    partial class frmRegistro
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuarioR = new System.Windows.Forms.TextBox();
            this.txtContraseñaR = new System.Windows.Forms.TextBox();
            this.txtRepetirU = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            this.lblUsuarioR = new System.Windows.Forms.Label();
            this.lblContraseñaR = new System.Windows.Forms.Label();
            this.lblContraseñaR2 = new System.Windows.Forms.Label();
            this.rdbSalir = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistGimnasio.Properties.Resources.pngwing_com__16_;
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtUsuarioR.Location = new System.Drawing.Point(197, 139);
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.Size = new System.Drawing.Size(178, 20);
            this.txtUsuarioR.TabIndex = 1;
            // 
            // txtContraseñaR
            // 
            this.txtContraseñaR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtContraseñaR.Location = new System.Drawing.Point(197, 239);
            this.txtContraseñaR.Name = "txtContraseñaR";
            this.txtContraseñaR.Size = new System.Drawing.Size(178, 20);
            this.txtContraseñaR.TabIndex = 2;
            this.txtContraseñaR.TextChanged += new System.EventHandler(this.txtContraseñaR_TextChanged);
            // 
            // txtRepetirU
            // 
            this.txtRepetirU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRepetirU.Location = new System.Drawing.Point(197, 188);
            this.txtRepetirU.Name = "txtRepetirU";
            this.txtRepetirU.Size = new System.Drawing.Size(178, 20);
            this.txtRepetirU.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(197, 335);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarme.Location = new System.Drawing.Point(176, 287);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(131, 32);
            this.btnRegistrarme.TabIndex = 5;
            this.btnRegistrarme.Text = "REGISTRARME";
            this.btnRegistrarme.UseVisualStyleBackColor = true;
            this.btnRegistrarme.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUsuarioR
            // 
            this.lblUsuarioR.AutoSize = true;
            this.lblUsuarioR.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioR.Location = new System.Drawing.Point(87, 131);
            this.lblUsuarioR.Name = "lblUsuarioR";
            this.lblUsuarioR.Size = new System.Drawing.Size(101, 28);
            this.lblUsuarioR.TabIndex = 6;
            this.lblUsuarioR.Text = "Usuario:";
            this.lblUsuarioR.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseñaR
            // 
            this.lblContraseñaR.AutoSize = true;
            this.lblContraseñaR.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaR.Location = new System.Drawing.Point(51, 180);
            this.lblContraseñaR.Name = "lblContraseñaR";
            this.lblContraseñaR.Size = new System.Drawing.Size(140, 28);
            this.lblContraseñaR.TabIndex = 7;
            this.lblContraseñaR.Text = "Contraseña:";
            // 
            // lblContraseñaR2
            // 
            this.lblContraseñaR2.AutoSize = true;
            this.lblContraseñaR2.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaR2.Location = new System.Drawing.Point(48, 231);
            this.lblContraseñaR2.Name = "lblContraseñaR2";
            this.lblContraseñaR2.Size = new System.Drawing.Size(140, 28);
            this.lblContraseñaR2.TabIndex = 8;
            this.lblContraseñaR2.Text = "Contraseña:";
            // 
            // rdbSalir
            // 
            this.rdbSalir.AutoSize = true;
            this.rdbSalir.BackColor = System.Drawing.Color.Transparent;
            this.rdbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSalir.ForeColor = System.Drawing.Color.Red;
            this.rdbSalir.Location = new System.Drawing.Point(389, 2);
            this.rdbSalir.Name = "rdbSalir";
            this.rdbSalir.Size = new System.Drawing.Size(50, 17);
            this.rdbSalir.TabIndex = 9;
            this.rdbSalir.TabStop = true;
            this.rdbSalir.Text = "Salir";
            this.rdbSalir.UseVisualStyleBackColor = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistGimnasio.Properties.Resources.pngwing_com__17_;
            this.ClientSize = new System.Drawing.Size(448, 439);
            this.Controls.Add(this.rdbSalir);
            this.Controls.Add(this.lblContraseñaR2);
            this.Controls.Add(this.lblContraseñaR);
            this.Controls.Add(this.lblUsuarioR);
            this.Controls.Add(this.btnRegistrarme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtRepetirU);
            this.Controls.Add(this.txtContraseñaR);
            this.Controls.Add(this.txtUsuarioR);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuarioR;
        private System.Windows.Forms.TextBox txtContraseñaR;
        private System.Windows.Forms.TextBox txtRepetirU;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.Label lblUsuarioR;
        private System.Windows.Forms.Label lblContraseñaR;
        private System.Windows.Forms.Label lblContraseñaR2;
        private System.Windows.Forms.RadioButton rdbSalir;
    }
}