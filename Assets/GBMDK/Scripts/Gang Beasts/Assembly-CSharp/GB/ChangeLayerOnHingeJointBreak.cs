using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB
{
	[RequireComponent(typeof(HingeJoint))]
	public class ChangeLayerOnHingeJointBreak : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnJointBreak_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChangeLayerOnHingeJointBreak _003C_003E4__this;

			private float _003Ctimer_003E5__2;

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
			public _003COnJointBreak_003Ed__4(int _003C_003E1__state)
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

		private HingeJoint _cachedJointRef;

		private Rigidbody _rb;

		[SerializeField]
		private float delay;

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003COnJointBreak_003Ed__4))]
		private IEnumerator OnJointBreak()
		{
			return null;
		}
	}
}
