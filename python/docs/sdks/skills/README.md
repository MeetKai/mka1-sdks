# Llm.Skills

## Overview

### Available Operations

* [create](#create) - Create skill
* [list](#list) - List skills
* [get](#get) - Retrieve skill
* [update](#update) - Update skill
* [delete](#delete) - Delete skill
* [content](#content) - Download skill content
* [create_version](#create_version) - Create skill version
* [list_versions](#list_versions) - List skill versions
* [get_version](#get_version) - Retrieve skill version
* [delete_version](#delete_version) - Delete skill version
* [version_content](#version_content) - Download skill version content
* [list_preconfigured](#list_preconfigured) - List preconfigured skills

## create

Create a new skill by uploading files. The uploaded files must include a SKILL.md manifest. Accepts multipart form data with individual files or a single zip archive.

### Example Usage

<!-- UsageSnippet language="python" operationID="createSkill" method="post" path="/api/v1/llm/skills" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.create()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `files`                                                             | List[[models.CreateSkillFile](../../models/createskillfile.md)]     | :heavy_minus_sign:                                                  | Skill files to upload (must include SKILL.md)                       |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.Skill](../../models/skill.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list

Returns a paginated list of skills.

### Example Usage

<!-- UsageSnippet language="python" operationID="listSkills" method="get" path="/api/v1/llm/skills" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.list(limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `after`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 20                                                                  |
| `order`                                                             | [Optional[models.ListSkillsOrder]](../../models/listskillsorder.md) | :heavy_minus_sign:                                                  | N/A                                                                 | desc                                                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SkillList](../../models/skilllist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Returns information about a specific skill.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSkill" method="get" path="/api/v1/llm/skills/{skill_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.get(skill_id="skill_1710000000000_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skill_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.Skill](../../models/skill.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update

Update the default version pointer for a skill.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateSkill" method="post" path="/api/v1/llm/skills/{skill_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.update(skill_id="skill_1710000000000_abc123", default_version="2")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skill_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `default_version`                                                   | *str*                                                               | :heavy_check_mark:                                                  | Version number to set as default                                    |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.Skill](../../models/skill.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

Delete a skill and all its versions.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteSkill" method="delete" path="/api/v1/llm/skills/{skill_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.delete(skill_id="skill_1710000000000_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skill_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.DeletedSkill](../../models/deletedskill.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## content

Download the zip bundle for a skill's default version.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSkillContent" method="get" path="/api/v1/llm/skills/{skill_id}/content" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.content(skill_id="skill_1710000000000_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skill_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[httpx.Response](../../models/.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_version

Create a new immutable version of a skill by uploading files. The uploaded files must include a SKILL.md manifest.

### Example Usage

<!-- UsageSnippet language="python" operationID="createSkillVersion" method="post" path="/api/v1/llm/skills/{skill_id}/versions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.create_version(skill_id="skill_1710000000000_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   | Example                                                                       |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `skill_id`                                                                    | *str*                                                                         | :heavy_check_mark:                                                            | N/A                                                                           | skill_1710000000000_abc123                                                    |
| `x_on_behalf_of`                                                              | *Optional[str]*                                                               | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |                                                                               |
| `files`                                                                       | List[[models.CreateSkillVersionFile](../../models/createskillversionfile.md)] | :heavy_minus_sign:                                                            | Skill version files to upload (must include SKILL.md)                         |                                                                               |
| `default`                                                                     | *Optional[bool]*                                                              | :heavy_minus_sign:                                                            | Set this version as the default                                               |                                                                               |
| `retries`                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)              | :heavy_minus_sign:                                                            | Configuration to override the default retry behavior of the client.           |                                                                               |

### Response

**[models.SkillVersion](../../models/skillversion.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_versions

Returns a paginated list of versions for a skill.

### Example Usage

<!-- UsageSnippet language="python" operationID="listSkillVersions" method="get" path="/api/v1/llm/skills/{skill_id}/versions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.list_versions(skill_id="skill_1710000000000_abc123", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       | Example                                                                           |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `skill_id`                                                                        | *str*                                                                             | :heavy_check_mark:                                                                | N/A                                                                               | skill_1710000000000_abc123                                                        |
| `after`                                                                           | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | N/A                                                                               |                                                                                   |
| `limit`                                                                           | *Optional[int]*                                                                   | :heavy_minus_sign:                                                                | N/A                                                                               | 20                                                                                |
| `order`                                                                           | [Optional[models.ListSkillVersionsOrder]](../../models/listskillversionsorder.md) | :heavy_minus_sign:                                                                | N/A                                                                               | desc                                                                              |
| `x_on_behalf_of`                                                                  | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | Optional external end-user identifier forwarded by the API gateway.               |                                                                                   |
| `retries`                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                  | :heavy_minus_sign:                                                                | Configuration to override the default retry behavior of the client.               |                                                                                   |

### Response

**[models.SkillVersionList](../../models/skillversionlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_version

Returns information about a specific skill version.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSkillVersion" method="get" path="/api/v1/llm/skills/{skill_id}/versions/{version}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.get_version(skill_id="skill_1710000000000_abc123", version="1")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skill_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `version`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SkillVersion](../../models/skillversion.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_version

Delete a specific version of a skill.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteSkillVersion" method="delete" path="/api/v1/llm/skills/{skill_id}/versions/{version}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.delete_version(skill_id="skill_1710000000000_abc123", version="1")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skill_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `version`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.DeletedSkillVersion](../../models/deletedskillversion.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## version_content

Download the zip bundle for a specific skill version.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSkillVersionContent" method="get" path="/api/v1/llm/skills/{skill_id}/versions/{version}/content" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.version_content(skill_id="skill_1710000000000_abc123", version="1")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skill_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `version`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[httpx.Response](../../models/.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_preconfigured

Returns the list of preconfigured skills that ship with the gateway. These can be referenced in shell tool definitions as { type: 'preconfigured', name: '...' }.

### Example Usage

<!-- UsageSnippet language="python" operationID="listPreconfiguredSkills" method="get" path="/api/v1/llm/skills/preconfigured" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.skills.list_preconfigured()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.PreconfiguredSkillList](../../models/preconfiguredskilllist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |