using System;
using UnityEngine;

namespace GB.Networking.Utils.Spawn
{
	public class GBGangSpawnPoint : GBMultiSpawnPoint
	{
		[Serializable]
		private struct Options
		{
			public Vector3 offset;

			public Vector3 rotation;

			public Options(Vector3 _offset, Vector3 _rotation)
			{
				offset = default(Vector3);
				rotation = default(Vector3);
			}
		}

		[SerializeField]
		private Options[] _options;

		public override bool Locked => false;

		public override int Size => 0;

		protected override Vector3 ResultingPosition(int i)
		{
			return default(Vector3);
		}

		protected override Quaternion ResultingRotation(int i)
		{
			return default(Quaternion);
		}
	}
}
