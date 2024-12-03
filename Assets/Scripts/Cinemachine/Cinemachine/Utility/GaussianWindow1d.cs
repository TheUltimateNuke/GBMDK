namespace Cinemachine.Utility
{
	internal abstract class GaussianWindow1d<T>
	{
		protected T[] mData;

		protected float[] mKernel;

		protected int mCurrentPos;

		public float Sigma { get; private set; }

		public int KernelSize => 0;

		public int BufferLength => 0;

		private void GenerateKernel(float sigma, int maxKernelRadius)
		{
		}

		protected abstract T Compute(int windowPos);

		public GaussianWindow1d(float sigma, int maxKernelRadius = 10)
		{
		}

		public void Reset()
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public void AddValue(T v)
		{
		}

		public T Filter(T v)
		{
			return default(T);
		}

		public T Value()
		{
			return default(T);
		}

		public void SetBufferValue(int index, T value)
		{
		}

		public T GetBufferValue(int index)
		{
			return default(T);
		}
	}
}
