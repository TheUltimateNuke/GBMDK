using UnityEngine;

public class AnimQuaternion : AnimValue<Quaternion>
{
	public override Quaternion Update(float step)
	{
		return default(Quaternion);
	}

	public AnimQuaternion()
	{
	}

	public AnimQuaternion(Quaternion value)
	{
	}
}
