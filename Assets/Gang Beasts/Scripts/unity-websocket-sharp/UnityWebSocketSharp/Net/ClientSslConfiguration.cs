using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace UnityWebSocketSharp.Net
{
	internal class ClientSslConfiguration
	{
		private bool _checkCertRevocation;

		private LocalCertificateSelectionCallback _clientCertSelectionCallback;

		private X509CertificateCollection _clientCerts;

		private SslProtocols _enabledSslProtocols;

		private RemoteCertificateValidationCallback _serverCertValidationCallback;

		private string _targetHost;

		public bool CheckCertificateRevocation => false;

		public X509CertificateCollection ClientCertificates => null;

		public LocalCertificateSelectionCallback ClientCertificateSelectionCallback => null;

		public SslProtocols EnabledSslProtocols
		{
			get
			{
				return default(SslProtocols);
			}
			set
			{
			}
		}

		public RemoteCertificateValidationCallback ServerCertificateValidationCallback => null;

		public string TargetHost => null;

		public ClientSslConfiguration(string targetHost)
		{
		}

		private static X509Certificate defaultSelectClientCertificate(object sender, string targetHost, X509CertificateCollection clientCertificates, X509Certificate serverCertificate, string[] acceptableIssuers)
		{
			return null;
		}

		private static bool defaultValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return false;
		}
	}
}
