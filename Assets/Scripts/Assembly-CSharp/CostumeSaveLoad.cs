using System;
using System.Collections.Generic;
using Costumes;
using UnityEngine;

public class CostumeSaveLoad
{
	private SaveLoad _saveLoad;

	private MonoBehaviour _monoBehaviour;

	private CostumeSaveDatabase _costumeSaveDatabase;

	public CostumeSaveLoad(SaveLoad saveLoad, CostumeSaveDatabase costumeSaveDatabase)
	{
	}

	public void Reload(SaveLoad saveLoad, CostumeSaveDatabase costumeSaveDatabase)
	{
	}

	public List<CostumeSaveEntry> GetCostumeSaveList()
	{
		return null;
	}

	public CostumeSaveEntry GetCostumeSaveAtIndex(int index)
	{
		return null;
	}

	public int? SetCostumeSaveAtIndex(int? index, CostumeSaveEntry costumeSaveEntry)
	{
		return null;
	}

	public void DeleteCostumeSaveAtIndex(int index)
	{
	}

	public void CloudLoadCostume(string costumeCode, Action<bool, CostumeSaveEntry> cloudLoadCallback)
	{
	}

	public void CloudSaveCostumeAtIndex(int? index, CostumeSaveEntry costumeSaveEntry, Action<bool> cloudSaveCallback)
	{
	}

	private void NewCloudSaveCostume(CostumeSaveEntry costumeSaveEntry, Action<bool> cloudSaveCallback)
	{
	}

	private void UpdateCloudSaveCostume(CostumeSaveEntry costumeSaveEntry, Action<bool> cloudSaveCallback, string recycledCloudID = null)
	{
	}

	public void DeleteCloudSaveAtIndex(int index)
	{
	}
}
