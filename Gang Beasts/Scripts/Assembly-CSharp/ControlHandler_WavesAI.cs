using Femur;
using UnityEngine;

public class ControlHandler_WavesAI : IControlHandler
{
	public Vector3 direction { get; set; }

	public Vector3 GetDesiredDirection(Actor actor)
	{
		return default(Vector3);
	}

	public void OverrideDesiredDirection(Actor actor, Vector3 direction)
	{
	}

	public void ProcessControl(Actor actor)
	{
	}

	public void ResetVariables()
	{
	}

	public void SetupControlHandler(Actor actor)
	{
	}
}
