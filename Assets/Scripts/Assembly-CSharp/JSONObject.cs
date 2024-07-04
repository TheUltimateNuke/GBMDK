using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public class JSONObject
{
	public enum Type
	{
		NULL = 0,
		STRING = 1,
		NUMBER = 2,
		OBJECT = 3,
		ARRAY = 4,
		BOOL = 5,
		BAKED = 6
	}

	public delegate void AddJSONContents(JSONObject self);

	public delegate void FieldNotFound(string name);

	public delegate void GetFieldResponse(JSONObject obj);

	[CompilerGenerated]
	private sealed class _003CBakeAsync_003Ed__98 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public JSONObject _003C_003E4__this;

		private IEnumerator<string> _003C_003E7__wrap1;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
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

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CBakeAsync_003Ed__98(int _003C_003E1__state)
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
		private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
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

        public IEnumerator<object> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

	[CompilerGenerated]
	private sealed class _003CPrintAsync_003Ed__100 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public JSONObject _003C_003E4__this;

		private bool pretty;

		public bool _003C_003E3__pretty;

		private StringBuilder _003Cbuilder_003E5__2;

		private IEnumerator _003C_003E7__wrap2;

		private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
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

        public string Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CPrintAsync_003Ed__100(int _003C_003E1__state)
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
		private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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

	[CompilerGenerated]
	private sealed class _003CStringifyAsync_003Ed__103 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int depth;

		public int _003C_003E3__depth;

		public JSONObject _003C_003E4__this;

		private StringBuilder builder;

		public StringBuilder _003C_003E3__builder;

		private bool pretty;

		public bool _003C_003E3__pretty;

		private int _003Ci_003E5__2;

		private IEnumerator _003C_003E7__wrap2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
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

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CStringifyAsync_003Ed__103(int _003C_003E1__state)
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
		private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
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

        public IEnumerator<object> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

	private const int MAX_DEPTH = 100;

	private const string INFINITY = "\"INFINITY\"";

	private const string NEGINFINITY = "\"NEGINFINITY\"";

	private const string NaN = "\"NaN\"";

	public static readonly char[] WHITESPACE;

	public Type type;

	public List<JSONObject> list;

	public List<string> keys;

	public string str;

	public float n;

	public bool b;

	private const float maxFrameTime = 0.008f;

	private static readonly Stopwatch printWatch;

	public bool isContainer => false;

	public int Count => 0;

	public float f => 0f;

	public static JSONObject nullJO => null;

	public static JSONObject obj => null;

	public static JSONObject arr => null;

	public bool IsNumber => false;

	public bool IsNull => false;

	public bool IsString => false;

	public bool IsBool => false;

	public bool IsArray => false;

	public bool IsObject => false;

	public JSONObject this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JSONObject this[string index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JSONObject(Type t)
	{
	}

	public JSONObject(bool b)
	{
	}

	public JSONObject(float f)
	{
	}

	public JSONObject(Dictionary<string, string> dic)
	{
	}

	public JSONObject(Dictionary<string, JSONObject> dic)
	{
	}

	public JSONObject(AddJSONContents content)
	{
	}

	public JSONObject(JSONObject[] objs)
	{
	}

	public static JSONObject StringObject(string val)
	{
		return null;
	}

	public void Absorb(JSONObject obj)
	{
	}

	public static JSONObject Create()
	{
		return null;
	}

	public static JSONObject Create(Type t)
	{
		return null;
	}

	public static JSONObject Create(bool val)
	{
		return null;
	}

	public static JSONObject Create(float val)
	{
		return null;
	}

	public static JSONObject Create(int val)
	{
		return null;
	}

	public static JSONObject CreateStringObject(string val)
	{
		return null;
	}

	public static JSONObject CreateBakedObject(string val)
	{
		return null;
	}

	public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
	{
		return null;
	}

	public static JSONObject Create(AddJSONContents content)
	{
		return null;
	}

	public static JSONObject Create(Dictionary<string, string> dic)
	{
		return null;
	}

	public JSONObject()
	{
	}

	public JSONObject(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
	{
	}

	private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
	{
	}

	public void Add(bool val)
	{
	}

	public void Add(float val)
	{
	}

	public void Add(int val)
	{
	}

	public void Add(string str)
	{
	}

	public void Add(AddJSONContents content)
	{
	}

	public void Add(JSONObject obj)
	{
	}

	public void AddField(string name, bool val)
	{
	}

	public void AddField(string name, float val)
	{
	}

	public void AddField(string name, int val)
	{
	}

	public void AddField(string name, AddJSONContents content)
	{
	}

	public void AddField(string name, string val)
	{
	}

	public void AddField(string name, JSONObject obj)
	{
	}

	public void SetField(string name, string val)
	{
	}

	public void SetField(string name, bool val)
	{
	}

	public void SetField(string name, float val)
	{
	}

	public void SetField(string name, int val)
	{
	}

	public void SetField(string name, JSONObject obj)
	{
	}

	public void RemoveField(string name)
	{
	}

	public bool GetField(ref bool field, string name, bool fallback)
	{
		return false;
	}

	public bool GetField(ref bool field, string name, FieldNotFound fail = null)
	{
		return false;
	}

	public bool GetField(ref float field, string name, float fallback)
	{
		return false;
	}

	public bool GetField(ref float field, string name, FieldNotFound fail = null)
	{
		return false;
	}

	public bool GetField(ref int field, string name, int fallback)
	{
		return false;
	}

	public bool GetField(ref int field, string name, FieldNotFound fail = null)
	{
		return false;
	}

	public bool GetField(ref uint field, string name, uint fallback)
	{
		return false;
	}

	public bool GetField(ref uint field, string name, FieldNotFound fail = null)
	{
		return false;
	}

	public bool GetField(ref string field, string name, string fallback)
	{
		return false;
	}

	public bool GetField(ref string field, string name, FieldNotFound fail = null)
	{
		return false;
	}

	public void GetField(string name, GetFieldResponse response, FieldNotFound fail = null)
	{
	}

	public JSONObject GetField(string name)
	{
		return null;
	}

	public bool HasFields(string[] names)
	{
		return false;
	}

	public bool HasField(string name)
	{
		return false;
	}

	public void Clear()
	{
	}

	public JSONObject Copy()
	{
		return null;
	}

	public void Merge(JSONObject obj)
	{
	}

	private static void MergeRecur(JSONObject left, JSONObject right)
	{
	}

	public void Bake()
	{
	}

	[IteratorStateMachine(typeof(_003CBakeAsync_003Ed__98))]
	public IEnumerable BakeAsync()
	{
		return null;
	}

	public string Print(bool pretty = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPrintAsync_003Ed__100))]
	public IEnumerable<string> PrintAsync(bool pretty = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStringifyAsync_003Ed__103))]
	private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
	{
		return null;
	}

	private void Stringify(int depth, StringBuilder builder, bool pretty = false)
	{
	}

	public static implicit operator WWWForm(JSONObject obj)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(bool pretty)
	{
		return null;
	}

	public Dictionary<string, string> ToDictionary()
	{
		return null;
	}

	public static implicit operator bool(JSONObject o)
	{
		return false;
	}
}
