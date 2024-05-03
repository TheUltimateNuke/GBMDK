using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class ModalPasswordInput : ModalHandler
	{
		public delegate void UsePasswordDel(string password);

		[SerializeField]
		private Button SelfDenyReference;

		private UsePasswordDel passwordAction;

		[SerializeField]
		private InputField passwordField;

		public override void PreInitialise(List<object> parameters)
		{
		}

		public void UsePassword()
		{
		}

		public void AddText(string character)
		{
		}

		public void RemoveCharacter()
		{
		}
	}
}
