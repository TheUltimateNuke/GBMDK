using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Costumes
{
	public class CloudCodeButton : MonoBehaviour, IMoveHandler, IEventSystemHandler
	{
		public Button ThisButton;

		public RectTransform Arrows;

		public List<CostumeSaveNumber> SaveNumbers;

		private int _currentSaveNumberIndex;

		private CostumeSaveNumber currentCostumeSaveNumber;

		private void Start()
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}

		public string GetCurrentCostumeSaveNumber()
		{
			return null;
		}

		public void NextNumber()
		{
		}

		public void PreviousNumber()
		{
		}

		private void SetActiveNumber()
		{
		}
	}
}
