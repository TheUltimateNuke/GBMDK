using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Data;
using GB.Networking.Objects;
using GB.Networking.Utils.Spawn;
using UnityEngine;

namespace GB.Game
{
	public class GameMode_Rumble : GameMode
	{
		private struct PlayerSpawnQueue
		{
			public int connectionID;

			public int controllerID;

			public PlayerSpawnQueue(int con, int cont):this()
			{
			}
		}

		private struct BeastSpawnList
		{
			public int playerID;

			public int type;

			public int colour;

			public ushort[] costume;

			public string name;
		}

		[CompilerGenerated]
		private sealed class _003CSpawnLoop_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode_Rumble _003C_003E4__this;

			private int _003CspawnFlipper_003E5__2;

			private GBSpawnPoint[] _003CspawnPoints_003E5__3;

			private int _003CspawnTimeInt_003E5__4;

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
			public _003CSpawnLoop_003Ed__22(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CPreGameCountdown_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CPreGameCountdown_003Ed__33(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public const int NETMESSAGE_NEXTSPAWN_TIME = 1501;

		public const int NETMESSAGE_BEAST_SPAWNED = 1502;

		public const int NETMESSAGE_BEAST_TOTALCHANGE = 1503;

		public const int NETMESSAGE_BEAST_LOST = 1504;

		public const string OVERRIDE_INFO_FILE = "Rumble_Override.txt";

		public const string ID = "rumble";

		private Coroutine _spawnCoroutine;

		private List<Actor> _activeActors;

		private int _nextPlayer;

		private float _spawnTimer;

		private float _spawnTime;

		private int _totalPlayers;

		private Queue<PlayerSpawnQueue> _spawnList;

		private List<BeastSpawnList> _spawnOverrideList;

		private RumbleData _rumbleInfomation;

		public override string GetID()
		{
			return null;
		}

		public override void Init()
		{
		}

		private void DataOverride()
		{
		}

		public override void Cleanup()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnLoop_003Ed__22))]
		private IEnumerator SpawnLoop()
		{
			return null;
		}

		private void SpawnNextBeast(GBSpawnPoint spawnPoint)
		{
		}

		public override bool UseGameTimer()
		{
			return false;
		}

		public override void EndRound()
		{
		}

		public override bool IsRoundOver()
		{
			return false;
		}

		public override bool IsGameValid()
		{
			return false;
		}

		public override void InitRound()
		{
		}

		protected override void InitBeast(NetBeast pBeast)
		{
		}

		protected override void InitGang(int gangId)
		{
		}

		public override void OnBeastDeath(NetBeast beast, Actor actor)
		{
		}

		public override void StartRound()
		{
		}

		[IteratorStateMachine(typeof(_003CPreGameCountdown_003Ed__33))]
		public override IEnumerator PreGameCountdown()
		{
			return null;
		}

		protected override bool GameWinnerFilter(NetGang beast)
		{
			return false;
		}

		public override List<NetGang> GetRoundWinners()
		{
			return null;
		}

		public override void SendRoundOverMessage(bool mapComplete)
		{
		}
	}
}
