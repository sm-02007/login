namespace login
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
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btn_inicio.Location = new System.Drawing.Point(161, 304);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(229, 66);
            this.btn_inicio.TabIndex = 0;
            this.btn_inicio.Text = "Iniciar Sesion";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btn_registro.Location = new System.Drawing.Point(161, 404);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(229, 66);
            this.btn_registro.TabIndex = 1;
            this.btn_registro.Text = "Registro";
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 629);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.btn_inicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_registro;
    }
}

