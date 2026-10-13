# Auth.ServiceAccounts

## Overview

### Available Operations

* [create](#create) - Create a service account
* [list](#list) - List service accounts
* [get](#get) - Get a service account
* [delete](#delete) - Delete a service account
* [list_api_keys](#list_api_keys) - List a service account's API keys
* [update_api_key](#update_api_key) - Update a service-account API key
* [delete_api_key](#delete_api_key) - Delete a service-account API key
* [regenerate_api_key](#regenerate_api_key) - Rotate a service-account API key's secret

## create

Mint a non-human principal scoped to this org (org owner/admin only).

### Example Usage

<!-- UsageSnippet language="python" operationID="createServiceAccount" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.create(org_id="<id>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.CreateServiceAccountResponse](../../models/createserviceaccountresponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| errors.CreateServiceAccountBadRequestError      | 400                                             | application/json                                |
| errors.CreateServiceAccountUnauthorizedError    | 401                                             | application/json                                |
| errors.CreateServiceAccountForbiddenError       | 403                                             | application/json                                |
| errors.CreateServiceAccountNotFoundError        | 404                                             | application/json                                |
| errors.CreateServiceAccountConflictError        | 409                                             | application/json                                |
| errors.CreateServiceAccountGoneError            | 410                                             | application/json                                |
| errors.CreateServiceAccountTooManyRequestsError | 429                                             | application/json                                |
| errors.SDKDefaultError                          | 4XX, 5XX                                        | \*/\*                                           |

## list

List service accounts

### Example Usage

<!-- UsageSnippet language="python" operationID="listServiceAccounts" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.list(org_id="<id>")

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

**[models.ListServiceAccountsResponse](../../models/listserviceaccountsresponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.ListServiceAccountsBadRequestError      | 400                                            | application/json                               |
| errors.ListServiceAccountsUnauthorizedError    | 401                                            | application/json                               |
| errors.ListServiceAccountsForbiddenError       | 403                                            | application/json                               |
| errors.ListServiceAccountsNotFoundError        | 404                                            | application/json                               |
| errors.ListServiceAccountsConflictError        | 409                                            | application/json                               |
| errors.ListServiceAccountsGoneError            | 410                                            | application/json                               |
| errors.ListServiceAccountsTooManyRequestsError | 429                                            | application/json                               |
| errors.SDKDefaultError                         | 4XX, 5XX                                       | \*/\*                                          |

## get

Get a service account

### Example Usage

<!-- UsageSnippet language="python" operationID="getServiceAccount" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.get(org_id="<id>", sa_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `sa_id`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetServiceAccountResponse](../../models/getserviceaccountresponse.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| errors.GetServiceAccountBadRequestError      | 400                                          | application/json                             |
| errors.GetServiceAccountUnauthorizedError    | 401                                          | application/json                             |
| errors.GetServiceAccountForbiddenError       | 403                                          | application/json                             |
| errors.GetServiceAccountNotFoundError        | 404                                          | application/json                             |
| errors.GetServiceAccountConflictError        | 409                                          | application/json                             |
| errors.GetServiceAccountGoneError            | 410                                          | application/json                             |
| errors.GetServiceAccountTooManyRequestsError | 429                                          | application/json                             |
| errors.SDKDefaultError                       | 4XX, 5XX                                     | \*/\*                                        |

## delete

Delete a service account

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteServiceAccount" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.delete(org_id="<id>", sa_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `sa_id`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteServiceAccountResponse](../../models/deleteserviceaccountresponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| errors.DeleteServiceAccountBadRequestError      | 400                                             | application/json                                |
| errors.DeleteServiceAccountUnauthorizedError    | 401                                             | application/json                                |
| errors.DeleteServiceAccountForbiddenError       | 403                                             | application/json                                |
| errors.DeleteServiceAccountNotFoundError        | 404                                             | application/json                                |
| errors.DeleteServiceAccountConflictError        | 409                                             | application/json                                |
| errors.DeleteServiceAccountGoneError            | 410                                             | application/json                                |
| errors.DeleteServiceAccountTooManyRequestsError | 429                                             | application/json                                |
| errors.SDKDefaultError                          | 4XX, 5XX                                        | \*/\*                                           |

## list_api_keys

List a service account's API keys

### Example Usage

<!-- UsageSnippet language="python" operationID="listServiceAccountApiKeys" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.list_api_keys(org_id="<id>", sa_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `sa_id`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[List[models.ListServiceAccountAPIKeysResponse]](../../models/.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| errors.ListServiceAccountAPIKeysBadRequestError      | 400                                                  | application/json                                     |
| errors.ListServiceAccountAPIKeysUnauthorizedError    | 401                                                  | application/json                                     |
| errors.ListServiceAccountAPIKeysForbiddenError       | 403                                                  | application/json                                     |
| errors.ListServiceAccountAPIKeysNotFoundError        | 404                                                  | application/json                                     |
| errors.ListServiceAccountAPIKeysConflictError        | 409                                                  | application/json                                     |
| errors.ListServiceAccountAPIKeysGoneError            | 410                                                  | application/json                                     |
| errors.ListServiceAccountAPIKeysTooManyRequestsError | 429                                                  | application/json                                     |
| errors.SDKDefaultError                               | 4XX, 5XX                                             | \*/\*                                                |

## update_api_key

Update a service-account API key

### Example Usage

<!-- UsageSnippet language="python" operationID="updateServiceAccountApiKey" method="patch" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.update_api_key(org_id="<id>", sa_id="<id>", key_id="<id>", scopes=[])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `sa_id`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `key_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `scopes`                                                            | List[*str*]                                                         | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `name`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `rate_limit_enabled`                                                | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `rate_limit_time_window`                                            | *Optional[float]*                                                   | :heavy_minus_sign:                                                  | N/A                                                                 |
| `rate_limit_max`                                                    | *Optional[float]*                                                   | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.UpdateServiceAccountAPIKeyResponse](../../models/updateserviceaccountapikeyresponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| errors.UpdateServiceAccountAPIKeyBadRequestError      | 400                                                   | application/json                                      |
| errors.UpdateServiceAccountAPIKeyUnauthorizedError    | 401                                                   | application/json                                      |
| errors.UpdateServiceAccountAPIKeyForbiddenError       | 403                                                   | application/json                                      |
| errors.UpdateServiceAccountAPIKeyNotFoundError        | 404                                                   | application/json                                      |
| errors.UpdateServiceAccountAPIKeyConflictError        | 409                                                   | application/json                                      |
| errors.UpdateServiceAccountAPIKeyGoneError            | 410                                                   | application/json                                      |
| errors.UpdateServiceAccountAPIKeyTooManyRequestsError | 429                                                   | application/json                                      |
| errors.SDKDefaultError                                | 4XX, 5XX                                              | \*/\*                                                 |

## delete_api_key

Delete a service-account API key

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteServiceAccountApiKey" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.delete_api_key(org_id="<id>", sa_id="<id>", key_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `sa_id`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `key_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteServiceAccountAPIKeyResponse](../../models/deleteserviceaccountapikeyresponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| errors.DeleteServiceAccountAPIKeyBadRequestError      | 400                                                   | application/json                                      |
| errors.DeleteServiceAccountAPIKeyUnauthorizedError    | 401                                                   | application/json                                      |
| errors.DeleteServiceAccountAPIKeyForbiddenError       | 403                                                   | application/json                                      |
| errors.DeleteServiceAccountAPIKeyNotFoundError        | 404                                                   | application/json                                      |
| errors.DeleteServiceAccountAPIKeyConflictError        | 409                                                   | application/json                                      |
| errors.DeleteServiceAccountAPIKeyGoneError            | 410                                                   | application/json                                      |
| errors.DeleteServiceAccountAPIKeyTooManyRequestsError | 429                                                   | application/json                                      |
| errors.SDKDefaultError                                | 4XX, 5XX                                              | \*/\*                                                 |

## regenerate_api_key

Rotate a service-account API key's secret

### Example Usage

<!-- UsageSnippet language="python" operationID="regenerateServiceAccountApiKey" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}/regenerate" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.service_accounts.regenerate_api_key(org_id="<id>", sa_id="<id>", key_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `sa_id`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `key_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RegenerateServiceAccountAPIKeyResponse](../../models/regenerateserviceaccountapikeyresponse.md)**

### Errors

| Error Type                                                | Status Code                                               | Content Type                                              |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| errors.RegenerateServiceAccountAPIKeyBadRequestError      | 400                                                       | application/json                                          |
| errors.RegenerateServiceAccountAPIKeyUnauthorizedError    | 401                                                       | application/json                                          |
| errors.RegenerateServiceAccountAPIKeyForbiddenError       | 403                                                       | application/json                                          |
| errors.RegenerateServiceAccountAPIKeyNotFoundError        | 404                                                       | application/json                                          |
| errors.RegenerateServiceAccountAPIKeyConflictError        | 409                                                       | application/json                                          |
| errors.RegenerateServiceAccountAPIKeyGoneError            | 410                                                       | application/json                                          |
| errors.RegenerateServiceAccountAPIKeyTooManyRequestsError | 429                                                       | application/json                                          |
| errors.SDKDefaultError                                    | 4XX, 5XX                                                  | \*/\*                                                     |