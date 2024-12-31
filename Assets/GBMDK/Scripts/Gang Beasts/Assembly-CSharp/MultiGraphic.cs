using UnityEngine;
using UnityEngine.UI;

public class MultiGraphic : Graphic
{
	[SerializeField]
	public Graphic[] targets;

	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
	{
	}
}
