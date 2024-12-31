using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Coatsink.Platform.Systems.Progression
{
	[Serializable]
	public class StatsCarrier : ISerializable
	{
		[Serializable]
		[StructLayout(LayoutKind.Explicit)]
		private struct DataCarrier
		{
			[FieldOffset(0)]
			public int Int;

			[FieldOffset(0)]
			public float Float;
		}

		private bool _dirty;

		private byte _version;

		private List<string> _keys;

		private List<DataCarrier> _data;

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

		public StatsCarrier()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public StatsCarrier(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
