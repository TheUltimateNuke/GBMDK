using System;

namespace Coatsink.Platform.Systems.Online.Connections
{
	[Serializable]
	[Flags]
	public enum ConnectionStatus : byte
	{
		Unknown = 1,
		Connecting = 2,
		Connected = 4,
		Disconnected = 8
	}
}
