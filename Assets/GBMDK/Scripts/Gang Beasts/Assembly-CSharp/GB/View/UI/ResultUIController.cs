using System.Collections.Generic;
using CoreNet.Model;
using CoreNet.Objects;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.UI;

namespace GB.View.UI
{
	public class ResultUIController : MonoBehaviour
	{
		private Text _Text;

		private NetModel _Model;

		private List<NetBeast> _Beasts;

		private void Start()
		{
		}

		public void OnDestroy()
		{
		}

		private void OnGameResultSet(NetInt netInt)
		{
		}
	}
}
