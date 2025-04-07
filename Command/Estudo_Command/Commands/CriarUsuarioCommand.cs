using MediatR;

namespace Estudo_Command.Commands
{
    public class CriarUsuarioCommand : IRequest<string>
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public CriarUsuarioCommand(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
