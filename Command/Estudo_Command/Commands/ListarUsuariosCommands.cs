using MediatR;

namespace Estudo_Command.Commands;

public class ListarUsuariosCommands
{
    public class ListarUsuariosCommand : IRequest<string>
    {
        public string Nome { get; }
        public string Email { get; }

        public ListarUsuariosCommand(string nome)
        {
            Nome = nome;
        }
    }
}
