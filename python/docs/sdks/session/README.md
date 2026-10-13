# Session

## Overview

### Available Operations

* [get_pending_invitation](#get_pending_invitation) - Find an unfinished invitation for the signed-in recipient
* [exchange_session_token](#exchange_session_token) - Exchange a live session for a delegated access token

## get_pending_invitation

Requires a session with a verified email. Returns a pending, unexpired organization invitation first, otherwise an unclaimed, unexpired cluster invitation bound to that email. Open cluster invitations are never returned. Does not accept or modify the invitation.

### Example Usage

<!-- UsageSnippet language="python" operationID="getPendingInvitation" method="get" path="/api/v1/authentication/pending-invitation" -->
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.session.get_pending_invitation(security=models.GetPendingInvitationSecurity(
        session_cookie="<YOUR_API_KEY_HERE>",
    ))

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `security`                                                                          | [models.GetPendingInvitationSecurity](../../models/getpendinginvitationsecurity.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `x_on_behalf_of`                                                                    | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `retries`                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                    | :heavy_minus_sign:                                                                  | Configuration to override the default retry behavior of the client.                 |

### Response

**[models.GetPendingInvitationResponse](../../models/getpendinginvitationresponse.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| errors.GetPendingInvitationUnauthorizedError | 401                                          | application/json                             |
| errors.GetPendingInvitationForbiddenError    | 403                                          | application/json                             |
| errors.SDKDefaultError                       | 4XX, 5XX                                     | \*/\*                                        |

## exchange_session_token

Mints a short-lived, audience-bound token with the same authority as the current live browser or device-login session. Identity, tenancy, permissions, and lifetime cannot be selected by the caller. The JSON body is limited to 4 KiB.

### Example Usage

<!-- UsageSnippet language="python" operationID="exchangeSessionToken" method="post" path="/api/v1/authentication/session/exchange-token" -->
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.session.exchange_session_token(security=models.ExchangeSessionTokenSecurity(
        session_cookie="<YOUR_API_KEY_HERE>",
    ), audience="https://apigw.mka1.com")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `security`                                                                          | [models.ExchangeSessionTokenSecurity](../../models/exchangesessiontokensecurity.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `audience`                                                                          | *str*                                                                               | :heavy_check_mark:                                                                  | Exact configured HTTPS gateway audience that will accept the session-derived token. |
| `x_on_behalf_of`                                                                    | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `retries`                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                    | :heavy_minus_sign:                                                                  | Configuration to override the default retry behavior of the client.                 |

### Response

**[models.ExchangeSessionTokenResponse](../../models/exchangesessiontokenresponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| errors.ExchangeSessionTokenBadRequestError            | 400                                                   | application/json                                      |
| errors.ExchangeSessionTokenUnauthorizedError          | 401                                                   | application/json                                      |
| errors.ExchangeSessionTokenForbiddenError             | 403                                                   | application/json                                      |
| errors.ExchangeSessionTokenRequestEntityTooLargeError | 413                                                   | application/json                                      |
| errors.ExchangeSessionTokenTooManyRequestsError       | 429                                                   | application/json                                      |
| errors.ExchangeSessionTokenInternalServerError        | 500                                                   | application/json                                      |
| errors.SDKDefaultError                                | 4XX, 5XX                                              | \*/\*                                                 |