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

<!-- UsageSnippet language="go" operationID="getJwtFromKey" method="post" path="/api/v1/authentication/api-key/exchange-token" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Auth.APIKey.GetJwtFromKey(ctx, operations.GetJwtFromKeyRequestBody{
        Audience: "https://my-awesome-website.com",
        ExternalUserID: "the-user-id-in-your-system",
        Permissions: []string{
            "agent:create",
            "agent:read",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `body`                                                                                     | [operations.GetJwtFromKeyRequestBody](../../models/operations/getjwtfromkeyrequestbody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.GetJwtFromKeyResponse](../../models/operations/getjwtfromkeyresponse.md), error**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| apierrors.GetJwtFromKeyBadRequestError     | 400                                        | application/json                           |
| apierrors.GetJwtFromKeyUnauthorizedError   | 401                                        | application/json                           |
| apierrors.GetJwtFromKeyInternalServerError | 500                                        | application/json                           |
| apierrors.APIError                         | 4XX, 5XX                                   | \*/\*                                      |