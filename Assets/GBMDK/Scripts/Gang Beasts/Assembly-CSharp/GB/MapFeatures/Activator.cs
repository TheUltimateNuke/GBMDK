using Femur;
using GB.Achievements;
using UnityEngine;
using UnityEngine.Events;

namespace GB.MapFeatures
{
	public class Activator : MonoBehaviour
	{
		[SerializeField]
		private ActivatorTarget[] Targets;

		[SerializeField]
		private AchievementTriggerType ActivationType;

		[SerializeField]
		private UnityEvent ActivationActions;

		[SerializeField]
		private UnityEvent DeactivationActions;

		private bool _cachedActivationActionState;

		[SerializeField]
		private Collider TriggerEnterCollider;

		[SerializeField]
		private BodyEnum[] ActorListenBodyParts;

		[SerializeField]
		private float ReTriggerDelay;

		private float _currentReTriggerTime;

		[SerializeField]
		private Collider UniqueTriggerCollider;

		private void Start()
		{
		}

		private void ToggleActivation()
		{
		}

		private void Activate()
		{
		}

		private void Deactivate()
		{
		}

		private void Update()
		{
		}
	}
}
