using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GB.DebugTools.Localisation
{
	[RequireComponent(typeof(TMP_Dropdown))]
	public class LeftRightDropdownSelector : MonoBehaviour, IMoveHandler, IEventSystemHandler
	{
		private TMP_Dropdown _dropdown;

		private void Awake()
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}
	}
}
