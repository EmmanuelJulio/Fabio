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
    public partial class frm_asignacion : formshijos
    {
        public frm_asignacion()
        {
            InitializeComponent();
        }

        private void Frm_asignacion_Load(object sender, EventArgs e)
        {
            using (Models.bulonera2 db = new Models.bulonera2())
            {
                

                var modul = (from m in db.MODULOS
                             select m).ToList();
                foreach (var m in modul)
                {
                   // Modulos.Items.Add(m.NOMBRE_MOD);
                }
            }
        }
    }
}
