using System.Collections.Generic;
using GB.Game.Health.Effects;
using GB.Game.Health.Events;
using UnityEngine;

namespace GB.Game.Health
{
	public class InteractableDamageMultiplier : MonoBehaviour, MultiplyEffect, ISerializationCallbackReceiver
	{
		public enum HealEffect
		{
			HealOnly = 0,
			DamageOnly = 1,
			Any = 2
		}

		[SerializeField]
		private HealEffect _typeBlock;

		public Dictionary<InteractableObject.Damage, float> Effects;

		[SerializeField]
		public List<InteractableObject.Damage> _serializerType;

		[SerializeField]
		public List<float> _serializerAmount;

		public HealEffect TypeBlock
		{
			get
			{
				return default(HealEffect);
			}
			set
			{
			}
		}

		public void OnChangedEffect(ChangeEffectEvent arg)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
