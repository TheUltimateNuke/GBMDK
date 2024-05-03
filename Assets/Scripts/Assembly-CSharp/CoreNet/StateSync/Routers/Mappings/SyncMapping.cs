namespace CoreNet.StateSync.Routers.Mappings
{
	public class SyncMapping
	{
		public delegate short FloatDowncaster(float value, float range);

		public delegate float FloatUpcaster(short value, float range);

		public float SyncRange;

		public FloatDowncaster Downcaster;

		public FloatUpcaster Upcaster;

		public SyncMapping(float range, FloatDowncaster down, FloatUpcaster up)
		{
		}

		public short Downcast(float value)
		{
			return 0;
		}

		public float Upcast(short value)
		{
			return 0f;
		}
	}
}
