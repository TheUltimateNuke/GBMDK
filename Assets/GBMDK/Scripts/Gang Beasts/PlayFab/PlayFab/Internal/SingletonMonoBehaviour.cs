using UnityEngine;

namespace PlayFab.Internal
{
	public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
	{
		private static T _instance;

		protected bool initialized;

		public static T instance => null;

		public static void CreateInstance()
		{
		}

		public virtual void Awake()
		{
		}

		protected virtual void Initialize()
		{
		}
	}
}
