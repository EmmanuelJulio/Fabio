﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fabio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            //fabio.Configuraciones.UserConfig.frm_AddUser lg = new Configuraciones.UserConfig.frm_AddUser();
            Application.Run(lg);
            
        }
    }
}
