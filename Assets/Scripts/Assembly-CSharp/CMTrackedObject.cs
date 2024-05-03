using Femur;
using UnityEngine;

public class CMTrackedObject
{
	public Transform Target;

	public bool IsHuman;

	public float Weight;

	public float Radius;

	public Actor beast;

	public bool track;

	public CMTrackedObject(Transform t, bool human, float w, float r, Actor actor = null)
	{
	}
}
