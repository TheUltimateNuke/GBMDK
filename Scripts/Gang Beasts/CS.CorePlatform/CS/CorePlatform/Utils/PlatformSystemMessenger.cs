using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.UI;
using UnityEngine;

namespace CS.CorePlatform.Utils
{
	public class PlatformSystemMessenger : MonoBehaviour, IUIPopUpManager
	{
		public class MessageInfo
		{
			public string messageBody;

			public string optionAText;

			public Action optionAAction;

			public string optionBText;

			public Action optionBAction;

			public bool HasOptionB => false;

			public MessageInfo(string bodyCode, string optionACode, Action onOptionA, string optionBCode = null, Action onOptionB = null)
			{
			}
		}

		public static string SYSTEM_MESSAGE_YES;

		public static string SYSTEM_MESSAGE_NO;

		public static string SYSTEM_MESSAGE_OK;

		private Queue<MessageInfo> _waitingMessages;

		protected MessageInfo _activeMessage;

		private int _optionChosen;

		public bool ShowingMessage => false;

		public int WiatingMessage => 0;

		public static event Action<bool> OnMessageChange
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

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public void ActivateOption(int options)
		{
		}

		private void DoAction()
		{
		}

		protected virtual void DiscardMessage()
		{
		}

		protected virtual void ShowMessage()
		{
		}

		public void ShowMessage(MessageInfo newMessage)
		{
		}

		public void ShowYESNO(string body, Action yes, Action no, string yesMessage = null, string noMessage = null)
		{
		}

		public void ShowOK(string body, Action action, string messageCode = null)
		{
		}

		public void Show(IDisplayTask taskResult)
		{
		}

		public void Closed()
		{
		}

		public string DebugDataStoreInfo()
		{
			return null;
		}
	}
}
