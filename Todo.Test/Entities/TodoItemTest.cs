

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;


//red -> Fail
//green -> Pass
//refactor
namespace Todo.Test.Handlers
{
	[TestClass]
	public class TodoItemTests
	{
		private readonly TodoItem _validTodo;
		public TodoItemTests()
		{
			_validTodo = new TodoItem("Titulo Aqui", DateTime.Now, "jairodrigues");
		}

		[TestMethod]
		public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
		{
			Assert.AreEqual(_validTodo.Done, false);
		}



	}
}
