using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Networking;

namespace Femur
{
	public class EffectsHandeler : NetworkBehaviour
	{
		public enum SoundType
		{
			Hurt = 0,
			KO = 1,
			Death = 2,
			LightImpactFoot = 3,
			HeavyImpactFoot = 4,
			LightImpactLimb = 5,
			HeavyImpactLimb = 6,
			LightImpactBody = 7,
			HeavyImpactBody = 8,
			LightImpactHead = 9,
			HeavyImpactHead = 10,
			Drag = 11,
			GrabEnter = 12,
			GrabExit = 13,
			HitGround = 14,
			ArmSwing = 15,
			Jump = 16
		}

		public enum VoiceType
		{
			DeathDefault = 0,
			DeathFalling = 1,
			Knockout = 2,
			Laugh = 3,
			NieNie = 4,
			UU = 5,
			Mungy = 6,
			BudBud = 7,
			Meh = 8,
			Exert = 9,
			Victory = 10,
			Vert = 11,
			Da = 12,
			Dee = 13,
			Doh = 14
		}

		[HideInInspector]
		public Transform localTransform;

		[HideInInspector]
		public Actor actor;

		[HideInInspector]
		public float blink;

		[HideInInspector]
		public float blinkDelay;

		[HideInInspector]
		public SkinnedMeshRenderer headMesh;

		public AudioClip[] lightImpactFootSound;

		public AudioClip[] heavyImpactFootSound;

		public AudioClip[] lightImpactLimbSound;

		public AudioClip[] heavyImpactLimbSound;

		public AudioClip[] lightImpactBodySound;

		public AudioClip[] heavyImpactBodySound;

		public AudioClip[] lightImpactHeadSound;

		public AudioClip[] heavyImpactHeadSound;

		public AudioClip[] hitGroundSound;

		public AudioClip[] grabEnterSound;

		public AudioClip[] grabExitSound;

		public AudioClip jumpSound;

		public AudioClip[] dragSound;

		private float audioDelay;

		public AudioClip[] armSwingSound;

		public AudioClip[] koSound;

		public AudioClip[] deathSound;

		private bool talking;

		public AudioMixerGroup physicalAudioMixerGroup;

		public AudioMixerGroup vocalsAudioMixerGroup;

		private static int kRpcRpcClientAudioEvent;

		private static int kRpcRpcVoiceBox;

		private void Update()
		{
		}

		private void Start()
		{
		}

		public void UpdateFaceState()
		{
		}

		[ClientRpc(channel = 0)]
		public void RpcClientAudioEvent(SoundType soundType, Vector3 position, float pitch, float volume)
		{
		}

		public void AudioEvent(SoundType soundType, Vector3 position, float pitch, float volume)
		{
		}

		public void Laugh()
		{
		}

		public void NieNie()
		{
		}

		public void UU()
		{
		}

		public void Meh()
		{
		}

		public void Mungy()
		{
		}

		public void Vert()
		{
		}

		public void Da()
		{
		}

		public void Dee()
		{
		}

		public void Doh()
		{
		}

		public void BudBud()
		{
		}

		[ClientRpc]
		private void RpcVoiceBox(VoiceType voiceType, bool force)
		{
		}

		public void VoiceBox(VoiceType voiceType, bool force = false)
		{
		}

		public void ResetVoiceBoxTag()
		{
		}

		private void OnDisable()
		{
		}

		public void UnlockVoiceBox()
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpcClientAudioEvent(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		protected static void InvokeRpcRpcVoiceBox(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpcClientAudioEvent(SoundType soundType, Vector3 position, float pitch, float volume)
		{
		}

		public void CallRpcVoiceBox(VoiceType voiceType, bool force)
		{
		}

		static EffectsHandeler()
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
