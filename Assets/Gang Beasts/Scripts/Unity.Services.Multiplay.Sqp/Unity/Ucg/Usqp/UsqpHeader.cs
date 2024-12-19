namespace Unity.Ucg.Usqp
{
	internal struct UsqpHeader
	{
		public uint ChallengeId;

		public byte Type { get; internal set; }

		public void ToStream(ref DataStreamWriter writer)
		{
		}

		public void FromStream(ref DataStreamReader reader)
		{
		}
	}
}
