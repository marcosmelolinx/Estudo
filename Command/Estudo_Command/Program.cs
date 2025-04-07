

using Estudo_Command;
using Estudo_Command.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Olá, o que deseja fazer?");
Menu menu = new Menu();
menu.Exibir();


var services = new ServiceCollection();
services.AddMediatR(typeof(CriarUsuarioCommand).Assembly);

var provider = services.BuildServiceProvider();
var mediator = provider.GetRequiredService<IMediator>();
