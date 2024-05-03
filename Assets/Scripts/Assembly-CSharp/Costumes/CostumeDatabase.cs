using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class CostumeDatabase : ScriptableObject, ISerializationCallbackReceiver
	{
		public List<string> Tags;

		[SerializeField]
		private List<CostumeObject> CostumeObjects;

		[SerializeField]
		private ushort currentUID;

		[NonSerialized]
		private SortedList<uint, CostumeObject> searchSpeeder;

		private ushort NewUID()
		{
			return 0;
		}

		public ushort GetCurrentUID()
		{
			return 0;
		}

		public void CreateNewCostumeObject()
		{
		}

		public bool CreateNewCostumeObjectWithUid(ushort uid)
		{
			return false;
		}

		public int CostumeObjectsCount()
		{
			return 0;
		}

		public CostumeObject GetCostumeOjectAtIndex(int index)
		{
			return null;
		}

		public int MoveCostumeOject(int index, int newIndex)
		{
			return 0;
		}

		public CostumeObject GetCostumeOjectWithID(ushort id, bool isEnabled = false, bool isUnlocked = false)
		{
			return null;
		}

		public void RemoveCostumeObjectAtIndex(int index)
		{
		}

		public List<CostumeObject> GetAllCostumeObjects(bool isEnabled = true, bool isUnlocked = true)
		{
			return null;
		}

		private List<CostumeObject> GetEnabled(List<CostumeObject> costumeObjectList)
		{
			return null;
		}

		private List<CostumeObject> GetUnlocked(List<CostumeObject> costumeObjectList)
		{
			return null;
		}

		private bool IsUnlocked(CostumeObject costumeObject)
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
