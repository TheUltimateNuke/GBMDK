using System.Collections.Generic;
using Femur;
using UnityEngine;

namespace GB.Game.Objective
{
	public class ObjectivePartInArea : ObjectivePartTrigger
	{
		protected List<Actor> _inArea;

		protected override bool OnActorEntered(Actor actor)
		{
			return false;
		}

		public void OnTriggerExit(Collider other)
		{
		}

		protected virtual bool OnActorExited(Actor actor)
		{
			return false;
		}
	}
}
