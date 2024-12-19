using System;
using System.Collections.Generic;
using Costumes;
using UnityEngine;

public abstract class CostumeUISaveLoad : MonoBehaviour
{
	public abstract int GetMaxSaves();

	public abstract List<CostumeSaveEntry> GetCostumeSaveList();

	public abstract CostumeSaveEntry GetCostumeSaveAtIndex(int index);

	public abstract int? SetCostumeSaveAtIndex(int? index, CostumeSaveEntry costumeSaveEntry);

	public abstract void DeleteCostumeSaveAtIndex(int index);

	public abstract void CloudLoadCostume(string costumeCode, Action<bool, CostumeSaveEntry> cloudLoadCallback);

	public abstract void CloudSaveCostumeAtIndex(int? index, CostumeSaveEntry costumeSaveEntry, Action<bool> cloudSaveCallback);

	public abstract void DeleteCloudSaveAtIndex(int index);
}
