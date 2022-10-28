namespace Presentacion_GUI
{
    partial class FrmPrincipal
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
            this.btnFamiliar = new System.Windows.Forms.Button();
            this.btnEmprearial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFamiliar
            // 
            this.btnFamiliar.Location = new System.Drawing.Point(42, 26);
            this.btnFamiliar.Name = "btnFamiliar";
            this.btnFamiliar.Size = new System.Drawing.Size(104, 23);
            this.btnFamiliar.TabIndex = 0;
            this.btnFamiliar.Text = "Familiar";
            this.btnFamiliar.UseVisualStyleBackColor = true;
            this.btnFamiliar.Click += new System.EventHandler(this.btnFamiliar_Click);
            // 
            // btnEmprearial
            // 
            this.btnEmprearial.Location = new System.Drawing.Point(42, 58);
            this.btnEmprearial.Name = "btnEmprearial";
            this.btnEmprearial.Size = new System.Drawing.Size(104, 23);
            this.btnEmprearial.TabIndex = 1;
            this.btnEmprearial.Text = "Empresarial";
            this.btnEmprearial.UseVisualStyleBackColor = true;
            this.btnEmprearial.Click += new System.EventHandler(this.btnEmprearial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(42, 93);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 139);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmprearial);
            this.Controls.Add(this.btnFamiliar);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFamiliar;
        private System.Windows.Forms.Button btnEmprearial;
        private System.Windows.Forms.Button btnSalir;
    }
}

