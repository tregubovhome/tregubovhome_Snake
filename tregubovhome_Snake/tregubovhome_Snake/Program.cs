﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tregubovhome_Snake
{    
    static class Program
    {        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Form stngFormGame;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
