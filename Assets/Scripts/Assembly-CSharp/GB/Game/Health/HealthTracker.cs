using System;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Health.Events;
using UnityEngine;

namespace GB.Game.Health
{
	public class HealthTracker : MonoBehaviour
	{
		[SerializeField]
		private bool _serverOnly;

		private ChangeEvent _changed;

		private ChangeEffectEvent _multiply;

		private DeathEvent _death;

		[SerializeField]
		private float _healthMax;

		private float _health;

		private bool _dead;

		[SerializeField]
		public bool _resurrectable;

		private Actor _lastHitActor;

		[SerializeField]
		private bool _overrideListeners;

		[SerializeField]
		private GameObject[] _overrideChangeListeners;

		[SerializeField]
		private GameObject[] _overrideChangeEffectListeners;

		[SerializeField]
		private GameObject[] _overrideDeathListeners;

		[SerializeField]
		private GameObject[] _overrideResurrectedListeners;

		public float Health => 0f;

		public float HealthMax => 0f;

		public bool Dead => false;

		public bool Resurrectable => false;

		public event Action<ChangeEvent> OnChanged
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

		public event Action<ChangeEffectEvent> OnChangedEffect
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

		public event Action<DeathEvent> OnDeath
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

		public event Action<ChangeEvent> OnResurrected
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		protected void RefindListeners()
		{
		}

		public void Kill(InteractableObject interactable = null, Actor actor = null, Collision collision = null)
		{
		}

		public void ChangeHealth(float value, InteractableObject interactable = null, Actor actor = null, Collision collision = null, bool pure = false)
		{
		}
	}
}
