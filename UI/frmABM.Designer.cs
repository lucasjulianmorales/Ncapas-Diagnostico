namespace UI
{
    partial class frmABM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbFechaNac = new System.Windows.Forms.TextBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(142, 71);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 13;
            // 
            // txbFechaNac
            // 
            this.txbFechaNac.Location = new System.Drawing.Point(142, 158);
            this.txbFechaNac.Name = "txbFechaNac";
            this.txbFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txbFechaNac.TabIndex = 12;
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(142, 204);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(100, 20);
            this.txbTel.TabIndex = 11;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(143, 116);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 10;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(283, 74);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(80, 37);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(283, 141);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(80, 37);
            this.btnBaja.TabIndex = 18;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(283, 199);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(80, 39);
            this.btnModificacion.TabIndex = 19;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // frmABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 362);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbFechaNac);
            this.Controls.Add(this.txbTel);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnAlta);
            this.Name = "frmABM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbFechaNac;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
    }
}

