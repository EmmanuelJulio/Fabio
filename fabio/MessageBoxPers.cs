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
    public partial class MessageBoxPers : Form
    {

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            hide.Start();
        }
        public MessageBoxPers(string sms,Messagetype type)
        {
            InitializeComponent();
            Show2.Start();
            bunifuCustomLabel1.Text = sms;
            switch (type)
            {
                case Messagetype.Acceso:
                    icon.Image = listicon.Images[3];
                    break;
                case Messagetype.Error:
                    icon.Image = listicon.Images[1];
                    break;
                case Messagetype.Hecho:
                    icon.Image = listicon.Images[4];
                    break;
                case Messagetype.Informacion:
                    icon.Image = listicon.Images[5];
                    break;
                case Messagetype.Peligro:
                    icon.Image = listicon.Images[6];
                    break;
            }
        }
        public static void message (string _sms,Messagetype _type)
        {
            new fabio.MessageBoxPers(_sms, _type).ShowDialog();
        }
            

        public enum Messagetype
        {
            Hecho,Peligro,Error,Informacion,Acceso

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hide.Start();

        }

       public MessageBoxPers()
        {
            this.Opacity = 0.1;
            InitializeComponent();
        }

        private void Show_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.2;
            }
            else
            {
                Show2.Stop();
            }
        }

        private void Hide_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >0)
            {
                this.Opacity -= 0.3;
            }
            else
            {
                Close();
                
            }
        }

        private void MessageBoxPers_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
        }
    }
}
