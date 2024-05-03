using UnityEngine.Networking;

namespace CoreNet.Model
{
	public abstract class NetBucket
	{
		protected short _Code;

		public short Code => 0;

		public bool Syncable => false;

		public abstract void Clear();

		public abstract void PropagateAllToClient(NetworkConnection conn);
	}
}
