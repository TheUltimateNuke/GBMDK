using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class ModalHandler : MonoBehaviour
	{
		public delegate void OnModalDestroyed(ModalHandler modal);

		[SerializeField]
		protected ModalType _typeFlag;

		[SerializeField]
		protected TextMeshProUGUI SelfTitleReference;

		[SerializeField]
		protected TextMeshProUGUI SelfBodyReference;

		[SerializeField]
		protected Button SelfConfirmReference;

		public OnModalDestroyed OnDestroyDelegate;

		[SerializeField]
		protected bool _KillWhenOverrided;

		public int DesiredEdgeOffset;

		private Selectable _lastSelectedUI;

		protected Action totalAction;

		public bool anyKeyDismiss;

		public bool blurOnShow;

		public ModalType TypeFlag
		{
			get
			{
				return default(ModalType);
			}
			set
			{
			}
		}

		public bool KillWhenOverrided => false;

		public virtual void Initialise(string title, string body, string confirm, bool showModalImmedietly, params Action[] additionalConfirmActions)
		{
		}

		public virtual void PreInitialise(List<object> parameters)
		{
		}

		public void PresentModal()
		{
		}

		public void HideModal()
		{
		}

		public void DestroyModal()
		{
		}

		private void Update()
		{
		}

		public void ForceSelectConfirm()
		{
		}

		public void ForceConfirm()
		{
		}

		public void ChangeCompleteAction(params Action[] additionalConfirmActions)
		{
		}

		public void AddCompleteAction(params Action[] additionalConfirmActions)
		{
		}
	}
}
