using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fabio.Configuraciones.Modulos
{
    public partial class frm_submenus : formshijos
    {
        public frm_submenus()
        {
            InitializeComponent();
        }
        List<Models.MODULOS> ModulosFijados= new List<Models.MODULOS>();
        List<Models.SUBMODULOS> SubModulosFijados = new List<Models.SUBMODULOS>();
        List<Models.SUBMENU> SubMenuFijados = new List<Models.SUBMENU>();
        private void Frm_submenus_Load(object sender, EventArgs e)
        {
            pnl_modulos.Width = 0;
            pnl_submod.Width = 0;
            pnl_forms.Width = 0;
            using (Models.bulonera2Entitys db = new Models.bulonera2Entitys())
            {
                
                ModulosFijados = (from x in db.MODULOS select x).ToList();
                SubModulosFijados = (from x in db.SUBMODULOS select x).ToList();
                SubMenuFijados = (from x in db.SUBMENU select x).ToList();
            }
            
        }
        public void Deslizar(Panel Aesconeder, Panel Amostrar)
        {
            panelanimator.HideSync(Aesconeder);
            panelanimator.ShowSync(Amostrar);
            Amostrar.Width = 400;
        }

        private void Btn_nmodulo_Click(object sender, EventArgs e)
        {

            pnl_forms.Visible=false;
            pnl_modulos.Visible = false;
            pnl_submod.Visible = false;
            pnl_modulos.Visible = false;
            pnl_modulos.Visible = true;


        }

        private void Btn_nuevoSub_Click(object sender, EventArgs e)
        {
            listb_modulos.Items.Clear();
            foreach (var mod in ModulosFijados)
            {
                listb_modulos.Items.Add(mod.NOMBRE_MOD);
            }
            pnl_forms.Visible = false;
            pnl_modulos.Visible = false;
            pnl_submod.Visible = false;
            pnl_modulos.Visible = false;
            pnl_submod.Visible = true;
            
            
        }

        private void Btn_nuevofrm_Click(object sender, EventArgs e)
        {
            pnl_forms.Visible = false;
            pnl_modulos.Visible = false;
            pnl_submod.Visible = false;
            pnl_modulos.Visible = false;
            pnl_forms.Visible = true;
            listBox_modulos.Items.Clear();
            listBox_submodulos.Items.Clear();
            foreach (var MODULOS in ModulosFijados)
            {
                listBox_modulos.Items.Add(MODULOS.NOMBRE_MOD);
            }
           
        }

        private void Btn_normalWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void BunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_agregarmod_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "")
            {
                using(Models.bulonera2Entitys db = new Models.bulonera2Entitys())
                {
                    bool exist = false;
                    var modulos = (from x in db.MODULOS select x).ToList();
                    foreach(var mod in modulos)
                    {
                        
                        if (mod.NOMBRE_MOD == txt_Nombre.Text)
                        {
                            MessageBoxPers.message("El nombre del modulo ya existe", MessageBoxPers.Messagetype.Error);
                            exist = true;
                        }
                       
                    }
                    if (exist==false)
                    {
                        using (var dbtransaction= db.Database.BeginTransaction())
                        {
                            try
                            {
                                Models.MODULOS Nmodulo = new Models.MODULOS();
                                Nmodulo.NOMBRE_MOD = txt_Nombre.Text;
                                Nmodulo.COD_MOD = txt_codmod.Text;
                                Nmodulo.SECTOR_MOD = 1;
                                ModulosFijados.Clear();
                                ModulosFijados = (from x in db.MODULOS select x).ToList();
                                db.MODULOS.Add(Nmodulo);
                                db.SaveChanges();
                                txt_codmod.Text="";
                                txt_Nombre.Text = "";
                                MessageBoxPers.message("Se cargo el modulo", MessageBoxPers.Messagetype.Hecho);
                                dbtransaction.Commit();
                            }
                            catch (Exception)
                            {
                                MessageBoxPers.message("Se produjo un error", MessageBoxPers.Messagetype.Error);
                                dbtransaction.Rollback();
                            }
                        }
                    }
                }
            }
        }

        private void Txt_Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                ((TextBox)sender).Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(((TextBox)sender).Text);
            }
        }

        private void Btn_guardarSubmod_Click(object sender, EventArgs e)
        {
            using (Models.bulonera2Entitys db = new Models.bulonera2Entitys())
            {
                using (var dbtransaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                       
                        
                        Models.SUBMODULOS OSubmodulo = new Models.SUBMODULOS();
                        OSubmodulo.ID_MODULO =(from x in ModulosFijados where x.NOMBRE_MOD== listb_modulos.SelectedItem.ToString() select x.ID_MODULO).FirstOrDefault();
                        OSubmodulo.NOMBRE_SUBMOD = txt_subnom.Text;
                        OSubmodulo.SYS_NOM = listb_modulos.SelectedItem.ToString();
                        db.SUBMODULOS.Add(OSubmodulo);
                        db.SaveChanges();
                        dbtransaccion.Commit();
                        MessageBoxPers.message("Se completo el ingreso", MessageBoxPers.Messagetype.Hecho);
                        SubModulosFijados.Clear();
                        SubModulosFijados = (from x in db.SUBMODULOS select x).ToList();



                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                        MessageBoxPers.message("No se completo el ingreso", MessageBoxPers.Messagetype.Error); 
                    }
                } 
            }
        }

        private void Listb_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBoxPers.message("se ingresara en " + listb_modulos.SelectedItem.ToString(), MessageBoxPers.Messagetype.Informacion);
            panel1.Visible = true;
        }

        private void Btn_MaximiseWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Btn_MinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Pnl_forms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBox_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_modulos.SelectedItem!=null)
            {
                listBox_submodulos.Items.Clear();
                int idMod = Configuraciones.Modulos.clsModulos.getIdModulo(((ListBox)sender).SelectedItem.ToString());
                List<Models.SUBMODULOS> Submod = new List<Models.SUBMODULOS>();
                using (Models.bulonera2Entitys db = new Models.bulonera2Entitys())
                {

                    Submod = (from x in db.SUBMODULOS where x.ID_MODULO == idMod select x).ToList();
                    foreach (var submod in Submod)
                    {
                        listBox_submodulos.Items.Add(submod.NOMBRE_SUBMOD);
                    }

                } 
            }
        }

        private void ListBox_submodulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_submodulos.SelectedItem != null)
            {
                MessageBoxPers.message("Se ingresara en " + listBox_submodulos.SelectedItem.ToString(), MessageBoxPers.Messagetype.Informacion);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textNombre.Text != "" & textFrmNombre.Text!="")
            {
                using (Models.bulonera2Entitys db = new Models.bulonera2Entitys())
                {
                    using (var Transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            Models.SUBMENU Osubmenu = new Models.SUBMENU();
                            Osubmenu.ID_SUBMODULO = Configuraciones.Modulos.clsModulos.getIdSubmodulo(listBox_submodulos.SelectedItem.ToString());
                            Osubmenu.subMenu_nombre = textNombre.Text;
                            Osubmenu.subMenu_Sys = textFrmNombre.Text;
                            db.SUBMENU.Add(Osubmenu);
                            db.SaveChanges();
                            Transaction.Commit();
                            Transaction.Dispose();
                            MessageBoxPers.message("Se agrego el modulo " + textNombre.Text, MessageBoxPers.Messagetype.Hecho);
                        }
                        catch
                        {
                            MessageBoxPers.message("Ocurrio un error ", MessageBoxPers.Messagetype.Error);
                            Transaction.Rollback();
                        }
                    }
                    textNombre.Text = "";
                    textFrmNombre.Text = "";
                    listBox_modulos.SelectedItem = null;
                    listBox_submodulos.SelectedItem = null;
                } 
            }
            else
            {
                MessageBoxPers.message("Los campos no pueden estar en blanco", MessageBoxPers.Messagetype.Informacion);
            }
        }
    }
   
}
