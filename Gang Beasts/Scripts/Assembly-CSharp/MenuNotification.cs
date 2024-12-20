using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuNotification : MonoBehaviour
{
	private class MenuNotificationObject
	{
		public float DisplayTime;

		public string DisplayText;

		public Color DisplayColor;

		public MenuNotificationObject(string displayText, float displayTime, Color displayColor)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplayNotificaion_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuNotification _003C_003E4__this;

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
		public _003CDisplayNotificaion_003Ed__6(int _003C_003E1__state)
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

	public Text NotificationText;

	public Color DefaultNotificaionColor;

	private bool _notificationDisplaying;

	private List<MenuNotificationObject> menuNotificationObjectList;

	public void SendNotification(string notificationText, float nofifiacionTime = 2f, Color notificationColor = default(Color))
	{
	}

	public void OverrideNotification(string notificationText, float nofifiacionTime = 2f, Color notificationColor = default(Color))
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayNotificaion_003Ed__6))]
	private IEnumerator DisplayNotificaion()
	{
		return null;
	}
}
