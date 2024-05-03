using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SuperGenius.Lib.Burst.Easing;
using SuperGenius.Lib.Burst.MeshModification;
using SuperGenius.Lib.Burst.Random;
using SuperGenius.Lib.Burst.Voronoi;
using SuperGenius.Scripts.Fracture.ScriptableObjects;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(NetworkIdentity))]
public class Fracture : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CVoronoiSplitMeshJob_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fracture _003C_003E4__this;

		public uint seed;

		public float minRadius;

		public float maxRadius;

		public int maxNewMeshes;

		public EaseFuctions.EaseType easeType;

		private int _003CcutFaceMaterialIndex_003E5__2;

		private List<Material> _003Cmaterials_003E5__3;

		private MeshData _003CmeshToCut_003E5__4;

		private JobHandle _003Chandle_003E5__5;

		private RandomPointsMinMaxRadiusJob _003CrandomPointsJob_003E5__6;

		private BruteVoronoiJob _003CvoronoiJob_003E5__7;

		private SplitMeshJob _003CsplitMeshJob_003E5__8;

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
		public _003CVoronoiSplitMeshJob_003Ed__24(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRaycastEdgeConnect_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fracture _003C_003E4__this;

		private Rigidbody _003Crigidbody_003E5__2;

		private List<Collider> _003CattachedColliders_003E5__3;

		private bool[] _003CcollidersActiveState_003E5__4;

		private bool _003CrigidbodyKinimaticState_003E5__5;

		private List<SplitMeshContainer> _003CsplitMeshJointCast_003E5__6;

		private NativeArray<RaycastHit> _003CsphereRayResults_003E5__7;

		private NativeArray<SpherecastCommand> _003CsphereRayCommands_003E5__8;

		private JobHandle _003Chandle_003E5__9;

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
		public _003CRaycastEdgeConnect_003Ed__25(int _003C_003E1__state)
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

	public FractureSettingsScriptable FractureSettingsScriptable;

	public FractureSettingsScriptable FractureLowSettingsScriptable;

	public FractureSettingsData FractureSettingsData;

	public UnityEvent<bool> OnFracture;

	[SyncVar]
	private int _seed;

	[SyncVar]
	private float _health;

	private Transform _fractorRoot;

	private GameObject _fractureShardGameObject;

	private List<SplitMeshContainer> _splitMeshes;

	private bool _fractureCreated;

	private static int kRpcRpcEnableFracture;

	public int Network_seed
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public float Network_health
	{
		get
		{
			return 0f;
		}
		[param: In]
		set
		{
		}
	}

	private void Awake()
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStartClient()
	{
	}

	protected void InitServer()
	{
	}

	protected void GenerateSeed()
	{
	}

	protected void InitHealth()
	{
	}

	protected void Init()
	{
	}

	protected void InitFracture(int seed)
	{
	}

	protected void SetupFractureShard()
	{
	}

	protected void StartMeshSplit(uint seed)
	{
	}

	protected void OnCollisionEnter(Collision collision)
	{
	}

	protected void Damage(Collision collision)
	{
	}

	[ClientRpc]
	protected void RpcEnableFracture(Vector3 hitPoint)
	{
	}

	protected void EnableFracture(Vector3 hitPoint)
	{
	}

	[IteratorStateMachine(typeof(_003CVoronoiSplitMeshJob_003Ed__24))]
	protected IEnumerator VoronoiSplitMeshJob(uint seed, float minRadius, float maxRadius, int maxNewMeshes, EaseFuctions.EaseType easeType = EaseFuctions.EaseType.None)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRaycastEdgeConnect_003Ed__25))]
	private IEnumerator RaycastEdgeConnect()
	{
		return null;
	}

	private void GlueEdges()
	{
	}

	private void AddColliders()
	{
	}

	protected void AddJoints()
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpcEnableFracture(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpcEnableFracture(Vector3 hitPoint)
	{
	}

	static Fracture()
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
