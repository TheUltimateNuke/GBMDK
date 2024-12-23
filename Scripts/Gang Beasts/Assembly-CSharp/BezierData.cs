using System;
using UnityEngine;

[Serializable]
public class BezierData
{
	public Transform StartNode;

	public Transform EndNode;

	public Transform StartTangent;

	public Transform EndTangent;

	public Vector3[] Points;

	public AnimationSpline.AnimationSplineClip AnimationClip;

	private BezierData(Transform _StartNode, Transform _EndNode, Transform _StartTangent, Transform _EndTangent, Vector3[] _Points, AnimationSpline.AnimationSplineClip _AnimationClip)
	{
	}

	public static BezierData CreateInstance(Transform _StartNode, Transform _EndNode, Transform _StartTangent, Transform _EndTangent, Vector3[] _Points, AnimationSpline.AnimationSplineClip _AnimationClip)
	{
		return null;
	}
}
