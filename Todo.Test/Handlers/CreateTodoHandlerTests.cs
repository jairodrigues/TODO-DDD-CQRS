
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commads;
using Todo.Domain.Handlers;

//red -> Fail
//green -> Pass
//refactor
namespace Todo.Test.Handlers
{
	[TestClass]
	public class CreateTodoHandlerTests
	{

		public CreateTodoHandlerTests()
		{

		}

		[TestMethod]
		public void Dado_um_commando_invalido_deve_interromper_a_execução()
		{
			var command = new CreateTodoCommand("", DateTime.Now, "");
			var hadler = new TodoHandler(null);
			Assert.Fail();
		}

		[TestMethod]
		public void Dado_um_commando_invalido_deve_criar_a_tarefa()
		{
			Assert.Fail();
		}

	}
}
