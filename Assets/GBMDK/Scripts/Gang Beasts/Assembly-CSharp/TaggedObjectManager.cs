using System.Collections.Generic;
using UnityEngine;

public class TaggedObjectManager
{
	public enum DamageType
	{
		None = 0,
		Default = 1,
		Harmful = 2,
		Deadly = 3
	}

	public enum GrabType
	{
		None = 0,
		Gripable = 1,
		Climbable = 2
	}

	public enum TargetType
	{
		None = 0,
		PropLowPriority = 1,
		PropMediumPriority = 2,
		PropHighPriority = 3,
		BodyLowPriority = 4,
		BodyMediumPriority = 5,
		BodyHighPriority = 6
	}

	private struct TaggedObjectsStruct
	{
		public GameObject go;

		public GrabType grabType;

		public TargetType targetType;

		public DamageType damageType;

		public TaggedObjectsStruct(GameObject _go, GrabType _grabType, TargetType _targetType, DamageType _damageType)
		{
			go = null;
			grabType = default(GrabType);
			targetType = default(TargetType);
			damageType = default(DamageType);
		}
	}

	private static List<TaggedObjectsStruct> taggedObjects;

	public static void RemoveTaggedObject(GameObject go)
	{
	}

	public static void SetTaggedObject(GameObject go, DamageType damgeType, GrabType grabType, TargetType targetType)
	{
	}

	public static GameObject GetClosestTarget(Vector3 position, out TargetType outType)
	{
		outType = default(TargetType);
		return null;
	}

	public static GameObject GetClosestTargetInFov(Transform onlooker, float maxFov, out TargetType outType)
	{
		outType = default(TargetType);
		return null;
	}
}
