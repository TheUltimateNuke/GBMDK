using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollisionImpulseSource.html")]
	[SaveDuringPlay]
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
	{
		[Tooltip("Only collisions with objects on these layers will generate Impulse events")]
		[Header("Trigger Object Filter")]
		public LayerMask m_LayerMask;

		[TagField]
		[Tooltip("No Impulse evemts will be generated for collisions with objects having these tags")]
		public string m_IgnoreTag;

		[Header("How To Generate The Impulse")]
		[Tooltip("If checked, signal direction will be affected by the direction of impact")]
		public bool m_UseImpactDirection;

		[Tooltip("If checked, signal amplitude will be multiplied by the mass of the impacting object")]
		public bool m_ScaleImpactWithMass;

		[Tooltip("If checked, signal amplitude will be multiplied by the speed of the impacting object")]
		public bool m_ScaleImpactWithSpeed;

		private Rigidbody mRigidBody;

		private Rigidbody2D mRigidBody2D;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private float GetMassAndVelocity(Collider other, ref Vector3 vel)
		{
			return 0f;
		}

		private void GenerateImpactEvent(Collider other, Vector3 vel)
		{
		}

		private void OnCollisionEnter2D(Collision2D c)
		{
		}

		private void OnTriggerEnter2D(Collider2D c)
		{
		}

		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel)
		{
			return 0f;
		}

		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel)
		{
		}
	}
}
