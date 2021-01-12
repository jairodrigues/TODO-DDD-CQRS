using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Test.Repositories
{
	public class FakeRepository : ITodoRepository
	{
		public void Create(TodoItem todo) { }

		public TodoItem GetById(Guid id, string user)
		{
			return new TodoItem("Titulo do teste", DateTime.Now, "jairodrigues");
		}

		public void Update(TodoItem todo) { }
	}
}