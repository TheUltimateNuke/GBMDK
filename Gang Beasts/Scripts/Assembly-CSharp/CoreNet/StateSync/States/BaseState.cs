using System;

namespace CoreNet.StateSync.States
{
	[Serializable]
	public class BaseState
	{
		public float Timestamp;

		public BaseState()
		{
		}

		public BaseState(float timestamp)
		{
		}

		public void Set(BaseState state)
		{
		}

		public void Set(float timestamp)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
