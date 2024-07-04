using CoreNet.StateSync.States;
using UnityEngine;

namespace CoreNet.StateSync.Syncs
{
	public class IgnoreScaleTransformSync : TransformSync
	{
		private TransformState _PrevState;

		private Vector3 initalPosition;

		private Quaternion initalRotation;

		private bool _hasRecievedState;

		public override BaseState GetRefState()
		{
			return null;
		}

		public override void AddState(BaseState state)
		{
		}

		public new void AddState(TransformState state)
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

		protected new void SetTransform(TransformState state)
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
	}
}
