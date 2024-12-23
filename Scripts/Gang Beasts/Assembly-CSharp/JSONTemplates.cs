using System.Collections.Generic;
using UnityEngine;

public static class JSONTemplates
{
	private static readonly HashSet<object> touched;

	public static JSONObject TOJSON(object obj)
	{
		return null;
	}

	public static Vector2 ToVector2(JSONObject obj)
	{
		return default(Vector2);
	}

	public static JSONObject FromVector2(Vector2 v)
	{
		return null;
	}

	public static JSONObject FromVector3(Vector3 v)
	{
		return null;
	}

	public static Vector3 ToVector3(JSONObject obj)
	{
		return default(Vector3);
	}

	public static JSONObject FromVector4(Vector4 v)
	{
		return null;
	}

	public static Vector4 ToVector4(JSONObject obj)
	{
		return default(Vector4);
	}

	public static JSONObject FromMatrix4x4(Matrix4x4 m)
	{
		return null;
	}

	public static Matrix4x4 ToMatrix4x4(JSONObject obj)
	{
		return default(Matrix4x4);
	}

	public static JSONObject FromQuaternion(Quaternion q)
	{
		return null;
	}

	public static Quaternion ToQuaternion(JSONObject obj)
	{
		return default(Quaternion);
	}

	public static JSONObject FromColor(Color c)
	{
		return null;
	}

	public static Color ToColor(JSONObject obj)
	{
		return default(Color);
	}

	public static JSONObject FromLayerMask(LayerMask l)
	{
		return null;
	}

	public static LayerMask ToLayerMask(JSONObject obj)
	{
		return default(LayerMask);
	}

	public static JSONObject FromRect(Rect r)
	{
		return null;
	}

	public static Rect ToRect(JSONObject obj)
	{
		return default(Rect);
	}

	public static JSONObject FromRectOffset(RectOffset r)
	{
		return null;
	}

	public static RectOffset ToRectOffset(JSONObject obj)
	{
		return null;
	}

	public static AnimationCurve ToAnimationCurve(JSONObject obj)
	{
		return null;
	}

	public static JSONObject FromAnimationCurve(AnimationCurve a)
	{
		return null;
	}

	public static Keyframe ToKeyframe(JSONObject obj)
	{
		return default(Keyframe);
	}

	public static JSONObject FromKeyframe(Keyframe k)
	{
		return null;
	}
}
