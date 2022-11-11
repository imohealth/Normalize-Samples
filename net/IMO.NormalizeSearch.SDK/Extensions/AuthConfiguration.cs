using System;
using System.Collections.Generic;
using IMO.NormalizeSearch.SDK.Api;
using IMO.NormalizeSearch.SDK.Client;
using IMO.NormalizeSearch.SDK.Model;

namespace IMO.NormalizeSearch.SDK.Extensions
{
    /// <summary>
    /// Represents a set of configuration settings with support for automatically maintained
    /// token retrieval and refresh.
    /// </summary>
    public class AuthConfiguration : Configuration
    {
        private ITokenRetryApi m_tokenClient;
        private DateTime _tokenExpiryDate;
        private string _token;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConfiguration" /> class
        /// </summary>
        public AuthConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConfiguration" /> class
        /// </summary>
        public AuthConfiguration(
            IDictionary<string, string> defaultHeaders,
            IDictionary<string, string> apiKey,
            IDictionary<string, string> apiKeyPrefix,
            string basePath = "https://api-sandbox.imohealth.com") : base(defaultHeaders, apiKey, apiKeyPrefix, basePath)
        {
        }

        /// <summary>
        /// For testing
        /// </summary>
        /// <param name="tokenClient"></param>
        public AuthConfiguration(ITokenRetryApi tokenClient)
        {
            m_tokenClient = tokenClient;
        }
        #endregion

        /// <summary>
        /// Retrieves access token using OAuth2 Client Credentials flow with
        /// provided <see cref="ClientId"/> and <see cref="ClientSecret"/>
        /// </summary>
        /// <remarks>
        /// Ensures token is refreshed if expired.
        /// </remarks>
        public override string AccessToken
        {
            get
            {
                if (string.IsNullOrEmpty(_token) || DateTime.Now >= _tokenExpiryDate)
                {
                    _token = RefreshToken();
                }

                return _token;
            }
        }

        /// <summary>
        /// Gets or sets the client id for authentication
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret for authentication
        /// </summary>
        public string ClientSecret { get; set; }

        private string RefreshToken()
        {
            if(m_tokenClient == null) m_tokenClient = new TokenApi(BasePath);
            var tokenRequest = new TokenRequest
            {
                Audience = BasePath,
                ClientId = ClientId,
                ClientSecret = ClientSecret,
                GrantType = "client_credentials"
            };
            var response = m_tokenClient.TokenWithRetry(tokenRequest);
            _tokenExpiryDate = DateTime.Now.AddSeconds((double)response.ExpiresIn);
            return response.AccessToken;
        }
    }
}
