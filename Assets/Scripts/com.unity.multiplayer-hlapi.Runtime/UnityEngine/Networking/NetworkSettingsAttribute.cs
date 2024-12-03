using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NetworkSettingsAttribute : Attribute
	{
		public int channel;

		public float sendInterval;
	}
}
