using System;
using System.Windows.Forms;
using Pantallas_Sistema_facturacion.Seguridad;



namespace Pantallas_Sistema_facturacion.Capa_presentacion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // La configuración estándar para .NET Framework
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia el formulario de login
            Application.Run(new FrmLogin());
        }
    }
}