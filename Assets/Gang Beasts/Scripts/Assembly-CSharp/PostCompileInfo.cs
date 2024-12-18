using System;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

[Serializable]
public class PostCompileInfo : NetObject
{
	public static readonly string FILE_NAME;

	[SerializeField]
	public string _gitBranch;

	[SerializeField]
	public string _gitHash;

	[SerializeField]
	public string _buildDate;

	[SerializeField]
	public double _netVersion;

	public static PostCompileInfo _instance;

	public static string GitBranch => null;

	public static string GitHash => null;

	public static string BuildDate => null;

	public static double NetVersion => 0.0;

	public void Set(string branch, string hash, string date, double netversion)
	{
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public bool Equals(PostCompileInfo compileInfo, bool ignoreDate)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public override void Serialize(NetworkWriter writer)
	{
	}

	public override void Deserialize(NetworkReader reader)
	{
	}
}
