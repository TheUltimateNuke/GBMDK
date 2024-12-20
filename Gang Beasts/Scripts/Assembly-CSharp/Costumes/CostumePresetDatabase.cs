using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class CostumePresetDatabase : ScriptableObject
	{
		[Serializable]
		public class CostumePreset
		{
			public bool Unlocked;

			public bool Unlockable;

			public DLC_NAME[] DlcUnlocks;

			public string[] achievementUnlocks;

			public CostumeSaveEntry CostumeSaveEntry;
		}

		[SerializeField]
		public List<CostumePreset> CostumePresets;

		public void AddNewCostumePreset()
		{
		}

		public void AddCostumePreset(CostumeSaveEntry costumeSaveEntry)
		{
		}

		public void RemovePresetAtIndex(int index)
		{
		}

		public List<CostumeSaveEntry> GetUnlockedPresetCostumeSaveObjects()
		{
			return null;
		}

		public CostumeSaveEntry GetCostumeByPresetName(string name)
		{
			return null;
		}

		public int MoveObject(int index, int newIndex)
		{
			return 0;
		}
	}
}
