# ~~Auth.ApiKey~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~get_jwt_from_key~~](#get_jwt_from_key) - Exchange API key for a JWT token :warning: **Deprecated** Use [exchange_token](docs/sdks/apikeys/README.md#exchange_token) instead.

## ~~get_jwt_from_key~~

Exchange an API key for a JWT token

> :warning: **DEPRECATED**: Use auth.apiKeys.exchangeToken() instead. This method will be removed in a future release.. Use `exchange_token` instead.

### Example Usage

<!-- UsageSnippet language="python" operationID="getJwtFromKey" method="post" path="/api/v1/authentication/api-key/exchange-token" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.api_key.get_jwt_from_key(audience="https://my-awesome-website.com", external_user_id="the-user-id-in-your-system", expires_in=3600.0, permissions=[
        "agent:create",
        "agent:read",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `audience`                                                                                                                                                                                                                      | *str*                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                              | JWT audience (aud) claim for the exchanged token. Set this to the target API/service URL that should accept the token.                                                                                                          |
| `external_user_id`                                                                                                                                                                                                              | *str*                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                              | Your external user identifier to place in the JWT subject (sub) claim. Must be 1–150 printable-ASCII characters and not the wildcard `*`.                                                                                       |
| `x_on_behalf_of`                                                                                                                                                                                                                | *Optional[str]*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                             |
| `expires_in`                                                                                                                                                                                                                    | *Optional[float]*                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                              | Token lifetime in seconds. Must be between 300 (5 minutes) and 2592000 (30 days). Defaults to 3600 (1 hour).                                                                                                                    |
| `permissions`                                                                                                                                                                                                                   | List[*str*]                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                              | Optional subset of the API key's scopes to embed in the token (e.g. read:responses). The exchanged token is attenuated to this set at the gateway perimeter. If omitted, all of the key's scopes are embedded (no attenuation). |
| `retries`                                                                                                                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                              | Configuration to override the default retry behavior of the client.                                                                                                                                                             |

### Response

**[models.GetJwtFromKeyResponse](../../models/getjwtfromkeyresponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| errors.GetJwtFromKeyBadRequestError     | 400                                     | application/json                        |
| errors.GetJwtFromKeyUnauthorizedError   | 401                                     | application/json                        |
| errors.GetJwtFromKeyInternalServerError | 500                                     | application/json                        |
| errors.SDKDefaultError                  | 4XX, 5XX                                | \*/\*                                   |