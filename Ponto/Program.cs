﻿using Ponto.Entidades;
using Ponto.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Usuario usuario = new Usuario();

            Login login = new Login(usuario);

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new TelaPrincipal(usuario));
            };
        }
    }
}
