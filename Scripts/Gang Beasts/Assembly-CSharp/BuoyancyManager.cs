using System.Collections.Generic;
using Stages._Prototype.Scripts;
using UnityEngine;

public class BuoyancyManager : MonoBehaviour
{
	public struct RegisteredLiquid
	{
		public Liquid liquid;

		public Collider collider;

		public RegisteredLiquid(Liquid liquid, Collider collider)
		{
			this.liquid = null;
			this.collider = null;
		}
	}

	private List<SimpleBuoyancy> simpleBuoyancies;

	private List<SimpleBuoyancy> simpleBuoyanciesEven;

	private List<SimpleBuoyancy> simpleBuoyanciesOdd;

	private bool oddPass;

	private static BuoyancyManager _instance;

	public List<RegisteredLiquid> AllLiquids;

	private Dictionary<Collider, SimpleBuoyancyCollider> BuoyancyColliders;

	public static BuoyancyManager Instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void AddLiquid(Liquid liquid)
	{
	}

	public void RemoveLiquid(Liquid liquid)
	{
	}

	public void AddSimpleBuoyancy(SimpleBuoyancy simpleBuoyancy)
	{
	}

	public void RemoveSimpleBuoyancy(SimpleBuoyancy simpleBuoyancy)
	{
	}

	public void AddBuoyancyCollider(Collider physicsCollider, SimpleBuoyancyCollider buoyancyCollider)
	{
	}

	public void RemoveBuoyancyCollider(Collider physicsCollider)
	{
	}

	private void FixedUpdate()
	{
	}

	public SimpleBuoyancyCollider GetBuoyancyCollider(Collider collider)
	{
		return null;
	}

	private void OnValidate()
	{
	}
}
