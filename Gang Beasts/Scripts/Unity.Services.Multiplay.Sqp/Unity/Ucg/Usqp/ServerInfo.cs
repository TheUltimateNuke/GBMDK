using System;
using System.Text;

namespace Unity.Ucg.Usqp
{
	internal class ServerInfo
	{
		[Serializable]
		public class Data
		{
			public string BuildId;

			public ushort CurrentPlayers;

			public string GameType;

			public string Map;

			public ushort MaxPlayers;

			public ushort Port;

			public string ServerName;

			private static void WriteString(ref DataStreamWriter writer, string value)
			{
			}

			public void ToStream(ref DataStreamWriter writer)
			{
			}
		}

		private static Encoding s_Encoding;

		private static Encoder s_Encoder;

		public uint ChunkLen;

		public QueryResponseHeader QueryHeader;

		public Data ServerInfoData;

		public void ToStream(ref DataStreamWriter writer)
		{
		}
	}
}
