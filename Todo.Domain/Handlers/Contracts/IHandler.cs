using Todo.Domain.Commads.Contracts;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contracts
{
	public interface IHandler<T> where T : ICommand
	{
		ICommandResult Handle(T ICommand);
	}
}