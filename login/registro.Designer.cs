namespace login
{
    partial class registro
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
            this.lb_repeticion_contrasena = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lb_correo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_repeticion_contrasena
            // 
            this.lb_repeticion_contrasena.AutoSize = true;
            this.lb_repeticion_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_repeticion_contrasena.Location = new System.Drawing.Point(111, 339);
            this.lb_repeticion_contrasena.Name = "lb_repeticion_contrasena";
            this.lb_repeticion_contrasena.Size = new System.Drawing.Size(172, 20);
            this.lb_repeticion_contrasena.TabIndex = 12;
            this.lb_repeticion_contrasena.Text = "Repetir Contraseña";
            this.lb_repeticion_contrasena.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(115, 352);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(311, 45);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Repetir Contraseña";
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            // 
            // lb_correo
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo.Location = new System.Drawing.Point(111, 180);
            this.lb_correo.Name = "lb_correo";
            this.lb_correo.Size = new System.Drawing.Size(66, 20);
            this.lb_correo.TabIndex = 10;
            this.lb_correo.Text = "Correo";
            this.lb_correo.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(115, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 45);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Correo";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btn_inicio.Location = new System.Drawing.Point(154, 467);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(229, 66);
            this.btn_inicio.TabIndex = 19;
            this.btn_inicio.Text = "Registrarme";
            this.btn_inicio.UseVisualStyleBackColor = false;
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.Location = new System.Drawing.Point(111, 257);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(105, 20);
            this.lb_contrasena.TabIndex = 17;
            this.lb_contrasena.Text = "Contraseña";
            this.lb_contrasena.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(115, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 45);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Contraseña";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(5, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(51, 48);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "<";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(111, 93);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(74, 20);
            this.lb_usuario.TabIndex = 15;
            this.lb_usuario.Text = "Usuario";
            this.lb_usuario.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 45);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Usuario";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 629);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.lb_contrasena);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_repeticion_contrasena);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lb_correo);
            this.Controls.Add(this.textBox2);
            this.Name = "registro";
            this.Text = "registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_repeticion_contrasena;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lb_correo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.TextBox textBox1;
    }
}