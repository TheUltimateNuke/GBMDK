using System.Collections.Generic;
using UnityEngine;

public class VoiceTag
{
	public enum VoiceType
	{
		None = 0,
		VoiceLaugh = 1,
		VoiceKnockout = 2,
		VoiceDeath = 3,
		VoiceDeathFalling = 4,
		VoiceBreak = 5,
		VoiceMeh = 6,
		VoiceBudBud = 7,
		VoiceMungy = 8,
		VoiceVert = 9
	}

	private struct VoiceTagStruct
	{
		public GameObject go;

		public VoiceType voice;
	}

	private static List<VoiceTagStruct> voiceTags;

	public static void RemoveVoiceGameObject(GameObject go)
	{
	}

	public static void SetVoiceTag(GameObject go, VoiceType type)
	{
	}

	public static GameObject GetClosestVoiceTag(Vector3 position, out VoiceType outType)
	{
		outType = default(VoiceType);
		return null;
	}

	public static GameObject GetClosestVoiceTagInFov(Transform onlooker, float maxFov, out VoiceType outType)
	{
		outType = default(VoiceType);
		return null;
	}
}
