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
    public partial class formshijos : Form
    {
        public formshijos()
        {
            InitializeComponent();
        }

        private void Formshijos_Load(object sender, EventArgs e)
        {
            lbl_modulo.Text = ContenedorPrincipal.moduloselecionado;
        }
        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_MaximiseWindow.Visible = false;
            btn_normalWindow.Visible = true;
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_normalWindow.Visible = false;
            btn_MaximiseWindow.Visible = true;

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void Btn_MinimizeWindow_Click(object sender, EventArgs e)
        {
            btn_MaximiseWindow.Visible = true;

            WindowState = FormWindowState.Minimized;
            this.Dock = DockStyle.None;
        }

        private void Btn_MaximiseWindow_Click(object sender, EventArgs e)
        {
            btn_MaximiseWindow.Visible = false;
            btn_normalWindow.Visible = true;
            this.Dock = DockStyle.Fill;
        }

        private void Btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_normalWindow_Click(object sender, EventArgs e)
        {
            btn_normalWindow.Visible = false;
            btn_MaximiseWindow.Visible = true;
            WindowState = FormWindowState.Normal;
            this.Dock = DockStyle.None;
        }
    }
}
