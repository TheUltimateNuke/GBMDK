using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.StateSync.BDSM
{
	[RequireComponent(typeof(Rigidbody))]
	public class SubmissiveRigidbody : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadDominantsNextFrame_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SubmissiveRigidbody _003C_003E4__this;

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
			public _003CLoadDominantsNextFrame_003Ed__9(int _003C_003E1__state)
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

		private List<Demand> _Demands;

		private List<IDominant> _Dominants;

		public bool _SyncingAsClient;

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void SetSyncing(bool syncing, bool isServer)
		{
		}

		private void Acquiesce()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}

		private void ConfigureRigidbody(bool isKinematic)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadDominantsNextFrame_003Ed__9))]
		private IEnumerator LoadDominantsNextFrame()
		{
			return null;
		}

		private void SupplicateDemands()
		{
		}
	}
}
