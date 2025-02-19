using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Data.Loading;
using GB.Networking.Objects;
using GB.Setup;
using UnityEngine;

namespace Costumes
{
	public class CostumePool : MonoBehaviour, IAsyncResourceLoader
	{
		[CompilerGenerated]
		private sealed class _003CLoadCostumeAssets_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CostumePool _003C_003E4__this;

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
			public _003CLoadCostumeAssets_003Ed__32(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CLoadPlayerDataStepped_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CostumePool _003C_003E4__this;

			private List<CostumeSaveEntry> _003CsaveData_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CLoadPlayerDataStepped_003Ed__36(int _003C_003E1__state)
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

		public static CostumePool I;

		public ColorDatabase PlayerColorDatabase;

		public ColorDatabase UserColorDatabase;

		public List<CostumeSaveEntry> _presetCostumes;

		public List<CostumeSaveEntry> _userCostumes;

		[SerializeField]
		private ResourceCache _beastLoader;

		private Coroutine _playerLoading;

		private CostumesAssetBundleLoader m_CostumesAssetBundleLoader;

		public CostumeDatabase m_CostumeDatabase;

		public CostumePresetDatabase m_CostumePresetDatabase;

		private bool _isDone;

		public CostumeDatabase CostumeDatabase => null;

		public CostumePresetDatabase CostumePresetDatabase => null;

		public IDataCache BeastResources => null;

		public int CostumeCount => 0;

		public int CustomCostumeCount => 0;

		public bool IsLoading => false;

		public static event Action OnPoolLoaded
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

		public void BeginAsyncLoading()
		{
		}

		public IList<object> GetAssetKeys()
		{
			return null;
		}

		public bool HasFinishedAsyncLoading()
		{
			return false;
		}

		public bool HasErrors()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CLoadCostumeAssets_003Ed__32))]
		private IEnumerator LoadCostumeAssets()
		{
			return null;
		}

		public void OnDestroy()
		{
		}

		private void LoadPresetCostumes()
		{
		}

		private void LoadPlayerData()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadPlayerDataStepped_003Ed__36))]
		private IEnumerator LoadPlayerDataStepped()
		{
			return null;
		}

		public int AddUserCostume(CostumeSaveEntry costumeSaveEntry, bool allowlocked = false)
		{
			return 0;
		}

		public void AddUserCostumes(List<CostumeSaveEntry> costumeSaveObjects, bool allowlocked = false)
		{
		}

		private void AddUserCostumeSave(CostumeSaveEntry save, string name = null)
		{
		}

		public void AddUserCostumeSaveAt(int index, CostumeSaveEntry save, string name = null)
		{
		}

		private void AddUserCostumeInstance(string name, Actor costumeInstance)
		{
		}

		private void AddUserCostumeInstanceAt(int index, string name, Actor costumeInstance)
		{
		}

		public void UpdateUserCostumeAt(int index, CostumeSaveEntry costumeSaveEntry)
		{
		}

		public void DeleteUserCostumeAt(int index)
		{
		}

		public CostumeSaveEntry GetRandomCostume()
		{
			return null;
		}

		public CostumeSaveEntry GetCostumeEntry(int costumeIndex)
		{
			return null;
		}

		public int GetCostumeEntryIndex(ushort[] costumeArticals)
		{
			return 0;
		}

		public int GetCostumeEntryIndex(NetCostumeArticle[] costumeArticals)
		{
			return 0;
		}

		public List<CostumeSaveEntry> VettCostumeSaveEntryList(List<CostumeSaveEntry> costumeSaveEntries, bool removeDubbleSloted = true, bool isUnlocked = true, bool isEnabled = true)
		{
			return null;
		}

		public CostumeSaveEntry VettCostumeSaveEntry(CostumeSaveEntry costumeSaveEntry, bool removeDubbleSloted = true, bool isUnlocked = true, bool isEnabled = true)
		{
			return null;
		}

		public List<CostumeSaveEntry.CostumeSaveItem> UnlockedCostumeSaveItems(List<CostumeSaveEntry.CostumeSaveItem> costumeSaveItems, bool isUnlocked = false, bool isEnabled = false)
		{
			return null;
		}

		public List<CostumeSaveEntry.CostumeSaveItem> RemoveDubbleSlotedCostumeSaveItems(List<CostumeSaveEntry.CostumeSaveItem> costumeSaveItems)
		{
			return null;
		}
	}
}
