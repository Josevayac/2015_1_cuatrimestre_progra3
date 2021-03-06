﻿using MecanicaUTN.Entidades;
using MecanicaUTN.Logica;
using MecanicaUTN.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanicaUTN
{
    static class Program
    {
        public static Usuario oUsuario;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AccesoDatos.AccesoDatos accesoDatos = AccesoDatos.AccesoDatos.Instance;
            Application.Run(new FrmLogin());
        }
    }
}
