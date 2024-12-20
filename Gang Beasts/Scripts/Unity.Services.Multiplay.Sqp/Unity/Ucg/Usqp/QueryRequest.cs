namespace Unity.Ucg.Usqp
{
	internal struct QueryRequest
	{
		public UsqpHeader Header;

		public ushort Version;

		public byte RequestedChunks;

		public void FromStream(ref DataStreamReader reader, bool header = true)
		{
		}
	}
}
