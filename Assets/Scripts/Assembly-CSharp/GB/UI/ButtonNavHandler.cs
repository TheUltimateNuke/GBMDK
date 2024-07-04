using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI
{
	public class ButtonNavHandler : MonoBehaviour, IMoveHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler, IPointerEnterHandler
	{
		[CompilerGenerated]
		private sealed class _003CDelayedSelectRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Selectable selection;

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
			public _003CDelayedSelectRoutine_003Ed__24(int _003C_003E1__state)
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

		[Tooltip("Add a reference to a disabled GameObject here, that will be enabled when this button is selected")]
		[SerializeField]
		private GameObject onSelectAdditionalGameObject;

		[Tooltip("As above, but for component references")]
		[SerializeField]
		private MonoBehaviour[] onSelectAdditionalComponents;

		[SerializeField]
		private float sizeIncreasePercentOnSelect;

		[SerializeField]
		private float sizeIncreaseWobbleOnSelect;

		[SerializeField]
		private float sizeIncreaseWobbleSpeed;

		[SerializeField]
		private bool allowNonButtonMoveActions;

		[SerializeField]
		private GameObject overrideWobbleGO;

		private Transform _wobbleTransformCached;

		private bool isSelected;

		private Vector3 cachedStartingScale;

		private Selectable selectable;

		private Navigation storedNavigation;

		private IMoveHandler[] nonButtonMoveHandlers;

		public Transform WobbleTransformCached => null;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public Selectable GetNextSelectable(AxisEventData eventData)
		{
			return null;
		}

		private Selectable GetNextAvailableButton(MoveDirection direction)
		{
			return null;
		}

		private void TriggerMoveHandlers(AxisEventData eventData)
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedSelectRoutine_003Ed__24))]
		private IEnumerator DelayedSelectRoutine(Selectable selection)
		{
			return null;
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}
	}
}
