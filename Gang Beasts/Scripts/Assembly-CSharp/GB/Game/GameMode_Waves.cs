using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Utils;
using Femur;
using GB.Game.Data;
using GB.Networking.Objects;
using UnityEngine;

namespace GB.Game
{
	public class GameMode_Waves : GameMode
	{
		private struct AIBeastData
		{
			public GameObject Object { get; set; }

			public NetBeast netBeastRef { get; set; }

			public Actor AIBeast { get; set; }

			public int Gang { get; set; }

			public AIBeastData(GameObject ob, NetBeast beastRef, Actor act, int Ga)
			{
				Object = null;
				netBeastRef = null;
				AIBeast = null;
				Gang = 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003CPreGameCountdown_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode_Waves _003C_003E4__this;

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
			public _003CPreGameCountdown_003Ed__19(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRunWaveLogic_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode_Waves _003C_003E4__this;

			private Wave _003CspawnList_003E5__2;

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
			public _003CRunWaveLogic_003Ed__28(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRespawnPlayers_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode_Waves _003C_003E4__this;

			private SpawnParams _003Cparameters_003E5__2;

			private List<NetBeast> _003ChumanPlayers_003E5__3;

			private bool _003Crespawned_003E5__4;

			private bool _003CallAlive_003E5__5;

			private CoreNetSpawnPosition[] _003Cpoints_003E5__6;

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
			public _003CRespawnPlayers_003Ed__29(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CSpawnWaveAI_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Wave spawnList;

			public GameMode_Waves _003C_003E4__this;

			private SpawnParams _003Cparameters_003E5__2;

			private bool _003Cspawned_003E5__3;

			private List<CoreNetSpawnPosition> _003CusedSpawns_003E5__4;

			private int _003Ci_003E5__5;

			private int _003Cgang_003E5__6;

			private int _003Ctype_003E5__7;

			private bool _003CnewNet_003E5__8;

			private NetBeast _003CnetBeastRef_003E5__9;

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
			public _003CSpawnWaveAI_003Ed__30(int _003C_003E1__state)
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

		public const string ID = "waves";

		public const int PLAYER_GANGID = 0;

		private float roundTimer;

		private float totalTime;

		private WavesData _waveInfomation;

		private int _roundCounter;

		private List<Actor> _aiActors;

		private static int AI_CONTROLLER_STARTIDEX;

		private List<NetBeast> _aiNetPlayers;

		private Coroutine aiSpawnCoroutine;

		private WaitForSeconds _spawnPointFullDelay;

		public override bool ReloadBetweenRounds => false;

		public override bool UseGameTimer()
		{
			return false;
		}

		public override void Init()
		{
		}

		public override void GameModeUpdate()
		{
		}

		public override void SetupGangIDsForOnlineSession(int totalPlayers, bool privateGame)
		{
		}

		public override void SendRoundBeginMessage()
		{
		}

		[IteratorStateMachine(typeof(_003CPreGameCountdown_003Ed__19))]
		public override IEnumerator PreGameCountdown()
		{
			return null;
		}

		public override void SendRoundOverMessage(bool mapComplete)
		{
		}

		private void SendMessage(string message, Vector2 offset, Color color)
		{
		}

		public override string GetID()
		{
			return null;
		}

		protected override void InitBeast(NetBeast pBeast)
		{
		}

		public override void Cleanup()
		{
		}

		public override void StartRound()
		{
		}

		public override bool IsGameValid()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CRunWaveLogic_003Ed__28))]
		private IEnumerator RunWaveLogic()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRespawnPlayers_003Ed__29))]
		private IEnumerator RespawnPlayers()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSpawnWaveAI_003Ed__30))]
		private IEnumerator SpawnWaveAI(Wave spawnList)
		{
			return null;
		}

		public void SpawnAdditionalDebugAI(int beastType = 0)
		{
		}

		public override void EndRound()
		{
		}

		public override bool IsRoundOver()
		{
			return false;
		}

		public override bool IsGameOver()
		{
			return false;
		}

		public override List<NetGang> GetRoundWinners()
		{
			return null;
		}

		public override List<NetGang> GetGameWinners()
		{
			return null;
		}

		public override void OnBeastDeath(NetBeast beast, Actor actor)
		{
		}

		protected override bool GameWinnerFilter(NetGang gang)
		{
			return false;
		}

		public override void HandleScore()
		{
		}

		public override void InitRound()
		{
		}
	}
}
