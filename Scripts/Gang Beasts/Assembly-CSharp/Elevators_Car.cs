using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

public class Elevators_Car : NetworkBehaviour
{
	public enum State
	{
		Stop = 0,
		ForcedStop = 1,
		Move = 2,
		Freefall = 3
	}

	public Transform floorCheck;

	public Elevators_Logic logic;

	public Rigidbody car;

	public Transform[] breaks;

	public float BrakesActiveDistance;

	public float BrakesInactiveDistance;

	public ParticleSystem[] sparks;

	public MeshRenderer[] sparkLights;

	public Transform[] clockwiseWheels;

	public Transform[] anticlockwiseWheels;

	public Rigidbody outerLeftDoor;

	public Rigidbody innerLeftDoor;

	public Rigidbody outerRightDoor;

	public Rigidbody innerRightDoor;

	public Light carLight;

	private Joint cachedCarJoint;

	public Elevators_Cable[] leftCables;

	public Rigidbody leftCableRoot;

	private bool _leftCableHasSnapped;

	public Elevators_Cable[] rightCables;

	public Rigidbody rightCableRoot;

	private bool _rightCableHasSnapped;

	[SyncVar]
	public bool breaksActive;

	public bool doorsActive;

	private bool doorsToggle;

	[SyncVar]
	public bool hasPower;

	[SyncVar]
	public bool malfunctioning;

	public float speed;

	[SyncVar]
	private float totalSpeed;

	public State state;

	public float[] floors;

	[SyncVar]
	public float targetFloor;

	public bool moving;

	public bool floorChangeLock;

	private float carVelocity;

	private bool fall;

	private bool _roundBlock;

	private static int kRpcRpc_PlayBreakSound;

	public bool leftCableHasSnapped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool rightCableHasSnapped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NetworkbreaksActive
	{
		get
		{
			return false;
		}
		[param: In]
		set
		{
		}
	}

	public bool NetworkhasPower
	{
		get
		{
			return false;
		}
		[param: In]
		set
		{
		}
	}

	public bool Networkmalfunctioning
	{
		get
		{
			return false;
		}
		[param: In]
		set
		{
		}
	}

	public float NetworktotalSpeed
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

	public float NetworktargetFloor
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

	private void OnLeftCableSnap()
	{
	}

	private void OnRightCableSnap()
	{
	}

	private void Awake()
	{
	}

	private void OnGameStarted()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Break Cable - Right")]
	private void BreakCableRight()
	{
	}

	[ContextMenu("Break Cable - Left")]
	private void BreakCableLeft()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void BreaksCheck()
	{
	}

	private void SparksCheck()
	{
	}

	private void WheelsCheck()
	{
	}

	private void DoorsAndLightsCheck()
	{
	}

	private void FloorsCheck()
	{
	}

	public void ChangeTargetFloor()
	{
	}

	private void ResetFloorChangeLock()
	{
	}

	[ContextMenu("Fall")]
	public void Fall()
	{
	}

	public void PlayBreakSound(Elevators_Cable cable, int sound, float pitch)
	{
	}

	[ClientRpc]
	public void Rpc_PlayBreakSound(int index, int sound, float pitch)
	{
	}

	private void UNetVersion()
	{
	}

	protected static void InvokeRpcRpc_PlayBreakSound(NetworkBehaviour obj, NetworkReader reader)
	{
	}

	public void CallRpc_PlayBreakSound(int index, int sound, float pitch)
	{
	}

	static Elevators_Car()
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
