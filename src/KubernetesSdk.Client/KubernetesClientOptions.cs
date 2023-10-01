using System;
using System.Security.Cryptography.X509Certificates;
using Kubernetes.Client.Authentication;

namespace Kubernetes.Client
{
    /// <summary>
    ///     Represents a set of kubernetes client configuration settings
    /// </summary>
    public class KubernetesClientOptions
    {
        /// <summary>
        ///     Gets current namespace
        /// </summary>
        public string? Namespace { get; set; }

        /// <summary>
        ///     Gets Host
        /// </summary>
        public string? Host { get; set; }

        /// <summary>
        ///     Gets SslCaCerts
        /// </summary>
        public X509Certificate2Collection? SslCaCerts { get; set; }

        /// <summary>
        ///     Gets ClientCertificateData
        /// </summary>
        public string? ClientCertificateData { get; set; }

        /// <summary>
        ///     Gets ClientCertificate Key
        /// </summary>
        public string? ClientCertificateKeyData { get; set; }

        /// <summary>
        ///     Gets ClientCertificate filename
        /// </summary>
        public string? ClientCertificateFilePath { get; set; }

        /// <summary>
        ///     Gets or sets the ClientCertificate KeyStoreFlags to specify where and how to import the certificate private key
        /// </summary>
        public X509KeyStorageFlags? ClientCertificateKeyStoreFlags { get; set; }

        /// <summary>
        ///     Gets ClientCertificate Key filename
        /// </summary>
        public string? ClientKeyFilePath { get; set; }

        /// <summary>
        ///     Gets a value indicating whether to skip ssl server cert validation
        /// </summary>
        public bool SkipTlsVerify { get; set; }

        /// <summary>
        ///     Option to override the TLS server name
        /// </summary>
        public string? TlsServerName { get; set; }

        /// <summary>
        ///     Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public string? UserAgent { get; set; }

        /// <summary>
        ///     Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public string? Username { get; set; }

        /// <summary>
        ///     Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public string? Password { get; set; }

        /// <summary>
        ///     Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public string? AccessToken { get; set; }

        /// <summary>
        ///     Gets or sets the TokenProvider for authentication.
        /// </summary>
        /// <value>The access token.</value>
        public ITokenProvider? TokenProvider { get; set; }

        /// <summary>
        ///     Timeout of REST calls to Kubernetes server
        ///     Does not apply to watch related api
        /// </summary>
        /// <value>timeout</value>
        public TimeSpan HttpClientTimeout { get; set; } = TimeSpan.FromSeconds(100);

        /// <summary>
        /// Do not use http2 even it is available
        /// </summary>
        public bool DisableHttp2 { get; set; } = false;
    }
}