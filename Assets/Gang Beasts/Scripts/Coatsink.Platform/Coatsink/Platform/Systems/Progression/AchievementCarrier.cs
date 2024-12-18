using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Coatsink.Platform.Systems.Progression
{
	[Serializable]
	public class AchievementCarrier : ISerializable
	{
		private bool _dirty;

		private byte _version;

		private List<string> _keys;

		private List<bool> _data;

		public bool Dirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AchievementCarrier()
		{
		}

		public bool Get(string name)
		{
			return false;
		}

		public bool Set(string name, bool value)
		{
			return false;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public AchievementCarrier(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
