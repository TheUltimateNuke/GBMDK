using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using GB.Menu;
using GB.Platform.Utils;
using GB.View;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GB.UI.Menu
{
	public class BaseMenuScreen : MonoBehaviour
	{
		[Serializable]
		public class CancelEvent : UnityEvent
		{
		}

		[Serializable]
		public class SubmitEvent : UnityEvent
		{
		}

		[CompilerGenerated]
		private sealed class _003CDelayedSelectRoutine_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
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

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CDelayedSelectRoutine_003Ed__51(int _003C_003E1__state)
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

		[SerializeField]
		public Selectable defaultSelection;

		[SerializeField]
		public Selectable defaultSelectionFallback;

		public Selectable previousSelection;

		[SerializeField]
		private bool _selectOnEnable;

		protected MenuController _currentController;

		[SerializeField]
		private bool ShowConfirmButton;

		[SerializeField]
		private PlatformBools ShowCancelButton;

		[SerializeField]
		private string overrideAcceptString;

		[SerializeField]
		private string overrideCancelString;

		[SerializeField]
		private GameObject cameraTarget;

		[SerializeField]
		private bool alwaysShow;

		private float posSmoothTime;

		private Vector3 velocity;

		private Vector3 velocity2;

		private Transform followTransform;

		private Vector3 followStartPos;

		private const float kInputLockTime = 0.55f;

		private bool inputEnabled;

		private float inputLockTimer;

		private AnimFloat alphaAnim;

		private float fadeTime;

		private CanvasGroup cg;

		public CancelEvent cancelEvent;

		public SubmitEvent submitEvent;

		private Quaternion startRotation;

		private float rotLerpVal;

		private float rotLerpSpeed;

		public Vector3 cameraOffset;

		private CinemachineVirtualCamera activeCam;

		private CinemachineTransposer camFollowSettings;

		private Vector3 camFollowOffset;

		[SerializeField]
		private CameraAnchor _vrAnchorPoint;

		private bool _selectionActive;

		private bool _selectLast;

		public bool HasFocus => false;

		public bool IsInputEnabled => false;

		public bool LastSelectLast => false;

		public bool SelectionActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void OnFocusGained(MenuController controller, bool lastSelect)
		{
		}

		private void SetupButtoms(bool show)
		{
		}

		private void HandleButton(bool show, InputMapActions button, string overrideString)
		{
		}

		public virtual void OnFocusLost()
		{
		}

		public void SelectDefault(bool lastSelect)
		{
		}

		public void Select(Selectable selection)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedSelectRoutine_003Ed__51))]
		private IEnumerator DelayedSelectRoutine(Selectable selection)
		{
			return null;
		}

		public void Deselect()
		{
		}

		private void OnCancel(GBUIInputHandler handler, BaseEventData obj)
		{
		}

		private void OnSubmit(GBUIInputHandler handler, BaseEventData obj)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateLastSelected()
		{
		}

		public virtual void Update()
		{
		}

		public string DEBUG_Information()
		{
			return null;
		}
	}
}
