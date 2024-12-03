using System;

namespace UnityEngine.Networking
{
	[Serializable]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public struct NetworkSceneId : IEquatable<NetworkSceneId>
	{
		[SerializeField]
		private uint m_Value;

		public uint Value => 0u;

		public NetworkSceneId(uint value)
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

		public bool Equals(NetworkSceneId other)
		{
			return false;
		}

		public static bool operator ==(NetworkSceneId c1, NetworkSceneId c2)
		{
			return false;
		}

		public static bool operator !=(NetworkSceneId c1, NetworkSceneId c2)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
