using System;
using System.Collections.Generic;

namespace GB.Networking.Router
{
	public class EventLogic<T>
	{
		private Dictionary<int, Action<T>> OnTriggerServer;

		private Dictionary<int, Action<T>> OnTriggerClient;

		public void AddServerTrigger(int key, Action<T> action)
		{
		}

		public void AddClientTrigger(int key, Action<T> action)
		{
		}

		public void RemoveServerTrigger(int key, Action<T> action)
		{
		}

		public void RemoveClientTrigger(int key, Action<T> action)
		{
		}

		public void ServerTrigger(int key, T value)
		{
		}

		public void ClientTrigger(int key, T value)
		{
		}
	}
	public class EventLogic<T1, T2>
	{
		private Dictionary<int, Action<T1, T2>> OnTriggerServer;

		private Dictionary<int, Action<T1, T2>> OnTriggerClient;

		public void AddServerTrigger(int key, Action<T1, T2> action)
		{
		}

		public void AddClientTrigger(int key, Action<T1, T2> action)
		{
		}

		public void RemoveServerTrigger(int key, Action<T1, T2> action)
		{
		}

		public void RemoveClientTrigger(int key, Action<T1, T2> action)
		{
		}

		public void ServerTrigger(int key, T1 value1, T2 value2)
		{
		}

		public void ClientTrigger(int key, T1 value1, T2 value2)
		{
		}
	}
}
