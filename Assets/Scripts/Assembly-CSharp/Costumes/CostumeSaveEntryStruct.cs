using System;

namespace Costumes
{
	[Serializable]
	public struct CostumeSaveEntryStruct
	{
		public struct CostumeCloudDataStruct
		{
			public string id;

			public string code;

			public string data;

			public string timestamp;

			public CostumeCloudDataStruct(CostumeCloudSaveLoad.CostumeCloudData cloudData)
			{
				id = null;
				code = null;
				data = null;
				timestamp = null;
			}

			public bool IsEmpty()
			{
				return false;
			}

			public bool Equals(CostumeCloudDataStruct other)
			{
				return false;
			}

			public override bool Equals(object other)
			{
				return false;
			}

			public static bool Equal(CostumeCloudDataStruct data1, CostumeCloudDataStruct data2)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public static bool operator ==(CostumeCloudDataStruct data1, CostumeCloudDataStruct data2)
			{
				return false;
			}

			public static bool operator !=(CostumeCloudDataStruct data1, CostumeCloudDataStruct data2)
			{
				return false;
			}
		}

		public int Version;

		public string Name;

		public string Voice;

		public CostumeCloudDataStruct CloudData;

		public CostumeSaveEntry.CostumeSaveItem[] CostumeSaveItems;

		public CostumeSaveEntryStruct(CostumeSaveEntry entry)
		{
			Version = 0;
			Name = null;
			Voice = null;
			CloudData = default(CostumeCloudDataStruct);
			CostumeSaveItems = null;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public bool Equals(CostumeSaveEntryStruct other)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public static bool Equal(CostumeSaveEntryStruct entry1, CostumeSaveEntryStruct entry2)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(CostumeSaveEntryStruct entry1, CostumeSaveEntryStruct entry2)
		{
			return false;
		}

		public static bool operator !=(CostumeSaveEntryStruct entry1, CostumeSaveEntryStruct entry2)
		{
			return false;
		}
	}
}
