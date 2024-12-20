using CS.CorePlatform;
using GB.Input;
using UnityEngine;

namespace GB.DebugTools.Localisation
{
	public class LocalisationTesting : MonoBehaviour
	{
		[Header("ModelManager")]
		private RemappingMenuManager.ModalManager modelManager;

		public Transform _modelParent;

		public CanvasGroup _modelBackgroundFaderGroup;

		public GameObject modalWindow_NoButtons_Prefab;

		public GameObject modalWindow_Okay_Prefab;

		public GameObject modalWindow_ConfirmCancel_Prefab;

		private const int MODAL_TYPE_DISCONNECTED = 1;

		private BasePlatformManager _manager;

		private BasePlatformManager Manager => null;

		public void TestPlatformFailed(string s)
		{
		}

		public void TestCreateDisconnectModal(string s)
		{
		}

		public void TestNotificationTicker(string s, bool isError = false)
		{
		}

		public void TestRemapOpenModal(string s, RemappingMenuManager.ModalType type = RemappingMenuManager.ModalType.Okay)
		{
		}

		public void TestShowSystemMessageOK(string s)
		{
		}

		public void TestShowSystemMessageYesNo(string s)
		{
		}

		private void Start()
		{
		}
	}
}
