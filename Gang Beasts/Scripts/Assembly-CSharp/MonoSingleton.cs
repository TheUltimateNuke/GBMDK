using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	protected static T _Instance;

	public static T Instance => null;

	public static T GetInstance(bool logError)
	{
		return null;
	}

	public static bool HasInstance()
	{
		return false;
	}
}
