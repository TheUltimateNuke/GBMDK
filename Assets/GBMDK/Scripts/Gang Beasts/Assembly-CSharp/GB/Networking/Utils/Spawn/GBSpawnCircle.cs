using CoreNet.Utils;
using UnityEngine;

namespace GB.Networking.Utils.Spawn
{
	public class GBSpawnCircle : GBMultiSpawnPoint
	{
		private enum StartPoint
		{
			Round = 0,
			Random = 1,
			Out = 2
		}

		private bool _setup;

		private int _size;

		[SerializeField]
		private bool _lookIn;

		[SerializeField]
		private float _raduis;

		[Range(0f, 1f)]
		[SerializeField]
		private float _segment;

		[SerializeField]
		private int _maxSize;

		[SerializeField]
		private StartPoint _startPointType;

		private Vector3 _offset;

		private float _rotationSet;

		private int _startPointIndex;

		public override int Size => 0;

		public override bool Locked => false;

		public override void Use(SpawnParams param)
		{
		}

		private void Setup(int size)
		{
		}

		private int UseIndexAt(int i)
		{
			return 0;
		}

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
