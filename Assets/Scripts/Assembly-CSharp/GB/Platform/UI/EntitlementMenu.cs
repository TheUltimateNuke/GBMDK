using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.View.UI;
using UnityEngine.UI;

namespace GB.Platform.UI
{
	public class EntitlementMenu : UIController
	{
		[CompilerGenerated]
		private sealed class _003CSelectButton_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EntitlementMenu _003C_003E4__this;

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
			public _003CSelectButton_003Ed__2(int _003C_003E1__state)
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

		public Selectable SelectOnEneable;

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CSelectButton_003Ed__2))]
		private IEnumerator SelectButton()
		{
			return null;
		}

		private void Update()
		{
		}

		public void ButtonStore()
		{
		}

		public void ButtonSupport()
		{
		}

		public void ButtonExit()
		{
		}
	}
}
