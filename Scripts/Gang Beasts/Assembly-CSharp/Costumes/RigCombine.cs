using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	public class RigCombine
	{
		[Serializable]
		public class CombinedObject
		{
			public GameObject[] MeshGameObjects;

			public GameObject[] AddedGamobjects;

			public CombinedObject(GameObject[] meshGameObjects, GameObject[] addedGamobjects)
			{
			}

			public void SetActive(bool active)
			{
			}
		}

		public string CollapseJointGOName;

		public bool CombineDuplicates;

		private GameObject _parentSkinnedMeshRendererGo;

		private List<GameObject> childRootGamobjects;

		private GameObject[] _childMeshObjectArray;

		private SkinnedMeshRenderer _parentSkinnedMeshRenderer;

		private bool _reConnectConfigruableJoints;

		private bool _collapseJoins;

		private bool _disableBreakableJoints;

		private Transform _collapseTarget;

		private List<GameObject> addedGameObjects;

		private bool _foundViaName;

		public CombinedObject CombineGameObjects(GameObject parentSkinnedMeshRendererGo, GameObject[] childPrefabGameObjects)
		{
			return null;
		}

		public CombinedObject CombineGameObjects(GameObject parentSkinnedMeshRendererGo, GameObject[] childPrefabGameObjects, bool reConnectConfigruableJoints)
		{
			return null;
		}

		public CombinedObject CombineGameObjects(GameObject parentSkinnedMeshRendererGo, GameObject[] childPrefabGameObjects, bool reConnectConfigruableJoints, bool collapseJoins)
		{
			return null;
		}

		public CombinedObject CombineGameObjects(GameObject parentSkinnedMeshRendererGo, GameObject[] childPrefabGameObjects, bool reConnectConfigruableJoints, bool collapseJoins, bool disableBreakableJoints)
		{
			return null;
		}

		public CombinedObject CombineGameObjects(GameObject parentSkinnedMeshRendererGo, GameObject[] childPrefabGameObjects, bool reConnectConfigruableJoints, bool collapseJoins, Transform collapseTarget)
		{
			return null;
		}

		private GameObject[] InstGameOjbects(GameObject[] childPrefabGameObjects)
		{
			return null;
		}

		private GameObject[] Combine()
		{
			return null;
		}

		private GameObject[] AttachBones(SkinnedMeshRenderer smr, Transform parentRoot)
		{
			return null;
		}

		private void TotallyHackyNetworkCapeFix(Transform child)
		{
		}

		private Transform FindTransformInBones(Transform trans, string transformName)
		{
			return null;
		}

		private Transform FindTransformViaName(Transform trans, string transformName)
		{
			return null;
		}

		private Transform ParentRequiredBones(Transform bone)
		{
			return null;
		}

		private void AttachBonelessMeshRenderer(GameObject childMeshRenderersGo, Transform parentRoot)
		{
		}

		private void ReAttachJoints(Transform[] transforms, Transform parentRoot)
		{
		}

		private void ReAttachJoints(Transform jointTransform, Transform parentRoot)
		{
		}

		private void ReAttachJoint(Joint joint, Transform parentRoot)
		{
		}

		private void CollapsJoint(Joint joint)
		{
		}

		private void CollapsJointsInChildren(Transform joint, Transform target)
		{
		}

		private Transform FindTopLvlRigibody(Transform transform)
		{
			return null;
		}

		private GameObject[] AddedChildern(GameObject child)
		{
			return null;
		}
	}
}
