using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GraphicMatchSelectableColor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetColor_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Color color;

		public GraphicMatchSelectableColor _003C_003E4__this;

		public bool revert;

		public float revertTime;

		private float _003CtotalTime_003E5__2;

		private Color _003CtargetColor_003E5__3;

		private Color _003CstartingColor_003E5__4;

		private Color _003CcurrentColor_003E5__5;

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
		public _003CSetColor_003Ed__18(int _003C_003E1__state)
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

	public Selectable TargetSelectable;

	[Tooltip("Will use graphic on this GameObject if not set.!")]
	public Graphic Graphic;

	private bool _interactable;

	private Color _graphicOrigColor;

	private Color _larpedColor;

	private bool _selected;

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void OnSelect(BaseEventData arg0)
	{
	}

	public void OnDeselect(BaseEventData arg0)
	{
	}

	public void OnPinterEnter(BaseEventData arg0)
	{
	}

	public void OnPointerExit(BaseEventData arg0)
	{
	}

	public void OnSubmit(BaseEventData arg0)
	{
	}

	public void OnInteractableChange()
	{
	}

	public void OnDisable()
	{
	}

	private bool CheckTransitionType()
	{
		return false;
	}

	private void StartSetColor(Color color, bool revert = false, float revertTime = 0.05f)
	{
	}

	[IteratorStateMachine(typeof(_003CSetColor_003Ed__18))]
	private IEnumerator SetColor(Color color, bool revert = false, float revertTime = 0.05f)
	{
		return null;
	}
}
