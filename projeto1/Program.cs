using Assistente_de_Instala��o.Forms;

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
            {
                MenuPrincipal.reiniciar = true;
                while(MenuPrincipal.reiniciar)
                {
                    MenuPrincipal.reiniciar = false;
                    Application.Run(new MenuPrincipal());
                }
            }
        }
    }
}