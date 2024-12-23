using UnityEngine;

namespace GB.UI.Utils
{
	public class DisableIfOnline : MonoBehaviour
	{
		[SerializeField]
		private GameObject _target;

		[SerializeField]
		private bool _showLocal;

		[SerializeField]
		private bool _showClient;

		[SerializeField]
		private bool _showServer;

		public GameObject Target => null;

		private void OnEnable()
		{
		}

		public bool Check()
		{
			return false;
		}
	}
}
