﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fabio
{
    public partial class ContenedorPrincipal : Form
    {
        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {
            string usu = Login.USUARIO;
            using (EntityBulonera db = new EntityBulonera())
            {

            //    var usurio_modulo = (from mod in db.MODULO_USUARIO.Join(db.USUARIOS, u => u.ID_USUARIO, us => us.id_usuario, (u, us) => new { u, us }).Where(z => z.u.ID_USUARIO == 1)select(*));

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
    }
}
