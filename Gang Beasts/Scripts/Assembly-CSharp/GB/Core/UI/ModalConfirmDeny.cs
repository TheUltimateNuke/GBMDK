using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class ModalConfirmDeny : ModalHandler
	{
		[SerializeField]
		private Button SelfDenyReference;

		public override void PreInitialise(List<object> parameters)
		{
		}
	}
}
