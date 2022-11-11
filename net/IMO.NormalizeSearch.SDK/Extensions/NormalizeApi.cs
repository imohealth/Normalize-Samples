using System.Threading.Tasks;
using IMO.NormalizeSearch.SDK.Extensions;
using IMO.NormalizeSearch.SDK.Model;

namespace IMO.NormalizeSearch.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints with configurable retry logic
    /// </summary>
    public interface INormalizeRetryApiSync
    {
        #region Synchronous Operations

        /// <summary>
        /// Normalize a set of input terms and codes to IMO lexicals
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="normalizeRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>NormalizeResponse</returns>
        NormalizeResponse NormalizeWithRetry(NormalizeRequest normalizeRequest = default(NormalizeRequest), int numRetries = 2);

        #endregion
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints with configurable retry logic
    /// </summary>
    public interface INormalizeRetryApiAsync
    {
        #region Asynchronous Operations
        /// <summary>
        /// Normalize a set of input terms and codes to IMO lexicals
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="normalizeRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>Task of NormalizeResponse</returns>
        System.Threading.Tasks.Task<NormalizeResponse> NormalizeWithRetryAsync(NormalizeRequest normalizeRequest = default(NormalizeRequest), int numRetries = 2);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints with configurable retry logic
    /// </summary>
    public interface INormalizeRetryApi : INormalizeRetryApiSync, INormalizeRetryApiAsync, INormalizeApi
    {

    }

    public partial class NormalizeApi : INormalizeRetryApi
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizeApi"/> class
        /// using an <see cref="AuthConfiguration"/> object
        /// </summary>
        /// <remarks>
        /// Use this constructor for automated token retrieval and refresh support.
        /// </remarks>
        /// <param name="configuration">An instance of <see cref="AuthConfiguration"/></param>
        /// <returns></returns>
        public NormalizeApi(AuthConfiguration configuration) : this((Client.Configuration) configuration)
        {
        }

        /// <summary>
        /// Normalize a set of input terms and codes to IMO lexicals
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="normalizeRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>NormalizeResponse</returns>
        public NormalizeResponse NormalizeWithRetry(NormalizeRequest normalizeRequest = default(NormalizeRequest), int numRetries = 2)
        {
            return ApiRetryPolicy.DefaultPolicy(numRetries).Execute(() => Normalize(normalizeRequest));
        }

        /// <summary>
        /// Normalize a set of input terms and codes to IMO lexicals
        /// </summary>
        /// <remarks>
        /// Will automatically perform back off and retry logic for any 4xx or 5xx errors.
        /// </remarks>
        /// <exception cref="IMO.NormalizeSearch.SDK.Client.ApiException">Thrown when fails to make API call after numRetries attempts</exception>
        /// <param name="normalizeRequest"> (optional)</param>
        /// <param name="numRetries"></param>
        /// <returns>Task of NormalizeResponse</returns>
        public async Task<NormalizeResponse> NormalizeWithRetryAsync(NormalizeRequest normalizeRequest = default(NormalizeRequest), int numRetries = 2)
        {
            return await ApiRetryPolicy.DefaultPolicyAsync(numRetries).ExecuteAsync(async () => await NormalizeAsync(normalizeRequest));
        }
    }
}
