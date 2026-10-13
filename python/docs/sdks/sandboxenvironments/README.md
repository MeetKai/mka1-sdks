# Sandbox.Environments

## Overview

### Available Operations

* [list](#list) - List Environments
* [create](#create) - Create Environment
* [get](#get) - Get Environment
* [update](#update) - Update Environment
* [delete](#delete) - Delete Environment
* [run_setup](#run_setup) - Run Environment Setup

## list

List the caller's saved environments, plus the per-environment repository limit.

### Example Usage

<!-- UsageSnippet language="python" operationID="listSandboxEnvironments" method="get" path="/api/v1/sandbox/environments" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.environments.list()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EnvironmentList](../../models/environmentlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create

Save a named environment: repositories to clone, environment variables, network access, and an optional bash setup script. Sessions created from it copy these settings. Do not put secrets in `environment_variables`.

### Example Usage

<!-- UsageSnippet language="python" operationID="createSandboxEnvironment" method="post" path="/api/v1/sandbox/environments" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.environments.create(name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `name`                                                                                | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `environment_variables`                                                               | Dict[str, *str*]                                                                      | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `setup_script`                                                                        | *OptionalNullable[str]*                                                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `repositories`                                                                        | List[[models.EnvironmentRepositoryModel](../../models/environmentrepositorymodel.md)] | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `network_access`                                                                      | [OptionalNullable[models.NetworkAccess]](../../models/networkaccess.md)               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |

### Response

**[models.EnvironmentModel](../../models/environmentmodel.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get

Return one of the caller's saved environments.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSandboxEnvironment" method="get" path="/api/v1/sandbox/environments/{environment_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.environments.get(environment_id=438435)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `environment_id`                                                    | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EnvironmentModel](../../models/environmentmodel.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## update

Replace a saved environment's settings. Omit `network_access` to keep the stored value. Sessions already created from the environment keep the settings they started with.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateSandboxEnvironment" method="put" path="/api/v1/sandbox/environments/{environment_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.environments.update(environment_id=946665, name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `environment_id`                                                                      | *int*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `name`                                                                                | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `environment_variables`                                                               | Dict[str, *str*]                                                                      | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `setup_script`                                                                        | *OptionalNullable[str]*                                                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `repositories`                                                                        | List[[models.EnvironmentRepositoryModel](../../models/environmentrepositorymodel.md)] | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `network_access`                                                                      | [OptionalNullable[models.NetworkAccess]](../../models/networkaccess.md)               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |

### Response

**[models.EnvironmentModel](../../models/environmentmodel.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## delete

Delete a saved environment. Sessions already created from it are not affected.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteSandboxEnvironment" method="delete" path="/api/v1/sandbox/environments/{environment_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.sandbox.environments.delete(environment_id=252282)

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `environment_id`                                                    | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## run_setup

Run the setup script of the environment the session was created from. Call it once the session's repositories have cloned. A `running` status means setup has not finished yet and calling again is safe; once setup has succeeded, later calls return `succeeded` without running it again.

### Example Usage

<!-- UsageSnippet language="python" operationID="runSandboxEnvironmentSetup" method="post" path="/api/v1/sandbox/sessions/{session_id}/environment-setup" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.environments.run_setup(session_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EnvironmentSetupRunModel](../../models/environmentsetuprunmodel.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |