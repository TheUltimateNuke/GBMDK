using UnityEngine.SceneManagement;

namespace UnityEngine.Networking
{
	public interface ILoadingSystem
	{
		bool IsLoading { get; }

		bool IsWaitingActivation { get; }

		bool IsActivated { get; }

		float Progression { get; }

		bool IsDone { get; }

		void ActivateScene();

		void CompleteLoad();

		void LoadScene(string map, LoadSceneMode mode);
	}
}
