using Estudo_Command.Models;
using MediatR;

namespace Estudo_Command.Commands
{
    public class CriarUsuarioHandler : IRequestHandler<CriarUsuarioCommand, string>
    {
        public Task<string> Handle(CriarUsuarioCommand command, CancellationToken _)
        {
            var novosUsuarios = new Usuario
            {
                Nome = command.Nome,
                Email = command.Email
            };

            UsuarioRepository.Usuarios.Add(novosUsuarios);
            return Task.FromResult($"Usuário Cadastrado: {novosUsuarios.Nome}, Email: {novosUsuarios.Email}");
        }
    }
}
