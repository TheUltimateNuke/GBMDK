using System;
using System.Collections.Generic;
using GB.Networking.Objects;

namespace Costumes
{
	[Serializable]
	public class CostumeSaveEntry
	{
		[Serializable]
		public struct CostumeSaveItem
		{
			public ushort ItemId;

			public ushort ColorId;

			public CostumeSaveItem(ushort itemID)
			{
				ItemId = 0;
				ColorId = 0;
			}

			public CostumeSaveItem(ushort itemID, ushort colorId)
			{
				ItemId = 0;
				ColorId = 0;
			}

			public CostumeSaveItem(CostumeObject costumeObj)
			{
				ItemId = 0;
				ColorId = 0;
			}
		}

		private const int COSTUME_VERSION = 1;

		public int Version;

		public string Name;

		public string Voice;

		public CostumeCloudSaveLoad.CostumeCloudData CloudData;

		public List<CostumeSaveItem> CostumeSaveItemList;

		public CostumeSaveEntry()
		{
		}

		public CostumeSaveEntry(CostumeSaveEntryStruct entryStruct)
		{
		}

		public CostumeSaveEntry(CostumeSaveEntry entry)
		{
		}

		public CostumeSaveEntry(ushort[] itemIDs, bool colours = false)
		{
		}

		public CostumeSaveEntry(NetCostumeArticle[] articles)
		{
		}

		private void InitFromShortArray(ushort[] ids, bool colours = false)
		{
		}

		public ushort[] ExtractCostumeItemIDs(bool colours = false)
		{
			return null;
		}

		public static bool Match(CostumeSaveEntryStruct A, CostumeSaveEntry B)
		{
			return false;
		}

		public static bool Match(CostumeSaveEntry A, CostumeSaveEntry B, bool voiceCheck = false)
		{
			return false;
		}
	}
}
