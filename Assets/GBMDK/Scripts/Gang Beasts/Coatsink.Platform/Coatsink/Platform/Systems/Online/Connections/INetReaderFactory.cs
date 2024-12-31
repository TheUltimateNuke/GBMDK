namespace Coatsink.Platform.Systems.Online.Connections
{
	public interface INetReaderFactory
	{
		INetReader CreateReader(string[] _keys);
	}
}
