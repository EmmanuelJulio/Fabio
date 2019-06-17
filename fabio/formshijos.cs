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

        private void Btn_desacoplar_Click(object sender, EventArgs e)
        { if(this.TopLevel == false)
            {
                this.Parent.Controls.Remove(this);
                this.TopLevel = true;
            }
            else
            {
                this.TopLevel = false;
                (this.Parent.Controls["..."] as Panel).Controls.Add(this);
                
            }
           
        }
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                Console.Write(true + "\n");
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            else
            {
                Console.Write(false + "\n");
            }
            base.WndProc(ref m);
        }
    }
}
