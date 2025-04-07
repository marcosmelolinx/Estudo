using Estudo_Command.Commands;
using static Estudo_Command.Commands.ListarUsuariosCommands;

namespace Estudo_Command;

public class Menu
{
    public void Exibir()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar Um usuário");
            Console.WriteLine("2 - Deletar um Usuário");
            Console.WriteLine("3 - Listagem de Usuários");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine(@"____Cadastrar um usuário____/n
                                        Digite o nome do usuário: ");
                    var nome = Console.ReadLine();

                    Console.WriteLine(@"Digite o  email do usuário: ");
                    var email = Console.ReadLine();
                    CriarUsuarioCommand command = new CriarUsuarioCommand(nome, email);
                    break;

                case "2":
                    Console.WriteLine(@"Digite o nome do usuário que deseja deletar: ");
                    break;

                case "3":
                    Console.WriteLine(@"Digite o nome do usuário que deseja listar: ");
                    var nomeListar = Console.ReadLine();
                    ListarUsuariosCommand listarCommand = new ListarUsuariosCommand(nomeListar);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
