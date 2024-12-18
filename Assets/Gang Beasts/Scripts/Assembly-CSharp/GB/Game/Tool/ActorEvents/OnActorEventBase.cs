using System;
using System.Collections.Generic;
using Femur;
using GB.Game.Tool.ActorEvents.Triggers;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Game.Tool.ActorEvents
{
	public class OnActorEventBase : MonoBehaviour, ISerializationCallbackReceiver
	{
		private enum TriggerLimits
		{
			None = 0,
			OneTime = 1,
			OncePerGang = 2,
			OncePerBeast = 3,
			Mono = 4
		}

		[SerializeField]
		private bool _needsEnableState;

		[SerializeField]
		private bool _neededState;

		[SerializeField]
		private TriggerLimits _triggerLimit;

		[SerializeField]
		private UnityEvent _event;

		private ITriggerBase _activeTrigger;

		[NonSerialized]
		private IActorOnTriggerEvent[] _beastEvents;

		[SerializeField]
		private List<MonoBehaviour> _beastEventsSerializable;

		[SerializeField]
		private MonoBehaviour _triggerCheckCustomeMono;

		private ITriggerBase _triggerCheckAddictional;

		protected ITriggerBase ActiveTrigger => null;

		public bool TriggerActive()
		{
			return false;
		}

		public void Trigger(Actor actor)
		{
		}

		protected void RunTrigger(Actor actor)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private void OnValidate()
		{
		}
	}
}
