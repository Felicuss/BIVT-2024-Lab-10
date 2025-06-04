using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model.Core.RestaurantClasses;
using Model.Core.MenuClasses;
using Model.Core.DishClasses;
using RestaurantMenu.Model;

namespace RestaurantMenu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //asdfg
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}