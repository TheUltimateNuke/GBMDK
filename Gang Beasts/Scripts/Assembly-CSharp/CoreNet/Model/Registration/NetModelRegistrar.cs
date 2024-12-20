using CoreNet.Objects;
using UnityEngine;

namespace CoreNet.Model.Registration
{
	[RequireComponent(typeof(NetModel))]
	public abstract class NetModelRegistrar : MonoBehaviour
	{
		private NetModel _Model;

		public void Awake()
		{
		}

		protected void RegisterItem<T>(short code = -1) where T : NetObject, new()
		{
		}

		protected void RegisterCollection<T>(short code = -1) where T : NetObject, new()
		{
		}

		protected abstract void Registration();
	}
}
