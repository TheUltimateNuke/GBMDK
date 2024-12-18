using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
	private static SaveLoad _instance;

	private SaveDatabase _saveDatabase;

	private CostumeSaveLoad _costumeSaveLoad;

	public static SaveLoad I => null;

	public bool HasLoaded => false;

	public CostumeSaveLoad CostumeSaveLoad => null;

	public static event Action OnLoadComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void Save()
	{
	}

	public void Load()
	{
	}
}
