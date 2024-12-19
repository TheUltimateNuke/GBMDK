using UnityEngine;
using UnityEngine.UI;

namespace Costumes
{
	public class CloudCodeRewiredNumber : MonoBehaviour
	{
		public Color SelectedColor;

		public Image NumberBG;

		public int CurrentNumber;

		public Text NumberText;

		[HideInInspector]
		public void SetNumber(int num)
		{
		}

		public void Increment(int numDelta)
		{
		}

		public void SetSelected()
		{
		}

		public void ClearSelected()
		{
		}
	}
}
