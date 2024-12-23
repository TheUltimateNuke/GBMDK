namespace UnityWebSocketSharp
{
	internal enum WebSocketState : ushort
	{
		New = 0,
		Connecting = 1,
		Open = 2,
		Closing = 3,
		Closed = 4
	}
}
