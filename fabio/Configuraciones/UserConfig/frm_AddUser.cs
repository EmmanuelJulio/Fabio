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
        public frm_AddUser()
        {
            InitializeComponent();
        }

        private void Frm_AddUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bulonera2DataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.bulonera2DataSet.USUARIOS);

        }
    }
}
