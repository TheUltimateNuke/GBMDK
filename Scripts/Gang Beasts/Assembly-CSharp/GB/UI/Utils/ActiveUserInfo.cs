using UnityEngine;
using UnityEngine.UI;

namespace GB.UI.Utils
{
	public class ActiveUserInfo : MonoBehaviour
	{
		[SerializeField]
		private RawImage _userIconPlace;

		[SerializeField]
		private Text _userName;

		private Texture2D _userIcon;

		private void OnEnable()
		{
		}

		private void CheckMainUser()
		{
		}

		private void OnDisable()
		{
		}

		private void OnMainUserStated(bool effect)
		{
		}
	}
}
