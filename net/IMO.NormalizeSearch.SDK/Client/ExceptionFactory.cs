/* 
 * IMO® Precision Normalize API
 *
 * <p>IMO® Precision Normalize provides normalization capabilities enabling standardization of inconsistent clinical data from diverse health information systems to a common, clinically validated terminology to ensure that problems, procedures, and medications have clean, enriched, and consistent meanings. This API normalizes input terms or codes to IMO identifiers.</p> <p>The information provided is confidential and proprietary. Any use of this outside an agreement or engagement with IMO is prohibited.</p>
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: customersupport@imo-online.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace IMO.NormalizeSearch.SDK.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}