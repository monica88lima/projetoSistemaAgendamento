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
                    Console.WriteLine("Seja Bem Vindo(a):\nO que deseja fazer:\n(1)Criar Perfil\n(2)Acessar Perfil ");


                    retorno = Services.ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

                } while (retorno < 1 || retorno > 2);

                if (retorno == 1)
                {
                    var usuario = new Services.NovoUsuario();
                    usuario.IniciarNovoPerfil();
                                        
                    Services.Seletor.MostrarAlternativas();

                    var usuario_pgto = new Metodos.FormaPgto_Metodo();
                    int frmPgto = usuario_pgto.ExibirFormaPgto();

                    var usuario_procedimento = new Metodos.Procedimentos_Metodo();
                    int escolhaProced = usuario_procedimento.ExibirProcedimento();
                    

                    var usuario_especialidade = new Especialidade_Metodo();
                    usuario_especialidade.Filtro(escolhaProced, frmPgto == 1, frmPgto == 2);
                    int espec = usuario_especialidade.ColetarEspecialidade();

                    var medico = new Medicos_Metodo();
                    medico.Filtro(espec);
                    int dr = medico.ColetarNomeMedico();


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


        }
    }
}