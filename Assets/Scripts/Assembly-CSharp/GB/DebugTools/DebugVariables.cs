using System;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

namespace GB.DebugTools
{
	public class DebugVariables : MonoBehaviour
	{
		public enum DebugVariableCheckMode
		{
			None = 0,
			PerFrame = 1,
			PerSecond = 2
		}

		[SerializeField]
		private static DebugVariables _instance;

		[SerializeField]
		private TextMeshProUGUI _textPrefab;

		[SerializeField]
		private RectTransform _groupPrefab;

		[SerializeField]
		private RectTransform _textParent;

		private List<IDebugVariable> _deleteKeys;

		private float _lastPerSecondUpdateTime;

		public static List<Type> typesWithReferenceAttributesInside;

		public static HashSet<string> checkedPaths;

		public static Dictionary<IDebugVariable, TextMeshProUGUI> variables;

		public static Dictionary<string, RectTransform> groupParents;

		public static List<IDebugVariable> perFrameUpdateVariables;

		public static List<IDebugVariable> perSecondUpdateVariables;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void SearchFields(FieldInfo[] fields, UnityEngine.Object obj, string path, HashSet<Type> types, int i = 0)
		{
		}

		private static bool HasReferenceAttributeTypeInside(FieldInfo[] fields, HashSet<Type> types, int i = 0)
		{
			return false;
		}

		public static DebugVariable<T> SetupVariable<T>(string name, T value, string groupName = "", DebugVariableCheckMode updateMode = DebugVariableCheckMode.None)
		{
			return null;
		}

		private static TextMeshProUGUI CreateText(string name, string value, string groupName)
		{
			return null;
		}

		private static void UpdateText(IDebugVariable variable)
		{
		}

		private static void DisplayText(TextMeshProUGUI text, string name, string value)
		{
		}

		public static void SubscribeToUpdate(IDebugVariable variable, DebugVariableCheckMode mode)
		{
		}

		private static RectTransform GetGroup(string groupName)
		{
			return null;
		}
	}
}
