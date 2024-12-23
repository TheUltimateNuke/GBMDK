namespace Coatsink.Platform.Systems.Online.Connections
{
	public interface INetConnectionFactory
	{
		INetConnection CreateConnection(string[] _keys);
	}
}
