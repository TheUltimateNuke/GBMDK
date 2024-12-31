using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Utils
{
	public abstract class CoreNetSpawnPosition : NetworkStartPosition
	{
		protected bool _locked;

		public virtual bool Locked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual Vector3 Position => default(Vector3);

		public virtual Quaternion Rotation => default(Quaternion);
	}
}
