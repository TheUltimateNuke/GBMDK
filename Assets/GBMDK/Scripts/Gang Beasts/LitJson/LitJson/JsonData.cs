using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace LitJson
{
	public class JsonData : IJsonWrapper, IEquatable<JsonData>, IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
	{
		private IList<JsonData> inst_array;

		private bool inst_boolean;

		private double inst_double;

		private int inst_int;

		private long inst_long;

		private IDictionary<string, JsonData> inst_object;

		private string inst_string;

		private string json;

		private JsonType type;

		private IList<KeyValuePair<string, JsonData>> object_list;

		private int System_002ECollections_002EICollection_002ECount => 0;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private bool System_002ECollections_002EIDictionary_002EIsFixedSize => false;

		private bool System_002ECollections_002EIDictionary_002EIsReadOnly => false;

		private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

		private ICollection System_002ECollections_002EIDictionary_002EValues => null;

		private bool LitJson_002EIJsonWrapper_002EIsArray => false;

		private bool LitJson_002EIJsonWrapper_002EIsBoolean => false;

		private bool LitJson_002EIJsonWrapper_002EIsDouble => false;

		private bool LitJson_002EIJsonWrapper_002EIsInt => false;

		private bool LitJson_002EIJsonWrapper_002EIsLong => false;

		private bool LitJson_002EIJsonWrapper_002EIsObject => false;

		private bool LitJson_002EIJsonWrapper_002EIsString => false;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

		private object System_002ECollections_002EIDictionary_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private object System_002ECollections_002EIList_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsArray => false;

		public bool IsBoolean => false;

		public bool IsDouble => false;

		public bool IsInt => false;

		public bool IsLong => false;

		public bool IsObject => false;

		public bool IsString => false;

		bool IList.IsFixedSize => throw new NotImplementedException();

		bool IList.IsReadOnly => throw new NotImplementedException();

		int ICollection.Count => throw new NotImplementedException();

		bool ICollection.IsSynchronized => throw new NotImplementedException();

		object ICollection.SyncRoot => throw new NotImplementedException();

		bool IDictionary.IsFixedSize => throw new NotImplementedException();

		bool IDictionary.IsReadOnly => throw new NotImplementedException();

		ICollection IDictionary.Keys => throw new NotImplementedException();

		ICollection IDictionary.Values => throw new NotImplementedException();

		object IDictionary.this[object key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		object IOrderedDictionary.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		object IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string this[string prop_name]
		{
			set
			{
			}
		}

		public int this[int index]
		{
			set
			{
			}
		}

		public JsonData()
		{
		}

		public JsonData(object obj)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		private void System_002ECollections_002EIDictionary_002EClear()
		{
		}

		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return false;
		}

		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002ERemove(object key)
		{
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private bool LitJson_002EIJsonWrapper_002EGetBoolean()
		{
			return false;
		}

		private double LitJson_002EIJsonWrapper_002EGetDouble()
		{
			return 0.0;
		}

		private int LitJson_002EIJsonWrapper_002EGetInt()
		{
			return 0;
		}

		private long LitJson_002EIJsonWrapper_002EGetLong()
		{
			return 0L;
		}

		private string LitJson_002EIJsonWrapper_002EGetString()
		{
			return null;
		}

		private void LitJson_002EIJsonWrapper_002ESetBoolean(bool val)
		{
		}

		private void LitJson_002EIJsonWrapper_002ESetDouble(double val)
		{
		}

		private void LitJson_002EIJsonWrapper_002ESetInt(int val)
		{
		}

		private void LitJson_002EIJsonWrapper_002ESetLong(long val)
		{
		}

		private void LitJson_002EIJsonWrapper_002ESetString(string val)
		{
		}

		private string LitJson_002EIJsonWrapper_002EToJson()
		{
			return null;
		}

		private void LitJson_002EIJsonWrapper_002EToJson(JsonWriter writer)
		{
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		private IDictionaryEnumerator System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EGetEnumerator()
		{
			return null;
		}

		private ICollection EnsureCollection()
		{
			return null;
		}

		private IDictionary EnsureDictionary()
		{
			return null;
		}

		private IList EnsureList()
		{
			return null;
		}

		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		public int Add(object value)
		{
			return 0;
		}

		public bool Equals(JsonData x)
		{
			return false;
		}

		public void SetJsonType(JsonType type)
		{
		}

		public string ToJson()
		{
			return null;
		}

		public void ToJson(JsonWriter writer)
		{
		}

		public override string ToString()
		{
			return null;
		}

		int IList.Add(object value)
		{
			throw new NotImplementedException();
		}

		void IList.Clear()
		{
			throw new NotImplementedException();
		}

		bool IList.Contains(object value)
		{
			throw new NotImplementedException();
		}

		int IList.IndexOf(object value)
		{
			throw new NotImplementedException();
		}

		void IList.Insert(int index, object value)
		{
			throw new NotImplementedException();
		}

		void IList.Remove(object value)
		{
			throw new NotImplementedException();
		}

		void IList.RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		void IOrderedDictionary.Insert(int index, object key, object value)
		{
			throw new NotImplementedException();
		}

		void IOrderedDictionary.RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		void IDictionary.Add(object key, object value)
		{
			throw new NotImplementedException();
		}

		void IDictionary.Clear()
		{
			throw new NotImplementedException();
		}

		bool IDictionary.Contains(object key)
		{
			throw new NotImplementedException();
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		void IDictionary.Remove(object key)
		{
			throw new NotImplementedException();
		}

		bool IJsonWrapper.GetBoolean()
		{
			throw new NotImplementedException();
		}

		double IJsonWrapper.GetDouble()
		{
			throw new NotImplementedException();
		}

		int IJsonWrapper.GetInt()
		{
			throw new NotImplementedException();
		}

		long IJsonWrapper.GetLong()
		{
			throw new NotImplementedException();
		}

		string IJsonWrapper.GetString()
		{
			throw new NotImplementedException();
		}

		void IJsonWrapper.SetBoolean(bool val)
		{
			throw new NotImplementedException();
		}

		void IJsonWrapper.SetDouble(double val)
		{
			throw new NotImplementedException();
		}

		void IJsonWrapper.SetInt(int val)
		{
			throw new NotImplementedException();
		}

		void IJsonWrapper.SetLong(long val)
		{
			throw new NotImplementedException();
		}

		void IJsonWrapper.SetString(string val)
		{
			throw new NotImplementedException();
		}
	}
}
