using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Utils;
using Femur;
using GB.Networking.Objects;
using UnityEngine;

public static class GameModeUtils
{
	public class RespawnManager
	{
		private struct RespawnElement
		{
			public NetBeast beast;

			public Coroutine coroutine;

			public RespawnElement(NetBeast beast, Coroutine coroutine) : this()
            {
			}
		}

		[CompilerGenerated]
		private sealed class _003CRespawnTimer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float respawnTimer;

			public RespawnManager _003C_003E4__this;

			public NetBeast beast;

			public Func<NetBeast, SpawnParams> spawnTypeNeeds;

			public Action<NetBeast, Actor> OnBeastSpawned;

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
			public _003CRespawnTimer_003Ed__10(int _003C_003E1__state)
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
		private sealed class _003CRespawnPlayer_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetBeast beast;

			public Func<NetBeast, SpawnParams> spawnTypeNeeds;

			public Action<NetBeast, Actor> OnBeastSpawned;

			public RespawnManager _003C_003E4__this;

			private SpawnParams _003Cparameters_003E5__2;

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
			public _003CRespawnPlayer_003Ed__11(int _003C_003E1__state)
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

		private List<RespawnElement> _respawnList;

		private List<CoreNetSpawnPosition> _usedSpawns;

		public List<CoreNetSpawnPosition> UsedSpawns => null;

		public void ClearSpawnQueue()
		{
		}

		public void FreeSpawnPoints()
		{
		}

		public bool HasQueued(int gangID)
		{
			return false;
		}

		public int HasTotalQueued(int gangID)
		{
			return 0;
		}

		public void QueueRespawn(float respawnTimer, NetBeast beast, Func<NetBeast, SpawnParams> spawnTypeNeeds, Action<NetBeast, Actor> OnBeastSpawned)
		{
		}

		[IteratorStateMachine(typeof(_003CRespawnTimer_003Ed__10))]
		private IEnumerator RespawnTimer(float respawnTimer, NetBeast beast, Func<NetBeast, SpawnParams> spawnTypeNeeds, Action<NetBeast, Actor> OnBeastSpawned)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRespawnPlayer_003Ed__11))]
		private IEnumerator RespawnPlayer(NetBeast beast, Func<NetBeast, SpawnParams> spawnTypeNeeds, Action<NetBeast, Actor> OnBeastSpawned)
		{
			return null;
		}
	}

	public static List<NetGang> HighestMapScore()
	{
		return null;
	}

	public static void SendMessage(string message, Vector2 offset, Color color)
	{
	}
}
