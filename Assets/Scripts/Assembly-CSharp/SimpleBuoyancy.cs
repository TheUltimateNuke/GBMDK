using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Stages._Prototype.Scripts;
using UnityEngine;

public class SimpleBuoyancy : SimpleBuoyancyCollider
{
	[CompilerGenerated]
	private sealed class _003CDelayedSetup_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleBuoyancy _003C_003E4__this;

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

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CDelayedSetup_003Ed__29(int _003C_003E1__state)
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

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

	public bool IsEnabled;

	public float offset;

	public float force;

	private static readonly float FORCE_MULTIPLIER;

	[Range(0.1f, 0.5f)]
	public float forceFalloff;

	public bool alignToVector;

	public Vector3 alignmentVector;

	public bool sinkOverTime;

	public float sinkAmount;

	public float stability;

	public float speed;

	public bool makeRipples;

	public bool makeSplashes;

	public bool makeBubbles;

	[SerializeField]
	private Rigidbody thisRigidbody;

	private float originalDrag;

	private float originalAngularDrag;

	private bool isSynced;

	private Vector3 lastRipplePosition;

	private Vector3 lastSplashPosition;

	private bool isReady;

	public List<SimpleBuoyancyCollider> BuoyancyColliders;

	public int FirstActiveLiquid => 0;

	public List<int> ActiveLiquid => null;

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	protected override void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedSetup_003Ed__29))]
	private IEnumerator DelayedSetup()
	{
		return null;
	}

	public static Liquid InsideLiquidCheck(Bounds bounds)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private bool SetupRigidBody()
	{
		return false;
	}

	public bool ShouldUpdate()
	{
		return false;
	}

	public void FixedUpdateImpl()
	{
	}

	private void WorkoutLiquidEffects(LiquidData liquid, bool sinking, ref float drag, ref float angularDrag, ref Vector3 velocity, ref Vector3 angularVelocity)
	{
	}

	private void DoEffects(Liquid liquid, Vector3 position)
	{
	}

	public void AlignToVector(Vector3 forcePoint)
	{
	}

	private Vector3 AlignmentToque()
	{
		return default(Vector3);
	}

	public void AddBuoyancyCollider(SimpleBuoyancyCollider buoyancyCollider)
	{
	}

	public void RemoveBuoyancyCollider(SimpleBuoyancyCollider buoyancyCollider)
	{
	}

	private bool GetActiveLiquids(List<Liquid> cache)
	{
		return false;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
