namespace Coatsink.Platform.Systems.Online.Connections
{
	public enum NetTransportUpdate
	{
		Error = 0,
		Connected = 1,
		Disconnected = 2,
		Received = 3,
		Skipped = 4,
		HostMigrating = 5,
		HostMigrated = 6
	}
}
