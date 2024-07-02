using CoreNet.StateSync.States;
using UnityEngine;

namespace CoreNet.StateSync.Syncs
{
	public class TransformSync : BaseSync
	{
		public const float SNAP_THRESHOLD = 10f;

		public int StateCount;

		private float _LastLerp;

		private TransformState _PrevState;

		protected TransformState[] _StateBuffer;

		protected TransformState refState;

		private Vector3 initalPosition;

		private Quaternion initalRotation;

		private bool _hasRecievedState;

		[HideInInspector]
		public Transform parent;

		public virtual Vector3 CurrentPosition => default(Vector3);

		public virtual Quaternion CurrentRotation => default(Quaternion);

		public virtual Vector3 CurrentScale => default(Vector3);

		public override BaseState GetRefState()
		{
			return null;
		}

		public override void AddState(BaseState state)
		{
		}

		public void AddState(TransformState state)
		{
		}

		public override void Init()
		{
		}

		protected override void UpdatePosition()
		{
		}

		private void Lerp()
		{
		}

		private TransformState GetState(int preIndex, int postIndex)
		{
			return null;
		}

		private TransformState GetState(int index)
		{
			return null;
		}

		private void SetTransformAbsolute(TransformState state)
		{
		}

		protected void SetTransform(TransformState state)
		{
		}

		private float GetTweenToLatest(float prevTimestep, float nextTimestep)
		{
			return 0f;
		}

		private TransformState InterpStates(TransformState a, TransformState b)
		{
			return null;
		}

		private TransformState InterpStates(TransformState a, TransformState b, float alpha)
		{
			return null;
		}

		private bool StateMeaningfullyDifferent(TransformState state)
		{
			return false;
		}

		private void PrintAllBuffers()
		{
		}

		protected void ShuffleBuffer()
		{
		}

		protected virtual void SetPosition(Vector3 position, bool teleport = false)
		{
		}

		protected virtual void SetRotation(Quaternion rotation, bool teleport = false)
		{
		}

		protected virtual void SetScale(Vector3 scale)
		{
		}

		public virtual void BlitzBuffer()
		{
		}

		public TransformState[] GetStateBuffer()
		{
			return null;
		}
	}
}
