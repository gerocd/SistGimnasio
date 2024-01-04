namespace SistGimnasio.CPresentacion
{
    partial class frmMenu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblFacturación = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.rdbSalir = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(51, 24);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(161, 42);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes";
            // 
            // lblFacturación
            // 
            this.lblFacturación.AutoSize = true;
            this.lblFacturación.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturación.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturación.Location = new System.Drawing.Point(386, 24);
            this.lblFacturación.Name = "lblFacturación";
            this.lblFacturación.Size = new System.Drawing.Size(225, 42);
            this.lblFacturación.TabIndex = 3;
            this.lblFacturación.Text = "Facturación";
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientes.Image = global::SistGimnasio.Properties.Resources.usuarios__1_;
            this.btnClientes.Location = new System.Drawing.Point(39, 112);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(230, 250);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.White;
            this.btnFactura.Image = global::SistGimnasio.Properties.Resources.cuenta;
            this.btnFactura.Location = new System.Drawing.Point(380, 112);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(231, 250);
            this.btnFactura.TabIndex = 5;
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // rdbSalir
            // 
            this.rdbSalir.AutoSize = true;
            this.rdbSalir.BackColor = System.Drawing.Color.Transparent;
            this.rdbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSalir.ForeColor = System.Drawing.Color.Red;
            this.rdbSalir.Location = new System.Drawing.Point(632, 0);
            this.rdbSalir.Name = "rdbSalir";
            this.rdbSalir.Size = new System.Drawing.Size(50, 17);
            this.rdbSalir.TabIndex = 6;
            this.rdbSalir.TabStop = true;
            this.rdbSalir.Text = "Salir";
            this.rdbSalir.UseVisualStyleBackColor = false;
            this.rdbSalir.CheckedChanged += new System.EventHandler(this.rdbSalir_CheckedChanged);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistGimnasio.Properties.Resources._3412131;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 413);
            this.ControlBox = false;
            this.Controls.Add(this.rdbSalir);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblFacturación);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblFacturación;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.RadioButton rdbSalir;
    }
}