# Flags.Audit

## Overview

### Available Operations

* [list](#list) - List audit entries, newest first

## list

List audit entries, newest first

### Example Usage

<!-- UsageSnippet language="python" operationID="listFeatureFlagAuditEntries" method="get" path="/api/v1/flags/audit" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.audit.list(limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `before`                                                            | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | Return entries with an id lower than this (from next_before).       |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagAuditPage](../../models/featureflagauditpage.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 400, 401, 403           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |