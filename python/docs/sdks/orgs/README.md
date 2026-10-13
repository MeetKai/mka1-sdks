# Auth.Orgs

## Overview

### Available Operations

* [get_by_id](#get_by_id) - Get basic organization details
* [update](#update) - Patch organization metadata (cluster-admin)
* [get_quota](#get_quota) - Get an org's usage quota
* [update_quota](#update_quota) - Set an org's usage quota (cluster-admin)
* [get_rate_limit](#get_rate_limit) - Get an org's rate limit
* [update_rate_limit](#update_rate_limit) - Set an org's rate limit (cluster-admin)

## get_by_id

Returns basic fields and the full metadata object to a member of the organization or a cluster admin. It never includes member identities, invitations, or API-key details.

### Example Usage

<!-- UsageSnippet language="python" operationID="getOrgById" method="get" path="/api/v1/authentication/orgs/{orgId}" -->
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.auth.orgs.get_by_id(security=models.GetOrgByIDSecurity(
        bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
    ), org_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `security`                                                          | [models.GetOrgByIDSecurity](../../models/getorgbyidsecurity.md)     | :heavy_check_mark:                                                  | N/A                                                                 |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.BasicOrganization](../../models/basicorganization.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| errors.GetOrgByIDBadRequestError      | 400                                   | application/json                      |
| errors.GetOrgByIDUnauthorizedError    | 401                                   | application/json                      |
| errors.GetOrgByIDForbiddenError       | 403                                   | application/json                      |
| errors.GetOrgByIDNotFoundError        | 404                                   | application/json                      |
| errors.GetOrgByIDConflictError        | 409                                   | application/json                      |
| errors.GetOrgByIDGoneError            | 410                                   | application/json                      |
| errors.GetOrgByIDTooManyRequestsError | 429                                   | application/json                      |
| errors.GetOrgByIDInternalServerError  | 500                                   | application/json                      |
| errors.SDKDefaultError                | 4XX, 5XX                              | \*/\*                                 |

## update

Merges supplied top-level metadata keys while preserving omitted siblings. metadata.codeConfig accepts one releaseManifestUrl; codeConfig:null removes that override.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateOrganization" method="patch" path="/api/v1/authentication/orgs/{orgId}" -->
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.auth.orgs.update(security=models.UpdateOrganizationSecurity(
        bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
    ), org_id="<id>", metadata=models.OrganizationMetadata())

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `security`                                                                      | [models.UpdateOrganizationSecurity](../../models/updateorganizationsecurity.md) | :heavy_check_mark:                                                              | N/A                                                                             |
| `org_id`                                                                        | *str*                                                                           | :heavy_check_mark:                                                              | N/A                                                                             |
| `metadata`                                                                      | [models.OrganizationMetadata](../../models/organizationmetadata.md)             | :heavy_check_mark:                                                              | N/A                                                                             |
| `x_on_behalf_of`                                                                | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | Optional external end-user identifier forwarded by the API gateway.             |
| `retries`                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                | :heavy_minus_sign:                                                              | Configuration to override the default retry behavior of the client.             |

### Response

**[models.BasicOrganization](../../models/basicorganization.md)**

### Errors

| Error Type                                          | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| errors.UpdateOrganizationBadRequestError            | 400                                                 | application/json                                    |
| errors.UpdateOrganizationUnauthorizedError          | 401                                                 | application/json                                    |
| errors.UpdateOrganizationForbiddenError             | 403                                                 | application/json                                    |
| errors.UpdateOrganizationNotFoundError              | 404                                                 | application/json                                    |
| errors.UpdateOrganizationConflictError              | 409                                                 | application/json                                    |
| errors.UpdateOrganizationGoneError                  | 410                                                 | application/json                                    |
| errors.UpdateOrganizationRequestEntityTooLargeError | 413                                                 | application/json                                    |
| errors.UpdateOrganizationTooManyRequestsError       | 429                                                 | application/json                                    |
| errors.UpdateOrganizationInternalServerError        | 500                                                 | application/json                                    |
| errors.SDKDefaultError                              | 4XX, 5XX                                            | \*/\*                                               |

## get_quota

Get an org's usage quota

### Example Usage

<!-- UsageSnippet language="python" operationID="getOrgQuota" method="get" path="/api/v1/authentication/orgs/{orgId}/quota" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.orgs.get_quota(org_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetOrgQuotaResponse](../../models/getorgquotaresponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.GetOrgQuotaBadRequestError      | 400                                    | application/json                       |
| errors.GetOrgQuotaUnauthorizedError    | 401                                    | application/json                       |
| errors.GetOrgQuotaForbiddenError       | 403                                    | application/json                       |
| errors.GetOrgQuotaNotFoundError        | 404                                    | application/json                       |
| errors.GetOrgQuotaConflictError        | 409                                    | application/json                       |
| errors.GetOrgQuotaGoneError            | 410                                    | application/json                       |
| errors.GetOrgQuotaTooManyRequestsError | 429                                    | application/json                       |
| errors.SDKDefaultError                 | 4XX, 5XX                               | \*/\*                                  |

## update_quota

Set an org's usage quota (cluster-admin)

### Example Usage

<!-- UsageSnippet language="python" operationID="updateOrgQuota" method="patch" path="/api/v1/authentication/orgs/{orgId}/quota" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.orgs.update_quota(org_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `org_id`                                                                  | *str*                                                                     | :heavy_check_mark:                                                        | N/A                                                                       |
| `x_on_behalf_of`                                                          | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | Optional external end-user identifier forwarded by the API gateway.       |
| `quota_enabled`                                                           | *Optional[bool]*                                                          | :heavy_minus_sign:                                                        | N/A                                                                       |
| `quota_period`                                                            | [Optional[models.QuotaPeriodRequest]](../../models/quotaperiodrequest.md) | :heavy_minus_sign:                                                        | N/A                                                                       |
| `quota_max`                                                               | *Optional[int]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       |
| `retries`                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)          | :heavy_minus_sign:                                                        | Configuration to override the default retry behavior of the client.       |

### Response

**[models.UpdateOrgQuotaResponse](../../models/updateorgquotaresponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| errors.UpdateOrgQuotaBadRequestError      | 400                                       | application/json                          |
| errors.UpdateOrgQuotaUnauthorizedError    | 401                                       | application/json                          |
| errors.UpdateOrgQuotaForbiddenError       | 403                                       | application/json                          |
| errors.UpdateOrgQuotaNotFoundError        | 404                                       | application/json                          |
| errors.UpdateOrgQuotaConflictError        | 409                                       | application/json                          |
| errors.UpdateOrgQuotaGoneError            | 410                                       | application/json                          |
| errors.UpdateOrgQuotaTooManyRequestsError | 429                                       | application/json                          |
| errors.SDKDefaultError                    | 4XX, 5XX                                  | \*/\*                                     |

## get_rate_limit

Get an org's rate limit

### Example Usage

<!-- UsageSnippet language="python" operationID="getOrgRateLimit" method="get" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.orgs.get_rate_limit(org_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetOrgRateLimitResponse](../../models/getorgratelimitresponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| errors.GetOrgRateLimitBadRequestError      | 400                                        | application/json                           |
| errors.GetOrgRateLimitUnauthorizedError    | 401                                        | application/json                           |
| errors.GetOrgRateLimitForbiddenError       | 403                                        | application/json                           |
| errors.GetOrgRateLimitNotFoundError        | 404                                        | application/json                           |
| errors.GetOrgRateLimitConflictError        | 409                                        | application/json                           |
| errors.GetOrgRateLimitGoneError            | 410                                        | application/json                           |
| errors.GetOrgRateLimitTooManyRequestsError | 429                                        | application/json                           |
| errors.SDKDefaultError                     | 4XX, 5XX                                   | \*/\*                                      |

## update_rate_limit

Set an org's rate limit (cluster-admin)

### Example Usage

<!-- UsageSnippet language="python" operationID="updateOrgRateLimit" method="patch" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.orgs.update_rate_limit(org_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `rate_limit_enabled`                                                | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `rate_limit_time_window`                                            | *Optional[float]*                                                   | :heavy_minus_sign:                                                  | N/A                                                                 |
| `rate_limit_max`                                                    | *OptionalNullable[int]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.UpdateOrgRateLimitResponse](../../models/updateorgratelimitresponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| errors.UpdateOrgRateLimitBadRequestError      | 400                                           | application/json                              |
| errors.UpdateOrgRateLimitUnauthorizedError    | 401                                           | application/json                              |
| errors.UpdateOrgRateLimitForbiddenError       | 403                                           | application/json                              |
| errors.UpdateOrgRateLimitNotFoundError        | 404                                           | application/json                              |
| errors.UpdateOrgRateLimitConflictError        | 409                                           | application/json                              |
| errors.UpdateOrgRateLimitGoneError            | 410                                           | application/json                              |
| errors.UpdateOrgRateLimitTooManyRequestsError | 429                                           | application/json                              |
| errors.SDKDefaultError                        | 4XX, 5XX                                      | \*/\*                                         |