using Costumes;
using Femur;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetCostume : MessageBase
	{
		public int Version;

		public string Name;

		public Actor.Voice Voice;

		public NetCostumeCloudData CloudData;

		public NetCostumeArticle[] NetCostumeArticles;

		public NetCostume()
		{
		}

		public NetCostume(CostumeSaveEntry entry)
		{
		}

		public CostumeSaveEntry ExtractCostumeEntry()
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
}
