using System;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using Coatsink.UnityServices.Matchmaking;
using UnityEngine;

namespace GB.UnityServices.Matchmaking
{
	public class MatchmakingClientMonobehaviour : MonoBehaviour
	{
		private const string logPrefix = "[MatchmakingClientMonobehaviour]";

		public string FleetId;

		private Action<MatchmakingResult> matchmakingCompleteCallback;

		private MatchmakingTicketModel currentTicket;

		private const int MAX_PROFILE_LENTH = 30;

		private string _activeProfile;

		private bool _initialised;

		private Action _waitingAction;

		public bool Initialised
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action<MatchmakingState> OnMatchmakingStateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialise()
		{
		}

		public void Initialise(BaseUserInfo user)
		{
		}

		public void Terminate()
		{
		}

		public void Initialise(string profileName)
		{
		}

		private void OnInitialised()
		{
		}

		public void StartMatchmaking(MatchmakingTicketModel request, string matchmakingQueue, Action<MatchmakingResult> OnComplete)
		{
		}

		private void RunStartMatchmakingLogic(MatchmakingTicketModel request, string matchmakingQueue, Action<MatchmakingResult> OnComplete, bool allowPingUpdate)
		{
		}

		public void CancelMatchmaking()
		{
		}

		private void OnMatchmakingComplete(MatchmakingResult clientResult)
		{
		}
	}
}
