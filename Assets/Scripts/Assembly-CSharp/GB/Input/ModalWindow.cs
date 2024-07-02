using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Input
{
	public class ModalWindow : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnEnableAsync_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ModalWindow _003C_003E4__this;

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
			public _003COnEnableAsync_003Ed__10(int _003C_003E1__state)
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

		public TextMeshProUGUI text;

		public Button confirmButton;

		public Button cancelButton;

		public GameObject defaultUIElement;

		private Action<UserResponse> responseCallback;

		private void OnEnable()
		{
		}

		public void OnConfirm()
		{
		}

		public void OnCancel()
		{
		}

		public void SetText(string text)
		{
		}

		public void SetResponseCallback(Action<UserResponse> responseCallback)
		{
		}

		[IteratorStateMachine(typeof(_003COnEnableAsync_003Ed__10))]
		private IEnumerator OnEnableAsync()
		{
			return null;
		}
	}
}
