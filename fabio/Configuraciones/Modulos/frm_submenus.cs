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
                var modulos = (from x in db.MODULOS select x).ToList();
                var submodulos = (from x in db.SUBMODULOS select x).ToList();
                var submenu = (from x in db.SUBMENU select x).ToList();
                ModulosFijados = modulos;
                SubModulosFijados = submodulos;
                SubMenuFijados = submenu;
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
        }

        private void Btn_normalWindow_Click(object sender, EventArgs e)
        {

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
            using(var dbtransaccion = new Models.bulonera2Entitys())
            {
                Models.SUBMODULOS OSubmodulo = new Models.SUBMODULOS();
                OSubmodulo.ID_MODULO = Convert.ToInt32((from x in ModulosFijados where x.NOMBRE_MOD == listb_modulos.SelectedItem.ToString() select x.ID_MODULO).ToString());
                OSubmodulo.NOMBRE_SUBMOD = txt_subnom.Text;
                OSubmodulo.SYS_NOM = listb_modulos.SelectedItem.ToString();
                
            }
        }

        private void Listb_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBoxPers.message("se ingresara en " + listb_modulos.SelectedItem.ToString(), MessageBoxPers.Messagetype.Informacion);
            panel1.Visible = true;
        }
    }
   
}
