using System.Collections.Generic;
using UnityEngine;

namespace GB.Stages.Ring
{
	public class StageScreenPartManager : MonoBehaviour
	{
		[SerializeField]
		private Camera _backCamera;

		[SerializeField]
		private List<StageScreenPart> _parts;

		private int _activeScreen;

		public Camera BackCamera => null;

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public bool UpdateActive()
		{
			return false;
		}

		public void ChangeActive(int i)
		{
		}
	}
}
