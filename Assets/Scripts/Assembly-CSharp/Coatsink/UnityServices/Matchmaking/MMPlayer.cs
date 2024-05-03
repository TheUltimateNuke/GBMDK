using System.Collections.Generic;
using Unity.Services.Matchmaker.Models;

namespace Coatsink.UnityServices.Matchmaking
{
	public class MMPlayer
	{
		public string Id;

		public object CustomData;

		public List<QosResult> QosResults;

		public MMPlayer(string id, object customData = null, List<QosResult> qosResults = null)
		{
		}
	}
}
