using System.Collections.Generic;
using UnityEngine;

namespace GB.UI.Utils.Settings
{
	public class ApplyInfo : MonoBehaviour
	{
		[SerializeField]
		private bool _clearOnDisabled;

		private bool _needsOption;

		private List<OptionsMenu> _currentOptions;

		public void AddOptions(OptionsMenu option)
		{
		}

		public void RemoveOptions(OptionsMenu option)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Apply()
		{
		}

		public void Reject()
		{
		}
	}
}
