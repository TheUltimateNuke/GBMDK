using System;
using UnityEngine;

namespace CoreNet.StateSync.States
{
	[Serializable]
	public class TransformState : BaseState
	{
		public Vector3 Position;

		public Quaternion Rotation;

		public Vector3 Scale;

		public TransformState()
		{
		}

		public TransformState(float timestamp, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		public void Set(TransformState state)
		{
		}

		public void Set(float timestamp, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
