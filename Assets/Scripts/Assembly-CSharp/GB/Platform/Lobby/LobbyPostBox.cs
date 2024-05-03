using System;
using System.Collections.Generic;
using CS.CorePlatform;
using CS.CorePlatform.Utils.Data;
using GB.Platform.Lobby.Messages;

namespace GB.Platform.Lobby
{
	public static class LobbyPostBox
	{
		private abstract class carrierBase
		{
			public Type Type;

			public abstract void Run(BaseUserInfo user, DataReader data);
		}

		private class carrierUser<T> : carrierBase where T : LobbyMessage, new()
		{
			public Action<BaseUserInfo, T> Action;

			private T reader;

			public override void Run(BaseUserInfo user, DataReader data)
			{
			}
		}

		private static Dictionary<byte, carrierBase> _pigeonHolesClient;

		private static Dictionary<byte, carrierBase> _pigeonHolesHost;

		private static Dictionary<byte, carrierBase> _pigeonHolesUser;

		static LobbyPostBox()
		{
		}

		public static void SetupListeners()
		{
		}

		private static void PlatformEvents_OnReceivedLobbyClientMessageEvent(BaseUserInfo user, DataReader message)
		{
		}

		public static void AddClientEvent<T>(byte target, Action<BaseUserInfo, T> trigger) where T : LobbyMessage, new()
		{
		}

		public static void RemoveClientEvent<T>(byte target, Action<BaseUserInfo, T> trigger) where T : LobbyMessage, new()
		{
		}

		private static void PlatformEvents_OnReceivedLobbyHostMessageEvent(DataReader message)
		{
		}

		public static void AddHostEvent<T>(byte target, Action<BaseUserInfo, T> trigger) where T : LobbyMessage, new()
		{
		}

		public static void RemoveHostEvent<T>(byte target, Action<BaseUserInfo, T> trigger) where T : LobbyMessage, new()
		{
		}

		private static void PlatformEvents_OnReceivedLobbyUserMessageEvent(BaseUserInfo user, DataReader message)
		{
		}

		public static void AddUserEvent<T>(byte target, Action<BaseUserInfo, T> trigger) where T : LobbyMessage, new()
		{
		}

		public static void RemoveUserEvent<T>(byte target, Action<BaseUserInfo, T> trigger) where T : LobbyMessage, new()
		{
		}
	}
}
