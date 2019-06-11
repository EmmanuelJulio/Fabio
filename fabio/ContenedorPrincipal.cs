using fabio.Procedures;
using System;
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
            int id_usu = Login.ID_usuario;
            using (EntityBulonera db = new EntityBulonera())
            {
              var modulos= db.Database.SqlQuery<sp_modulospermitidos>("sp_modulospermitidos @p0",id_usu).ToList();
                foreach (var Omodulo in modulos)
                {
                    Button boton = new Button();
                    boton.Text = Omodulo.NOMBRE_MOD;
                    boton.AccessibleName = Omodulo.COD_MOD;
                    boton.Dock = DockStyle.Top;
                    boton.Height = 40;
                    boton.BackColor = Color.Aqua;
                    boton.FlatStyle = FlatStyle.Flat;




                    Panel_botones.Controls.Add(boton);
                }
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
