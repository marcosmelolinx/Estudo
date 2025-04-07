using Estudo_Command.Models;
using static Estudo_Command.Commands.ListarUsuariosCommands;

namespace Estudo_Command.Commands
{
    public class ListarUsuariosCommandHandler
    {
        public Task<string> Handle(ListarUsuariosCommand command, CancellationToken _)
        {
            var usuarios = UsuarioRepository.Usuarios;
            var usuarioEncontrados = usuarios?.Where(u => u.Nome.Contains(command.Nome, StringComparison.OrdinalIgnoreCase)).ToList();

            if (usuarioEncontrados == null || usuarioEncontrados.Count == 0)
                return Task.FromResult($"Usuário não encontrado: {command.Nome}");

            if (usuarioEncontrados.Count > 0)
                return Task.FromResult($"Usuário encontrado: {command.Nome}, Email: {command.Email}");

            return Task.FromResult(string.Empty);
        }
    }
}
