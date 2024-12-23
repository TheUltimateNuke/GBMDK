using System;
using System.Collections.Generic;
using CoreNet.Components;
using CoreNet.Messaging;
using UnityEngine.Networking;

namespace GB.Networking.Components.Client
{
	public class GBClientGamemodeInfoListener : NetComponent
	{
		private abstract class carrierBase
		{
			public Type Type;

			public abstract void Register();

			public abstract bool Empty();
		}

		private class carrierUser<T> : carrierBase where T : MessageBase, new()
		{
			public NetMessenger.MessageCallback<T> Action;

			private T reader;

			private short Code;

			public carrierUser(short code)
			{
			}

			public override bool Empty()
			{
				return false;
			}

			public override void Register()
			{
			}

			public void Handler(T message, NetworkConnection conn)
			{
			}
		}

		private static Dictionary<short, carrierBase> _REGISTERED_NEEDS;

		private void Start()
		{
		}

		private void RegisterNeeds()
		{
		}

		public static void AddEvent<T>(short code, NetMessenger.MessageCallback<T> handle) where T : MessageBase, new()
		{
		}

		public static void RemoveEvent<T>(short code, NetMessenger.MessageCallback<T> handle) where T : MessageBase, new()
		{
		}

		public static void Flush()
		{
		}
	}
}
