using CS.CorePlatform;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

namespace GB.Platform.Utils
{
	public class SystemWarning : MonoBehaviour
	{
		[SerializeField]
		private string _codeMainUserLost;

		private string _mainUserLostMessage;

		private BasePlatformManager _manager;

		private int mainLocalID;

		private bool _forced;

		private BasePlatformManager Manager => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		private void OnPlatformSleepChanged(bool IsSleeping)
		{
		}

		public void LoadLanguage()
		{
		}

		private void StringLoader_OnLanguageLoaded(Locale locale = null)
		{
		}

		private void PlatformEvents_OnMainUserStateEvent(bool effect)
		{
		}

		private void SignoutOkButton()
		{
		}

		private void OnPrimUserLost()
		{
		}

		private void ForceMenu()
		{
		}
	}
}
