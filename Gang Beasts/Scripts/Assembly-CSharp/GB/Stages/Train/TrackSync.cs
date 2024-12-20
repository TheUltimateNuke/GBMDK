using CoreNet.StateSync.States;
using CoreNet.StateSync.Syncs;
using UnityEngine;

namespace GB.Stages.Train
{
	public class TrackSync : TransformSync
	{
		[SerializeField]
		private TrackPool _trackPool;

		private TrackMover _lastTarget;

		private TrackSyncState refTrackState;

		protected Rigidbody _rigidbody;

		public override void Init()
		{
		}

		public override void AddState(BaseState state)
		{
		}

		private bool StateMeaningfullyDifferent(TrackSyncState state)
		{
			return false;
		}

		protected TransformState GetState(int preIndex, int postIndex)
		{
			return null;
		}

		protected TrackSyncState GetState(int index)
		{
			return null;
		}

		public override BaseState GetRefState()
		{
			return null;
		}

		protected override void UpdatePosition()
		{
		}

		private void UpdateChain()
		{
		}

		public byte PickTarget()
		{
			return 0;
		}

		public Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		public Quaternion TargetRotation()
		{
			return default(Quaternion);
		}

		public Vector3 TargetScale()
		{
			return default(Vector3);
		}

		protected override void SetPosition(Vector3 position, bool teleport = false)
		{
		}

		protected override void SetRotation(Quaternion rotation, bool teleport = false)
		{
		}
	}
}
