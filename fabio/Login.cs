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
    public partial class Login : Form
    {
        public static string USUARIO;
        public static int ID_usuario;
        public string GetUsuario()
        {
            return USUARIO;
        }


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
            if (this.Opacity !=  1)
            {
                this.Opacity =this.Opacity+0.2;
            }
            else
            {
                HORA.Enabled = false;
            }



        }




        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txtuser_Enter_1(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void Txtuser_Leave_1(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void Txtpass_Enter_1(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void Txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void Txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString()=="\r")
            {
                txtpass.Focus();
            }
        }

        private void Txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnlogin.Focus();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            using(Models.bulonera2Entities1 db = new Models.bulonera2Entities1())
            {
                var list = db.USUARIOS;
                bool usuario=false;
                while (usuario== false)
                {
                    foreach (var Ousuario in list)
                    {
                        if(Ousuario.nombre_usuario==txtuser.Text & Ousuario.contraseña == txtpass.Text)
                        {
                            ID_usuario = Ousuario.id_usuario;
                            usuario = true;
                            USUARIO = Ousuario.nombre_usuario;
                            MessageBoxPers.message("Acceso Autorizado", MessageBoxPers.Messagetype.Acceso);
                           
                            ContenedorPrincipal cp = new ContenedorPrincipal();
                            cp.Show();
                            this.Hide();
                            break;

                        }
                 
                       
                    }
                    
                    break;
                }
                if (usuario == false)
                {
                txtpass.Text = "Contraseña";
                txtuser.Text = "Usuario";
                txtpass.UseSystemPasswordChar = false;
                
                    MessageBoxPers.message("no se encontro el usuario o la contraceña es incorrecta", MessageBoxPers.Messagetype.Error);
                    
                }
            }
        }
    }
}

