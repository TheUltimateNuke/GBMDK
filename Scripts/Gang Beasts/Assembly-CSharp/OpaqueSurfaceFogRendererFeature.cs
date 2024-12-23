using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class OpaqueSurfaceFogRendererFeature : ScriptableRendererFeature
{
	[Serializable]
	public struct OpaqueSurfaceFogSettings
	{
		[ColorUsage(false, true)]
		public Color skyColor;

		[ColorUsage(false, true)]
		public Color fogColor;

		[Range(0f, 1f)]
		public float fogLightScatterIntensity;

		[Min(0.001f)]
		public float skyFogMaxDepth;

		[Min(0.001f)]
		public float skyFogElevation;

		[Min(0.001f)]
		public float groundFogMaxDepth;

		public float groundFogElevation;
	}

	private class OpaqueSurfaceFogRenderPass : ScriptableRenderPass
	{
		private readonly string profilerTag;

		private Material blitMaterial;

		private readonly int idViewDirBL;

		private readonly int idViewDirBR;

		private readonly int idViewDirTL;

		private readonly int idViewDirTR;

		private RenderTargetIdentifier Source { get; set; }

		public OpaqueSurfaceFogRenderPass(string profilerTag)
		{
		}

		public void Setup(RenderTargetIdentifier source)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public void InitializeBlitMaterial(Shader blitShader)
		{
		}

		private void UpdateGlobalShaderProperties(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private Vector3 GetWorldViewDirection(float horizontalClipPos, float verticalClipPos, Matrix4x4 inverseVPMatrix, Vector3 cameraWorldPosition, float cameraFarPlaneDistance)
		{
			return default(Vector3);
		}
	}

	private const string ShaderName = "Hidden/GangBeasts/OpaqueSurfaceFog";

	private readonly int idSkyColor;

	private readonly int idFogColor;

	private readonly int idFogLightScatterIntensity;

	private readonly int idSkyFogMaxDepth;

	private readonly int idSkyFogElevation;

	private readonly int idGroundFogMaxDepth;

	private readonly int idGroundFogElevation;

	[SerializeField]
	private OpaqueSurfaceFogSettings opaqueFogSettings;

	[SerializeField]
	private Shader opaqueFogShader;

	private OpaqueSurfaceFogRenderPass renderPass;

	public void UpdateSettings(OpaqueSurfaceFogSettings settings)
	{
	}

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	private void InitializeRenderPassBlitMaterial()
	{
	}

	private void OnValidate()
	{
	}

	private void UpdateGlobalShaderProperties()
	{
	}
}
