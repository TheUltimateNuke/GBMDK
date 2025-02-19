using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using GB.Core;
using UnityEngine.AddressableAssets;

public class CostumesAssetBundleLoader
{
	[CompilerGenerated]
	private sealed class _003CLoadCostumeDatabases_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CostumesAssetBundleLoader _003C_003E4__this;

		private AssetReference _003CassetRequestPres_003E5__2;

		private LoadResourceTask<CostumePresetDatabase> _003CdataPres_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator<object>.Current => throw new NotImplementedException();

		object IEnumerator.Current => throw new NotImplementedException();

		[DebuggerHidden]
		public _003CLoadCostumeDatabases_003Ed__17(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw new NotImplementedException();
		}

		void IDisposable.Dispose()
		{
			throw new NotImplementedException();
		}
	}

	public const string k_CostumeDatabasesBundleName = "costume-databases";

	public const string k_CostumeSharedMaterialsBundleName = "costume-shared-materials";

	public static readonly string k_AssetBundleDirectory;

	public const string k_CostumeScriptableObjectsDirectory = "Assets/Costumes/BundleAssets/ScriptableObjects";

	public const string k_CostumeSharedMaterialsDirectory = "Assets/Costumes/BundleAssets/Materials";

	public const string k_CostumePresetDatabasePath = "Assets/Costumes/BundleAssets/ScriptableObjects/CostumePresetDatabase.asset";

	private static readonly string k_CostumePresetDatabaseAssetName;

	public static AssetReference CostumePresetDatabaseRef => null;

	public CostumeDatabase CostumeDatabase { get; private set; }

	public CostumePresetDatabase CostumePresetDatabase { get; private set; }

	[IteratorStateMachine(typeof(_003CLoadCostumeDatabases_003Ed__17))]
	public IEnumerator LoadCostumeDatabases()
	{
		return null;
	}

	public void ReleaseAssets()
	{
	}
}
