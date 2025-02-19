using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GB.NetworkedInput
{
	public class InputDriver : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayPauseRescan_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InputDriver _003C_003E4__this;

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
			public _003CDelayPauseRescan_003Ed__11(int _003C_003E1__state)
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

		public bool OverrideControl;

		public InputState DrivenState;

		private Actor _Actor;

		private int m_Frame;

		private int m_ControllerId;

		private bool _lastSetDoubleJump;

		private float unPauseTime;

		public void Initialise(Actor controllingActor)
		{
		}

		public void DisconnectController()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPauseAltered()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayPauseRescan_003Ed__11))]
		private IEnumerator DelayPauseRescan()
		{
			return null;
		}

		private void InputActionTriggered(InputAction.CallbackContext context)
		{
		}

		private void Update()
		{
		}

		public void ResetInput()
		{
		}

		public void RescanInput()
		{
		}

		private void PauseScanInput()
		{
		}

		private void OnApplicationFocus(bool focusState)
		{
		}

		private Vector3 GetForward()
		{
			return default(Vector3);
		}

		public void SetVibration(float lowFrequency, float highFrequency, float duration)
		{
		}

		public void StopVibration()
		{
		}

		private bool IsVibrationAllowed()
		{
			return false;
		}
	}
}
