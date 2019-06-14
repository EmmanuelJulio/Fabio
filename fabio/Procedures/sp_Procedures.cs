using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabio.Procedures
{
    class sp_modulospermitidos
    {
        public string NOMBRE_MOD { get; set; }
        public string COD_MOD { get; set; }
    }
    class Sp_Submodulos
    {
        public string NOMBRE_SUBMOD { get; set; }
        public string SYS_NOM { get; set; }
    }
    class Sp_SubMenus
    {
        public string subMenu_nombre { get; set; }
        public string subMenu_Sys { get; set; }
    }
}
