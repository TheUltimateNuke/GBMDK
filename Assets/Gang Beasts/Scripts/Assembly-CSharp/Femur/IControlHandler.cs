using UnityEngine;

namespace Femur
{
	public interface IControlHandler
	{
		Vector3 direction { get; set; }

		void ProcessControl(Actor actor);

		void SetupControlHandler(Actor actor);

		void ResetVariables();
	}
}
