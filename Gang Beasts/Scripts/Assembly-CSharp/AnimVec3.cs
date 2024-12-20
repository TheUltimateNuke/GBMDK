using UnityEngine;

public class AnimVec3 : AnimValue<Vector3>
{
	public override Vector3 Update(float step)
	{
		return default(Vector3);
	}

	public AnimVec3()
	{
	}

	public AnimVec3(Vector3 value)
	{
	}
}
