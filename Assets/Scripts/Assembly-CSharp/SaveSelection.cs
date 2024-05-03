using System.Collections.Generic;
using Costumes;
using UnityEngine;

public class SaveSelection : MonoBehaviour
{
	public CostumeCustomization CostumeCustomization;

	public CostumeUISaveLoad CostumeUISaveLoad;

	public CostumeSaveUI CostumeSaveUi;

	private int _saveIndex;

	public int SaveIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
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
