# Session

## Overview

### Available Operations

* [GetPendingInvitation](#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
* [ExchangeSessionToken](#exchangesessiontoken) - Exchange a live session for a delegated access token

## GetPendingInvitation

Requires a session with a verified email. Returns a pending, unexpired organization invitation first, otherwise an unclaimed, unexpired cluster invitation bound to that email. Open cluster invitations are never returned. Does not accept or modify the invitation.

### Example Usage

<!-- UsageSnippet language="go" operationID="getPendingInvitation" method="get" path="/api/v1/authentication/pending-invitation" -->
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

    s := mka1.New()

    res, err := s.Session.GetPendingInvitation(ctx, operations.GetPendingInvitationSecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        switch res.Object.Invitation.Type {
            case operations.InvitationTypeOrganization:
                // res.Object.Invitation.InvitationOrganization is populated
            case operations.InvitationTypeCluster:
                // res.Object.Invitation.InvitationCluster is populated
            default:
                // Unknown type - use res.Object.Invitation.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `security`                                                                                         | [operations.GetPendingInvitationSecurity](../../models/operations/getpendinginvitationsecurity.md) | :heavy_check_mark:                                                                                 | The security requirements to use for the request.                                                  |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.GetPendingInvitationResponse](../../models/operations/getpendinginvitationresponse.md), error**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| apierrors.GetPendingInvitationUnauthorizedError | 401                                             | application/json                                |
| apierrors.GetPendingInvitationForbiddenError    | 403                                             | application/json                                |
| apierrors.APIError                              | 4XX, 5XX                                        | \*/\*                                           |

## ExchangeSessionToken

Mints a short-lived, audience-bound token with the same authority as the current live browser or device-login session. Identity, tenancy, permissions, and lifetime cannot be selected by the caller. The JSON body is limited to 4 KiB.

### Example Usage

<!-- UsageSnippet language="go" operationID="exchangeSessionToken" method="post" path="/api/v1/authentication/session/exchange-token" -->
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

    s := mka1.New()

    res, err := s.Session.ExchangeSessionToken(ctx, operations.ExchangeSessionTokenSecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
    }, operations.ExchangeSessionTokenRequestBody{
        Audience: "https://apigw.mka1.com",
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

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `security`                                                                                               | [operations.ExchangeSessionTokenSecurity](../../models/operations/exchangesessiontokensecurity.md)       | :heavy_check_mark:                                                                                       | The security requirements to use for the request.                                                        |
| `body`                                                                                                   | [operations.ExchangeSessionTokenRequestBody](../../models/operations/exchangesessiontokenrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.ExchangeSessionTokenResponse](../../models/operations/exchangesessiontokenresponse.md), error**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| apierrors.ExchangeSessionTokenBadRequestError            | 400                                                      | application/json                                         |
| apierrors.ExchangeSessionTokenUnauthorizedError          | 401                                                      | application/json                                         |
| apierrors.ExchangeSessionTokenForbiddenError             | 403                                                      | application/json                                         |
| apierrors.ExchangeSessionTokenRequestEntityTooLargeError | 413                                                      | application/json                                         |
| apierrors.ExchangeSessionTokenTooManyRequestsError       | 429                                                      | application/json                                         |
| apierrors.ExchangeSessionTokenInternalServerError        | 500                                                      | application/json                                         |
| apierrors.APIError                                       | 4XX, 5XX                                                 | \*/\*                                                    |