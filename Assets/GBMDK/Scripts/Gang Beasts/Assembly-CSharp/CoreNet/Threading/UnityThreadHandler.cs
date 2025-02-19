using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.Threading
{
	public class UnityThreadHandler : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayAction_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public Action action;

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
			public _003CDelayAction_003Ed__11(int _003C_003E1__state)
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

		private ConcurrentQueue<Action> QueuedActions;

		private static UnityThreadHandler _instance;

		public static UnityThreadHandler Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void QueueEvent(Action function)
		{
		}

		public void FlushEvents()
		{
		}

		public static void ExternalDelay(float delay, Action action)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayAction_003Ed__11))]
		public static IEnumerator DelayAction(float delay, Action action)
		{
			return null;
		}

		public static void ExternalCoroutine(IEnumerator coroutine)
		{
		}
	}
}
