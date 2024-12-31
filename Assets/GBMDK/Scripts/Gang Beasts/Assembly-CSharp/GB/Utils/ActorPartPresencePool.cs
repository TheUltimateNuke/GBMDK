namespace GB.Utils
{
	internal static class ActorPartPresencePool
	{
		private static readonly Pool<ActorPartPresence> Pool;

		public static ActorPartPresence GetActorPartPresence()
		{
			return null;
		}

		public static void Recycle(ActorPartPresence writer)
		{
		}
	}
}
