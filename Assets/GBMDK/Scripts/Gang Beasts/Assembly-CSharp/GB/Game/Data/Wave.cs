using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Game.Data
{
	[Serializable]
	public class Wave
	{
		[SerializeField]
		public string beginCode;

		[SerializeField]
		public Color beginColour;

		[SerializeField]
		public string endCode;

		[SerializeField]
		public Color endColour;

		[SerializeField]
		public List<BeastSetup> beasts;
	}
}
