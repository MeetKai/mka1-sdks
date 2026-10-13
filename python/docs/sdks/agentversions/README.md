# AgentVersions

## Overview

Inspect an agent's configuration history and roll back to a prior version.

### Available Operations

* [list_agent_versions](#list_agent_versions) - List agent versions
* [get_agent_version](#get_agent_version) - Retrieve an agent version
* [rollback_agent_version](#rollback_agent_version) - Roll back an agent to a version

## list_agent_versions

Lists the configuration history for an agent. Each committed change (create, update, rollback) appends a version.

### Example Usage

<!-- UsageSnippet language="python" operationID="listAgentVersions" method="get" path="/api/v1/agents/{agent_id}/versions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_versions.list_agent_versions(agent_id="<id>", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `agent_id`                                                                        | *str*                                                                             | :heavy_check_mark:                                                                | N/A                                                                               |
| `limit`                                                                           | *Optional[int]*                                                                   | :heavy_minus_sign:                                                                | N/A                                                                               |
| `order`                                                                           | [Optional[models.ListAgentVersionsOrder]](../../models/listagentversionsorder.md) | :heavy_minus_sign:                                                                | N/A                                                                               |
| `x_on_behalf_of`                                                                  | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | Optional external end-user identifier forwarded by the API gateway.               |
| `retries`                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                  | :heavy_minus_sign:                                                                | Configuration to override the default retry behavior of the client.               |

### Response

**[models.AgentVersionList](../../models/agentversionlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_agent_version

Retrieve an agent version

### Example Usage

<!-- UsageSnippet language="python" operationID="getAgentVersion" method="get" path="/api/v1/agents/{agent_id}/versions/{version}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_versions.get_agent_version(agent_id="<id>", version=652149)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `version`                                                           | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentVersion](../../models/agentversion.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## rollback_agent_version

Restores the target version's configuration as a new current version. History is preserved: the restore is appended as a new version rather than deleting later ones.

### Example Usage

<!-- UsageSnippet language="python" operationID="rollbackAgentVersion" method="post" path="/api/v1/agents/{agent_id}/versions/{version}/rollback" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_versions.rollback_agent_version(agent_id="<id>", version=880902)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `version`                                                           | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.Agent](../../models/agent.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |