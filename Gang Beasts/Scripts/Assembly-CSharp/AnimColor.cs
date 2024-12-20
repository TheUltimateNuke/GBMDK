using UnityEngine;

public class AnimColor : AnimValue<Color>
{
	public override Color Update(float step)
	{
		return default(Color);
	}

	public AnimColor()
	{
	}

	public AnimColor(Color color)
	{
	}
}
