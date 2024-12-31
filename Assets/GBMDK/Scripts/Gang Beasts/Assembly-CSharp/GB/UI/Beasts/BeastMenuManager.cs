using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using Femur;
using GB.Platform.Lobby;
using UnityEngine;

namespace GB.UI.Beasts
{
	public class BeastMenuManager : MonoBehaviour
	{
		private struct PointInformation
		{
			private int _playerAssigned;

			private int _pointIndex;

			[CompilerGenerated]
			private Action<int, int> m__onAssignedChanged;

			public int PlayerAssigned
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int PointIndex => 0;

			private event Action<int, int> _onAssignedChanged
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

			public PointInformation(int pointIndex, Action<int, int> onAssignedChanged) : this()
			{
				_playerAssigned = 0;
				_pointIndex = 0;
			}

			public void RefreshPoint()
			{
			}
		}

		[Serializable]
		private struct SpawnOrder
		{
			public int[] Order;

			public SpawnOrder(int[] _order)
			{
				Order = null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CPinBeastsRoutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BeastMenuManager _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CPinBeastsRoutine_003Ed__37(int _003C_003E1__state)
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
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[SerializeField]
		private BeastMenuSpawner _beastSpawnPoints;

		private List<int> lobbyBeastsInTeams;

		private PointInformation[] _pointInfo;

		[SerializeField]
		private SpawnOrder[] _spawnOrder;

		private List<Actor> actorsToPin;

		private Coroutine pinRoutine;

		public event Action OnPositionClear
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

		public event Action<int, int> OnPositionPlayerChanged
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

		public event Action<int, int> OnPositionSet
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

		public event Action<int, int> OnPositionCleared
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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void LobbyPlayerManager_OnPlayerLeft(BaseUserInfo obj)
		{
		}

		private bool Setup()
		{
			return false;
		}

		private void OnDestroy()
		{
		}

		public int GetLobbyBeastTeamCount()
		{
			return 0;
		}

		private void BeastTeamChange(LocalPlayerInfomationCache player, int oldTeam)
		{
		}

		private void OnlineBeastTeamChange(OnlinePlayerInfomationCache player, int oldTeam)
		{
		}

		public void DespawnBeast(int playerID)
		{
		}

		public void SpawnBeast(int playerID, int teamIndex)
		{
		}

		public int GetSpawn(int playerID, int teamIndex)
		{
			return 0;
		}

		public void ResetPositions()
		{
		}

		public void ClearPositions()
		{
		}

		private void PositionAssignedChanged(int point, int player)
		{
		}

		public int GetPointPlayerID(int point)
		{
			return 0;
		}

		public void StartPinRoutine()
		{
		}

		public void EndPinRoutine()
		{
		}

		[IteratorStateMachine(typeof(_003CPinBeastsRoutine_003Ed__37))]
		public IEnumerator PinBeastsRoutine()
		{
			return null;
		}
	}
}