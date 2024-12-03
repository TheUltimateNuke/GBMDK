using System;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Network/NetworkAnimator")]
	[RequireComponent(typeof(NetworkIdentity))]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	[RequireComponent(typeof(Animator))]
	public class NetworkAnimator : NetworkBehaviour
	{
		[SerializeField]
		private Animator m_Animator;

		[SerializeField]
		private uint m_ParameterSendBits;

		private static AnimationMessage s_AnimationMessage;

		private static AnimationParametersMessage s_AnimationParametersMessage;

		private static AnimationTriggerMessage s_AnimationTriggerMessage;

		private int m_AnimationHash;

		private int m_TransitionHash;

		private NetworkWriter m_ParameterWriter;

		private float m_SendTimer;

		public string param0;

		public string param1;

		public string param2;

		public string param3;

		public string param4;

		public string param5;

		public Animator animator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool sendMessagesAllowed => false;

		public void SetParameterAutoSend(int index, bool value)
		{
		}

		public bool GetParameterAutoSend(int index)
		{
			return false;
		}

		internal void ResetParameterOptions()
		{
		}

		private void FixedUpdate()
		{
		}

		private bool CheckAnimStateChanged(out int stateHash, out float normalizedTime)
		{
			stateHash = default(int);
			normalizedTime = default(float);
			return false;
		}

		private void CheckSendRate()
		{
		}

		private void SendMessage(short type, MessageBase msg)
		{
		}

		private void SetSendTrackingParam(string p, int i)
		{
		}

		private void SetRecvTrackingParam(string p, int i)
		{
		}

		internal void HandleAnimMsg(AnimationMessage msg, NetworkReader reader)
		{
		}

		internal void HandleAnimParamsMsg(AnimationParametersMessage msg, NetworkReader reader)
		{
		}

		internal void HandleAnimTriggerMsg(int hash)
		{
		}

		private void WriteParameters(NetworkWriter writer, bool autoSend)
		{
		}

		private void ReadParameters(NetworkReader reader, bool autoSend)
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public void SetTrigger(string triggerName)
		{
		}

		public void SetTrigger(int hash)
		{
		}

		internal static void OnAnimationServerMessage(NetworkMessage netMsg)
		{
		}

		internal static void OnAnimationParametersServerMessage(NetworkMessage netMsg)
		{
		}

		internal static void OnAnimationTriggerServerMessage(NetworkMessage netMsg)
		{
		}

		internal static void OnAnimationClientMessage(NetworkMessage netMsg)
		{
		}

		internal static void OnAnimationParametersClientMessage(NetworkMessage netMsg)
		{
		}

		internal static void OnAnimationTriggerClientMessage(NetworkMessage netMsg)
		{
		}
	}
}
