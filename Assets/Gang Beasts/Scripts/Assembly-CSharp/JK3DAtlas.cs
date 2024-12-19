using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class JK3DAtlas : ScriptableObject, ISerializationCallbackReceiver
{
	[Flags]
	public enum MeshAttribute
	{
		Normals = 1,
		Tangents = 2,
		Colors = 4,
		TexCoords = 8,
		TexCoord2s = 0x10
	}

	[Serializable]
	public struct AdditionalTexture
	{
		public string shaderProperty;

		public Texture texture;
	}

	private struct TextureGroup
	{
		public Texture2D albedo;

		public Color vertexColour;

		public Texture2D specularSmoothness;

		public Color specularColor;

		public Texture2D emissive;

		public Texture2D normal;

		public Texture2D mask;

		public TextureGroup(Texture2D _albedo, Color _vertex, Texture2D _specularSmoothness, Color _specular, Texture2D _emissive, Texture2D _normal, Texture2D _mask)
		{
			albedo = null;
			vertexColour = default(Color);
			specularSmoothness = null;
			specularColor = default(Color);
			emissive = null;
			normal = null;
			mask = null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}

	[NonSerialized]
	public static bool ForceJK3DRefNotToSync;

	public bool lightmapBatch;

	[FormerlySerializedAs("renderQueue")]
	public int renderQueueStatic;

	public int renderQueueDynamic;

	public MeshAttribute meshAttributes;

	public List<AdditionalTexture> additionalTextures;

	private const string kAtlasDataFolderName = "AtlasData";

	private const string kAtlasTexturesFolderName = "AtlasTextures";

	[HideInInspector]
	public JK3DAtlas targetMergeAtlas;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
