using System;
using IMO.NormalizeSearch.SDK.Client;
using Polly;

namespace IMO.NormalizeSearch.SDK.Extensions
{
    /// <summary>
    /// Class for retry policies related to api requests
    /// </summary>
    public static class ApiRetryPolicy
    {
        /// <summary>
        /// Default retry policy for <see cref="ApiException"/>
        /// </summary>
        /// <remarks>Executes a wait and retry with exponential back off (starting at 250ms)</remarks>
        /// <param name="numRetries"></param>
        /// <returns></returns>
        public static Polly.Retry.RetryPolicy DefaultPolicy(int numRetries = 2)
        {
            return Policy.Handle<ApiException>()
                .WaitAndRetry(
                    numRetries,
                    retryAttempt => TimeSpan.FromMilliseconds(Math.Pow(2, retryAttempt) * 250));
        }

        /// <summary>
        /// Default retry policy for <see cref="ApiException"/>
        /// </summary>
        /// <remarks>Executes a wait and retry with exponential back off (starting at 250ms)</remarks>
        /// <param name="numRetries"></param>
        /// <returns></returns>
        public static Polly.Retry.AsyncRetryPolicy DefaultPolicyAsync(int numRetries = 2)
        {
            return Policy.Handle<ApiException>()
                .WaitAndRetryAsync(
                    numRetries,
                    retryAttempt => TimeSpan.FromMilliseconds(Math.Pow(2, retryAttempt) * 250));
        }
    }
}
