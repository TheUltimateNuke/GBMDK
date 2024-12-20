using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Core.UI
{
	public class ModalSpawnParameters
	{
		public string TitleText;

		public string BodyText;

		public string ConfirmText;

		public GameObject ModalPrefab;

		public Transform DesiredParent;

		public bool allowAnyKeyDismiss;

		public ModalType typeFlag;

		public List<object> StartupActionParameters;

		public Action[] ConfirmActions;

		public bool showBlur;

		public ModalSpawnParameters(string title, string body, string confirm)
		{
		}

		public ModalSpawnParameters(string title, string body, string confirm, List<object> startupParameters = null, params Action[] additionalConfirmActions)
		{
		}

		public ModalSpawnParameters(ModalType type, string title, string body, string confirm, List<object> startupParameters = null, params Action[] additionalConfirmActions)
		{
		}
	}
}
