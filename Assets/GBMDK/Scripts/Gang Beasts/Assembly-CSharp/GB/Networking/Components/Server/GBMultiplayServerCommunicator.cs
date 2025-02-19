using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Components;
using GB.Config;
using GB.Gamemodes;
using GB.Networking.Objects;
using Unity.Services.Matchmaker.Models;
using UnityEngine.SceneManagement;

namespace GB.Networking.Components.Server
{
	public class GBMultiplayServerCommunicator : NetComponent
	{
		[CompilerGenerated]
		private sealed class _003CCloseGame_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator<object>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CCloseGame_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		private const string logPrefix = "[GBMultiplayServerCommunicator]";

		private ushort maxPlayersDefault;

		public GBSessionData ActiveSessionData { get; private set; }

		public event Action<GBSessionData> OnGBSessionDataReceived
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

		private new void Awake()
		{
		}

		private void OnServicesInitialised()
		{
		}

		private void OnServerStarted()
		{
		}

		private void OnServerStopped()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetGameMode(string gameMode)
		{
		}

		public void SetMaxPlayers(ushort maxPlayers)
		{
		}

		private void OnRotationConfigUpdated(RotationConfig newConfig)
		{
		}

		private void OnGameModeChanged(GameModeEnum gameMode)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnMatchmakingResultsReceived(MatchmakingResults matchmakingResults)
		{
		}

		private void OnMatchmakingResultsError()
		{
		}

		[IteratorStateMachine(typeof(_003CCloseGame_003Ed__23))]
		private IEnumerator CloseGame()
		{
			return null;
		}

		private void SceneManager_sceneLoaded(Scene newScene, LoadSceneMode loadMode)
		{
		}

		private void PlayerAdded(NetBeast player)
		{
		}

		private void PlayerNothing(NetBeast userInfo)
		{
		}

		private void PlayerLost(NetBeast player)
		{
		}
	}
}
