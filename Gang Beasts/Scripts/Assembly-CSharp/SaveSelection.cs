using System;
using System.Collections.Generic;
using Costumes;
using UnityEngine;

public class SaveSelection : MonoBehaviour
{
	public CostumeCustomization CostumeCustomization;

	public CostumeUISaveLoad CostumeUISaveLoad;

	public CostumeSaveUI CostumeSaveUi;

	public Action<int> SaveIndexChanged;

	private int _saveIndex;

	public int SaveIndex => 0;

	public void SetSaveIndex(int saveIndex)
	{
	}

	public int GetSaveCount()
	{
		return 0;
	}

	public List<CostumeSaveEntry> GetCostumeSaveEntrieList()
	{
		return null;
	}

	private void LoadAction(int saveIndex)
	{
	}
}
