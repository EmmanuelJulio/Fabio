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

        private void Frm_submenus_Load(object sender, EventArgs e)
        {
            pnl_modulos.Width = 0;
            pnl_submod.Width = 0;
            pnl_forms.Width = 0;

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
                using(Models.bulonera2 db = new Models.bulonera2())
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
    }
   
}
