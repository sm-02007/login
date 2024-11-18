namespace login
{
    partial class login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 45);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Usuario";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(118, 178);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(74, 20);
            this.lb_usuario.TabIndex = 1;
            this.lb_usuario.Text = "Usuario";
            this.lb_usuario.Visible = false;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(13, 13);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(51, 48);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "<";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.Location = new System.Drawing.Point(118, 288);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(105, 20);
            this.lb_contrasena.TabIndex = 2;
            this.lb_contrasena.Text = "Contraseña";
            this.lb_contrasena.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(122, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 45);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Contraseña";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btn_inicio.Location = new System.Drawing.Point(157, 392);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(229, 66);
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.Text = "Iniciar Sesion";
            this.btn_inicio.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 629);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.lb_contrasena);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_inicio;
    }
}