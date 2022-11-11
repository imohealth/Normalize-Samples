# IMO.NormalizeSearch.SDK - the C# library for the IMO® Precision Normalize API

<p>IMO® Precision Normalize provides normalization capabilities enabling standardization of inconsistent clinical data from diverse health information systems to a common, clinically validated terminology to ensure that problems, procedures, and medications have clean, enriched, and consistent meanings. This API normalizes input terms or codes to IMO identifiers.</p> <p>The information provided is confidential and proprietary. Any use of this outside an agreement or engagement with IMO is prohibited.</p>

This sample provides examples for authenticating against and issuing normalization requests to the IMO Precision Normalize API

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using IMO.NormalizeSearch.SDK.Api;
using IMO.NormalizeSearch.SDK.Client;
using IMO.NormalizeSearch.SDK.Model;
using IMO.NormalizeSearch.SDK.Extensions;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            AuthConfiguration config = new AuthConfiguration();
            config.BasePath = "https://api.imohealth.com";
            config.ClientId = "YOUR_CLIENT_ID";
            config.ClientSecret = "YOUR_CLIENT_SECRET";

            var apiInstance = new NormalizeApi(config);
            var normalizeRequest = new NormalizeRequest(); // NormalizeRequest |  (optional) 

            try
            {
                // Normalize a set of input terms and codes to IMO lexicals
                NormalizeResponse result = apiInstance.Normalize(normalizeRequest);
                Debug.WriteLine(result);
                
                // Include automatic back off and retry logic around errors
                NormalizeResponse result = apiInstance.NormalizeWithRetry(normalizeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NormalizeApi.Normalize: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```
