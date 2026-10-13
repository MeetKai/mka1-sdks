# Session

## Overview

### Available Operations

* [GetPendingInvitation](#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
* [ExchangeSessionToken](#exchangesessiontoken) - Exchange a live session for a delegated access token

## GetPendingInvitation

Requires a session with a verified email. Returns a pending, unexpired organization invitation first, otherwise an unclaimed, unexpired cluster invitation bound to that email. Open cluster invitations are never returned. Does not accept or modify the invitation.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPendingInvitation" method="get" path="/api/v1/authentication/pending-invitation" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK();

var res = await sdk.Session.GetPendingInvitationAsync(security: new GetPendingInvitationSecurity() {
    SessionCookie = "<YOUR_API_KEY_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `security`                                                                           | [GetPendingInvitationSecurity](../../Types/Requests/GetPendingInvitationSecurity.md) | :heavy_check_mark:                                                                   | The security requirements to use for the request.                                    |
| `XOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |

### Response

**[GetPendingInvitationResponse](../../Types/Requests/GetPendingInvitationResponse.md)**

### Errors

| Error Type                                                          | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetPendingInvitationUnauthorizedException | 401                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.GetPendingInvitationForbiddenException    | 403                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.APIException                              | 4XX, 5XX                                                            | \*/\*                                                               |

## ExchangeSessionToken

Mints a short-lived, audience-bound token with the same authority as the current live browser or device-login session. Identity, tenancy, permissions, and lifetime cannot be selected by the caller. The JSON body is limited to 4 KiB.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="exchangeSessionToken" method="post" path="/api/v1/authentication/session/exchange-token" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK();

var res = await sdk.Session.ExchangeSessionTokenAsync(
    security: new ExchangeSessionTokenSecurity() {
        SessionCookie = "<YOUR_API_KEY_HERE>",
    },
    body: new ExchangeSessionTokenRequestBody() {
        Audience = "https://apigw.mka1.com",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `security`                                                                                 | [ExchangeSessionTokenSecurity](../../Types/Requests/ExchangeSessionTokenSecurity.md)       | :heavy_check_mark:                                                                         | The security requirements to use for the request.                                          |
| `Body`                                                                                     | [ExchangeSessionTokenRequestBody](../../Types/Requests/ExchangeSessionTokenRequestBody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `XOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |

### Response

**[ExchangeSessionTokenResponse](../../Types/Requests/ExchangeSessionTokenResponse.md)**

### Errors

| Error Type                                                                   | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ExchangeSessionTokenBadRequestException            | 400                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.ExchangeSessionTokenUnauthorizedException          | 401                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.ExchangeSessionTokenForbiddenException             | 403                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.ExchangeSessionTokenRequestEntityTooLargeException | 413                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.ExchangeSessionTokenTooManyRequestsException       | 429                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.ExchangeSessionTokenInternalServerError            | 500                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.APIException                                       | 4XX, 5XX                                                                     | \*/\*                                                                        |