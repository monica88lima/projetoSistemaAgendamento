using SistemaAgendamentoIndividual.Interfaces;
using SistemaAgendamentoIndividual.Metodos;

namespace SistemaAgendamentoIndividual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services.ConfiguraLayout.LayoutDoConsole();

            try
            {
                
                int retorno = 0;

                do
                {
                    Console.WriteLine("Seja Bem Vindo(a):\nO que deseja fazer:\n(1)Criar Perfil\n(2)Acessar Perfil ");

                    
                    retorno = Services.ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

                } while (retorno < 1 || retorno > 2);

                if (retorno == 1)
                {
                    new Services.NovoUsuario(new Usuario_Metodo()).IniciarNovoPerfil();
                    Services.Seletor.MostrarAlternativas();

                }
                else if (retorno == 2)
                {

                }


            }
            catch (Exception ex)
            {
                Services.ConfiguraLayout.ClearLayout();
                Console.WriteLine(ex.Message);

            }


            var t = new Calendario_Metodo();
        }
    }
}