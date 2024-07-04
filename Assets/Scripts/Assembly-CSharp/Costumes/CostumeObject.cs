using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Costumes
{
	public class CostumeObject : ScriptableObject
	{
		public ushort _uid;

		public string PartName;

		public AssetReferenceGameObject[] CostumeItems;

		public bool Enabled;

		public bool Unlocked;

		public bool Unlockable;

		public DLC_NAME[] DlcUnlocks;

		public string[] achievementUnlocks;

		public string PrefabPath;

		public CostumeParts PrimaryPart;

		public CostumeParts[] DisableParts;

		public List<string> Tags;

		[HideInInspector]
		public int SortOrder;

		public void Init(ushort uid = 0)
		{
		}
	}
}
