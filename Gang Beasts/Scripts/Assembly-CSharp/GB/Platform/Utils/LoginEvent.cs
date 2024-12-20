using UnityEngine;
using UnityEngine.Events;

namespace GB.Platform.Utils
{
	public class LoginEvent : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent OnLogin;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void PlatformEvents_OnMainUserStateEvent(bool effect)
		{
		}

		public void TryLogin()
		{
		}

		public void LogoutMain()
		{
		}

		public void Update()
		{
		}
	}
}
