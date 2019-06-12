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
                    boton.Height = 30;
                    boton.BackColor = Color.FromArgb(15, 112, 183);
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.ForeColor = Color.FromArgb(45, 45, 48);
                    boton.Click+= new EventHandler(boton_Click);




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
            pictureBox4.Visible = true;

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureBox4.Visible = false;
            pictureBox2.Visible = true;
        }

        private void PNL_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void deslisarmenu(Panel pn)
        {
            if (pnl_submodulos.Width == 1)
            {
                btn_volver.Visible = true;
                pnl_submodulos.Width = 289;
                PanelAnimator.ShowSync(pn);
            }
            else
            {
                btn_volver.Visible = false;
                pnl_submodulos.Width = 1;
                PanelAnimator.ShowSync(pn);
            }

        }

        private void boton_Click(object sender, EventArgs e)
        {
           // pnl_submodulos.Controls.Remove();
           foreach(Button b in pnl_submodulos.Controls)
            {
                pnl_submodulos.Controls.Remove(b);
            }

            string nombreSub = ((Button)sender).Text;
            using (EntityBulonera db = new EntityBulonera())
            {
                var submodulos = db.Database.SqlQuery<Sp_Submodulos>("Sp_Submodulos @p0", nombreSub).ToList();
                foreach (var submoduli in submodulos)
                {
                    Button botonSub = new Button();
                    botonSub.Text = submoduli.NOMBRE_SUBMOD;
                    botonSub.AccessibleName = submoduli.SYS_NOM;
                    botonSub.Dock = DockStyle.Top;
                    botonSub.Height = 30;
                    botonSub.BackColor = Color.FromArgb(15, 112, 200);
                    botonSub.FlatStyle = FlatStyle.Flat;
                    botonSub.ForeColor = Color.FromArgb(45, 45, 48);
                    botonSub.Click += new EventHandler(BotonSub_Click);
                    pnl_submodulos.Controls.Add(botonSub);

                }
            }
                deslisarmenu(pnl_submodulos);
            }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            deslisarmenu(pnl_submodulos);
        }

        private void BotonSub_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
