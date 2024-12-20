using UnityEngine;
using UnityEngine.SceneManagement;

namespace Bootstrap
{
	public abstract class Bootstrapper : MonoBehaviour
	{
		public bool BootstrapOnSceneChange;

		public void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		protected abstract void Bootstrap();

		protected T Bootstrap<T>(GameObject go, bool reverse = false) where T : MonoBehaviour
		{
			return null;
		}

		private void Unbootstrap<T>(GameObject go) where T : MonoBehaviour
		{
		}
	}
}
