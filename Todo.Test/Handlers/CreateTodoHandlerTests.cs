
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commads;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Test.Repositories;

//red -> Fail
//green -> Pass
//refactor
namespace Todo.Test.Handlers
{
	[TestClass]
	public class CreateTodoHandlerTests
	{
		private readonly CreateTodoCommand _invalidCommand;
		private readonly CreateTodoCommand _validCommand;
		private readonly TodoHandler _handler;

		public CreateTodoHandlerTests()
		{
			_invalidCommand = new CreateTodoCommand("", DateTime.Now, "");
			_validCommand = new CreateTodoCommand("Titula da tarefa", DateTime.Now, "Jairo Rodrigues");
			_handler = new TodoHandler(new FakeRepository());
		}

		[TestMethod]
		public void Dado_um_commando_invalido_deve_interromper_a_execução()
		{
			var result = (GenericCommandResult)_handler.Handle(_invalidCommand);
			Assert.AreEqual(result.Success, false);
		}

		[TestMethod]
		public void Dado_um_commando_invalido_deve_criar_a_tarefa()
		{

			var result = (GenericCommandResult)_handler.Handle(_validCommand);
			Assert.AreEqual(result.Success, true);
		}

	}
}
