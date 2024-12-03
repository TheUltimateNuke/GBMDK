using System;
using UnityEngine;

namespace CoreNet.Components
{
	public abstract class NetRoundOrganiser : NetComponent
	{
		protected static NetRoundOrganiser _instance;

		protected bool isRestarting;

		public Action OnServerClientsLoaded;

		public Action OnGameSetup;

		public Action OnGameStart;

		public Action OnGameEnded;

		public Action OnPostGameEnded;

		public Action OnPreLevelLoad;

		public Action OnClientJoined;

		public static NetRoundOrganiser Instance => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		protected void FlushAllEvents()
		{
		}

		public void InvokeOnServerClientsLoaded()
		{
		}

		public void InvokeOnGameSetup()
		{
		}

		public void InvokeOnGameStart()
		{
		}

		public void InvokeOnGameEnded()
		{
		}

		public void InvokeOnPostGameEnded()
		{
		}

		public void InvokeOnPreLevelLoad()
		{
		}

		public void InvokeOnClientJoined()
		{
		}

		public void RestartRound()
		{
		}

		public bool IsRestartingRound()
		{
			return false;
		}

		private void NetLog(string logMessage)
		{
		}
	}
}
