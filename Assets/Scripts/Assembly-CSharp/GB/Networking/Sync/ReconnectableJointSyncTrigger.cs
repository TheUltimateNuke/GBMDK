using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Networking.Sync
{
	public class ReconnectableJointSyncTrigger : JointBreakSyncTrigger
	{
		[CompilerGenerated]
		private sealed class _003CDelayedReconnect_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ReconnectableJointSyncTrigger _003C_003E4__this;

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
			public _003CDelayedReconnect_003Ed__7(int _003C_003E1__state)
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

		private GameObject _object;

		private Rigidbody _reconnectTarget;

		private WaitForSeconds _reconnectWait;

		[SerializeField]
		private float _reconnectTime;

		protected override void OnEnable()
		{
		}

		public override void OverrideSync(bool state)
		{
		}

		protected override void OnBreak()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedReconnect_003Ed__7))]
		protected IEnumerator DelayedReconnect()
		{
			return null;
		}

		public virtual void RecreateJoint()
		{
		}
	}
}
