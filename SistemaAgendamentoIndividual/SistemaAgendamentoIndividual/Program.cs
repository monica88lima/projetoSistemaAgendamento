using SistemaAgendamentoIndividual.Entidades;
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
                    Console.WriteLine("\n\nSeja Bem Vindo(a): O que deseja fazer:\n\n(1)Criar Perfil\n(2)Acessar Perfil\n ");


                    retorno = Services.ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

                } while (retorno < 1 || retorno > 2);

                if (retorno == 1)
                {
                    var usuario = new Services.NovoUsuario();
                    usuario.IniciarNovoPerfil();
                                        
                    Services.Seletor.MostrarAlternativas();
                                        

                }
                else if (retorno == 2)
                {
                    var usuario = new Services.LoginUsuario();
                    usuario.LogarUsuario();

                    Services.Seletor.MostrarAlternativas();

                }


            }
            catch (Exception ex)
            {
                Services.ConfiguraLayout.ClearLayout();
                Console.WriteLine(ex.Message);

            }


        }
    }
}