using System;

namespace UnityEngine.Networking
{
	[Serializable]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public struct NetworkInstanceId : IEquatable<NetworkInstanceId>
	{
		[SerializeField]
		private readonly uint m_Value;

		public static NetworkInstanceId Invalid;

		internal static NetworkInstanceId Zero;

		public uint Value => 0u;

		public NetworkInstanceId(uint value)
		{
			m_Value = 0u;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(NetworkInstanceId other)
		{
			return false;
		}

		public static bool operator ==(NetworkInstanceId c1, NetworkInstanceId c2)
		{
			return false;
		}

		public static bool operator !=(NetworkInstanceId c1, NetworkInstanceId c2)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
