namespace MiPrimerAplicacion
{
    partial class FormPrimerPractica
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
            this.BtnBOTON = new System.Windows.Forms.Button();
            this.lbletiqueta = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBOTON
            // 
            this.BtnBOTON.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnBOTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBOTON.Image = global::MiPrimerAplicacion.Properties.Resources._290149_building_estate_home_house_real_icon;
            this.BtnBOTON.Location = new System.Drawing.Point(302, 160);
            this.BtnBOTON.Name = "BtnBOTON";
            this.BtnBOTON.Size = new System.Drawing.Size(165, 77);
            this.BtnBOTON.TabIndex = 0;
            this.BtnBOTON.Text = "BOTON";
            this.BtnBOTON.UseVisualStyleBackColor = false;
            this.BtnBOTON.Click += new System.EventHandler(this.BtnBOTON_Click);
            // 
            // lbletiqueta
            // 
            this.lbletiqueta.AutoSize = true;
            this.lbletiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbletiqueta.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiqueta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbletiqueta.Location = new System.Drawing.Point(12, 277);
            this.lbletiqueta.Name = "lbletiqueta";
            this.lbletiqueta.Size = new System.Drawing.Size(273, 47);
            this.lbletiqueta.TabIndex = 1;
            this.lbletiqueta.Text = "SoyUnaEtiqueta";
            this.lbletiqueta.MouseLeave += new System.EventHandler(this.lbletiqueta_MouseLeave);
            this.lbletiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbletiqueta_MouseMove);
            // 
            // txtBox
            // 
            this.txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox.Location = new System.Drawing.Point(291, 277);
            this.txtBox.MaxLength = 300;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(343, 22);
            this.txtBox.TabIndex = 2;
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(291, 305);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox2.Size = new System.Drawing.Size(343, 22);
            this.txtBox2.TabIndex = 3;
            this.txtBox2.Leave += new System.EventHandler(this.txtBox2_Leave);
            // 
            // FormPrimerPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lbletiqueta);
            this.Controls.Add(this.BtnBOTON);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrimerPractica";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimerPractica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrimerPractica_FormClosing);
            this.Load += new System.EventHandler(this.FormPrimerPractica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBOTON;
        private System.Windows.Forms.Label lbletiqueta;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtBox2;
    }
}

