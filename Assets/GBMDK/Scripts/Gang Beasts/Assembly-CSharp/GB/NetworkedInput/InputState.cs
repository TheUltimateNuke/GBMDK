using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Femur;
using GB.Networking.Delegates;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.NetworkedInput
{
	public class InputState : NetworkBehaviour
	{
		public const float MIN_MOVEMENT_DELTA = 0.001f;

		public const string INPUT_JUMP = "Jump";

		public const string INPUT_JUMP_DOUBLE = "DoubleJump";

		public const string INPUT_DUCK = "Duck";

		public const string INPUT_LIFT = "Lift";

		public const string INPUT_KICK = "Kick";

		public const string INPUT_GRAB_LEFT = "LeftGrab";

		public const string INPUT_GRAB_RIGHT = "RightGrab";

		public const string INPUT_HORIZONTAL_MOVEMENT = "HoriMove";

		public const string INPUT_VERTICAL_MOVEMENT = "VertMove";

		private Dictionary<string, DigitalState> DigitalInputState;

		private Dictionary<string, float> AnalogueInputState;

		private Actor _Actor;

		private InputDriver _Driver;

		private bool _LockInput;

		private static int kRpcRpc_RescanInput;

		private static int kRpcRpc_SetVibration;

		private static int kCmdCmdAlterDigitalInput;

		private static int kCmdCmdAlterAnalogueInput;

		public float TimeSinceLastInput { get; private set; }

		public static event Handler OnLocalPlayerSpawned
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

		private void Awake()
		{
		}

		private void RegenInputDictionaries()
		{
		}

		public void Initialise()
		{
		}

		public void FlushTimeSinceLastInput()
		{
		}

		[Server]
		public void LockInput()
		{
		}

		[Server]
		public void UnlockInput()
		{
		}

		[ClientRpc]
		private void Rpc_RescanInput()
		{
		}

		[ClientRpc]
		private void Rpc_SetVibration(float lowFrequency, float highFrequency, float duration)
		{
		}

		private void Update()
		{
		}

		public void FixedUpdate()
		{
		}

		public bool GetDigitalInput(string input)
		{
			return false;
		}

		public bool GetDigitalInputJustDown(string input)
		{
			return false;
		}

		public bool GetDigitalInputJustUp(string input)
		{
			return false;
		}

		public float GetAnalogueInput(string input)
		{
			return 0f;
		}

		public bool GetAnyInputDown()
		{
			return false;
		}

		public void FlushSetDigitalInput(string input, bool value, bool forceOverride = false)
		{
		}

		public void SetDigitalInput(string input, bool value, bool forceOverride = false)
		{
		}

		public void SetAnalogueInput(string input, float value)
		{
		}

		private bool SignificantChange(float o, float n)
		{
			return false;
		}

		[Command]
		private void CmdAlterDigitalInput(string input, bool value)
		{
		}

		[Command]
		private void CmdAlterAnalogueInput(string input, float value)
		{
		}

		public void FlushCurrentInputs()
		{
		}

		public void SetVibration(float lowFrequency, float highFrequency, float duration)
		{
		}

		public void StopVibration()
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeCmdCmdAlterDigitalInput(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		protected static void InvokeCmdCmdAlterAnalogueInput(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallCmdAlterDigitalInput(string input, bool value)
		{
		}

		public void CallCmdAlterAnalogueInput(string input, float value)
		{
		}

		protected static void InvokeRpcRpc_RescanInput(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		protected static void InvokeRpcRpc_SetVibration(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_RescanInput()
		{
		}

		public void CallRpc_SetVibration(float lowFrequency, float highFrequency, float duration)
		{
		}

		static InputState()
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
}
