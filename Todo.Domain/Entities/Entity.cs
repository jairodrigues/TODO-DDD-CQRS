using System;

namespace Todo.Domain.Entities
{
	//IEquatable => permite um ou mais comparações entre objetos
	public abstract class Entity : IEquatable<Entity>
	{
		public Entity()
		{
			Id = Guid.NewGuid();
		}

		public Guid Id { get; private set; }

		public bool Equals(Entity other)
		{
			return Id == other.Id;
		}
	}
}