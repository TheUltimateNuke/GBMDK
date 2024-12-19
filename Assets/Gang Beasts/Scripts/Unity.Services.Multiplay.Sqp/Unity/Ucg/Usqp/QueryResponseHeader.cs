namespace Unity.Ucg.Usqp
{
	internal struct QueryResponseHeader
	{
		public UsqpHeader Header;

		public ushort Version;

		public byte CurrentPacket;

		public byte LastPacket;

		public ushort Length;

		private DataStreamWriter m_LengthWriter;

		public void ToStream(ref DataStreamWriter writer)
		{
		}

		public void UpdateLength(ushort length)
		{
		}
	}
}
