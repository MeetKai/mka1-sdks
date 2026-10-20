# MKA1 Python SDK

Official Python SDK for the MKA1 API.

Use `meetkai-mka1` to call MKA1 from Python, with both synchronous and asynchronous clients. The SDK includes typed clients for responses, agents, files, vector stores, evals, usage, model registry operations, guardrails, sandbox APIs, and more.

Full product and API documentation lives at [docs.mka1.com](https://docs.mka1.com).

<!-- Start Summary [summary] -->
## Summary

MKA1 API: The MKA1 API is a RESTful API that provides access to the MKA1 platform. Learn how to get started with the API and the TypeScript SDK [here](https://mka1.apidocumentation.com/guides/getting-started).
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [MKA1 Python SDK](#mka1-python-sdk)
  * [SDK Installation](#sdk-installation)
  * [IDE Support](#ide-support)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Server-sent event streaming](#server-sent-event-streaming)
  * [File uploads](#file-uploads)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
  * [Custom HTTP Client](#custom-http-client)
  * [Resource Management](#resource-management)
  * [Debugging](#debugging)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

> [!TIP]
> To finish publishing your SDK to PyPI you must [run your first generation action](https://www.speakeasy.com/docs/github-setup#step-by-step-guide).


> [!NOTE]
> **Python version upgrade policy**
>
> Once a Python version reaches its [official end of life date](https://devguide.python.org/versions/), a 3-month grace period is provided for users to upgrade. Following this grace period, the minimum python version supported in the SDK will be updated.

The SDK can be installed with *uv*, *pip*, or *poetry* package managers.

### uv

*uv* is a fast Python package installer and resolver, designed as a drop-in replacement for pip and pip-tools. It's recommended for its speed and modern Python tooling capabilities.

```bash
uv add git+https://github.com/MeetKai/mka1-sdks.git#subdirectory=python
```

### PIP

*PIP* is the default package installer for Python, enabling easy installation and management of packages from PyPI via the command line.

```bash
pip install git+https://github.com/MeetKai/mka1-sdks.git#subdirectory=python
```

### Poetry

*Poetry* is a modern tool that simplifies dependency management and package publishing by using a single `pyproject.toml` file to handle project metadata and dependencies.

```bash
poetry add git+https://github.com/MeetKai/mka1-sdks.git#subdirectory=python
```

### Shell and script usage with `uv`

You can use this SDK in a Python shell with [uv](https://docs.astral.sh/uv/) and the `uvx` command that comes with it like so:

```shell
uvx --from meetkai-mka1 python
```

It's also possible to write a standalone Python script without needing to set up a whole project like so:

```python
#!/usr/bin/env -S uv run --script
# /// script
# requires-python = ">=3.10"
# dependencies = [
#     "meetkai-mka1",
# ]
# ///

from meetkai_mka1 import SDK

sdk = SDK(
  # SDK arguments
)

# Rest of script here...
```

Once that is saved to a file, you can run it with `uv run script.py` where
`script.py` can be replaced with the actual file name.
<!-- End SDK Installation [installation] -->

<!-- Start IDE Support [idesupport] -->
## IDE Support

### PyCharm

Generally, the SDK will work well with most IDEs out of the box. However, when using PyCharm, you can enjoy much better integration with Pydantic by installing an additional plugin.

- [PyCharm Pydantic Plugin](https://docs.pydantic.dev/latest/integrations/pycharm/)
<!-- End IDE Support [idesupport] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```python
# Synchronous Example
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

    # Use the SDK ...
```

</br>

The same SDK client can also be used to make asynchronous requests by importing asyncio.

```python
# Asynchronous Example
import asyncio
from meetkai_mka1 import SDK

async def main():

    async with SDK(
        bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
    ) as sdk:

        await sdk.permissions.llm.grant_async(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

        # Use the SDK ...

asyncio.run(main())
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name          | Type | Scheme      |
| ------------- | ---- | ----------- |
| `bearer_auth` | http | HTTP Bearer |

To authenticate with the API the `bearer_auth` parameter must be set when initializing the SDK client instance. For example:
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

    # Use the SDK ...

```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.auth.orgs.list_members(security=models.ListOrgMembersSecurity(

    ), org_id="<id>")

    # Handle response
    print(res)

```
<!-- End Authentication [security] -->

## Available Resources and Operations

The per-operation reference, with request and response shapes and examples for every SDK, is at [docs.mka1.com/api-reference](https://docs.mka1.com/api-reference).

<!-- No Available Resources and Operations [operations] -->

<!-- Start Server-sent event streaming [eventstream] -->
## Server-sent event streaming

[Server-sent events][mdn-sse] are used to stream content from certain
operations. These operations will expose the stream as [Generator][generator] that
can be consumed using a simple `for` loop. The loop will
terminate when the server no longer has any events to send and closes the
underlying connection.  

The stream is also a [Context Manager][context-manager] and can be used with the `with` statement and will close the
underlying connection when the context is exited.

```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.responses.create(model="meetkai:functionary-urdu-mini-pak", input="What is the capital of France?", stream=False, store=True, background=False, parallel_tool_calls=True, max_tool_calls=64, truncation="auto", service_tier="auto")

    with res as event_stream:
        for event in event_stream:
            # handle event
            print(event, flush=True)

```

[mdn-sse]: https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events
[generator]: https://book.pythontips.com/en/latest/generators.html
[context-manager]: https://book.pythontips.com/en/latest/context_managers.html
<!-- End Server-sent event streaming [eventstream] -->

<!-- Start File uploads [file-upload] -->
## File uploads

Certain SDK methods accept file objects as part of a request body or multi-part request. It is possible and typically recommended to upload files as a stream rather than reading the entire contents into memory. This avoids excessive memory consumption and potentially crashing with out-of-memory errors when working with very large files. The following example demonstrates how to attach a file stream to a request.

> [!TIP]
>
> For endpoints that handle file uploads bytes arrays can also be used. However, using streams is recommended for large files.
>

```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.files.upload(file={
        "file_name": "example.file",
        "content": open("example.file", "rb"),
    }, purpose="assistants")

    # Handle response
    print(res)

```
<!-- End File uploads [file-upload] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply provide a `RetryConfig` object to the call:
```python
from meetkai_mka1 import SDK
from meetkai_mka1.utils import BackoffStrategy, RetryConfig


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer",
        RetryConfig("backoff", BackoffStrategy(1, 50, 1.1, 100), False))

    # Use the SDK ...

```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `retry_config` optional parameter when initializing the SDK:
```python
from meetkai_mka1 import SDK
from meetkai_mka1.utils import BackoffStrategy, RetryConfig


with SDK(
    retry_config=RetryConfig("backoff", BackoffStrategy(1, 50, 1.1, 100), False),
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

    # Use the SDK ...

```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`SDKError`](./src/meetkai_mka1/errors/sdkerror.py) is the base class for all HTTP error responses. It has the following properties:

| Property           | Type             | Description                                                                             |
| ------------------ | ---------------- | --------------------------------------------------------------------------------------- |
| `err.message`      | `str`            | Error message                                                                           |
| `err.status_code`  | `int`            | HTTP response status code eg `404`                                                      |
| `err.headers`      | `httpx.Headers`  | HTTP response headers                                                                   |
| `err.body`         | `str`            | HTTP body. Can be empty string if no body is returned.                                  |
| `err.raw_response` | `httpx.Response` | Raw HTTP response                                                                       |
| `err.data`         |                  | Optional. Some errors may contain structured data. [See Error Classes](#error-classes). |

### Example
```python
from meetkai_mka1 import SDK, errors


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:
    res = None
    try:

        res = sdk.llm.files.content(file_id="file-abc123")

        # Handle response
        print(res)


    except errors.SDKError as e:
        # The base class for HTTP error responses
        print(e.message)
        print(e.status_code)
        print(e.body)
        print(e.headers)
        print(e.raw_response)

        # Depending on the method different errors may be thrown
        if isinstance(e, errors.GetFileContentBadRequestError):
            print(e.data.error)  # Optional[models.BadRequestError]
```

### Error Classes
**Primary error:**
* [`SDKError`](./src/meetkai_mka1/errors/sdkerror.py): The base class for HTTP error responses.

<details><summary>Less common errors (365)</summary>

<br />

**Network errors:**
* [`httpx.RequestError`](https://www.python-httpx.org/exceptions/#httpx.RequestError): Base class for request errors.
    * [`httpx.ConnectError`](https://www.python-httpx.org/exceptions/#httpx.ConnectError): HTTP client was unable to make a request to a server.
    * [`httpx.TimeoutException`](https://www.python-httpx.org/exceptions/#httpx.TimeoutException): HTTP request timed out.


**Inherit from [`SDKError`](./src/meetkai_mka1/errors/sdkerror.py)**:
* [`HTTPValidationError`](./src/meetkai_mka1/errors/httpvalidationerror.py): Validation Error. Status code `422`. Applicable to 47 of 493 methods.*
* [`ErrorEnvelope`](./src/meetkai_mka1/errors/errorenvelope.py): Error response. Applicable to 29 of 493 methods.*
* [`FeatureFlagError`](./src/meetkai_mka1/errors/featureflagerror.py): The request is malformed or fails validation. Applicable to 22 of 493 methods.*
* [`AnalyticsError`](./src/meetkai_mka1/errors/analyticserror.py): Request failed. Applicable to 12 of 493 methods.*
* [`RepoError`](./src/meetkai_mka1/errors/repoerror.py): The uniform error envelope. `error` is a stable machine-readable code (never an internal reason); `correlation_id` echoes the request's `X-Correlation-ID` for log correlation. Applicable to 7 of 493 methods.*
* [`ExchangeSessionTokenBadRequestError`](./src/meetkai_mka1/errors/exchangesessiontokenbadrequesterror.py): Invalid request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetFileContentBadRequestError`](./src/meetkai_mka1/errors/getfilecontentbadrequesterror.py): Invalid request - File ID is required. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListOrgMembersBadRequestError`](./src/meetkai_mka1/errors/listorgmembersbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`InviteOrgMemberBadRequestError`](./src/meetkai_mka1/errors/inviteorgmemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateOrgMemberBadRequestError`](./src/meetkai_mka1/errors/updateorgmemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`RemoveOrgMemberBadRequestError`](./src/meetkai_mka1/errors/removeorgmemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetSsoPolicyBadRequestError`](./src/meetkai_mka1/errors/getssopolicybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateSsoPolicyBadRequestError`](./src/meetkai_mka1/errors/updatessopolicybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDBadRequestError`](./src/meetkai_mka1/errors/getorgbyidbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationBadRequestError`](./src/meetkai_mka1/errors/updateorganizationbadrequesterror.py): Invalid JSON or metadata patch. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetOrgQuotaBadRequestError`](./src/meetkai_mka1/errors/getorgquotabadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateOrgQuotaBadRequestError`](./src/meetkai_mka1/errors/updateorgquotabadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetOrgRateLimitBadRequestError`](./src/meetkai_mka1/errors/getorgratelimitbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateOrgRateLimitBadRequestError`](./src/meetkai_mka1/errors/updateorgratelimitbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetNetworkPolicyAccessBadRequestError`](./src/meetkai_mka1/errors/getnetworkpolicyaccessbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`CreateTeamBadRequestError`](./src/meetkai_mka1/errors/createteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListTeamsBadRequestError`](./src/meetkai_mka1/errors/listteamsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetTeamBadRequestError`](./src/meetkai_mka1/errors/getteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateTeamBadRequestError`](./src/meetkai_mka1/errors/updateteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`DeleteTeamBadRequestError`](./src/meetkai_mka1/errors/deleteteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`AddTeamMemberBadRequestError`](./src/meetkai_mka1/errors/addteammemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListTeamMembersBadRequestError`](./src/meetkai_mka1/errors/listteammembersbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateTeamMemberBadRequestError`](./src/meetkai_mka1/errors/updateteammemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`RemoveTeamMemberBadRequestError`](./src/meetkai_mka1/errors/removeteammemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`CreateScopedAPIKeyBadRequestError`](./src/meetkai_mka1/errors/createscopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListScopedAPIKeysBadRequestError`](./src/meetkai_mka1/errors/listscopedapikeysbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateScopedAPIKeyBadRequestError`](./src/meetkai_mka1/errors/updatescopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`RegenerateScopedAPIKeyBadRequestError`](./src/meetkai_mka1/errors/regeneratescopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ExchangeAPIKeyTokenBadRequestError`](./src/meetkai_mka1/errors/exchangeapikeytokenbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`CreateServiceAccountBadRequestError`](./src/meetkai_mka1/errors/createserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountsBadRequestError`](./src/meetkai_mka1/errors/listserviceaccountsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetServiceAccountBadRequestError`](./src/meetkai_mka1/errors/getserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountBadRequestError`](./src/meetkai_mka1/errors/deleteserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountAPIKeysBadRequestError`](./src/meetkai_mka1/errors/listserviceaccountapikeysbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateServiceAccountAPIKeyBadRequestError`](./src/meetkai_mka1/errors/updateserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountAPIKeyBadRequestError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`RegenerateServiceAccountAPIKeyBadRequestError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`CreateClusterInviteBadRequestError`](./src/meetkai_mka1/errors/createclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListClusterInvitesBadRequestError`](./src/meetkai_mka1/errors/listclusterinvitesbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UpdateClusterInviteBadRequestError`](./src/meetkai_mka1/errors/updateclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`RevokeClusterInviteBadRequestError`](./src/meetkai_mka1/errors/revokeclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ListClusterOrgsBadRequestError`](./src/meetkai_mka1/errors/listclusterorgsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetClusterOrgBadRequestError`](./src/meetkai_mka1/errors/getclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`DeleteClusterOrgBadRequestError`](./src/meetkai_mka1/errors/deleteclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`InviteClusterOrgMembersBadRequestError`](./src/meetkai_mka1/errors/inviteclusterorgmembersbadrequesterror.py): Invalid body or batch size. Status code `400`. Applicable to 1 of 493 methods.*
* [`SuspendClusterOrgBadRequestError`](./src/meetkai_mka1/errors/suspendclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`UnsuspendClusterOrgBadRequestError`](./src/meetkai_mka1/errors/unsuspendclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`ReissueOwnerKeyBadRequestError`](./src/meetkai_mka1/errors/reissueownerkeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetClusterInviteInfoBadRequestError`](./src/meetkai_mka1/errors/getclusterinviteinfobadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 493 methods.*
* [`AcceptClusterInviteBadRequestError`](./src/meetkai_mka1/errors/acceptclusterinvitebadrequesterror.py): Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetJwtFromKeyBadRequestError`](./src/meetkai_mka1/errors/getjwtfromkeybadrequesterror.py): Invalid request body. Status code `400`. Applicable to 1 of 493 methods.*
* [`GetPendingInvitationUnauthorizedError`](./src/meetkai_mka1/errors/getpendinginvitationunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ExchangeSessionTokenUnauthorizedError`](./src/meetkai_mka1/errors/exchangesessiontokenunauthorizederror.py): Missing, invalid, revoked or expiring session. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetFileContentUnauthorizedError`](./src/meetkai_mka1/errors/getfilecontentunauthorizederror.py): Unauthorized - Invalid or missing authentication. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListOrgMembersUnauthorizedError`](./src/meetkai_mka1/errors/listorgmembersunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`InviteOrgMemberUnauthorizedError`](./src/meetkai_mka1/errors/inviteorgmemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateOrgMemberUnauthorizedError`](./src/meetkai_mka1/errors/updateorgmemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`RemoveOrgMemberUnauthorizedError`](./src/meetkai_mka1/errors/removeorgmemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetSsoPolicyUnauthorizedError`](./src/meetkai_mka1/errors/getssopolicyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateSsoPolicyUnauthorizedError`](./src/meetkai_mka1/errors/updatessopolicyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDUnauthorizedError`](./src/meetkai_mka1/errors/getorgbyidunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationUnauthorizedError`](./src/meetkai_mka1/errors/updateorganizationunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetOrgQuotaUnauthorizedError`](./src/meetkai_mka1/errors/getorgquotaunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateOrgQuotaUnauthorizedError`](./src/meetkai_mka1/errors/updateorgquotaunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetOrgRateLimitUnauthorizedError`](./src/meetkai_mka1/errors/getorgratelimitunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateOrgRateLimitUnauthorizedError`](./src/meetkai_mka1/errors/updateorgratelimitunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetNetworkPolicyAccessUnauthorizedError`](./src/meetkai_mka1/errors/getnetworkpolicyaccessunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`CreateTeamUnauthorizedError`](./src/meetkai_mka1/errors/createteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListTeamsUnauthorizedError`](./src/meetkai_mka1/errors/listteamsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetTeamUnauthorizedError`](./src/meetkai_mka1/errors/getteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateTeamUnauthorizedError`](./src/meetkai_mka1/errors/updateteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`DeleteTeamUnauthorizedError`](./src/meetkai_mka1/errors/deleteteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`AddTeamMemberUnauthorizedError`](./src/meetkai_mka1/errors/addteammemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListTeamMembersUnauthorizedError`](./src/meetkai_mka1/errors/listteammembersunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateTeamMemberUnauthorizedError`](./src/meetkai_mka1/errors/updateteammemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`RemoveTeamMemberUnauthorizedError`](./src/meetkai_mka1/errors/removeteammemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`CreateScopedAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/createscopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListScopedAPIKeysUnauthorizedError`](./src/meetkai_mka1/errors/listscopedapikeysunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateScopedAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/updatescopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`RegenerateScopedAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/regeneratescopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ExchangeAPIKeyTokenUnauthorizedError`](./src/meetkai_mka1/errors/exchangeapikeytokenunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`CreateServiceAccountUnauthorizedError`](./src/meetkai_mka1/errors/createserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountsUnauthorizedError`](./src/meetkai_mka1/errors/listserviceaccountsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetServiceAccountUnauthorizedError`](./src/meetkai_mka1/errors/getserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountUnauthorizedError`](./src/meetkai_mka1/errors/deleteserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountAPIKeysUnauthorizedError`](./src/meetkai_mka1/errors/listserviceaccountapikeysunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateServiceAccountAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/updateserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`RegenerateServiceAccountAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`CreateClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/createclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListClusterInvitesUnauthorizedError`](./src/meetkai_mka1/errors/listclusterinvitesunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UpdateClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/updateclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`RevokeClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/revokeclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ListClusterOrgsUnauthorizedError`](./src/meetkai_mka1/errors/listclusterorgsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/getclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`DeleteClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/deleteclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`InviteClusterOrgMembersUnauthorizedError`](./src/meetkai_mka1/errors/inviteclusterorgmembersunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`SuspendClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/suspendclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`UnsuspendClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/unsuspendclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`ReissueOwnerKeyUnauthorizedError`](./src/meetkai_mka1/errors/reissueownerkeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetClusterInviteInfoUnauthorizedError`](./src/meetkai_mka1/errors/getclusterinviteinfounauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`AcceptClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/acceptclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetJwtFromKeyUnauthorizedError`](./src/meetkai_mka1/errors/getjwtfromkeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 493 methods.*
* [`GetPendingInvitationForbiddenError`](./src/meetkai_mka1/errors/getpendinginvitationforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ExchangeSessionTokenForbiddenError`](./src/meetkai_mka1/errors/exchangesessiontokenforbiddenerror.py): Active organization or team is missing or inaccessible. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListOrgMembersForbiddenError`](./src/meetkai_mka1/errors/listorgmembersforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`InviteOrgMemberForbiddenError`](./src/meetkai_mka1/errors/inviteorgmemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateOrgMemberForbiddenError`](./src/meetkai_mka1/errors/updateorgmemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`RemoveOrgMemberForbiddenError`](./src/meetkai_mka1/errors/removeorgmemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetSsoPolicyForbiddenError`](./src/meetkai_mka1/errors/getssopolicyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateSsoPolicyForbiddenError`](./src/meetkai_mka1/errors/updatessopolicyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDForbiddenError`](./src/meetkai_mka1/errors/getorgbyidforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationForbiddenError`](./src/meetkai_mka1/errors/updateorganizationforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetOrgQuotaForbiddenError`](./src/meetkai_mka1/errors/getorgquotaforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateOrgQuotaForbiddenError`](./src/meetkai_mka1/errors/updateorgquotaforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetOrgRateLimitForbiddenError`](./src/meetkai_mka1/errors/getorgratelimitforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateOrgRateLimitForbiddenError`](./src/meetkai_mka1/errors/updateorgratelimitforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetNetworkPolicyAccessForbiddenError`](./src/meetkai_mka1/errors/getnetworkpolicyaccessforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`CreateTeamForbiddenError`](./src/meetkai_mka1/errors/createteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListTeamsForbiddenError`](./src/meetkai_mka1/errors/listteamsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetTeamForbiddenError`](./src/meetkai_mka1/errors/getteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateTeamForbiddenError`](./src/meetkai_mka1/errors/updateteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`DeleteTeamForbiddenError`](./src/meetkai_mka1/errors/deleteteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`AddTeamMemberForbiddenError`](./src/meetkai_mka1/errors/addteammemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListTeamMembersForbiddenError`](./src/meetkai_mka1/errors/listteammembersforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateTeamMemberForbiddenError`](./src/meetkai_mka1/errors/updateteammemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`RemoveTeamMemberForbiddenError`](./src/meetkai_mka1/errors/removeteammemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`CreateScopedAPIKeyForbiddenError`](./src/meetkai_mka1/errors/createscopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListScopedAPIKeysForbiddenError`](./src/meetkai_mka1/errors/listscopedapikeysforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateScopedAPIKeyForbiddenError`](./src/meetkai_mka1/errors/updatescopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`RegenerateScopedAPIKeyForbiddenError`](./src/meetkai_mka1/errors/regeneratescopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ExchangeAPIKeyTokenForbiddenError`](./src/meetkai_mka1/errors/exchangeapikeytokenforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`CreateServiceAccountForbiddenError`](./src/meetkai_mka1/errors/createserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountsForbiddenError`](./src/meetkai_mka1/errors/listserviceaccountsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetServiceAccountForbiddenError`](./src/meetkai_mka1/errors/getserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountForbiddenError`](./src/meetkai_mka1/errors/deleteserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountAPIKeysForbiddenError`](./src/meetkai_mka1/errors/listserviceaccountapikeysforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateServiceAccountAPIKeyForbiddenError`](./src/meetkai_mka1/errors/updateserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountAPIKeyForbiddenError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`RegenerateServiceAccountAPIKeyForbiddenError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`CreateClusterInviteForbiddenError`](./src/meetkai_mka1/errors/createclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListClusterInvitesForbiddenError`](./src/meetkai_mka1/errors/listclusterinvitesforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UpdateClusterInviteForbiddenError`](./src/meetkai_mka1/errors/updateclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`RevokeClusterInviteForbiddenError`](./src/meetkai_mka1/errors/revokeclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ListClusterOrgsForbiddenError`](./src/meetkai_mka1/errors/listclusterorgsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetClusterOrgForbiddenError`](./src/meetkai_mka1/errors/getclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`DeleteClusterOrgForbiddenError`](./src/meetkai_mka1/errors/deleteclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`InviteClusterOrgMembersForbiddenError`](./src/meetkai_mka1/errors/inviteclusterorgmembersforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`SuspendClusterOrgForbiddenError`](./src/meetkai_mka1/errors/suspendclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`UnsuspendClusterOrgForbiddenError`](./src/meetkai_mka1/errors/unsuspendclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`ReissueOwnerKeyForbiddenError`](./src/meetkai_mka1/errors/reissueownerkeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetClusterInviteInfoForbiddenError`](./src/meetkai_mka1/errors/getclusterinviteinfoforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`AcceptClusterInviteForbiddenError`](./src/meetkai_mka1/errors/acceptclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 493 methods.*
* [`GetFileContentNotFoundError`](./src/meetkai_mka1/errors/getfilecontentnotfounderror.py): File not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListOrgMembersNotFoundError`](./src/meetkai_mka1/errors/listorgmembersnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`InviteOrgMemberNotFoundError`](./src/meetkai_mka1/errors/inviteorgmembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateOrgMemberNotFoundError`](./src/meetkai_mka1/errors/updateorgmembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`RemoveOrgMemberNotFoundError`](./src/meetkai_mka1/errors/removeorgmembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetSsoPolicyNotFoundError`](./src/meetkai_mka1/errors/getssopolicynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateSsoPolicyNotFoundError`](./src/meetkai_mka1/errors/updatessopolicynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDNotFoundError`](./src/meetkai_mka1/errors/getorgbyidnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationNotFoundError`](./src/meetkai_mka1/errors/updateorganizationnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetOrgQuotaNotFoundError`](./src/meetkai_mka1/errors/getorgquotanotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateOrgQuotaNotFoundError`](./src/meetkai_mka1/errors/updateorgquotanotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetOrgRateLimitNotFoundError`](./src/meetkai_mka1/errors/getorgratelimitnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateOrgRateLimitNotFoundError`](./src/meetkai_mka1/errors/updateorgratelimitnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetNetworkPolicyAccessNotFoundError`](./src/meetkai_mka1/errors/getnetworkpolicyaccessnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`CreateTeamNotFoundError`](./src/meetkai_mka1/errors/createteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListTeamsNotFoundError`](./src/meetkai_mka1/errors/listteamsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetTeamNotFoundError`](./src/meetkai_mka1/errors/getteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateTeamNotFoundError`](./src/meetkai_mka1/errors/updateteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`DeleteTeamNotFoundError`](./src/meetkai_mka1/errors/deleteteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`AddTeamMemberNotFoundError`](./src/meetkai_mka1/errors/addteammembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListTeamMembersNotFoundError`](./src/meetkai_mka1/errors/listteammembersnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateTeamMemberNotFoundError`](./src/meetkai_mka1/errors/updateteammembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`RemoveTeamMemberNotFoundError`](./src/meetkai_mka1/errors/removeteammembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`CreateScopedAPIKeyNotFoundError`](./src/meetkai_mka1/errors/createscopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListScopedAPIKeysNotFoundError`](./src/meetkai_mka1/errors/listscopedapikeysnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateScopedAPIKeyNotFoundError`](./src/meetkai_mka1/errors/updatescopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`RegenerateScopedAPIKeyNotFoundError`](./src/meetkai_mka1/errors/regeneratescopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ExchangeAPIKeyTokenNotFoundError`](./src/meetkai_mka1/errors/exchangeapikeytokennotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`CreateServiceAccountNotFoundError`](./src/meetkai_mka1/errors/createserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountsNotFoundError`](./src/meetkai_mka1/errors/listserviceaccountsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetServiceAccountNotFoundError`](./src/meetkai_mka1/errors/getserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountNotFoundError`](./src/meetkai_mka1/errors/deleteserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountAPIKeysNotFoundError`](./src/meetkai_mka1/errors/listserviceaccountapikeysnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateServiceAccountAPIKeyNotFoundError`](./src/meetkai_mka1/errors/updateserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountAPIKeyNotFoundError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`RegenerateServiceAccountAPIKeyNotFoundError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`CreateClusterInviteNotFoundError`](./src/meetkai_mka1/errors/createclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListClusterInvitesNotFoundError`](./src/meetkai_mka1/errors/listclusterinvitesnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UpdateClusterInviteNotFoundError`](./src/meetkai_mka1/errors/updateclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`RevokeClusterInviteNotFoundError`](./src/meetkai_mka1/errors/revokeclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListClusterOrgsNotFoundError`](./src/meetkai_mka1/errors/listclusterorgsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetClusterOrgNotFoundError`](./src/meetkai_mka1/errors/getclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`DeleteClusterOrgNotFoundError`](./src/meetkai_mka1/errors/deleteclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`InviteClusterOrgMembersNotFoundError`](./src/meetkai_mka1/errors/inviteclusterorgmembersnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`SuspendClusterOrgNotFoundError`](./src/meetkai_mka1/errors/suspendclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`UnsuspendClusterOrgNotFoundError`](./src/meetkai_mka1/errors/unsuspendclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ReissueOwnerKeyNotFoundError`](./src/meetkai_mka1/errors/reissueownerkeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`GetClusterInviteInfoNotFoundError`](./src/meetkai_mka1/errors/getclusterinviteinfonotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`AcceptClusterInviteNotFoundError`](./src/meetkai_mka1/errors/acceptclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 493 methods.*
* [`ListOrgMembersConflictError`](./src/meetkai_mka1/errors/listorgmembersconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`InviteOrgMemberConflictError`](./src/meetkai_mka1/errors/inviteorgmemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateOrgMemberConflictError`](./src/meetkai_mka1/errors/updateorgmemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`RemoveOrgMemberConflictError`](./src/meetkai_mka1/errors/removeorgmemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetSsoPolicyConflictError`](./src/meetkai_mka1/errors/getssopolicyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateSsoPolicyConflictError`](./src/meetkai_mka1/errors/updatessopolicyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDConflictError`](./src/meetkai_mka1/errors/getorgbyidconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationConflictError`](./src/meetkai_mka1/errors/updateorganizationconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetOrgQuotaConflictError`](./src/meetkai_mka1/errors/getorgquotaconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateOrgQuotaConflictError`](./src/meetkai_mka1/errors/updateorgquotaconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetOrgRateLimitConflictError`](./src/meetkai_mka1/errors/getorgratelimitconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateOrgRateLimitConflictError`](./src/meetkai_mka1/errors/updateorgratelimitconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetNetworkPolicyAccessConflictError`](./src/meetkai_mka1/errors/getnetworkpolicyaccessconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`CreateTeamConflictError`](./src/meetkai_mka1/errors/createteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListTeamsConflictError`](./src/meetkai_mka1/errors/listteamsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetTeamConflictError`](./src/meetkai_mka1/errors/getteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateTeamConflictError`](./src/meetkai_mka1/errors/updateteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`DeleteTeamConflictError`](./src/meetkai_mka1/errors/deleteteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`AddTeamMemberConflictError`](./src/meetkai_mka1/errors/addteammemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListTeamMembersConflictError`](./src/meetkai_mka1/errors/listteammembersconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateTeamMemberConflictError`](./src/meetkai_mka1/errors/updateteammemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`RemoveTeamMemberConflictError`](./src/meetkai_mka1/errors/removeteammemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`CreateScopedAPIKeyConflictError`](./src/meetkai_mka1/errors/createscopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListScopedAPIKeysConflictError`](./src/meetkai_mka1/errors/listscopedapikeysconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateScopedAPIKeyConflictError`](./src/meetkai_mka1/errors/updatescopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`RegenerateScopedAPIKeyConflictError`](./src/meetkai_mka1/errors/regeneratescopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ExchangeAPIKeyTokenConflictError`](./src/meetkai_mka1/errors/exchangeapikeytokenconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`CreateServiceAccountConflictError`](./src/meetkai_mka1/errors/createserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountsConflictError`](./src/meetkai_mka1/errors/listserviceaccountsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetServiceAccountConflictError`](./src/meetkai_mka1/errors/getserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountConflictError`](./src/meetkai_mka1/errors/deleteserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountAPIKeysConflictError`](./src/meetkai_mka1/errors/listserviceaccountapikeysconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateServiceAccountAPIKeyConflictError`](./src/meetkai_mka1/errors/updateserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountAPIKeyConflictError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`RegenerateServiceAccountAPIKeyConflictError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`CreateClusterInviteConflictError`](./src/meetkai_mka1/errors/createclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListClusterInvitesConflictError`](./src/meetkai_mka1/errors/listclusterinvitesconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UpdateClusterInviteConflictError`](./src/meetkai_mka1/errors/updateclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`RevokeClusterInviteConflictError`](./src/meetkai_mka1/errors/revokeclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListClusterOrgsConflictError`](./src/meetkai_mka1/errors/listclusterorgsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetClusterOrgConflictError`](./src/meetkai_mka1/errors/getclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`DeleteClusterOrgConflictError`](./src/meetkai_mka1/errors/deleteclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`InviteClusterOrgMembersConflictError`](./src/meetkai_mka1/errors/inviteclusterorgmembersconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`SuspendClusterOrgConflictError`](./src/meetkai_mka1/errors/suspendclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`UnsuspendClusterOrgConflictError`](./src/meetkai_mka1/errors/unsuspendclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ReissueOwnerKeyConflictError`](./src/meetkai_mka1/errors/reissueownerkeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`GetClusterInviteInfoConflictError`](./src/meetkai_mka1/errors/getclusterinviteinfoconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`AcceptClusterInviteConflictError`](./src/meetkai_mka1/errors/acceptclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 493 methods.*
* [`ListOrgMembersGoneError`](./src/meetkai_mka1/errors/listorgmembersgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`InviteOrgMemberGoneError`](./src/meetkai_mka1/errors/inviteorgmembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateOrgMemberGoneError`](./src/meetkai_mka1/errors/updateorgmembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`RemoveOrgMemberGoneError`](./src/meetkai_mka1/errors/removeorgmembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetSsoPolicyGoneError`](./src/meetkai_mka1/errors/getssopolicygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateSsoPolicyGoneError`](./src/meetkai_mka1/errors/updatessopolicygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDGoneError`](./src/meetkai_mka1/errors/getorgbyidgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationGoneError`](./src/meetkai_mka1/errors/updateorganizationgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetOrgQuotaGoneError`](./src/meetkai_mka1/errors/getorgquotagoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateOrgQuotaGoneError`](./src/meetkai_mka1/errors/updateorgquotagoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetOrgRateLimitGoneError`](./src/meetkai_mka1/errors/getorgratelimitgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateOrgRateLimitGoneError`](./src/meetkai_mka1/errors/updateorgratelimitgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetNetworkPolicyAccessGoneError`](./src/meetkai_mka1/errors/getnetworkpolicyaccessgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`CreateTeamGoneError`](./src/meetkai_mka1/errors/createteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ListTeamsGoneError`](./src/meetkai_mka1/errors/listteamsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetTeamGoneError`](./src/meetkai_mka1/errors/getteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateTeamGoneError`](./src/meetkai_mka1/errors/updateteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`DeleteTeamGoneError`](./src/meetkai_mka1/errors/deleteteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`AddTeamMemberGoneError`](./src/meetkai_mka1/errors/addteammembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ListTeamMembersGoneError`](./src/meetkai_mka1/errors/listteammembersgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateTeamMemberGoneError`](./src/meetkai_mka1/errors/updateteammembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`RemoveTeamMemberGoneError`](./src/meetkai_mka1/errors/removeteammembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`CreateScopedAPIKeyGoneError`](./src/meetkai_mka1/errors/createscopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ListScopedAPIKeysGoneError`](./src/meetkai_mka1/errors/listscopedapikeysgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateScopedAPIKeyGoneError`](./src/meetkai_mka1/errors/updatescopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`RegenerateScopedAPIKeyGoneError`](./src/meetkai_mka1/errors/regeneratescopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ExchangeAPIKeyTokenGoneError`](./src/meetkai_mka1/errors/exchangeapikeytokengoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`CreateServiceAccountGoneError`](./src/meetkai_mka1/errors/createserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountsGoneError`](./src/meetkai_mka1/errors/listserviceaccountsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetServiceAccountGoneError`](./src/meetkai_mka1/errors/getserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountGoneError`](./src/meetkai_mka1/errors/deleteserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountAPIKeysGoneError`](./src/meetkai_mka1/errors/listserviceaccountapikeysgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateServiceAccountAPIKeyGoneError`](./src/meetkai_mka1/errors/updateserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountAPIKeyGoneError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`RegenerateServiceAccountAPIKeyGoneError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`CreateClusterInviteGoneError`](./src/meetkai_mka1/errors/createclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ListClusterInvitesGoneError`](./src/meetkai_mka1/errors/listclusterinvitesgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UpdateClusterInviteGoneError`](./src/meetkai_mka1/errors/updateclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`RevokeClusterInviteGoneError`](./src/meetkai_mka1/errors/revokeclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ListClusterOrgsGoneError`](./src/meetkai_mka1/errors/listclusterorgsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetClusterOrgGoneError`](./src/meetkai_mka1/errors/getclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`DeleteClusterOrgGoneError`](./src/meetkai_mka1/errors/deleteclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`InviteClusterOrgMembersGoneError`](./src/meetkai_mka1/errors/inviteclusterorgmembersgoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`SuspendClusterOrgGoneError`](./src/meetkai_mka1/errors/suspendclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`UnsuspendClusterOrgGoneError`](./src/meetkai_mka1/errors/unsuspendclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ReissueOwnerKeyGoneError`](./src/meetkai_mka1/errors/reissueownerkeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`GetClusterInviteInfoGoneError`](./src/meetkai_mka1/errors/getclusterinviteinfogoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`AcceptClusterInviteGoneError`](./src/meetkai_mka1/errors/acceptclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 493 methods.*
* [`ExchangeSessionTokenRequestEntityTooLargeError`](./src/meetkai_mka1/errors/exchangesessiontokenrequestentitytoolargeerror.py): Request body exceeds the endpoint's 4 KiB limit. Status code `413`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationRequestEntityTooLargeError`](./src/meetkai_mka1/errors/updateorganizationrequestentitytoolargeerror.py): Request or merged metadata exceeds 64 KiB. Status code `413`. Applicable to 1 of 493 methods.*
* [`ExchangeSessionTokenTooManyRequestsError`](./src/meetkai_mka1/errors/exchangesessiontokentoomanyrequestserror.py): Per-session or per-user mint rate exceeded. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListOrgMembersTooManyRequestsError`](./src/meetkai_mka1/errors/listorgmemberstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`InviteOrgMemberTooManyRequestsError`](./src/meetkai_mka1/errors/inviteorgmembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateOrgMemberTooManyRequestsError`](./src/meetkai_mka1/errors/updateorgmembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`RemoveOrgMemberTooManyRequestsError`](./src/meetkai_mka1/errors/removeorgmembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetSsoPolicyTooManyRequestsError`](./src/meetkai_mka1/errors/getssopolicytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateSsoPolicyTooManyRequestsError`](./src/meetkai_mka1/errors/updatessopolicytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDTooManyRequestsError`](./src/meetkai_mka1/errors/getorgbyidtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationTooManyRequestsError`](./src/meetkai_mka1/errors/updateorganizationtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetOrgQuotaTooManyRequestsError`](./src/meetkai_mka1/errors/getorgquotatoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateOrgQuotaTooManyRequestsError`](./src/meetkai_mka1/errors/updateorgquotatoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetOrgRateLimitTooManyRequestsError`](./src/meetkai_mka1/errors/getorgratelimittoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateOrgRateLimitTooManyRequestsError`](./src/meetkai_mka1/errors/updateorgratelimittoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetNetworkPolicyAccessTooManyRequestsError`](./src/meetkai_mka1/errors/getnetworkpolicyaccesstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`CreateTeamTooManyRequestsError`](./src/meetkai_mka1/errors/createteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListTeamsTooManyRequestsError`](./src/meetkai_mka1/errors/listteamstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetTeamTooManyRequestsError`](./src/meetkai_mka1/errors/getteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateTeamTooManyRequestsError`](./src/meetkai_mka1/errors/updateteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`DeleteTeamTooManyRequestsError`](./src/meetkai_mka1/errors/deleteteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`AddTeamMemberTooManyRequestsError`](./src/meetkai_mka1/errors/addteammembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListTeamMembersTooManyRequestsError`](./src/meetkai_mka1/errors/listteammemberstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateTeamMemberTooManyRequestsError`](./src/meetkai_mka1/errors/updateteammembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`RemoveTeamMemberTooManyRequestsError`](./src/meetkai_mka1/errors/removeteammembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`CreateScopedAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/createscopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListScopedAPIKeysTooManyRequestsError`](./src/meetkai_mka1/errors/listscopedapikeystoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateScopedAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/updatescopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`RegenerateScopedAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/regeneratescopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ExchangeAPIKeyTokenTooManyRequestsError`](./src/meetkai_mka1/errors/exchangeapikeytokentoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`CreateServiceAccountTooManyRequestsError`](./src/meetkai_mka1/errors/createserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountsTooManyRequestsError`](./src/meetkai_mka1/errors/listserviceaccountstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetServiceAccountTooManyRequestsError`](./src/meetkai_mka1/errors/getserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountTooManyRequestsError`](./src/meetkai_mka1/errors/deleteserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListServiceAccountAPIKeysTooManyRequestsError`](./src/meetkai_mka1/errors/listserviceaccountapikeystoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateServiceAccountAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/updateserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`DeleteServiceAccountAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`RegenerateServiceAccountAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`CreateClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/createclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListClusterInvitesTooManyRequestsError`](./src/meetkai_mka1/errors/listclusterinvitestoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UpdateClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/updateclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`RevokeClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/revokeclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ListClusterOrgsTooManyRequestsError`](./src/meetkai_mka1/errors/listclusterorgstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/getclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`DeleteClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/deleteclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`InviteClusterOrgMembersTooManyRequestsError`](./src/meetkai_mka1/errors/inviteclusterorgmemberstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`SuspendClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/suspendclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`UnsuspendClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/unsuspendclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ReissueOwnerKeyTooManyRequestsError`](./src/meetkai_mka1/errors/reissueownerkeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`GetClusterInviteInfoTooManyRequestsError`](./src/meetkai_mka1/errors/getclusterinviteinfotoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`AcceptClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/acceptclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 493 methods.*
* [`ExchangeSessionTokenInternalServerError`](./src/meetkai_mka1/errors/exchangesessiontokeninternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 493 methods.*
* [`GetFileContentInternalServerError`](./src/meetkai_mka1/errors/getfilecontentinternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 493 methods.*
* [`GetOrgByIDInternalServerError`](./src/meetkai_mka1/errors/getorgbyidinternalservererror.py): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 493 methods.*
* [`UpdateOrganizationInternalServerError`](./src/meetkai_mka1/errors/updateorganizationinternalservererror.py): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 493 methods.*
* [`GetJwtFromKeyInternalServerError`](./src/meetkai_mka1/errors/getjwtfromkeyinternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 493 methods.*
* [`ServiceUnavailableError`](./src/meetkai_mka1/errors/serviceunavailableerror.py): The invitation spend limit could not be confirmed. The organization and invitation claim were rolled back; retry acceptance. Status code `503`. Applicable to 1 of 493 methods.*
* [`ResponseValidationError`](./src/meetkai_mka1/errors/responsevalidationerror.py): Type mismatch between the response data and the expected Pydantic model. Provides access to the Pydantic validation error via the `cause` attribute.

</details>

\* Check [the method documentation](#available-resources-and-operations) to see if the error is applicable.
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `server_idx: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                   | Description                                            |
| --- | ------------------------ | ------------------------------------------------------ |
| 0   | `https://apigw.mka1.com` | MKA1 API Gateway                                       |
| 1   | `/`                      | Relative server URL (configurable via SDK constructor) |

#### Example

```python
from meetkai_mka1 import SDK


with SDK(
    server_idx=0,
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

    # Use the SDK ...

```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `server_url: str` optional parameter when initializing the SDK client instance. For example:
```python
from meetkai_mka1 import SDK


with SDK(
    server_url="https://apigw.mka1.com",
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

    # Use the SDK ...

```
<!-- End Server Selection [server] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The Python SDK makes API calls using the [httpx](https://www.python-httpx.org/) HTTP library.  In order to provide a convenient way to configure timeouts, cookies, proxies, custom headers, and other low-level configuration, you can initialize the SDK client with your own HTTP client instance.
Depending on whether you are using the sync or async version of the SDK, you can pass an instance of `HttpClient` or `AsyncHttpClient` respectively, which are Protocol's ensuring that the client has the necessary methods to make API calls.
This allows you to wrap the client with your own custom logic, such as adding custom headers, logging, or error handling, or you can just pass an instance of `httpx.Client` or `httpx.AsyncClient` directly.

For example, you could specify a header for every request that this sdk makes as follows:
```python
from meetkai_mka1 import SDK
import httpx

http_client = httpx.Client(headers={"x-custom-header": "someValue"})
s = SDK(client=http_client)
```

or you could wrap the client with your own custom logic:
```python
from meetkai_mka1 import SDK
from meetkai_mka1.httpclient import AsyncHttpClient
import httpx

class CustomClient(AsyncHttpClient):
    client: AsyncHttpClient

    def __init__(self, client: AsyncHttpClient):
        self.client = client

    async def send(
        self,
        request: httpx.Request,
        *,
        stream: bool = False,
        auth: Union[
            httpx._types.AuthTypes, httpx._client.UseClientDefault, None
        ] = httpx.USE_CLIENT_DEFAULT,
        follow_redirects: Union[
            bool, httpx._client.UseClientDefault
        ] = httpx.USE_CLIENT_DEFAULT,
    ) -> httpx.Response:
        request.headers["Client-Level-Header"] = "added by client"

        return await self.client.send(
            request, stream=stream, auth=auth, follow_redirects=follow_redirects
        )

    def build_request(
        self,
        method: str,
        url: httpx._types.URLTypes,
        *,
        content: Optional[httpx._types.RequestContent] = None,
        data: Optional[httpx._types.RequestData] = None,
        files: Optional[httpx._types.RequestFiles] = None,
        json: Optional[Any] = None,
        params: Optional[httpx._types.QueryParamTypes] = None,
        headers: Optional[httpx._types.HeaderTypes] = None,
        cookies: Optional[httpx._types.CookieTypes] = None,
        timeout: Union[
            httpx._types.TimeoutTypes, httpx._client.UseClientDefault
        ] = httpx.USE_CLIENT_DEFAULT,
        extensions: Optional[httpx._types.RequestExtensions] = None,
    ) -> httpx.Request:
        return self.client.build_request(
            method,
            url,
            content=content,
            data=data,
            files=files,
            json=json,
            params=params,
            headers=headers,
            cookies=cookies,
            timeout=timeout,
            extensions=extensions,
        )

s = SDK(async_client=CustomClient(httpx.AsyncClient()))
```
### httpx2 (Pydantic's httpx fork)

[httpx2](https://httpx2.pydantic.dev/) is Pydantic's maintained fork of `httpx`. To run this SDK on httpx2, call `alias_httpx()` at your program's entry point, before importing the SDK, so every `import httpx` — including the ones inside the SDK — resolves to `httpx2`:
```python
import httpx2

httpx2.alias_httpx()

from meetkai_mka1 import SDK

s = SDK()
```

An SDK can also be generated against httpx2 directly, so it depends on the fork instead of `httpx`, by setting `python.httpClientLibrary: httpx2` in `gen.yaml`.
<!-- End Custom HTTP Client [http-client] -->

<!-- Start Resource Management [resource-management] -->
## Resource Management

The `SDK` class implements the context manager protocol and registers a finalizer function to close the underlying sync and async HTTPX clients it uses under the hood. This will close HTTP connections, release memory and free up other resources held by the SDK. In short-lived Python programs and notebooks that make a few SDK method calls, resource management may not be a concern. However, in longer-lived programs, it is beneficial to create a single SDK instance via a [context manager][context-manager] and reuse it across the application.

[context-manager]: https://docs.python.org/3/reference/datamodel.html#context-managers

```python
from meetkai_mka1 import SDK
def main():

    with SDK(
        bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
    ) as sdk:
        # Rest of application here...


# Or when using async:
async def amain():

    async with SDK(
        bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
    ) as sdk:
        # Rest of application here...
```
<!-- End Resource Management [resource-management] -->

<!-- Start Debugging [debug] -->
## Debugging

You can setup your SDK to emit debug logs for SDK requests and responses.

You can pass your own logger class directly into your SDK.
```python
from meetkai_mka1 import SDK
import logging

logging.basicConfig(level=logging.DEBUG)
s = SDK(debug_logger=logging.getLogger("meetkai_mka1"))
```
<!-- End Debugging [debug] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=openapi&utm_campaign=python)
