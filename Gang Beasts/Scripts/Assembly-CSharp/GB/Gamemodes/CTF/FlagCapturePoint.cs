using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Gamemodes.CTF
{
	public class FlagCapturePoint : NetworkBehaviour
	{
		[Serializable]
		public struct RenderTarget
		{
			public Renderer renderer;

			public int materialIndex;
		}

		public delegate void FlagCaptureHandler(FlagCapturePoint flagCP, Flag flag);

		[SerializeField]
		private RenderTarget[] _targetRenderers;

		private Material[] _targetMaterials;

		private Sequence[] flashSequence;

		[SyncVar(hook = "GangIDChanged")]
		private int _gangID;

		private static int kRpcRpcFlashColor;

		private Material[] TargetMaterial => null;

		public int GangID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Network_gangID
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

		public static event FlagCaptureHandler OnFlagCapture
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

		public void GangIDChanged(int value)
		{
		}

		public void OnEnable()
		{
		}

		private void UpdateColour()
		{
		}

		public void OnTriggerEnter(Collider col)
		{
		}

		[ClientRpc]
		private void RpcFlashColor()
		{
		}

		private void FlashColor()
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpcFlashColor(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpcFlashColor()
		{
		}

		static FlagCapturePoint()
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
