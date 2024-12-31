using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Costumes
{
	public class ControllerButtons : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IMoveHandler, ISubmitHandler
	{
		public delegate void ChangeItem(MoveDirection Dir);

		public delegate void SelectEvent();

		[CompilerGenerated]
		private sealed class _003CButtonColorOnPressed_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerButtons _003C_003E4__this;

			public Button button;

			public Color color;

			public float time;

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
			public _003CButtonColorOnPressed_003Ed__50(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CButtonColorDissabled_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerButtons _003C_003E4__this;

			public Color color;

			public float time;

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
			public _003CButtonColorDissabled_003Ed__51(int _003C_003E1__state)
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

		public Button ThisButton;

		public Button LeftButton;

		public Button RightButton;

		public Color NormalColor;

		public Color HighlightedColor;

		public Color PressedColor;

		public Color DisabledColor;

		public Color DeactivatedByColor;

		public Color DeactivatingColor;

		public float SelectedColorTime;

		public SelectedMenuInputEvent SelectedMenuInputEvent;

		private Color PressedColorTimeoutColor;

		private bool _enabled;

		public bool showTintMessage;

		public bool showResetMessage;

		public bool showSubmitButton;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event ChangeItem Change
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event SelectEvent Selected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event SelectEvent Deselected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void SendEvent(string direction)
		{
		}

		public void OnMove(AxisEventData axisEventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void Select()
		{
		}

		public void UpdateMessages()
		{
		}

		public void SelectedEvent()
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void Deselect()
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		private void SendEvent(MoveDirection direction)
		{
		}

		public void SetColorButtonColor(Color color)
		{
		}

		public void SetColorButtonColor()
		{
		}

		public void DisableSelectedSLot()
		{
		}

		public void DisableSlot()
		{
		}

		public void EnableSlot()
		{
		}

		private void SetButtonsColor(Color color, bool updatedTimeoutColor = true)
		{
		}

		private void SetButtonColor(Button button, Color color)
		{
		}

		[IteratorStateMachine(typeof(_003CButtonColorOnPressed_003Ed__50))]
		private IEnumerator ButtonColorOnPressed(float time, Button button, Color color)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CButtonColorDissabled_003Ed__51))]
		private IEnumerator ButtonColorDissabled(float time, Color color)
		{
			return null;
		}

		private void SetInteractable(bool state)
		{
		}
	}
}
