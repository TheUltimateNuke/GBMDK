using System;
using UnityEngine;

namespace GB.Menu
{
	[Serializable]
	public class InputActionMap
	{
		[SerializeField]
		public InputMapActions key;

		[SerializeField]
		public Sprite sprite;
	}
}
