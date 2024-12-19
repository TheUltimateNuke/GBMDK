using System;
using UnityEngine;

namespace GB.DebugTools
{
	public class DebugVariable<T> : IDebugVariable
	{
		public T value;

		public string Name { get; set; }

		public string Group { get; set; }

		public Color Color { get; set; }

		public DebugVariables.DebugVariableCheckMode UpdateMode { get; set; }

		public Action OnChange { get; set; }

		public DebugVariable()
		{
		}

		public DebugVariable(Action OnChangeFunc)
		{
		}

		public virtual string GetValueString()
		{
			return null;
		}

		public bool ShouldDelete()
		{
			return false;
		}

		public virtual void ChangeValue(T newValue)
		{
		}
	}
}
