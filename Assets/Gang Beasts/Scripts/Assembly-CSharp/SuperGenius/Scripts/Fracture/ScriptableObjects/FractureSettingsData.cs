using System;
using SuperGenius.Lib.Burst.Easing;
using SuperGenius.Scripts.Audio.ScriptableObjects;
using SuperGenius.Scripts.Fracture.Utilities;
using UnityEngine;

namespace SuperGenius.Scripts.Fracture.ScriptableObjects
{
	[Serializable]
	public class FractureSettingsData
	{
		public float Health;

		public float MinShardSize;

		public float MaxShardSize;

		[Tooltip("Useful if you want the shard sizes to be less uniform in size.")]
		public EaseFuctions.EaseType ShardSizeDistributionEase;

		public int MaxShards;

		public bool TransferRigidbodyVelocity;

		public bool UseBreakEffect;

		public SoundEffectScriptable SoundEffectScriptable;

		public GameObject FractureShardPrefab;

		public ShardCollider ShardCollider;

		public bool AddJoints;

		public ShardJoint ShardJoint;

		public bool ConnectToNearbyEdges;

		public NearbyEdgeConnectionType NearbyEdgeConnectionType;

		public bool UseShardJointForConnectedEdges;

		public ShardJoint EdgeShardJoint;

		[Tooltip("The material index for the newly created cut faces.")]
		public int CutMaterialIndex;

		public bool OverrideCutMaterial;

		public Material CutMaterial;

		public bool OverrideShardMaterials;

		public Material[] OverrideMaterials;
	}
}
