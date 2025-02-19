using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class CostumeMultiModalHandler : ModalHandler
	{
		private class CostumeModalStatus
		{
			public int _controlID;

			public bool _ready;

			public bool _nulled;

			public CostumeModalStatus(int id)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCountdownCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CostumeMultiModalHandler _003C_003E4__this;

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
			public _003CCountdownCoroutine_003Ed__13(int _003C_003E1__state)
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

		[SerializeField]
		private CostumeSelectModal[] ModalRefs;

		private CostumeModalStatus[] ModalStatuses;

		[SerializeField]
		private Text CountdownUI;

		[SerializeField]
		private float CountdownTimerLength;

		private float countdownTimer;

		private Coroutine countdownCoroutine;

		public override void PreInitialise(List<object> parameters)
		{
		}

		public void AlertHandlerPlayerReady(int id)
		{
		}

		public void CheckStartTimer()
		{
		}

		public void AlertHandlerPlayerUnready(int id)
		{
		}

		public void AlertHandlerNulled(int id)
		{
		}

		public void AlertHandlerUnnulled(int id)
		{
		}

		[IteratorStateMachine(typeof(_003CCountdownCoroutine_003Ed__13))]
		private IEnumerator CountdownCoroutine()
		{
			return null;
		}

		private void StopGameStartCountdown()
		{
		}

		private void Update()
		{
		}
	}
}
