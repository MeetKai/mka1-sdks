# Flags

## Overview

### Available Operations

* [list](#list) - List flags
* [create](#create) - Create a flag
* [delete](#delete) - Delete a flag and its settings in every environment
* [get](#get) - Get a flag
* [update](#update) - Update a flag's name, description, default value, or project
* [archive](#archive) - Archive a flag
* [set_environment_state](#set_environment_state) - Replace a flag's settings in one environment
* [unarchive](#unarchive) - Restore an archived flag

## list

Every flag with a per-environment digest of its state.

### Example Usage

<!-- UsageSnippet language="python" operationID="listFeatureFlags" method="get" path="/api/v1/flags" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.list(include_archived=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `include_archived`                                                            | *Optional[bool]*                                                              | :heavy_minus_sign:                                                            | N/A                                                                           |
| `project_id`                                                                  | *Optional[str]*                                                               | :heavy_minus_sign:                                                            | Return only flags assigned to this project. Flag keys remain globally unique. |
| `x_on_behalf_of`                                                              | *Optional[str]*                                                               | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |
| `retries`                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)              | :heavy_minus_sign:                                                            | Configuration to override the default retry behavior of the client.           |

### Response

**[List[models.FeatureFlagListItem]](../../models/.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 400, 401, 403, 404      | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## create

The flag starts disabled in every environment and belongs to Default when project_id is omitted.

### Example Usage

<!-- UsageSnippet language="python" operationID="createFeatureFlag" method="post" path="/api/v1/flags" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.create(default_value="<value>", key="<key>", name="<value>", value_type="boolean")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `default_value`                                                     | *Any*                                                               | :heavy_check_mark:                                                  | Any JSON value; its shape is constrained by the flag's value_type.  |
| `key`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `value_type`                                                        | [models.FeatureFlagValueType](../../models/featureflagvaluetype.md) | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `description`                                                       | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `project_id`                                                        | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Project to assign. Defaults to the Default project.                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagDetail](../../models/featureflagdetail.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 400, 401, 403, 404, 409 | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## delete

Delete a flag and its settings in every environment

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteFeatureFlag" method="delete" path="/api/v1/flags/{key}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.flags.delete(key="<key>")

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `key`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403, 404           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## get

Get a flag

### Example Usage

<!-- UsageSnippet language="python" operationID="getFeatureFlag" method="get" path="/api/v1/flags/{key}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.get(key="<key>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `key`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagDetail](../../models/featureflagdetail.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403, 404           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## update

Update a flag's name, description, default value, or project

### Example Usage

<!-- UsageSnippet language="python" operationID="updateFeatureFlag" method="patch" path="/api/v1/flags/{key}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.update(key="<key>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `key`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `default_value`                                                     | *Optional[Any]*                                                     | :heavy_minus_sign:                                                  | Any JSON value; its shape is constrained by the flag's value_type.  |
| `description`                                                       | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `name`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `project_id`                                                        | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagDetail](../../models/featureflagdetail.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 400, 401, 403, 404      | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## archive

Archived flags are excluded from evaluation in every environment; their settings are kept.

### Example Usage

<!-- UsageSnippet language="python" operationID="archiveFeatureFlag" method="post" path="/api/v1/flags/{key}/archive" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.archive(key="<key>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `key`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagDetail](../../models/featureflagdetail.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403, 404           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## set_environment_state

Replace a flag's settings in one environment

### Example Usage

<!-- UsageSnippet language="python" operationID="setFeatureFlagEnvironmentState" method="put" path="/api/v1/flags/{key}/environments/{env}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.set_environment_state(key="<key>", env="<value>", enabled=True, overrides=[
        {
            "enabled": True,
            "identity": "<value>",
        },
    ], rollout_percentage=29814, rules=[
        {
            "conditions": [],
            "enabled": False,
        },
    ], value="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                        | Type                                                                                                                                                                                                                             | Required                                                                                                                                                                                                                         | Description                                                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `key`                                                                                                                                                                                                                            | *str*                                                                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `env`                                                                                                                                                                                                                            | *str*                                                                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `enabled`                                                                                                                                                                                                                        | *bool*                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `overrides`                                                                                                                                                                                                                      | List[[models.FeatureFlagOverride](../../models/featureflagoverride.md)]                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `rollout_percentage`                                                                                                                                                                                                             | *int*                                                                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `rules`                                                                                                                                                                                                                          | List[[models.FeatureFlagRule](../../models/featureflagrule.md)]                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `value`                                                                                                                                                                                                                          | *Any*                                                                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                               | Any JSON value; its shape is constrained by the flag's value_type.                                                                                                                                                               |
| `if_match`                                                                                                                                                                                                                       | *Optional[str]*                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                               | The `version` of the state you read and edited. When supplied, the write is refused with `412` if anyone changed the state in the meantime, instead of silently overwriting them. `*` matches the current state unconditionally. |
| `x_on_behalf_of`                                                                                                                                                                                                                 | *Optional[str]*                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                              |
| `retries`                                                                                                                                                                                                                        | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                               | Configuration to override the default retry behavior of the client.                                                                                                                                                              |

### Response

**[models.SetFeatureFlagEnvironmentStateResponse](../../models/setfeatureflagenvironmentstateresponse.md)**

### Errors

| Error Type                   | Status Code                  | Content Type                 |
| ---------------------------- | ---------------------------- | ---------------------------- |
| errors.FeatureFlagError      | 400, 401, 403, 404, 409, 412 | application/json             |
| errors.SDKDefaultError       | 4XX, 5XX                     | \*/\*                        |

## unarchive

Restore an archived flag

### Example Usage

<!-- UsageSnippet language="python" operationID="unarchiveFeatureFlag" method="post" path="/api/v1/flags/{key}/unarchive" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.unarchive(key="<key>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `key`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagDetail](../../models/featureflagdetail.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403, 404           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |