using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.UI
{
	[Serializable]
	public class PlaylistsByMode
	{
		[SerializeField]
		public PlayListType type;

		[SerializeField]
		public bool availableOnline;

		[SerializeField]
		public GangType gangType;

		[SerializeField]
		public List<string> playlistNames;
	}
}
