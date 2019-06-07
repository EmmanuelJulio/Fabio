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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            HORA.Text = DateTime.Now.ToLongTimeString();
            if (this.Opacity !=  100)
            {
                this.Opacity =this.Opacity+0.1;
            }



        }

    
       

        private void Txt_usuario_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "";
        }
     
        private void Txt_pass_Click_1(object sender, EventArgs e)
        {
            Txt_pass.Text = "";
        }
    }
}
