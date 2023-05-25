using Assistente_de_Instalação.Forms;

namespace projeto1
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
            ApplicationConfiguration.Initialize();

            Login pediSenha = new();
            if (pediSenha.ShowDialog() == DialogResult.Continue)
                Application.Run(new MenuPrincipal());
        }
    }
}