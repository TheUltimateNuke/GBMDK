using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Coatsink.Common
{
	public static class CollectionsX
	{
		public struct IndexValuePair<T>
		{
			public int index;

			public T value;
		}

		[CompilerGenerated]
		private sealed class _003CZipWithIndices_003Ed__19<T> : IEnumerable<IndexValuePair<T>>, IEnumerable, IEnumerator<IndexValuePair<T>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private IndexValuePair<T> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> enumerable;

			public IEnumerable<T> _003C_003E3__enumerable;

			private int _003Cindex_003E5__2;

			private IEnumerator<T> _003C_003E7__wrap2;

			private IndexValuePair<T> System_002ECollections_002EGeneric_002EIEnumerator_003CCoatsink_002ECommon_002ECollectionsX_002EIndexValuePair_003CT_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(IndexValuePair<T>);
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

			IndexValuePair<T> IEnumerator<IndexValuePair<T>>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CZipWithIndices_003Ed__19(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<IndexValuePair<T>> System_002ECollections_002EGeneric_002EIEnumerable_003CCoatsink_002ECommon_002ECollectionsX_002EIndexValuePair_003CT_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			IEnumerator<IndexValuePair<T>> IEnumerable<IndexValuePair<T>>.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CAllPermutationsOf_003Ed__24<TRes, T1, T2> : IEnumerable<TRes>, IEnumerable, IEnumerator<TRes>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TRes _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T1> col1;

			public IEnumerable<T1> _003C_003E3__col1;

			private IEnumerable<T2> col2;

			public IEnumerable<T2> _003C_003E3__col2;

			private Func<T1, T2, TRes> generate;

			public Func<T1, T2, TRes> _003C_003E3__generate;

			private IEnumerator<T1> _003C_003E7__wrap1;

			private T1 _003CelemFrom1_003E5__3;

			private IEnumerator<T2> _003C_003E7__wrap3;

			private TRes System_002ECollections_002EGeneric_002EIEnumerator_003CTRes_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(TRes);
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

			TRes IEnumerator<TRes>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CAllPermutationsOf_003Ed__24(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<TRes> System_002ECollections_002EGeneric_002EIEnumerable_003CTRes_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			IEnumerator<TRes> IEnumerable<TRes>.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CAllPermutationsOf_003Ed__25<TRes, T1, T2, T3> : IEnumerable<TRes>, IEnumerable, IEnumerator<TRes>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TRes _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T1> col1;

			public IEnumerable<T1> _003C_003E3__col1;

			private IEnumerable<T2> col2;

			public IEnumerable<T2> _003C_003E3__col2;

			private IEnumerable<T3> col3;

			public IEnumerable<T3> _003C_003E3__col3;

			private Func<T1, T2, T3, TRes> generate;

			public Func<T1, T2, T3, TRes> _003C_003E3__generate;

			private IEnumerator<T1> _003C_003E7__wrap1;

			private T1 _003CelemFrom1_003E5__3;

			private IEnumerator<T2> _003C_003E7__wrap3;

			private T2 _003CelemFrom2_003E5__5;

			private IEnumerator<T3> _003C_003E7__wrap5;

			private TRes System_002ECollections_002EGeneric_002EIEnumerator_003CTRes_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(TRes);
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

			TRes IEnumerator<TRes>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CAllPermutationsOf_003Ed__25(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<TRes> System_002ECollections_002EGeneric_002EIEnumerable_003CTRes_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			IEnumerator<TRes> IEnumerable<TRes>.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CAllPermutationsOf_003Ed__26<TRes, T1, T2, T3, T4> : IEnumerable<TRes>, IEnumerable, IEnumerator<TRes>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TRes _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T1> col1;

			public IEnumerable<T1> _003C_003E3__col1;

			private IEnumerable<T2> col2;

			public IEnumerable<T2> _003C_003E3__col2;

			private IEnumerable<T3> col3;

			public IEnumerable<T3> _003C_003E3__col3;

			private IEnumerable<T4> col4;

			public IEnumerable<T4> _003C_003E3__col4;

			private Func<T1, T2, T3, T4, TRes> generate;

			public Func<T1, T2, T3, T4, TRes> _003C_003E3__generate;

			private IEnumerator<T1> _003C_003E7__wrap1;

			private T1 _003CelemFrom1_003E5__3;

			private IEnumerator<T2> _003C_003E7__wrap3;

			private T2 _003CelemFrom2_003E5__5;

			private IEnumerator<T3> _003C_003E7__wrap5;

			private T3 _003CelemFrom3_003E5__7;

			private IEnumerator<T4> _003C_003E7__wrap7;

			private TRes System_002ECollections_002EGeneric_002EIEnumerator_003CTRes_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(TRes);
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

			TRes IEnumerator<TRes>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CAllPermutationsOf_003Ed__26(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			private void _003C_003Em__Finally4()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<TRes> System_002ECollections_002EGeneric_002EIEnumerable_003CTRes_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			IEnumerator<TRes> IEnumerable<TRes>.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		public static T[] Generate<T>(int qty) where T : new()
		{
			return null;
		}

		public static T[] Generate<T>(int qty, T initVal)
		{
			return null;
		}

		public static List<T> GenerateList<T>(int qty) where T : new()
		{
			return null;
		}

		public static T[] Population<T>(Func<T> generator, int qty)
		{
			return null;
		}

		public static void Remove<T>(this List<T> list, params IEnumerable<T>[] ranges)
		{
		}

		public static T GetValueAtWrappedOffset<T>(this IList<T> list, T member, int offset)
		{
			return default(T);
		}

		public static bool ContainsName(this IList<GameObject> enumerable, string name)
		{
			return false;
		}

		public static T FirstOfName<T>(this IList<T> list, string name) where T : UnityEngine.Object
		{
			return null;
		}

		public static T RemoveByName<T>(this IList<T> list, string name, bool single = true) where T : UnityEngine.Object
		{
			return null;
		}

		public static T[] Concat<T>(params T[][] arrays)
		{
			return null;
		}

		public static T FirstOrDefault<T>(this IList<T> source, Func<T, bool> predicate, T defaultVal)
		{
			return default(T);
		}

		public static bool TryFirst<T>(this IList<T> source, Func<T, bool> predicate, ref T destination)
		{
			return false;
		}

		public static IEnumerable<T> ConcatArgs<T>(this IEnumerable<T> collection, params T[] newMembers)
		{
			return null;
		}

		public static IEnumerable<T> RemoveWithIndices<T>(this IEnumerable<T> source, IEnumerable<int> indices)
		{
			return null;
		}

		public static IEnumerable<T> RemoveWithIndices<T>(this IEnumerable<T> collection, params int[] indices)
		{
			return null;
		}

		public static T[] RemoveValues<T>(this T[] array, params T[] values)
		{
			return null;
		}

		public static T[] InsertValuesAtIndices<T>(this T[] array, IDictionary<int, T[]> newMembers)
		{
			return null;
		}

		public static T[] InsertValueAtIndex<T>(this T[] array, T newMember, int newIndex = -1)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CZipWithIndices_003Ed__19<>))]
		public static IEnumerable<IndexValuePair<T>> ZipWithIndices<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		public static void SetValues<T>(this T[] array, params T[] values)
		{
		}

		public static IEnumerable<T> Sequence<T>(params T[] elements)
		{
			return null;
		}

		public static IEnumerable<T> SimpleShuffle<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		public static IEnumerator<T> GetPrecachedEnumerator<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAllPermutationsOf_003Ed__24<,,>))]
		public static IEnumerable<TRes> AllPermutationsOf<TRes, T1, T2>(this Func<T1, T2, TRes> generate, IEnumerable<T1> col1, IEnumerable<T2> col2)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAllPermutationsOf_003Ed__25<,,,>))]
		public static IEnumerable<TRes> AllPermutationsOf<TRes, T1, T2, T3>(this Func<T1, T2, T3, TRes> generate, IEnumerable<T1> col1, IEnumerable<T2> col2, IEnumerable<T3> col3)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAllPermutationsOf_003Ed__26<,,,,>))]
		public static IEnumerable<TRes> AllPermutationsOf<TRes, T1, T2, T3, T4>(this Func<T1, T2, T3, T4, TRes> generate, IEnumerable<T1> col1, IEnumerable<T2> col2, IEnumerable<T3> col3, IEnumerable<T4> col4)
		{
			return null;
		}

		public static void Zip<T1, T2>(T1[] col1, T2[] col2, Action<T1, T2> zipper)
		{
		}

		public static void Zip<T1, T2>(IEnumerable<T1> col1, IEnumerable<T2> col2, Action<T1, T2> zipper)
		{
		}

		public static void ShuffleArray<T>(T[] array)
		{
		}

		public static void Order<T>(ref T smaller, ref T larger) where T : IComparable<T>
		{
		}
	}
}
