using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using Femur;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Actor))]
public class ActorCostume : NetworkBehaviour
{
	public delegate void CostumeSetHandler();

	[Serializable]
	public class ApplyedCostume
	{
		public CostumeObject CostumeObject;

		public RigCombine.CombinedObject CombinedObject;

		public Mesh[] OriginalMeshes;

		public SkinnedMeshRenderer[] OriginalSKMs;

		public CostumeSaveEntry.CostumeSaveItem CostumeSaveItem;

		public Renderer[] RendererCache;

		public Color[][] MatColors;

		public void CacheMeshes()
		{
		}

		public void CacheMaterialColors()
		{
		}

		public void ResetMeshesToCache()
		{
		}

		public void ResetMaterialColors()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003COnCostumeFinishedSetting_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActorCostume _003C_003E4__this;

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
		public _003COnCostumeFinishedSetting_003Ed__36(int _003C_003E1__state)
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
            throw new NotImplementedException();
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

	public ColorDatabase UserColorDatabase;

	public bool SetVoice;

	public bool RunRemoveUnseenMesh;

	public bool SendOnCostumeSetEvent;

	public bool CacheMeshesBeforeReduce;

	public CostumeSaveEntryStruct SaveEntryStruct;

	[HideInInspector]
	[SerializeField]
	private string _costumePresetName;

	private Actor thisActor;

	private IEnumerator SetCostumeOverTimeRef;

	public SkinnedMeshRenderer Body;

	public SkinnedMeshRenderer Head;

	public List<RigCombine.CombinedObject> CombineResultList;

	public List<ApplyedCostume> ApplyedCostumes;

	public Mesh bodyMesh;

	public Mesh headMesh;

	[HideInInspector]
	public readonly int TintCount;

	private CostumeDatabase m_CostumeDatabase;

	private CostumePresetDatabase m_CostumePresetDatabase;

	public CostumeDatabase CostumeDatabase => null;

	public CostumePresetDatabase CostumePresetDatabase => null;

	public CostumeSaveEntry SaveEntry
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CostumePresetName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event CostumeSetHandler OnCostumeSet
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

	public void Awake()
	{
	}

	public void SetCostume(CostumeSaveEntry costumeSaveEntry, RigCombine rigCombine = null, RemoveUnseenMesh removeUnseenMesh = null, MaterialsFromGos materialFromGos = null)
	{
	}

	public void UpdateCostume(CostumeSaveEntry costumeSaveEntry, RigCombine rigCombine = null, RemoveUnseenMesh removeUnseenMesh = null, MaterialsFromGos materialFromGos = null)
	{
	}

	private void SendOnCostumeSet()
	{
	}

	[IteratorStateMachine(typeof(_003COnCostumeFinishedSetting_003Ed__36))]
	private IEnumerator OnCostumeFinishedSetting()
	{
		return null;
	}

	public void ResetCostume()
	{
	}

	private void ResetCostumePart(RigCombine.CombinedObject combinedObject)
	{
	}

	private bool SharesAddedObject(RigCombine.CombinedObject combinedObject, GameObject go)
	{
		return false;
	}

	private void ResetCostumeMeshies()
	{
	}

	public int GetTintRange(ushort uid)
	{
		return 0;
	}

	public void UpdateCostumeTint(Color value)
	{
	}

	public void SetCostumeTint(Color value)
	{
	}

	public bool IsTintable(ushort uid)
	{
		return false;
	}

	private Color GetHairTint(Color value, int level)
	{
		return default(Color);
	}

	private Color GetPlayerTint(Color value, int level)
	{
		return default(Color);
	}

	private void UNetVersion()
	{
	}

	public override bool OnSerialize(NetworkWriter writer, bool forceAll)
	{
		return false;
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	public override void PreStartClient()
	{
	}
}
