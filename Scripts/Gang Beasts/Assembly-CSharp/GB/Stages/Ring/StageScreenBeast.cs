using Femur;
using GB.Game.Tool.ActorEvents;
using TMPro;
using UnityEngine;

namespace GB.Stages.Ring
{
	public class StageScreenBeast : StageScreenPart, IActorOnTriggerEvent
	{
		[SerializeField]
		private GameObject _rootObject;

		[SerializeField]
		private TextMeshProUGUI _nameBox;

		[SerializeField]
		private Transform[] _cameraPoints;

		private Actor _target;

		public void Event(Actor actor)
		{
		}

		public override void OnFocusGained()
		{
		}

		public override void OnFocusLossed()
		{
		}

		public override void UpdateActive()
		{
		}
	}
}
