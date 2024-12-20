using UnityEngine;

namespace GB.View.UI
{
	public class UIControllerFallback : UIController
	{
		[SerializeField]
		private Vector3 _vrMorphSize;

		[SerializeField]
		private Vector2 _vrMorphDelta;

		private new void Awake()
		{
		}
	}
}
