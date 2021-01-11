using Flunt.Notifications;
using Todo.Domain.Commads;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
	public class TodoHandler : Notifiable, IHandler<CreateTodoCommand>
	{
		private readonly ITodoRepository _repository;

		public TodoHandler(ITodoRepository repository)
		{
			_repository = repository;
		}

		public ICommandResult Handle(CreateTodoCommand command)
		{
			//valida o commando
			command.Validate();
			if (command.Invalid)
				return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada", command.Notifications);

			//cria um novo Todo
			var todo = new TodoItem(command.Title, command.Date, command.User);

			//salva no banco
			_repository.Create(todo);

			//returna o resultado
			return new GenericCommandResult(true, "Tarefa salva", todo);
		}
	}
}