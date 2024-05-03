using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[RequireComponent(typeof(AudioSource))]
	[RequireComponent(typeof(CharacterController))]
	public class FirstPersonController : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsWalking;

		[SerializeField]
		private float m_WalkSpeed;

		[SerializeField]
		private float m_RunSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[SerializeField]
		private float m_JumpSpeed;

		[SerializeField]
		private float m_StickToGroundForce;

		[SerializeField]
		private float m_GravityMultiplier;

		[SerializeField]
		private MouseLook m_MouseLook;

		[SerializeField]
		private bool m_UseFovKick;

		[SerializeField]
		private FOVKick m_FovKick;

		[SerializeField]
		private bool m_UseHeadBob;

		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[SerializeField]
		private float m_StepInterval;

		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[SerializeField]
		private AudioClip m_JumpSound;

		[SerializeField]
		private AudioClip m_LandSound;

		private Camera m_Camera;

		private bool m_Jump;

		private float m_YRotation;

		private CameraRefocus m_CameraRefocus;

		private Vector2 m_Input;

		private Vector3 m_MoveDir;

		private CharacterController m_CharacterController;

		private CollisionFlags m_CollisionFlags;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private float m_StepCycle;

		private float m_NextStep;

		private bool m_Jumping;

		private AudioSource m_AudioSource;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void PlayLandingSound()
		{
		}

		private void FixedUpdate()
		{
		}

		private void PlayJumpSound()
		{
		}

		private void ProgressStepCycle(float speed)
		{
		}

		private void PlayFootStepAudio()
		{
		}

		private void UpdateCameraPosition(float speed)
		{
		}

		private void GetInput(out float speed)
		{
			speed = default(float);
		}

		private void RotateView()
		{
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}
	}
}
