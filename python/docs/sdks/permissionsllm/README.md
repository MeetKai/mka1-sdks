# Permissions.Llm

## Overview

### Available Operations

* [grant](#grant) - Grant permission to a user or make public
* [revoke](#revoke) - Revoke permission from a user or remove public access
* [check](#check) - Check user permission

## grant

Grant a role to a user for a resource, or grant public access by using "*" as userId. Only owners can grant permissions. Public access is allowed only for writer and reader roles.

### Example Usage

<!-- UsageSnippet language="python" operationID="llm.grant" method="post" path="/api/v1/authorization/llm/grant" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

    # Use the SDK ...

```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `resource_type`                                                      | [models.LlmResourceType](../../models/llmresourcetype.md)            | :heavy_check_mark:                                                   | Type of LLM resource                                                 |
| `resource_id`                                                        | *str*                                                                | :heavy_check_mark:                                                   | Unique identifier for the resource                                   |
| `user_id`                                                            | *str*                                                                | :heavy_check_mark:                                                   | Unique identifier for the user, or "*" to grant/revoke public access |
| `role`                                                               | [models.ResourceRole](../../models/resourcerole.md)                  | :heavy_check_mark:                                                   | Permission role for the resource (owner > writer > reader)           |
| `x_on_behalf_of`                                                     | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | Optional external end-user identifier forwarded by the API gateway.  |
| `retries`                                                            | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)     | :heavy_minus_sign:                                                   | Configuration to override the default retry behavior of the client.  |

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## revoke

Revoke a role from a user for a resource, or remove public access by using "*" as userId. Only owners can revoke permissions.

### Example Usage

<!-- UsageSnippet language="python" operationID="llm.revoke" method="post" path="/api/v1/authorization/llm/revoke" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.revoke(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="reader")

    # Use the SDK ...

```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `resource_type`                                                      | [models.LlmResourceType](../../models/llmresourcetype.md)            | :heavy_check_mark:                                                   | Type of LLM resource                                                 |
| `resource_id`                                                        | *str*                                                                | :heavy_check_mark:                                                   | Unique identifier for the resource                                   |
| `user_id`                                                            | *str*                                                                | :heavy_check_mark:                                                   | Unique identifier for the user, or "*" to grant/revoke public access |
| `role`                                                               | [models.ResourceRole](../../models/resourcerole.md)                  | :heavy_check_mark:                                                   | Permission role for the resource (owner > writer > reader)           |
| `x_on_behalf_of`                                                     | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | Optional external end-user identifier forwarded by the API gateway.  |
| `retries`                                                            | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)     | :heavy_minus_sign:                                                   | Configuration to override the default retry behavior of the client.  |

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## check

Check whether the authenticated caller has a specific role on a resource.

### Example Usage

<!-- UsageSnippet language="python" operationID="llm.check" method="get" path="/api/v1/authorization/llm/check" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.permissions.llm.check(resource_type="conversation", resource_id="<id>", role="writer")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `resource_type`                                                     | [models.LlmResourceType](../../models/llmresourcetype.md)           | :heavy_check_mark:                                                  | Type of LLM resource                                                |
| `resource_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `role`                                                              | [models.ResourceRole](../../models/resourcerole.md)                 | :heavy_check_mark:                                                  | Permission role for the resource (owner > writer > reader)          |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.CheckPermissionResponse](../../models/checkpermissionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |