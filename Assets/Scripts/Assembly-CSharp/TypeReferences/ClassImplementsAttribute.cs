using System;

namespace TypeReferences
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class ClassImplementsAttribute : ClassTypeConstraintAttribute
	{
		public Type InterfaceType { get; private set; }

		public ClassImplementsAttribute()
		{
		}

		public ClassImplementsAttribute(Type interfaceType)
		{
		}

		public override bool IsConstraintSatisfied(Type type)
		{
			return false;
		}
	}
}
