using fabio.Procedures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fabio
{
    public partial class ContenedorPrincipal : Form
    {
        Dictionary<string, Form> Ins = new Dictionary<string, Form>();
        private const int cGrip = 16;
        private const int cCaption = 32;
        
        public static string moduloselecionado;
        public static string Opcionmodseleccionada;
        public string opcionseleccionada;
        public string formularioseleccionado;
        public void Deslizar(Panel Aesconeder,Panel Amostrar)
        {
            //while (Aesconeder.Width > 1)
            //{
            //    Aesconeder.Width -= 3;

            //}
            //while (Amostrar.Width < 280)
            //{
            //    Amostrar.Width += 3;
            //}
                PanelAnimator.HideSync(Aesconeder);
                PanelAnimator.ShowSync(Amostrar);
                 Amostrar.Width = 280;
                // SystemSounds.Asterisk.Play();

        }
        public ContenedorPrincipal()
        {

            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
       // protected override void WndProc(ref Message n)
        //{
        //    if (n.Msg == 0x84)
        //    {
        //        Point pos = new Point(n.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if(pos.Y < cCaption)
        //        {
        //            n.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X>=this.ClientSize.Width-cGrip && pos.Y >= this.ClientSize.Height -cGrip)
        //        {
        //            n.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref n);
        //}
        //Cargo todos los botones que tenga permitido el usuario que ingreso los botones se van a llamar depende lo que diga la base de datos 
        //pero en el programa seran buton
        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {
            cabezera.Width = 280;
            Panel_botones.Width = 280;
            pnl_submodulos.Width = 1;
            Pnl_subsubmdoulos.Width = 1;
            string usu = Login.USUARIO;
            int id_usu = Login.ID_usuario;
            using (Models.bulonera2 db = new Models.bulonera2())
            {
              var modulos= db.Database.SqlQuery<sp_modulospermitidos>("sp_modulospermitidos @p0",id_usu).ToList();
                foreach (var Omodulo in modulos)
                {
                    Button Boton = new Button();
                    Boton.Text = Omodulo.NOMBRE_MOD;
                    Boton.AccessibleName = Omodulo.COD_MOD;
                    Boton.Dock = DockStyle.Top;
                    Boton.Height = 30;
                    Boton.BackColor = Color.FromArgb(15, 112, 183);
                    Boton.FlatStyle = FlatStyle.Flat;
                    Boton.ForeColor = Color.FromArgb(45, 45, 48);
                    Boton.Click+= new EventHandler(Boton_Click);
                    Panel_botones.Controls.Add(Boton);
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

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //lo que ocurre cuando precionas un boton de l modulo es preparar los botones que contiene ese modulo en otro panel
        //al apretar uno de estos se crean los botones en el panel Pnl_subsubmdoulos
        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //lo que oasa cuadno se terminan de crear todas las opcciones
        //ultimo paso de carga de botones
        private void Boton_Click(object sender, EventArgs e)
        {
            pnl_submodulos.Controls.Clear();
            if (Panel_botones.Width > 4)
            {
                Btn_volvermodulos.Visible = true;
            }
            else
            {
                Btn_volvermodulos.Visible = false;
            }


            Btn_volveropciones.Visible = false;
            string nombreSub = ((Button)sender).Text;
            lbl_texto.Text = nombreSub;
            moduloselecionado = nombreSub;
            using (Models.bulonera2 db = new Models.bulonera2())
            {
                var submodulos = db.Database.SqlQuery<Sp_Submodulos>("Sp_Submodulos @p0", nombreSub).ToList();
                foreach (var submoduli in submodulos)
                {
                    Button botonSub = new Button();
                    botonSub.Text = submoduli.NOMBRE_SUBMOD;
                    botonSub.AccessibleName = submoduli.SYS_NOM;
                    botonSub.Dock = DockStyle.Top;
                    botonSub.Height = 30;
                    botonSub.BackColor = Color.FromArgb(84, 132, 182);
                    botonSub.FlatStyle = FlatStyle.Flat;
                    botonSub.ForeColor = Color.FromArgb(45, 45, 48);
                    botonSub.Click += new EventHandler(BotonSub_Click);
                    pnl_submodulos.Controls.Add(botonSub);

                }
            }

            Deslizar(Panel_botones, pnl_submodulos);
        }
        private void BotonSub_Click(object sender, EventArgs e)
        {
            Btn_volvermodulos.Visible = false;
            Btn_volveropciones.Visible = true;
           // Deslisarmenu(PNL_Modulos);
            Pnl_subsubmdoulos.Controls.Clear();

            string nombreSub2 = ((Button)sender).Text;
            lbl_texto.Text = nombreSub2;
            opcionseleccionada = nombreSub2;
           // lbl_SubSubmodulo.Text = nombreSub2;
            using (Models.bulonera2 db = new Models.bulonera2())
            {
                var submodulos = db.Database.SqlQuery<Sp_SubMenus>("Sp_SubMenus @p0", nombreSub2).ToList();
                foreach (var submoduli in submodulos)
                {
                    Button BotonSub3 = new Button();
                    BotonSub3.Text = submoduli.subMenu_nombre;
                    BotonSub3.AccessibleName = submoduli.subMenu_Sys;
                    BotonSub3.Dock = DockStyle.Top;
                    BotonSub3.Height = 30;
                    BotonSub3.BackColor = Color.FromArgb(220, 78, 65);
                    BotonSub3.FlatStyle = FlatStyle.Flat;
                    BotonSub3.ForeColor = Color.FromArgb(45, 45, 48);
                    BotonSub3.Click += new EventHandler(BotonSub3_Click);
                    Pnl_subsubmdoulos.Controls.Add(BotonSub3);

                }
            }
            Deslizar(pnl_submodulos, Pnl_subsubmdoulos);
     
        }
        //este boton me va a abrir los forms

        private void BotonSub3_Click(object sender, EventArgs e)
        {

            string nombreSub3 = ((Button)sender).Text;
           

            using (Models.bulonera2 db = new Models.bulonera2())
            {
                var Subme = from Submenu in db.SUBMENU
                             where Submenu.subMenu_nombre == nombreSub3
                             select new
                             {
                                 frmnombre = Submenu.subMenu_Sys
                             };
                foreach (var sub in Subme)
                {


                    try
                    {
                        string NameSpace = "fabio" + "." + moduloselecionado + "." + opcionseleccionada;
                        string Nombreform = sub.frmnombre;
                        while (NameSpace.Contains(" "))
                        {
                            NameSpace.Remove(8, 1);
                        }

                        Assembly asm = Assembly.GetEntryAssembly();
                        //fabio.Configuraciones.UserConfig
                        Type formtype = asm.GetType(string.Format("{0}.{1}", NameSpace, Nombreform));

                        Form f = (Form)Activator.CreateInstance(formtype);

                        AbrirFormHijo(f);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                        
                    


                }
            }
           
           
          
        }
       
        public void AbrirFormHijo(object formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
            {
                this.contenedor.Controls.RemoveAt(0);
            }
            else
            {
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.None;
                this.contenedor.Controls.Add(fh);
                this.contenedor.Tag = fh;
                fh.Dock = DockStyle.Fill;
                fh.Show();
                
            }
        }
        

        public void OpenForm(String NombreForm,String NameSpace)
        {
           
           

        }
        

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            Login lg = new Login();
        }

        

      

      

        private void Btn_volverModulos_Click(object sender, EventArgs e)
        {
          //  Deslizar(PanelOpcionesModulos, modulos);
        }

        private void Btn_volveropciones_Click(object sender, EventArgs e)
        {
            Btn_volvermodulos.Visible = false;
            lbl_texto.Text = "Modulos";
            Deslizar(pnl_submodulos, Panel_botones);
        }

        private void Btn_volveropciones_Click_1(object sender, EventArgs e)
        {
            lbl_texto.Text = moduloselecionado;
            Btn_volveropciones.Visible = false;
            Btn_volvermodulos.Visible = true;

            Deslizar(Pnl_subsubmdoulos, pnl_submodulos);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
