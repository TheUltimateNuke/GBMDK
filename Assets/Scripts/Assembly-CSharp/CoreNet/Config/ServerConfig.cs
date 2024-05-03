using Newtonsoft.Json;

namespace CoreNet.Config
{
	public class ServerConfig
	{
		[JsonProperty("ip")]
		public string Ip;

		[JsonProperty("port")]
		public int ServerPort;

		[JsonProperty("password")]
		public string Password;

		[JsonProperty("server_name")]
		public string ServerName;

		[JsonProperty("public")]
		public bool Public;
	}
}
