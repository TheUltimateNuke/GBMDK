using System;
using System.Reflection;

namespace Coatsink.Common
{
	public static class ReflectionX
	{
		public static FieldInfo[] GetPublicInstFields(this object obj)
		{
			return null;
		}

		public static bool IsSubclassOfRawGeneric(this Type type, Type rawGenericType)
		{
			return false;
		}

		public static bool HasAttr<T>(this MemberInfo element, bool inherit = false) where T : Attribute
		{
			return false;
		}

		public static T GetAttr<T>(this MemberInfo element, bool inherit = false) where T : Attribute
		{
			return null;
		}

		public static bool IsBacking(this FieldInfo field)
		{
			return false;
		}

		public static PropertyInfo GetBackedProperty(this FieldInfo field)
		{
			return null;
		}

		public static int PrimitiveSize(this Type type)
		{
			return 0;
		}
	}
}
