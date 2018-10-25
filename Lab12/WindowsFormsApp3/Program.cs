﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12

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
            Controlador controlador = new Controlador();
            Form1 form1 = new Form1();
            //controlador.form1 = form1;
            form1.OnagregarComida += controlador.OnagregarComida;

            Application.Run(form1);
        }
    }
}
