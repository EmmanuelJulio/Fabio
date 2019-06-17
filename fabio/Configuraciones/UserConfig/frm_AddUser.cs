using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fabio.Configuraciones.UserConfig
{
    public partial class frm_AddUser : formshijos
    {
        string TxtSelccionado;
        public frm_AddUser()
        {
            InitializeComponent();
        }

        private void Frm_AddUser_Load(object sender, EventArgs e)
        {
            using(Models.bulonera2 db= new Models.bulonera2())
            {
                var sectores = (from p in db.DICCIONARIO_FAB
                                where p.dic_cab == 28
                                select p).ToList();
                combo_seccion.ValueMember = "dic_des";
                combo_seccion.DataSource = sectores;
            }
            

        }

        private void Txt_Nombre_Click(object sender, EventArgs e)
        {
            TxtSelccionado = ((TextBox)sender).Text;
            ((TextBox)sender).Text = "";
            
        }

        private void Txt_Nombre_Enter(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text== TxtSelccionado)
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.LightGray;
                
            }
        }

        private void Txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = TxtSelccionado;
                ((TextBox)sender).ForeColor = Color.Silver;

            }
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            using(Models.bulonera2 db = new Models.bulonera2())
            {
                var usuarios = (from us in db.USUARIOS
                               select us.nombre).ToList();
                var usuarios2 = db.USUARIOS;
                
                if (txt_Nombre.Text == ""||  txt_Nombre.Text == "Nombre")
                {
                    MessageBoxPers.message("El nombre no puede estar en blanco", MessageBoxPers.Messagetype.Error);
                    foreach (var usu in usuarios2)
                    {
                        string usuario = txt_Nombre.Text + Txt_apellido;
                        if (usu.nombre + usu.apellido == txt_Nombre.Text + Txt_apellido.Text)
                        {
                            MessageBoxPers.message("El usuario " + txt_Nombre.Text + " " + Txt_apellido.Text + " ya esta registrado", MessageBoxPers.Messagetype.Error);
                        }
                        if (txt_pass.Text == "")
                        {
                            MessageBoxPers.message("La contraceña no puede estar en blanco", MessageBoxPers.Messagetype.Error);

                        }
                        if (txt_pass.Text != txt_pass2.Text)
                        {
                            MessageBoxPers.message("Las contraceñas no coinciden", MessageBoxPers.Messagetype.Error);
                        }
                        
                    }

                }
                using (var dbTransaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        Models.USUARIOS NuevoUsuario = new Models.USUARIOS();
                        NuevoUsuario.nombre = txt_Nombre.Text;
                        NuevoUsuario.apellido = Txt_apellido.Text;
                        NuevoUsuario.contraseña = txt_pass.Text;
                        NuevoUsuario.acceso = "Total";
                        NuevoUsuario.sector = combo_seccion.Text;
                        db.USUARIOS.Add(NuevoUsuario);
                        db.SaveChanges();
                        Txt_apellido.Text="Apellido";
                        txt_Nombre.Text = "Nombre";
                        txt_pass.Text = "Contraseña";
                        txt_pass2.Text = "Repetir Contraseña";
                        combo_seccion.Text = "Sector";
                        Txt_Usuario.Text = "Nombre Usuario";
                        MessageBoxPers.message("Se ingreso el usuario, Debe de asignarle modulos", MessageBoxPers.Messagetype.Hecho);

                    }
                    catch (Exception)
                    {
                        MessageBoxPers.message("Revise todos los campos", MessageBoxPers.Messagetype.Peligro);
                        dbTransaccion.Rollback();

                    }
                }
                //  var isExist = usuarios.AsEnumerable().Contains(txt_Nombre.Text);


            }
            
        }

        public void Txt_Nombre_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {                 
                SendKeys.Send("{TAB}");
                ((TextBox)sender).Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(((TextBox)sender).Text);
            }
            

        }

        private void Txt_NombreUs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();
            }
        }
    }

}
//if (txtuser.Text == "")
//            {
//                txtuser.Text = "Usuario";
//                txtuser.ForeColor = Color.Silver;
//            }
//        }

//        private void Txtpass_Enter_1(object sender, EventArgs e)
//{
//    if (txtpass.Text == "Contraseña")
//    {
//        txtpass.Text = "";
//        txtpass.ForeColor = Color.LightGray;
//        txtpass.UseSystemPasswordChar = true;
//    }

