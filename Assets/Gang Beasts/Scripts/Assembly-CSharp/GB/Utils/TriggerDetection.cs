using System;
using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace GB.Utils
{
	public class TriggerDetection : MonoBehaviour
	{
		private Action enterAction;

		private Action exitAction;

		private BeastAction enterActionBeast;

		private BeastAction stayActionBeast;

		private BeastAction exitActionBeast;

		private bool BeastsOnly;

		private bool AlwaysAlert;

		private BodyEnum[] _listenBodyParts;

		private GameObject[] ListenForObj;

		private bool _hasAny;

		private List<ActorPartPresence> PresentActorParts;

		private BodyEnum[] ListenBodyParts
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Setup(Action onEnterResponse, Action onExitResponse, params GameObject[] ListenFor)
		{
		}

		public void Setup(BeastAction onEnterResponse, BeastAction onExitResponse, bool alwaysTrigger = false, params BodyEnum[] listenParts)
		{
		}

		public void Setup(BeastAction onEnterResponse, BeastAction onExitResponse, BeastAction onStayResponse, params BodyEnum[] listenParts)
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private bool CheckTransformAgainstPartList(Actor actor, Transform xform)
		{
			return false;
		}
	}
}
