﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_inicio.FlatAppearance.BorderSize = 0;   
            btn_inicio.Paint += Btn_inicio_Paint; // Asocia el evento Paint
            btn_registro.FlatAppearance.BorderSize = 0;
            btn_registro.Paint += Btn_registro_Paint;
        }

        private void Btn_registro_Paint(object sender, PaintEventArgs e)
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

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();   
            this.Hide();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            registro registro = new registro();
            registro.Show();
            this.Hide();
        }
    }
}
