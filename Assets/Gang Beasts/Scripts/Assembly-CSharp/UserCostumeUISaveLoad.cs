using System;
using System.Collections.Generic;
using Costumes;

public class UserCostumeUISaveLoad : CostumeUISaveLoad
{
	public override int GetMaxSaves()
	{
		return 0;
	}

	public override List<CostumeSaveEntry> GetCostumeSaveList()
	{
		return null;
	}

	public override CostumeSaveEntry GetCostumeSaveAtIndex(int index)
	{
		return null;
	}

	public override int? SetCostumeSaveAtIndex(int? index, CostumeSaveEntry costumeSaveEntry)
	{
		return null;
	}

	public override void DeleteCostumeSaveAtIndex(int index)
	{
	}

	public override void CloudLoadCostume(string costumeCode, Action<bool, CostumeSaveEntry> cloudLoadCallback)
	{
	}

	public override void CloudSaveCostumeAtIndex(int? index, CostumeSaveEntry costumeSaveEntry, Action<bool> cloudSaveCallback)
	{
	}

	public override void DeleteCloudSaveAtIndex(int index)
	{
	}
}
