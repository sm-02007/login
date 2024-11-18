using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class registro : Form
    {
        private conexion dbconexion;
        public registro()
        {
            InitializeComponent();
            btn_inicio.FlatAppearance.BorderSize = 0;
            btn_inicio.Paint += Btn_inicio_Paint; // Asocia el evento Paint
            dbconexion = new conexion();
        }
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO usuarios (usuario, correo, contraseña) VALUES (@usuario, @correo, @contrasena)";

            // Verifica si la conexión es válida
            if (dbconexion.GetConnection() != null)
            {
                try
                {
                    using (MySqlCommand mySqlCommand = new MySqlCommand(query, dbconexion.GetConnection()))
                    {
                        // Agregar valores a los parámetros
                        mySqlCommand.Parameters.AddWithValue("@usuario", lb_usuario.Text);
                        mySqlCommand.Parameters.AddWithValue("@correo", lb_correo.Text);
                        mySqlCommand.Parameters.AddWithValue("@contrasena", lb_contrasena.Text);

                        // Ejecutar la consulta
                        int rowsAffected = mySqlCommand.ExecuteNonQuery();

                        // Comprobar si se insertó el registro
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No se pudo establecer la conexión con la base de datos.");
            }
        }

        private void Btn_inicio_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            GraphicsPath path = new GraphicsPath();

            // Define el rectángulo y el radio para las esquinas redondeadas
            int radius = 20; // Ajusta el radio según lo desees
            Rectangle rect = btn.ClientRectangle;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Cambia el diseño del botón
            btn.Region = new Region(path);


        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == lb_usuario.Text)
            {
                textBox1.Text = "";
                lb_usuario.Visible = true;
            }
            else
            {
                lb_usuario.Visible = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == lb_correo.Text)
            {
                textBox2.Text = "";
                lb_correo.Visible = true;
            }
            else
            {
                lb_correo.Visible = false;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if(textBox3.Text == lb_contrasena.Text)
            {
                textBox3.Text = "";
                lb_contrasena.Visible = true;
            }
            else
            {
                lb_contrasena.Visible = false;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == lb_repeticion_contrasena.Text)
            {
                textBox4.Text = "";
                lb_repeticion_contrasena.Visible = true;
            }
            else
            {
                lb_repeticion_contrasena.Visible = false;
            }
        }

        
    }
}
