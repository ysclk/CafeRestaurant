using System;
using System.Windows.Forms;

namespace CafeRestaurant

{
    using CafeRestaurant.Forms;
    using System.Web.UI.WebControls;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CategoryForm());
        }
    }
}
