# ~~Auth.ApiKey~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~GetJwtFromKey~~](#getjwtfromkey) - Exchange API key for a JWT token :warning: **Deprecated** Use [ExchangeToken](docs/sdks/apikeys/README.md#exchangetoken) instead.

## ~~GetJwtFromKey~~

Exchange an API key for a JWT token

> :warning: **DEPRECATED**: Use auth.apiKeys.exchangeToken() instead. This method will be removed in a future release.. Use `ExchangeToken` instead.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getJwtFromKey" method="post" path="/api/v1/authentication/api-key/exchange-token" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ApiKey.GetJwtFromKeyAsync(body: new GetJwtFromKeyRequestBody() {
    Audience = "https://my-awesome-website.com",
    ExternalUserId = "the-user-id-in-your-system",
    Permissions = new List<string>() {
        "agent:create",
        "agent:read",
    },
});

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Body`                                                                       | [GetJwtFromKeyRequestBody](../../Types/Requests/GetJwtFromKeyRequestBody.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |

### Response

**[GetJwtFromKeyResponse](../../Types/Requests/GetJwtFromKeyResponse.md)**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.GetJwtFromKeyBadRequestException   | 400                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetJwtFromKeyUnauthorizedException | 401                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetJwtFromKeyInternalServerError   | 500                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.APIException                       | 4XX, 5XX                                                     | \*/\*                                                        |