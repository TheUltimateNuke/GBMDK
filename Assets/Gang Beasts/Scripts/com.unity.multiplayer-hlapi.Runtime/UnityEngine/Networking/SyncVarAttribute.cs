using System;

namespace UnityEngine.Networking
{
	[AttributeUsage(AttributeTargets.Field)]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class SyncVarAttribute : Attribute
	{
		public string hook;
	}
}
