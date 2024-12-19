using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Femur
{
	public class StatusHandeler : NetworkBehaviour
	{
		private struct Damage
		{
			public InteractableObject.Damage _type;

			public float _amount;

			public GameObject _causer;

			public Damage(InteractableObject.Damage type, float amount, GameObject causer)
			{
				_type = default(InteractableObject.Damage);
				_amount = 0f;
				_causer = null;
			}
		}

		[HideInInspector]
		public Actor actor;

		public bool initialized;

		public bool canDie;

		public bool forceDie;

		[HideInInspector]
		public float healthDamage;

		[HideInInspector]
		public float staminaDamage;

		public List<string> damageCausers;

		[SyncVar]
		private float m_health;

		[SyncVar]
		private float m_stamina;

		public float maxHealth;

		public float maxStamina;

		public float healthRegeneration;

		public float staminaRegeneration;

		public float lastHealth;

		public float lastStamina;

		public float painThreshold;

		public float knockoutThreshold;

		public bool invulnerable;

		public bool immortal;

		[HideInInspector]
		public float dmgModifier;

		[HideInInspector]
		public float unconsciousTime;

		private float maxUnconsciousTime;

		private float minUnconsciousTime;

		private float invincibleTimer;

		private const float kInvincibleTime = 2f;

		public GameObject statusBarPrefab;

		[HideInInspector]
		public Transform statusBarTransform;

		private Image healthBarFill;

		private Image healthBarBack;

		private Image staminaBarFill;

		private Image staminaBarBack;

		private Image unconsciousBarFill;

		private Image unconsciousBarBack;

		private float displayTime;

		public float displayTimer;

		public bool showStatusBar;

		private bool dying;

		public bool blockAudioEvents;

		private GlobalManager globalManager;

		public GameObject nameBarPrefab;

		public float _damageModifer;

		private Damage[] damageTypes;

		private int numOfDamageTypes;

		private bool hasDamageTypes;

		private float staminaVibrateTimer;

		private bool alwaysDrain;

		public float health
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float stamina
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Networkm_health
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

		public float Networkm_stamina
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

		public void Start()
		{
		}

		public void AddDamage(InteractableObject.Damage type, float damage, GameObject causer)
		{
		}

		public void ClearDamageTypes()
		{
		}

		public void Update()
		{
		}

		public void UpdateHealth()
		{
		}

		private void KillBeast()
		{
		}

		public void SetMaxUnconsciousTime(float time)
		{
		}

		private void CheckForDamageAchievements()
		{
		}

		public void UpdateStamina()
		{
		}

		public void UpdateGrab()
		{
		}

		public void CheckConscious()
		{
		}

		public void UpdateBars()
		{
		}

		public void Kill()
		{
		}

		public bool TryKill(bool forceKillImmortal, Action killCallback = null)
		{
			return false;
		}

		public void Resurrect()
		{
		}

		private Quaternion GetForwardRotation()
		{
			return default(Quaternion);
		}

		private void UNetVersion()
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
