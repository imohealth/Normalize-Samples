using System.Threading.Tasks;
using IMO.NormalizeSearch.SDK.Extensions;
using IMO.NormalizeSearch.SDK.Model;

namespace IMO.NormalizeSearch.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints with configurable retry logic
    /// </summary>
    public interface ITokenRetryApiSync
    {
        #region Synchronous Operations

        /// <summary>
        /// Retrieve token for authentication using client credentials OAuth flow
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="tokenRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>TokenResponse</returns>
        TokenResponse TokenWithRetry(TokenRequest tokenRequest = default(TokenRequest), int numRetries = 2);

        #endregion
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints with configurable retry logic
    /// </summary>
    public interface ITokenRetryApiAsync
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve token for authentication using client credentials OAuth flow
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="tokenRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>Task of TokenResponse</returns>
        System.Threading.Tasks.Task<TokenResponse> TokenWithRetryAsync(TokenRequest tokenRequest = default(TokenRequest), int numRetries = 2);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints with configurable retry logic
    /// </summary>
    public interface ITokenRetryApi : ITokenRetryApiSync, ITokenRetryApiAsync, ITokenApi
    {

    }

    public partial class TokenApi : ITokenRetryApi
    {
        /// <summary>
        /// Retrieve token for authentication using client credentials OAuth flow
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="tokenRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>TokenResponse</returns>
        public TokenResponse TokenWithRetry(TokenRequest tokenRequest = default(TokenRequest), int numRetries = 2)
        {
            return ApiRetryPolicy.DefaultPolicy(numRetries).Execute(() => Token(tokenRequest));
        }

        /// <summary>
        /// Retrieve token for authentication using client credentials OAuth flow
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="tokenRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>Task of TokenResponse</returns>
        public async Task<TokenResponse> TokenWithRetryAsync(TokenRequest tokenRequest = default(TokenRequest), int numRetries = 2)
        {
            return await ApiRetryPolicy.DefaultPolicyAsync(numRetries).ExecuteAsync(async () => await TokenAsync(tokenRequest));
        }
    }
}
