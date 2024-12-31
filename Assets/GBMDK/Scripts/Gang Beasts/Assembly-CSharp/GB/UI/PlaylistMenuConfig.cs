using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.UI
{
	[Serializable]
	public class PlaylistMenuConfig : ScriptableObject
	{
		[SerializeField]
		public List<PlaylistsByMode> playlistsByMode;
	}
}
