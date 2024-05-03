using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Bootstrap;
using GB.Networking;
using UnityEngine;

namespace CoreNet.Bootstrap
{
	public class CoreNetBootstrapper : Bootstrapper
	{
		[CompilerGenerated]
		private sealed class _003COnSessionDataInternal_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003COnSessionDataInternal_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003COnReset_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoreNetBootstrapper _003C_003E4__this;

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
			public _003COnReset_003Ed__18(int _003C_003E1__state)
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

		public static Action OnNetModelResetBegan;

		public static Action OnNetModelResetComplete;

		private const float sessionStartTimeout = 15f;

		private static float sessionStartTimer;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void FlushEvents()
		{
		}

		protected override void Bootstrap()
		{
		}

		private void OnGBSessionDataReceived(GBSessionData sessionData)
		{
		}

		[IteratorStateMachine(typeof(_003COnSessionDataInternal_003Ed__8))]
		private IEnumerator OnSessionDataInternal(GBSessionData sessionData)
		{
			return null;
		}

		private void OnLocalPlayerStarted()
		{
		}

		private void OnLocalPlayerStopped()
		{
		}

		private void OnClientPreLoad()
		{
		}

		private void OnClientStarted()
		{
		}

		private void OnClientStopped()
		{
		}

		private void OnServerPreLoad()
		{
		}

		private void OnServerStarted()
		{
		}

		private void OnServerStopped()
		{
		}

		private void OnNetCleanup()
		{
		}

		[IteratorStateMachine(typeof(_003COnReset_003Ed__18))]
		private IEnumerator OnReset()
		{
			return null;
		}

		private void BootstrapClientPreLoad(bool reverse = false)
		{
		}

		private void BootstrapClient(bool reverse = false)
		{
		}

		private void BootstrapLocalClient(bool reverse = false)
		{
		}

		private void BootstrapServerPreLoad(bool reverse = false)
		{
		}

		private void BootstrapServer(bool reverse = false)
		{
		}
	}
}
