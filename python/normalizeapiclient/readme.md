# normalizeapiclient - the python library for the IMO® Precision Normalize API

<p>IMO® Precision Normalize provides normalization capabilities enabling standardization of inconsistent clinical data from diverse health information systems to a common, clinically validated terminology to ensure that problems, procedures, and medications have clean, enriched, and consistent meanings. This API normalizes input terms or codes to IMO identifiers.</p> <p>The information provided is confidential and proprietary. Any use of this outside an agreement or engagement with IMO is prohibited.</p>

This sample provides examples for authenticating against and issuing normalization requests to the IMO Precision Normalize API

<a name="getting-started"></a>
## Getting Started

```python
import normalizeapiclient
from normalizeapiclient.api import normalize_api, token_api
from normalizeapiclient.model.token_request import TokenRequest
from normalizeapiclient.model.token_response import TokenResponse

class Example:
  def __init__(self):
    configuration = normalizeapiclient.Configuration(host=base_endpoint)
      
  def handler(self):
    with normalizeapiclient.ApiClient(configuration) as api_client:
        token_api_instance = token_api.TokenApi(api_client)
        token_request = TokenRequest(
            grant_type = "client_credentials",
            client_id = "YOUR_CLIENT_ID",
            client_secret = "YOUR_CLIENT_SECRET",
            audience = "https://api.imohealth.com"
        )
        token_response: TokenResponse = token_api_instance.token(token_request=token_request)
        api_client.configuration.access_token = token_response["access_token"]

        normalize_api_instance = normalize_api.NormalizeApi(api_client)
          
        request = NormalizeRequestRequestsInner(
                record_id = "record_id_for_tracking_individual_records",
                input_term = "YOUR_INPUT_TERM",
                domain = "problem"
            )
        if context is not None:
            request.set_attribute("context", context)

        payload = NormalizeRequest(
            client_request_id = "unique_id_for_tracking_request",
            preferences = NormalizeRequestPreferences(match_field_pref="input_term"),
            requests = [request]
        )

        return normalize_api_instance.normalize(normalize_request=payload)
```
