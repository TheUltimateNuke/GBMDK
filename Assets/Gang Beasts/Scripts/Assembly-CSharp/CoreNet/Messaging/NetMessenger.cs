using System;
using System.Collections.Generic;
using CoreNet.Messaging.Permissions;
using CoreNet.Model;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Messaging
{
	public static class NetMessenger
	{
		public delegate void MessageCallback<T>(T message, NetworkConnection conn) where T : MessageBase, new();

		public const int MESSENGER_CHANNEL = 0;

		private static NetModel _Model;

		private static NetConnection _ServerConnection;

		private static List<NetConnection> _ClientConnections;

		private static Dictionary<short, Permission> _Permissions;

		private static List<Action> _FromClientHandlerBacklog;

		private static List<Action> _FromServerHandlerBacklog;

		public static NetModel Model
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static NetConnection ServerConnection => null;

		public static List<NetConnection> ClientConnections => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void Cleanup()
		{
		}

		public static void RegisterBackloggedFromClientHandlers()
		{
		}

		public static void RegisterBackloggedFromServerHandlers()
		{
		}

		private static void RegisterBackloggedHandlers(List<Action> handlers)
		{
		}

		public static void RegisterFromClientHandler<T>(short messageCode, MessageCallback<T> handler) where T : MessageBase, new()
		{
		}

		public static void RegisterFromServerHandler<T>(short messageCode, MessageCallback<T> handler) where T : MessageBase, new()
		{
		}

		public static void RegisterFromClientHandler<T1, T2>(short messageCode, MessageCallback<T1> handler) where T1 : MessageBase, new() where T2 : Permission, new()
		{
		}

		public static void RegisterFromServerHandler<T1, T2>(short messageCode, MessageCallback<T1> handler) where T1 : MessageBase, new() where T2 : Permission, new()
		{
		}

		public static void OpenHandToServer(short messageCode)
		{
		}

		public static void OpenHandTo(NetConnection connection, short messageCode)
		{
		}

		public static void OpenHandTo(NetworkConnection conn, short messageCode)
		{
		}

		public static bool PermitMessage(int connectionId, short messageCode)
		{
			return false;
		}

		public static void SendAsServer(short messageCode, MessageBase message, bool sendToSelf = false)
		{
		}

		public static void SendAsClient(short messageCode, MessageBase message)
		{
		}

		public static void Send(NetConnection connection, short messageCode, MessageBase message)
		{
		}

		public static void Send(NetworkConnection conn, short messageCode, MessageBase message)
		{
		}

		private static void ListHandlers(NetworkConnection conn, ref string debugString)
		{
		}

		private static NetworkMessageDelegate GenerateHandler<T>(MessageCallback<T> handler) where T : MessageBase, new()
		{
			return null;
		}

		public static void PrintHandlerAndPermissionStatus()
		{
		}
	}
}
