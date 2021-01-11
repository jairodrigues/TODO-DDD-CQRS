using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commads;

//red -> Fail
//green -> Pass
//refactor
namespace Todo.Test
{
	[TestClass]
	public class CreateTodoCommandTests
	{
		private readonly CreateTodoCommand _invalidCommand;
		private readonly CreateTodoCommand _validCommand;

		public CreateTodoCommandTests()
		{
			_invalidCommand = new CreateTodoCommand("", DateTime.Now, "");
			_invalidCommand.Validate();

			_validCommand = new CreateTodoCommand("Titulo teste", DateTime.Now, "jairo Rodrigues");
			_validCommand.Validate();
		}

		[TestMethod]
		public void Dado_um_commando_invalido()
		{
			Assert.AreEqual(_invalidCommand.Valid, false);
		}

		[TestMethod]
		public void Dado_um_commando_valido()
		{
			Assert.AreEqual(_validCommand.Valid, true);
		}
	}
}
