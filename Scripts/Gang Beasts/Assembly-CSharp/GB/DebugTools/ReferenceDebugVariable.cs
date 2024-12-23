using System.Reflection;
using UnityEngine;

namespace GB.DebugTools
{
	public class ReferenceDebugVariable : IDebugVariable
	{
		public FieldInfo fieldInfo;

		public object context;

		public Object unityObject;

		public string path;

		private string _name;

		public int depth;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Group { get; set; }

		public Color Color { get; set; }

		public DebugVariables.DebugVariableCheckMode UpdateMode { get; set; }

		public ReferenceDebugVariable(Object context, FieldInfo fieldInfo, string path)
		{
		}

		public bool ShouldDelete()
		{
			return false;
		}

		public string GetValueString()
		{
			return null;
		}

		private object FindObjectReference(Object context, string[] path)
		{
			return null;
		}

		private void SetName(string name)
		{
		}
	}
}
