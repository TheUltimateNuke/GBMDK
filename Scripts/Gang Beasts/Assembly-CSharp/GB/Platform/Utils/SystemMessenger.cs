using System;
using CS.CorePlatform.Utils;
using GB.Menu;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.Platform.Utils
{
	public class SystemMessenger : PlatformSystemMessenger
	{
		[SerializeField]
		private Canvas _messageCanvas;

		[SerializeField]
		private TextMeshProUGUI _messageBody;

		[SerializeField]
		private InputMapActions _optionAButton;

		[SerializeField]
		private InputMapActions _optionBButton;

		private bool _firstPass;

		private Action _doThisOne;

		private static SystemMessenger _instance;

		private int _lastInputController;

		public static SystemMessenger Instance => null;

		public int LastControllerInput => 0;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		protected override void DiscardMessage()
		{
		}

		protected override void ShowMessage()
		{
		}

		private void ShowActiveMessage()
		{
		}

		private void TriggerOptionA()
		{
		}

		private void TriggerOptionB()
		{
		}

		private void Update()
		{
		}
	}
}
