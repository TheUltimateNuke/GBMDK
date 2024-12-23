using System;
using UnityEngine;

namespace GB.Game.Data
{
	[Serializable]
	public class BeastSetup
	{
		[SerializeField]
		public int colour;

		[SerializeField]
		public int gangID;

		[SerializeField]
		public bool costumeFallback;

		[SerializeField]
		public string costume;

		[SerializeField]
		public int type;

		public BeastSetup(int gangID)
		{
		}

		public BeastSetup()
		{
		}

		public void Clear()
		{
		}

		public BeastSetup(BeastSetup thisThing)
		{
		}

		public void Copy(BeastSetup thisThing)
		{
		}
	}
}
