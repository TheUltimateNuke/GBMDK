namespace GB.NetworkedInput
{
	public class DigitalState
	{
		public bool PreviousState;

		public bool CurrentState;

		public void Flush()
		{
		}

		public bool GetState()
		{
			return false;
		}

		public bool GetJustDown()
		{
			return false;
		}

		public bool GetJustUp()
		{
			return false;
		}
	}
}
