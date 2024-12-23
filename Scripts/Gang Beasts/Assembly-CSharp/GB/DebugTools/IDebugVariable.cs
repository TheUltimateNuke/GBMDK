using UnityEngine;

namespace GB.DebugTools
{
	public interface IDebugVariable
	{
		string Name { get; set; }

		string Group { get; set; }

		Color Color { get; set; }

		DebugVariables.DebugVariableCheckMode UpdateMode { get; set; }

		bool ShouldDelete();

		string GetValueString();
	}
}
