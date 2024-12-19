using System;
using Femur;
using UnityEngine;

namespace GB.UI.Beasts
{
	public class BeastMenuSpawner : MonoBehaviour
	{
		private class ActorHolder
		{
			public Actor beast;

			public bool locked;
		}

		public Action<int, Actor> OnBeastGenerated;

		[SerializeField]
		private Transform[] _spawnPoint;

		[SerializeField]
		private Transform _beastParent;

		private bool _isReady;

		private ActorHolder[] _actorHolders;

		public int TotalPoints => 0;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		private Actor GenBeastFor(int point)
		{
			return null;
		}

		public Actor GetActor(int point)
		{
			return null;
		}

		public bool GetLock(int point)
		{
			return false;
		}

		public void SetLock(int point, bool locked)
		{
		}

		public int SetPointFor(Actor point)
		{
			return 0;
		}

		public int GetFirstFreePoint()
		{
			return 0;
		}
	}
}
