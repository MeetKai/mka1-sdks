# Flags.Environments

## Overview

### Available Operations

* [list](#list) - List environments
* [create](#create) - Create an environment
* [delete](#delete) - Delete an environment and every flag setting in it
* [update](#update) - Rename an environment
* [evaluate](#evaluate) - Evaluate every flag for an identity
* [evaluate_with_traits](#evaluate_with_traits) - Evaluate every flag for an identity with traits
* [revoke_evaluation_key](#revoke_evaluation_key) - Revoke an environment evaluation key
* [generate_evaluation_key](#generate_evaluation_key) - Generate or replace an environment evaluation key

## list

List environments

### Example Usage

<!-- UsageSnippet language="python" operationID="listFeatureFlagEnvironments" method="get" path="/api/v1/flags/environments" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.environments.list()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[List[models.FeatureFlagEnvironment]](../../models/.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403                | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## create

Every existing flag gets a disabled state in the new environment.

### Example Usage

<!-- UsageSnippet language="python" operationID="createFeatureFlagEnvironment" method="post" path="/api/v1/flags/environments" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.environments.create(key="<key>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `key`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagEnvironment](../../models/featureflagenvironment.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 400, 401, 403, 409      | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## delete

Delete an environment and every flag setting in it

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteFeatureFlagEnvironment" method="delete" path="/api/v1/flags/environments/{env}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.flags.environments.delete(env="<value>")

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `env`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403, 404           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## update

Rename an environment

### Example Usage

<!-- UsageSnippet language="python" operationID="updateFeatureFlagEnvironment" method="patch" path="/api/v1/flags/environments/{env}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.environments.update(env="<value>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `env`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FeatureFlagEnvironment](../../models/featureflagenvironment.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 400, 401, 403, 404      | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## evaluate

Resolves every non-archived flag of the environment for an anonymous caller, or for the identity given in the query. Sends an ETag and answers 304 to a matching If-None-Match after authenticating the environment evaluation key.

### Example Usage

<!-- UsageSnippet language="python" operationID="evaluateFeatureFlags" method="get" path="/api/v1/flags/environments/{env}/evaluate" -->
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.flags.environments.evaluate(security=models.EvaluateFeatureFlagsSecurity(
        evaluation_key_auth="<YOUR_BEARER_TOKEN_HERE>",
    ), env="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `security`                                                                          | [models.EvaluateFeatureFlagsSecurity](../../models/evaluatefeatureflagssecurity.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `env`                                                                               | *str*                                                                               | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `identity`                                                                          | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Stable identifier of the caller; enables rollouts and overrides.                    |
| `x_on_behalf_of`                                                                    | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `retries`                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                    | :heavy_minus_sign:                                                                  | Configuration to override the default retry behavior of the client.                 |

### Response

**[models.EvaluateFeatureFlagsResponse](../../models/evaluatefeatureflagsresponse.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401                     | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## evaluate_with_traits

Evaluate every flag for an identity with traits

### Example Usage

<!-- UsageSnippet language="python" operationID="evaluateFeatureFlagsWithTraits" method="post" path="/api/v1/flags/environments/{env}/evaluate" -->
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.flags.environments.evaluate_with_traits(security=models.EvaluateFeatureFlagsWithTraitsSecurity(
        evaluation_key_auth="<YOUR_BEARER_TOKEN_HERE>",
    ), env="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [models.EvaluateFeatureFlagsWithTraitsSecurity](../../models/evaluatefeatureflagswithtraitssecurity.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `env`                                                                                                   | *str*                                                                                                   | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `x_on_behalf_of`                                                                                        | *Optional[str]*                                                                                         | :heavy_minus_sign:                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                     |
| `identity`                                                                                              | *Optional[str]*                                                                                         | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `traits`                                                                                                | Dict[str, *Any*]                                                                                        | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `retries`                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                        | :heavy_minus_sign:                                                                                      | Configuration to override the default retry behavior of the client.                                     |

### Response

**[models.FeatureFlagEvaluateResponse](../../models/featureflagevaluateresponse.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 400, 401                | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## revoke_evaluation_key

Revocation is idempotent while the environment exists.

### Example Usage

<!-- UsageSnippet language="python" operationID="revokeFeatureFlagEvaluationKey" method="delete" path="/api/v1/flags/environments/{env}/evaluation-key" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.flags.environments.revoke_evaluation_key(env="<value>")

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `env`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403, 404           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## generate_evaluation_key

Returns the new plaintext key once. Only its SHA-256 digest and a display hint are stored; generating another key immediately replaces the previous credential on this replica.

### Example Usage

<!-- UsageSnippet language="python" operationID="generateFeatureFlagEvaluationKey" method="post" path="/api/v1/flags/environments/{env}/evaluation-key" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.flags.environments.generate_evaluation_key(env="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `env`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GenerateFeatureFlagEvaluationKeyResponse](../../models/generatefeatureflagevaluationkeyresponse.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.FeatureFlagError | 401, 403, 404           | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |