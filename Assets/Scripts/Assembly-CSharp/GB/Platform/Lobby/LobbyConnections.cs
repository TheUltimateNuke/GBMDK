using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using GB.Platform.Lobby.Messages;
using UnityEngine;

namespace GB.Platform.Lobby
{
	public class LobbyConnections : LobbyPart
	{
		private class PingCarrier
		{
			[CompilerGenerated]
			private sealed class _003CPingLoop_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public PingCarrier _003C_003E4__this;

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
				public _003CPingLoop_003Ed__13(int _003C_003E1__state)
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

			public BaseUserInfo user;

			private Ping pinger;

			private int _lastTime;

			private string _ip;

			public Coroutine looper;

			public int Time
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public string IP
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool PingActive => false;

			[IteratorStateMachine(typeof(_003CPingLoop_003Ed__13))]
			public IEnumerator PingLoop()
			{
				return null;
			}
		}

		public static Action<BaseUserInfo, int> OnPingUpdate;

		private Dictionary<BaseUserInfo, PingCarrier> _pings;

		private StringMessage _ipMessage;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void ClearData()
		{
		}

		public void SendIp()
		{
		}

		private void SendIp(BaseUserInfo arg1, StringMessage arg2)
		{
		}

		private void GotIp(BaseUserInfo arg1, StringMessage arg2)
		{
		}

		private void FindMyIP()
		{
		}

		private void OnPlayerLeft(BaseUserInfo user)
		{
		}

		public int GetPing(BaseUserInfo user)
		{
			return 0;
		}

		public override void DrawInspector()
		{
		}
	}
}
