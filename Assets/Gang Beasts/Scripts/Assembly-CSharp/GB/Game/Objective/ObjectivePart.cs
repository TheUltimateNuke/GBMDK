using System;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Game.Objective
{
	public class ObjectivePart : MonoBehaviour
	{
		[SerializeField]
		protected bool _needsHost;

		[SerializeField]
		protected bool _retractable;

		public Func<NetBeast, ObjectivePart, bool> OnAchieved;

		public Func<NetBeast, ObjectivePart, bool> OnRetracted;

		public Func<NetBeast, ObjectivePart, bool> UptoCheck;

		[SerializeField]
		protected UnityEvent _onComplete;

		[SerializeField]
		protected UnityEvent _onRetract;

		public virtual bool Active => false;

		private void OnEnable()
		{
		}

		public virtual void OnComplete(NetBeast other)
		{
		}

		public virtual void OnRetract(NetBeast other)
		{
		}
	}
}
