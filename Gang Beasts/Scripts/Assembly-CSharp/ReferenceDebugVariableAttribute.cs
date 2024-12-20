using System;
using GB.DebugTools;

public class ReferenceDebugVariableAttribute : Attribute
{
	public string name;

	public string groupName;

	public DebugVariables.DebugVariableCheckMode updateMode;

	public ReferenceDebugVariableAttribute(string name = "", string groupName = "", DebugVariables.DebugVariableCheckMode updateMode = DebugVariables.DebugVariableCheckMode.None)
	{
	}
}
