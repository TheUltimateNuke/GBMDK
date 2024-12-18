using UnityEngine;

namespace CoreNet.Pooling
{
	public interface IPooledItem
	{
		bool Pooled { get; }

		event RepoolHandler OnRepool;

		GameObject GetGameObject();

		void OnSpawn();

		void Repool();

		void SetNamePrefix(string prefix);

		void PostSpawn();
	}
}
