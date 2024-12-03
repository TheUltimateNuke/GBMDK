using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityWebSocketSharp
{
	internal class PayloadData : IEnumerable<byte>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__25 : IEnumerator<byte>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private byte _003C_003E2__current;

			public PayloadData _003C_003E4__this;

			private byte[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private byte System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EByte_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public byte Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CGetEnumerator_003Ed__25(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private byte[] _data;

		private long _extDataLength;

		private long _length;

		public static readonly PayloadData Empty;

		public static readonly ulong MaxLength;

		internal ushort Code => 0;

		internal bool HasReservedCode => false;

		public byte[] ApplicationData => null;

		public ulong Length => 0uL;

		static PayloadData()
		{
		}

		internal PayloadData(byte[] data)
		{
		}

		internal PayloadData(byte[] data, long length)
		{
		}

		internal PayloadData(ushort code, string reason)
		{
		}

		internal void Mask(byte[] key)
		{
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__25))]
		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		public byte[] ToArray()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
