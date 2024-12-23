using System;

namespace UnityEngine.Networking
{
	[AttributeUsage(AttributeTargets.Event)]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class SyncEventAttribute : Attribute
	{
		public int channel;
	}
}
