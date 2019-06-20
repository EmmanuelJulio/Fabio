using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabio.Configuraciones.Modulos
{
    class clsModulos
    {
        public static int getIdModulo(string Nombre)
        {
            int id;
            using(Models.bulonera2Entitys db = new Models.bulonera2Entitys())
            {

                id = Convert.ToInt32((from x in db.MODULOS where x.NOMBRE_MOD == Nombre select x.ID_MODULO).FirstOrDefault());
                return id;
            }
        }
        public static int getIdSubmodulo( string Nombre)
        {
            int id;
            using (Models.bulonera2Entitys db = new Models.bulonera2Entitys())
            {

                id = Convert.ToInt32((from x in db.SUBMODULOS where x.NOMBRE_SUBMOD == Nombre select x.ID_SUBMODULO).FirstOrDefault());
                return id;
            }
        }
    }
}
