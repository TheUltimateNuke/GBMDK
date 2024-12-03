using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Coatsink.Platform
{
	public class TaskResult : TaskResultBase<TaskResult>
	{
		private TaskCompletionSource<int> _tcs;

		private Action<TaskResult> _continuation;

		private TaskResult _continuationTask;
	}
	public class TaskResult<T1> : TaskResultBase<TaskResult<T1>>
	{
		private TaskCompletionSource<T1> _tcs;

		private Action<TaskResult<T1>> _continuation;

		private TaskResult _continuationTask;

		protected T1 _result;

		public T1 Result
		{
			get
			{
				return default(T1);
			}
			set
			{
			}
		}

		protected override void ResetInternal()
		{
		}

		protected override void CompleteInternal()
		{
		}
	}
	public class TaskResult<T1, T2> : TaskResultBase<TaskResult<T1, T2>>
	{
		public readonly struct Result
		{
			public readonly T1 Result1;

			public readonly T2 Result2;
		}

		private TaskCompletionSource<Result> _tcs;

		private Action<TaskResult<T1, T2>> _continuation;

		protected T1 _result1;

		protected T2 _result2;

		public T1 Result1
		{
			get
			{
				return default(T1);
			}
			set
			{
			}
		}

		public T2 Result2
		{
			get
			{
				return default(T2);
			}
			set
			{
			}
		}

		protected override void ResetInternal()
		{
		}

		protected override void CompleteInternal()
		{
		}
	}
	public class TaskResult<T1, T2, T3> : TaskResultBase<TaskResult<T1, T2, T3>>
	{
		public readonly struct Result
		{
			public readonly T1 Result1;

			public readonly T2 Result2;

			public readonly T3 Result3;

			public Result(T1 a, T2 b, T3 c) : this()
			{
			
			}
		}

		private TaskCompletionSource<Result> _tcs;

		private Action<TaskResult<T1, T2, T3>> _continuation;

		protected T1 _result1;

		protected T2 _result2;

		protected T3 _result3;

		public T1 Result1
		{
			get
			{
				return default(T1);
			}
			set
			{
			}
		}

		public T2 Result2
		{
			get
			{
				return default(T2);
			}
			set
			{
			}
		}

		public T3 Result3
		{
			get
			{
				return default(T3);
			}
			set
			{
			}
		}

		protected override void ResetInternal()
		{
		}

		protected override void CompleteInternal()
		{
		}
	}
}
