using System.Collections.Generic;
using UnityEngine;

public class AnimationSplineScriptableObject : ScriptableObject
{
	public List<BezierData> BezierCurves;

	public GameObject GhostPreview;
}
