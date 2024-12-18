using UnityEngine;

namespace Stages._Prototype.Scripts
{
	public class SimpleBuoyancyCollider : MonoBehaviour
	{
		public SimpleBuoyancy Buoyancy;

		protected Liquid _currentLiquid;

		protected Collider m_PhysicsCollider;

		public Liquid Liquid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Collider RegisteredCollider => null;

		protected virtual void OnEnable()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
