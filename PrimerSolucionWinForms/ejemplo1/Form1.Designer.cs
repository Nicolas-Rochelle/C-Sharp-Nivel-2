namespace ejemplo1
{
    partial class Form1
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.AccessibleName = "btnSaludar";
            this.btnSaludar.Location = new System.Drawing.Point(214, 161);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(281, 92);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(393, 350);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(0, 16);
            this.labelSaludo.TabIndex = 1;
            this.labelSaludo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(340, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(211, 98);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(123, 16);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Ingresa Tu Nombre";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(340, 133);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(53, 22);
            this.textEdad.TabIndex = 4;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(214, 133);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(100, 16);
            this.labelEdad.TabIndex = 5;
            this.labelEdad.Text = "ingresa tu edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelSaludo);
            this.Controls.Add(this.btnSaludar);
            this.Name = "Form1";
            this.Text = "Primera App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label labelEdad;
    }
}

