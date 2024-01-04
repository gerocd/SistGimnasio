namespace SistGimnasio.CPresentacion
{
    partial class frmFactura
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
            this.txtIdf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.btnEliminarF = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnActualizarF = new System.Windows.Forms.Button();
            this.txtPack = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtBuscarPlan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolverF = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdf
            // 
            this.txtIdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdf.Location = new System.Drawing.Point(153, 77);
            this.txtIdf.Name = "txtIdf";
            this.txtIdf.Size = new System.Drawing.Size(56, 20);
            this.txtIdf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plan:";
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarF.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarF.Image = global::SistGimnasio.Properties.Resources.aceptar__1_;
            this.btnAgregarF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarF.Location = new System.Drawing.Point(12, 306);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(152, 50);
            this.btnAgregarF.TabIndex = 5;
            this.btnAgregarF.Text = "Agregar";
            this.btnAgregarF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarF.UseVisualStyleBackColor = true;
            this.btnAgregarF.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarF
            // 
            this.btnEliminarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarF.Image = global::SistGimnasio.Properties.Resources.cancelar__1_1;
            this.btnEliminarF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarF.Location = new System.Drawing.Point(389, 307);
            this.btnEliminarF.Name = "btnEliminarF";
            this.btnEliminarF.Size = new System.Drawing.Size(153, 50);
            this.btnEliminarF.TabIndex = 6;
            this.btnEliminarF.Text = "Eliminar";
            this.btnEliminarF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarF.UseVisualStyleBackColor = true;
            this.btnEliminarF.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 362);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvFactura.Size = new System.Drawing.Size(565, 196);
            this.dgvFactura.TabIndex = 7;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnActualizarF
            // 
            this.btnActualizarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarF.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarF.Image = global::SistGimnasio.Properties.Resources.actualizar;
            this.btnActualizarF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarF.Location = new System.Drawing.Point(197, 307);
            this.btnActualizarF.Name = "btnActualizarF";
            this.btnActualizarF.Size = new System.Drawing.Size(165, 49);
            this.btnActualizarF.TabIndex = 6;
            this.btnActualizarF.Text = "Actualizar";
            this.btnActualizarF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarF.UseVisualStyleBackColor = true;
            this.btnActualizarF.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPack
            // 
            this.txtPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPack.Location = new System.Drawing.Point(153, 120);
            this.txtPack.Name = "txtPack";
            this.txtPack.Size = new System.Drawing.Size(148, 20);
            this.txtPack.TabIndex = 0;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(153, 181);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(148, 20);
            this.txtPrecioUnitario.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCantidad.Location = new System.Drawing.Point(151, 223);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // txtBuscarPlan
            // 
            this.txtBuscarPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBuscarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPlan.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscarPlan.Location = new System.Drawing.Point(389, 157);
            this.txtBuscarPlan.Name = "txtBuscarPlan";
            this.txtBuscarPlan.Size = new System.Drawing.Size(188, 44);
            this.txtBuscarPlan.TabIndex = 0;
            this.txtBuscarPlan.Text = "Total:";
            this.txtBuscarPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Unitario:";
            // 
            // btnVolverF
            // 
            this.btnVolverF.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolverF.Image = global::SistGimnasio.Properties.Resources.simbolo_de_flecha_hacia_la_izquierda_direccional;
            this.btnVolverF.Location = new System.Drawing.Point(520, 16);
            this.btnVolverF.Name = "btnVolverF";
            this.btnVolverF.Size = new System.Drawing.Size(57, 34);
            this.btnVolverF.TabIndex = 8;
            this.btnVolverF.UseVisualStyleBackColor = false;
            this.btnVolverF.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = global::SistGimnasio.Properties.Resources.calculadora;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(480, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 46);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistGimnasio.Properties.Resources.pngwing_com__18_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(587, 571);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnVolverF);
            this.Controls.Add(this.txtIdf);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizarF);
            this.Controls.Add(this.btnEliminarF);
            this.Controls.Add(this.btnAgregarF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPlan);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtPack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarF;
        private System.Windows.Forms.Button btnEliminarF;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnActualizarF;
        private System.Windows.Forms.TextBox txtPack;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtBuscarPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolverF;
        private System.Windows.Forms.Button btnCalcular;
    }
}