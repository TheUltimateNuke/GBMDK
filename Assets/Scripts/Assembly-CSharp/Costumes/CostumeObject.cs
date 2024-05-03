using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class CostumeObject
	{
		public ushort _uid;

		public string PartName;

		public GameObject[] CostumeItems;

		public bool Enabled;

		public bool Unlocked;

		public bool Unlockable;

		public DLC_NAME[] DlcUnlocks;

		public string[] achievementUnlocks;

		public string PrefabPath;

		public CostumeParts PrimaryPart;

		public CostumeParts[] DisableParts;

		public List<string> Tags;

		public CostumeObject(ushort uid)
		{
		}
	}
}
