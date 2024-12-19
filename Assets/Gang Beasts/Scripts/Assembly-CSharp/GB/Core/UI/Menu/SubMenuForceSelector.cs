using UnityEngine;

namespace GB.Core.UI.Menu
{
	public class SubMenuForceSelector : MonoBehaviour
	{
		[SerializeField]
		private RectTransform RootMenuTransform;

		[SerializeField]
		private RectTransform RootStartScreenTransform;

		[SerializeField]
		private SelectLastSelectable RootLocalMenuTransform;

		public void SetMenuState(SubMenu menu)
		{
		}

		public RectTransform GetRootMenuCanvas()
		{
			return null;
		}
	}
}
