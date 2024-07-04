using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.StateSync.Syncs;
using CoreNet.StateSync.Triggers;
using UnityEngine;

namespace GB.Networking.Sync
{
	public class JointBreakSyncTrigger : BaseSyncTrigger, IAutoJointV2PrecopyEvent
	{
		[CompilerGenerated]
		private sealed class _003CIEnumeratorCheckBreak_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JointBreakSyncTrigger _003C_003E4__this;

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
			public _003CIEnumeratorCheckBreak_003Ed__29(int _003C_003E1__state)
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
		private Joint _joint;

		[SerializeField]
		private TransformSync _syncTarget;

		private bool _cachedValues;

		private float _jointBreakValue;

		private float _jointTorqueBreakValue;

		[SerializeField]
		private float _randomBreakMin;

		[SerializeField]
		private float _randomBreakMax;

		[SerializeField]
		private float _randomTorqueMin;

		[SerializeField]
		private float _randomTorqueMax;

		private Coroutine _breakCheck;

		public TransformSync SyncTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static bool JointsActive => false;

		public Joint Joint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void OnAutoJointV2Precopy(Joint newJoint)
		{
		}

		public override void OverrideSync(bool state)
		{
		}

		private void CacheJointValues()
		{
		}

		protected void DestroyJoint()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected void Start()
		{
		}

		private void OnDestroy()
		{
		}

		protected void SetupJoint()
		{
		}

		protected virtual void SetJointBreakValues()
		{
		}

		protected void InvulnJoint()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		[IteratorStateMachine(typeof(_003CIEnumeratorCheckBreak_003Ed__29))]
		private IEnumerator IEnumeratorCheckBreak()
		{
			return null;
		}

		private void CheckBreak()
		{
		}

		protected virtual void OnBreak()
		{
		}
	}
}
