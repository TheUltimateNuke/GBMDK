using UnityEngine;

internal interface IRigCombine
{
	void PreCombineAction();

	void PostCombineAction(Transform rootTransform);
}
