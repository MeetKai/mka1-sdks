# openapi

Developer-friendly & type-safe Python SDK specifically catered to leverage *openapi* API.

[![Built by Speakeasy](https://img.shields.io/badge/Built_by-SPEAKEASY-374151?style=for-the-badge&labelColor=f3f4f6)](https://www.speakeasy.com/?utm_source=openapi&utm_campaign=python)
[![License: MIT](https://img.shields.io/badge/LICENSE_//_MIT-3b5bdb?style=for-the-badge&labelColor=eff6ff)](https://opensource.org/licenses/MIT)


<br /><br />
> [!IMPORTANT]
> This SDK is not yet ready for production use. To complete setup please follow the steps outlined in your [workspace](https://app.speakeasy.com/org/meetkai/mk1). Delete this section before > publishing to a package manager.

<!-- Start Summary [summary] -->
## Summary

MKA1 API: The MKA1 API is a RESTful API that provides access to the MKA1 platform. Learn how to get started with the API and the TypeScript SDK [here](https://mka1.apidocumentation.com/guides/getting-started).
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [openapi](https://github.com/MeetKai/mka1-sdks/blob/master/python/#openapi)
  * [SDK Installation](https://github.com/MeetKai/mka1-sdks/blob/master/python/#sdk-installation)
  * [IDE Support](https://github.com/MeetKai/mka1-sdks/blob/master/python/#ide-support)
  * [SDK Example Usage](https://github.com/MeetKai/mka1-sdks/blob/master/python/#sdk-example-usage)
  * [Authentication](https://github.com/MeetKai/mka1-sdks/blob/master/python/#authentication)
  * [Available Resources and Operations](https://github.com/MeetKai/mka1-sdks/blob/master/python/#available-resources-and-operations)
  * [Server-sent event streaming](https://github.com/MeetKai/mka1-sdks/blob/master/python/#server-sent-event-streaming)
  * [File uploads](https://github.com/MeetKai/mka1-sdks/blob/master/python/#file-uploads)
  * [Retries](https://github.com/MeetKai/mka1-sdks/blob/master/python/#retries)
  * [Error Handling](https://github.com/MeetKai/mka1-sdks/blob/master/python/#error-handling)
  * [Server Selection](https://github.com/MeetKai/mka1-sdks/blob/master/python/#server-selection)
  * [Custom HTTP Client](https://github.com/MeetKai/mka1-sdks/blob/master/python/#custom-http-client)
  * [Resource Management](https://github.com/MeetKai/mka1-sdks/blob/master/python/#resource-management)
  * [Debugging](https://github.com/MeetKai/mka1-sdks/blob/master/python/#debugging)
* [Development](https://github.com/MeetKai/mka1-sdks/blob/master/python/#development)
  * [Maturity](https://github.com/MeetKai/mka1-sdks/blob/master/python/#maturity)
  * [Contributions](https://github.com/MeetKai/mka1-sdks/blob/master/python/#contributions)

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

    res = sdk.auth.orgs.get_by_id(security=models.GetOrgByIDSecurity(

    ), org_id="<id>")

    # Handle response
    print(res)

```
<!-- End Authentication [security] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AgentConnectors](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentconnectors/README.md)

* [list_agent_connectors](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentconnectors/README.md#list_agent_connectors) - List connectors for an agent
* [create_agent_connector](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentconnectors/README.md#create_agent_connector) - Create a connector
* [setup_whats_app_app_webhook](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentconnectors/README.md#setup_whats_app_app_webhook) - Set up a WhatsApp app webhook (Beta)
* [get_agent_connector](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentconnectors/README.md#get_agent_connector) - Retrieve a connector
* [delete_agent_connector](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentconnectors/README.md#delete_agent_connector) - Delete a connector
* [activate_agent_connector](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentconnectors/README.md#activate_agent_connector) - Activate a connector

### [AgentRuns](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentruns/README.md)

* [list_agent_runs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentruns/README.md#list_agent_runs) - List runs for an agent
* [create_agent_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentruns/README.md#create_agent_run) - Start a saved agent run
* [stream_agent_run_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentruns/README.md#stream_agent_run_events) - Stream agent run events
* [wake_agent_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentruns/README.md#wake_agent_run) - Wake a sleeping agent run
* [decide_agent_run_mcp_approval](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentruns/README.md#decide_agent_run_mcp_approval) - Approve or deny a pending MCP tool call
* [get_agent_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentruns/README.md#get_agent_run) - Retrieve an agent run

### [AgentSchedules](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md)

* [list_agent_schedules](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md#list_agent_schedules) - List schedules for an agent
* [create_agent_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md#create_agent_schedule) - Create an agent schedule
* [get_agent_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md#get_agent_schedule) - Retrieve an agent schedule
* [update_agent_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md#update_agent_schedule) - Update an agent schedule
* [delete_agent_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md#delete_agent_schedule) - Delete an agent schedule
* [pause_agent_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md#pause_agent_schedule) - Pause an agent schedule
* [resume_agent_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentschedules/README.md#resume_agent_schedule) - Resume an agent schedule

### [AgentVersions](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentversions/README.md)

* [list_agent_versions](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentversions/README.md#list_agent_versions) - List agent versions
* [get_agent_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentversions/README.md#get_agent_version) - Retrieve an agent version
* [rollback_agent_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agentversions/README.md#rollback_agent_version) - Roll back an agent to a version

### [Agents](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agents/README.md)

* [list_agents](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agents/README.md#list_agents) - List agents
* [create_agent](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agents/README.md#create_agent) - Create an agent
* [get_agent](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agents/README.md#get_agent) - Retrieve an agent
* [update_agent](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agents/README.md#update_agent) - Update an agent
* [delete_agent](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/agents/README.md#delete_agent) - Delete an agent

### [Analytics](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analytics/README.md)

* [capture](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analytics/README.md#capture) - Durably accept a batch of events
* [query](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analytics/README.md#query) - Query event counts or unique visitors

#### [Analytics.Events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/events/README.md)

* [search](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/events/README.md#search) - Search events in a time range

#### [Analytics.Keys](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/keys/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/keys/README.md#create) - Create a capture key and return its secret once
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/keys/README.md#list) - List capture key metadata
* [revoke](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/keys/README.md#revoke) - Revoke a capture key

#### [Analytics.Projects](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analyticsprojects/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analyticsprojects/README.md#create) - Create an analytics project
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analyticsprojects/README.md#list) - List accessible analytics projects
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analyticsprojects/README.md#get) - Get an analytics project
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analyticsprojects/README.md#update) - Rename an active analytics project
* [archive](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/analyticsprojects/README.md#archive) - Archive an analytics project

#### [Analytics.Visitors](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/visitors/README.md)

* [search](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/visitors/README.md#search) - Search visitors in a time range

### [~~Auth.ApiKey~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/authapikey/README.md)

* [~~get_jwt_from_key~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/authapikey/README.md#get_jwt_from_key) - Exchange API key for a JWT token :warning: **Deprecated** Use [exchange_token](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/apikeys/README.md#exchange_token) instead.

### [Auth.ApiKeys](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/apikeys/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/apikeys/README.md#create) - Mint a scoped API key
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/apikeys/README.md#list) - List scoped API keys
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/apikeys/README.md#update) - Update a scoped API key
* [regenerate](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/apikeys/README.md#regenerate) - Rotate a scoped API key's secret
* [exchange_token](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/apikeys/README.md#exchange_token) - Exchange API key for a JWT token

### [Auth.Cluster](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md)

* [create_invite](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#create_invite) - Create a cluster invitation
* [list_invites](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#list_invites) - List cluster invitations
* [update_invite](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#update_invite) - Update a pending cluster invitation
* [revoke_invite](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#revoke_invite) - Revoke a cluster invitation
* [list_orgs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#list_orgs) - List all organizations
* [get_org](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#get_org) - Get an organization
* [delete_org](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#delete_org) - Soft-delete an organization
* [invite_org_members](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#invite_org_members) - Invite members on behalf of an organization
* [suspend_org](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#suspend_org) - Suspend an organization
* [unsuspend_org](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#unsuspend_org) - Unsuspend an organization
* [reissue_owner_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#reissue_owner_key) - Re-issue an org owner key (recovery)
* [invite_info](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#invite_info) - Read cluster-invite info (public)
* [accept_invite](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/cluster/README.md#accept_invite) - Accept a cluster invitation (public)

### [Auth.Orgs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/orgs/README.md)

* [get_by_id](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/orgs/README.md#get_by_id) - Get basic organization details
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/orgs/README.md#update) - Patch organization metadata (cluster-admin)
* [get_quota](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/orgs/README.md#get_quota) - Get an org's usage quota
* [update_quota](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/orgs/README.md#update_quota) - Set an org's usage quota (cluster-admin)
* [get_rate_limit](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/orgs/README.md#get_rate_limit) - Get an org's rate limit
* [update_rate_limit](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/orgs/README.md#update_rate_limit) - Set an org's rate limit (cluster-admin)

### [Auth.ServiceAccounts](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#create) - Create a service account
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#list) - List service accounts
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#get) - Get a service account
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#delete) - Delete a service account
* [list_api_keys](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#list_api_keys) - List a service account's API keys
* [update_api_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#update_api_key) - Update a service-account API key
* [delete_api_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#delete_api_key) - Delete a service-account API key
* [regenerate_api_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/serviceaccounts/README.md#regenerate_api_key) - Rotate a service-account API key's secret

### [Auth.Teams](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#create) - Create a team
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#list) - List teams in an org
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#get) - Get a team
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#update) - Rename a team
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#delete) - Delete a team
* [add_member](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#add_member) - Add a team member
* [list_members](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#list_members) - List team members
* [remove_member](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/teams/README.md#remove_member) - Remove a team member

### [Billing](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/billing/README.md)

* [get_organization_billing](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/billing/README.md#get_organization_billing)
* [set_organization_billing_enabled](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/billing/README.md#set_organization_billing_enabled)
* [update_organization_billing_profile](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/billing/README.md#update_organization_billing_profile)
* [create_organization_billing_setup](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/billing/README.md#create_organization_billing_setup)
* [create_organization_billing_portal](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/billing/README.md#create_organization_billing_portal)
* [list_organization_billing_invoices](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/billing/README.md#list_organization_billing_invoices)

### [Budgets](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#list) - List budgets
* [get_org](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_org) - List org budgets
* [set_org](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_org) - Set an org budget
* [delete_org](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_org) - Delete an org budget
* [org_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#org_events) - List org budget events
* [get_api_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_api_key) - List apikey budgets
* [set_api_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_api_key) - Set an apikey budget
* [delete_api_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_api_key) - Delete an apikey budget
* [api_key_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#api_key_events) - List apikey budget events
* [get_user](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_user) - List user budgets
* [set_user](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_user) - Set a user budget
* [delete_user](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_user) - Delete a user budget
* [user_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#user_events) - List user budget events
* [get_team](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_team) - List team budgets
* [set_team](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_team) - Set a team budget
* [delete_team](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_team) - Delete a team budget
* [team_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#team_events) - List team budget events
* [get_external_user](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_external_user) - List external user budgets
* [set_external_user](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_external_user) - Set a external user budget
* [delete_external_user](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_external_user) - Delete a external user budget
* [external_user_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#external_user_events) - List external user budget events
* [get_user_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_user_default) - List per-user default budgets
* [set_user_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_user_default) - Set a per-user default budget
* [delete_user_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_user_default) - Delete a per-user default budget
* [user_default_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#user_default_events) - List per-user default budget events
* [get_team_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_team_default) - List per-team default budgets
* [set_team_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_team_default) - Set a per-team default budget
* [delete_team_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_team_default) - Delete a per-team default budget
* [team_default_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#team_default_events) - List per-team default budget events
* [get_external_user_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_external_user_default) - List per-external user default budgets
* [set_external_user_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_external_user_default) - Set a per-external user default budget
* [delete_external_user_default](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#delete_external_user_default) - Delete a per-external user default budget
* [external_user_default_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#external_user_default_events) - List per-external user default budget events
* [get_currency](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#get_currency) - Get display currency
* [set_currency](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/budgets/README.md#set_currency) - Set display currency

### [ComputeCatalog](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computecatalog/README.md)

* [list_accelerators](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computecatalog/README.md#list_accelerators) - List accelerators
* [get_accelerator](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computecatalog/README.md#get_accelerator) - Get an accelerator
* [list_compute_offers](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computecatalog/README.md#list_compute_offers) - List provider offers
* [list_compute_providers](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computecatalog/README.md#list_compute_providers) - List provider health
* [create_compute_quote](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computecatalog/README.md#create_compute_quote) - Create a quote

### [ComputeJobs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md)

* [list_jobs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md#list_jobs) - List jobs
* [create_job](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md#create_job) - Create a job
* [get_job](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md#get_job) - Get a job
* [list_job_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md#list_job_events) - List job events
* [list_job_instances](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md#list_job_instances) - List observed job instances
* [list_job_logs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md#list_job_logs) - List job logs
* [terminate_job](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computejobs/README.md#terminate_job) - Terminate a job

### [ComputePricing](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computepricingsdk/README.md)

* [get_pricing](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computepricingsdk/README.md#get_pricing) - Get the latest committed storage price
* [put_pricing](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computepricingsdk/README.md#put_pricing) - Create an immutable storage-price version

### [ComputeSecrets](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computesecrets/README.md)

* [list_compute_secrets](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computesecrets/README.md#list_compute_secrets) - List secrets
* [create_compute_secret](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computesecrets/README.md#create_compute_secret) - Create a secret
* [delete_compute_secret](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computesecrets/README.md#delete_compute_secret) - Delete a secret
* [get_compute_secret](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computesecrets/README.md#get_compute_secret) - Get a secret

### [ComputeServices](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md)

* [list_services](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#list_services) - List services
* [create_service](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#create_service) - Create a service
* [get_service](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#get_service) - Get a service
* [list_service_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#list_service_events) - List service events
* [list_service_instances](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#list_service_instances) - List observed service instances
* [list_service_logs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#list_service_logs) - List service logs
* [update_service_scaling](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#update_service_scaling) - Replace a service scaling policy
* [terminate_service](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeservices/README.md#terminate_service) - Terminate a service

### [ComputeTenants](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computetenants/README.md)

* [list_compute_tenants](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computetenants/README.md#list_compute_tenants) - List tenants
* [get_compute_tenant](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computetenants/README.md#get_compute_tenant) - Get a tenant
* [put_compute_tenant](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computetenants/README.md#put_compute_tenant) - Update a tenant

### [ComputeUsage](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeusagesdk/README.md)

* [get_compute_usage](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computeusagesdk/README.md#get_compute_usage) - Get usage

### [ComputeVolumes](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computevolumes/README.md)

* [list_standalone_volumes](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computevolumes/README.md#list_standalone_volumes) - List organization volumes
* [create_standalone_volume](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computevolumes/README.md#create_standalone_volume) - Create a standalone shared volume
* [delete_standalone_volume](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computevolumes/README.md#delete_standalone_volume) - Permanently delete a standalone volume
* [get_standalone_volume](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computevolumes/README.md#get_standalone_volume) - Get a standalone volume
* [list_standalone_volume_attachments](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/computevolumes/README.md#list_standalone_volume_attachments) - List volume attachments

### [Datasets](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md)

* [list_generators](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#list_generators) - List Generators
* [get_generator](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#get_generator) - Get Generator
* [quote_generator](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#quote_generator) - Quote Generator
* [list_generations](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#list_generations) - List Generations
* [create_generation](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#create_generation) - Create Generation
* [get_generation](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#get_generation) - Get Generation
* [get_generation_logs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#get_generation_logs) - Get Logs
* [get_generation_events](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#get_generation_events) - Get Events
* [cancel_generation](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#cancel_generation) - Cancel Generation
* [list_formats](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#list_formats) - List Formats
* [get_format](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/datasets/README.md#get_format) - Get Format

### [Flags](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#list) - List flags
* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#create) - Create a flag
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#delete) - Delete a flag and its settings in every environment
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#get) - Get a flag
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#update) - Update a flag's name, description, default value, or project
* [archive](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#archive) - Archive a flag
* [set_environment_state](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#set_environment_state) - Replace a flag's settings in one environment
* [unarchive](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flags/README.md#unarchive) - Restore an archived flag

#### [Flags.Audit](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/audit/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/audit/README.md#list) - List audit entries, newest first

#### [Flags.Environments](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#list) - List environments
* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#create) - Create an environment
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#delete) - Delete an environment and every flag setting in it
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#update) - Rename an environment
* [evaluate](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#evaluate) - Evaluate every flag for an identity
* [evaluate_with_traits](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#evaluate_with_traits) - Evaluate every flag for an identity with traits
* [revoke_evaluation_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#revoke_evaluation_key) - Revoke an environment evaluation key
* [generate_evaluation_key](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsenvironments/README.md#generate_evaluation_key) - Generate or replace an environment evaluation key

#### [Flags.Projects](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsprojects/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsprojects/README.md#list) - List projects
* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsprojects/README.md#create) - Create a project
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsprojects/README.md#delete) - Delete an empty project
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsprojects/README.md#get) - Get a project
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/flagsprojects/README.md#update) - Rename a project

### [Guardrails](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/guardrails/README.md)

* [get_guardrails](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/guardrails/README.md#get_guardrails) - Get effective guardrails
* [update_guardrails](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/guardrails/README.md#update_guardrails) - Update guardrails policy
* [delete_guardrails](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/guardrails/README.md#delete_guardrails) - Delete guardrails policy
* [list_guardrails_policies](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/guardrails/README.md#list_guardrails_policies) - List guardrails policies
* [test_guardrails](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/guardrails/README.md#test_guardrails) - Test content against guardrails

### [Llm.Batches](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/batches/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/batches/README.md#create) - Create a batch
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/batches/README.md#list) - List batches
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/batches/README.md#get) - Get a batch
* [cancel](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/batches/README.md#cancel) - Cancel a batch

### [~~Llm.Chat~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/chat/README.md)

* [~~create_chat~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/chat/README.md#create_chat) - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
* [~~stream~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/chat/README.md#stream) - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**

### [Llm.Classify](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/classify/README.md)

* [classify](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/classify/README.md#classify) - Classify text into predefined categories

### [Llm.Conversations](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#create) - Create a conversation
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#list) - List conversations
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#get) - Retrieve a conversation
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#update) - Update a conversation
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#delete) - Delete a conversation
* [list_items](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#list_items) - List conversation items
* [create_items](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#create_items) - Create conversation items
* [delete_items](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#delete_items) - Delete multiple conversation items
* [get_item](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#get_item) - Retrieve a conversation item
* [delete_item](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/conversations/README.md#delete_item) - Delete a conversation item

### [Llm.Embeddings](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/embeddings/README.md)

* [list_models](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/embeddings/README.md#list_models) - List available embedding models
* [embed](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/embeddings/README.md#embed) - Create text embeddings

### [Llm.Evals](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md)

* [create_suite](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#create_suite) - Create an eval suite
* [list_suites](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#list_suites) - List eval suites
* [get_suite](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_suite) - Get an eval suite
* [delete_suite](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#delete_suite) - Delete an eval suite
* [create_suite_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#create_suite_version) - Create an eval suite version
* [list_suite_versions](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#list_suite_versions) - List eval suite versions
* [get_suite_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_suite_version) - Get an eval suite version
* [list_suite_leaderboard_runs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#list_suite_leaderboard_runs) - List leaderboard runs for an eval suite
* [get_suite_leaderboard](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_suite_leaderboard) - Get the coding-agent leaderboard for an eval suite
* [measure_suite_tokens](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#measure_suite_tokens) - Count tokens from stored text for a suite's unmeasured samples
* [create_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#create_run) - Create an eval run
* [list_runs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#list_runs) - List eval runs
* [get_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_run) - Get an eval run
* [delete_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#delete_run) - Delete an eval run
* [cancel_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#cancel_run) - Cancel an eval run
* [rerun_failed_samples](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#rerun_failed_samples) - Rerun failed eval samples
* [retry_failed_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#retry_failed_run) - Retry an eval run
* [get_run_overview](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_run_overview) - Get an eval run overview
* [list_samples](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#list_samples) - List eval samples
* [get_sample_audio](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_sample_audio) - Get eval sample audio
* [get_sample_trajectory](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_sample_trajectory) - Get an eval sample trajectory
* [upload_sample_trajectory](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#upload_sample_trajectory) - Upload an eval sample trajectory
* [get_artifacts](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_artifacts) - Get eval run artifacts
* [import_agent_run](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#import_agent_run) - Import a finished coding-agent run
* [append_agent_trials](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#append_agent_trials) - Append trials to an open coding-agent run
* [import_historical_results](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#import_historical_results) - Import historical eval results from Hugging Face
* [create_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#create_schedule) - Create an eval schedule
* [list_schedules](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#list_schedules) - List eval schedules
* [get_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#get_schedule) - Get an eval schedule
* [update_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#update_schedule) - Update an eval schedule
* [delete_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#delete_schedule) - Delete an eval schedule
* [trigger_schedule](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#trigger_schedule) - Trigger an eval schedule now
* [list_schedule_runs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/evals/README.md#list_schedule_runs) - List runs created by an eval schedule

### [Llm.Extract](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/extract/README.md)

* [extract](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/extract/README.md#extract) - Extract structured data with inline JSON Schema
* [create_schema](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/extract/README.md#create_schema) - Create reusable extraction schema template
* [get_schema](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/extract/README.md#get_schema) - Get extraction schema by ID
* [update_schema](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/extract/README.md#update_schema) - Update extraction schema by ID
* [delete_schema](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/extract/README.md#delete_schema) - Delete extraction schema by ID
* [extract_with_schema](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/extract/README.md#extract_with_schema) - Extract data using saved schema template

### [Llm.Feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md)

* [create_completion_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#create_completion_feedback) - Submit feedback for chat completion
* [list_completion_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#list_completion_feedback) - List chat completion feedback
* [get_completion_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#get_completion_feedback) - Retrieve feedback by completion ID
* [update_completion_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#update_completion_feedback) - Update existing completion feedback
* [batch_get_completion_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#batch_get_completion_feedback) - Batch retrieve feedback for multiple completions
* [create_response_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#create_response_feedback) - Submit feedback for response
* [list_response_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#list_response_feedback) - List response feedback
* [get_response_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#get_response_feedback) - Retrieve feedback by response ID
* [update_response_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#update_response_feedback) - Update existing response feedback
* [batch_get_response_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#batch_get_response_feedback) - Batch retrieve feedback for multiple responses
* [export_completion_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#export_completion_feedback) - Export completion feedback as CSV
* [export_response_feedback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#export_response_feedback) - Export response feedback as CSV
* [start_export](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#start_export) - Start feedback export
* [get_export_status](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/feedback/README.md#get_export_status) - Get feedback export status

### [Llm.Files](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/files/README.md)

* [upload](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/files/README.md#upload) - Upload file
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/files/README.md#list) - List files
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/files/README.md#get) - Retrieve file
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/files/README.md#delete) - Delete file
* [content](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/files/README.md#content) - Retrieve file content

### [~~Llm.FineTuning~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md)

* [~~create~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#create) - [Deprecated] Create a fine-tuning job :warning: **Deprecated**
* [~~list~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#list) - [Deprecated] List fine-tuning jobs :warning: **Deprecated**
* [~~retrieve~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#retrieve) - [Deprecated] Retrieve a fine-tuning job :warning: **Deprecated**
* [~~cancel~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#cancel) - [Deprecated] Cancel a fine-tuning job :warning: **Deprecated**
* [~~pause~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#pause) - [Deprecated] Pause a fine-tuning job :warning: **Deprecated**
* [~~resume~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#resume) - [Deprecated] Resume a fine-tuning job :warning: **Deprecated**
* [~~list_events~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#list_events) - [Deprecated] List fine-tuning events :warning: **Deprecated**
* [~~list_checkpoints~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/finetuning/README.md#list_checkpoints) - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**

### [Llm.Images](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/images/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/images/README.md#create) - Generate images from text descriptions

### [Llm.McpVault](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md)

* [create_server](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#create_server) - Create MCP server
* [list_servers](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#list_servers) - List MCP servers
* [get_server](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#get_server) - Retrieve MCP server
* [update_server](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#update_server) - Update MCP server
* [delete_server](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#delete_server) - Delete MCP server
* [create_credential](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#create_credential) - Create MCP credential
* [list_credentials](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#list_credentials) - List MCP credentials
* [delete_credential](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#delete_credential) - Delete MCP credential
* [test_server](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/mcpvault/README.md#test_server) - Test MCP server

### [Llm.MemoryStores](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#create) - Create memory store
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#list) - List memory stores
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#get) - Retrieve memory store
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#update) - Update memory store
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#delete) - Delete memory store
* [create_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#create_entry) - Create memory entry
* [list_entries](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#list_entries) - List memory entries
* [get_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#get_entry) - Retrieve memory entry
* [update_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#update_entry) - Update memory entry
* [delete_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/memorystores/README.md#delete_entry) - Delete memory entry

### [Llm.Models](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list) - List available models
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#get) - Retrieve a model
* [list_catalog](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_catalog) - List the organization's model catalog
* [add_catalog_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#add_catalog_entry) - Define a BYO catalog model
* [update_catalog_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#update_catalog_entry) - Update a BYO catalog model
* [delete_catalog_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#delete_catalog_entry) - Remove a BYO catalog model
* [check_catalog_health](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#check_catalog_health) - Check a BYO catalog model's health
* [list_catalog_org_access](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_catalog_org_access) - List an organization's cluster model access
* [add_catalog_org_access](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#add_catalog_org_access) - Add cluster model access for an organization
* [replace_catalog_org_access](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#replace_catalog_org_access) - Replace an organization's cluster model access
* [list_catalog_model_access](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_catalog_model_access) - List organizations with access to a cluster model
* [list_registry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_registry) - List the organization's active model registry
* [activate_registry_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#activate_registry_entry) - Activate a catalog entry
* [deactivate_registry_entry](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#deactivate_registry_entry) - Deactivate a model registry name
* [list_org_auto_models](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_org_auto_models) - List this org's auto-model overrides
* [put_org_auto_model](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#put_org_auto_model) - Set this org's auto policy for an endpoint
* [delete_org_auto_model](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#delete_org_auto_model) - Clear this org's auto-model override for an endpoint
* [get_cluster_currency](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#get_cluster_currency) - Get the cluster currency
* [set_cluster_currency](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#set_cluster_currency) - Set the cluster currency
* [list_cluster_prices](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_cluster_prices) - List cluster-default model prices
* [set_cluster_price](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#set_cluster_price) - Set a cluster-default model price
* [clear_cluster_price](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#clear_cluster_price) - Clear a cluster-default model price
* [list_org_prices](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_org_prices) - List an org's price overrides
* [set_org_price](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#set_org_price) - Set an org price override
* [clear_org_price](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#clear_org_price) - Clear an org price override
* [list_effective_prices](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/models/README.md#list_effective_prices) - List effective prices for the caller's models

### [Llm.Prompts](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#create) - Create a prompt
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#list) - List prompts
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#get) - Get a prompt
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#update) - Update a prompt
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#delete) - Delete a prompt
* [create_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#create_version) - Create a new version
* [list_versions](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#list_versions) - List versions
* [get_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#get_version) - Get a specific version
* [rollback](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/prompts/README.md#rollback) - Rollback to a version

### [Llm.Responses](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#create) - Create an agent-powered response with tool support
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#list) - List all responses with pagination
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#get) - Retrieve response by ID with status and results
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#update) - Update a response
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#delete) - Permanently delete a response and its data
* [cancel](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#cancel) - Cancel an in-progress background response
* [wake](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#wake) - Wake a sleeping background response
* [list_input_items](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#list_input_items) - List paginated input items for a response
* [compact](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/responses/README.md#compact) - Compact a conversation

### [Llm.Skills](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#create) - Create skill
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#list) - List skills
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#get) - Retrieve skill
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#update) - Update skill
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#delete) - Delete skill
* [content](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#content) - Download skill content
* [create_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#create_version) - Create skill version
* [list_versions](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#list_versions) - List skill versions
* [get_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#get_version) - Retrieve skill version
* [delete_version](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#delete_version) - Delete skill version
* [version_content](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#version_content) - Download skill version content
* [list_preconfigured](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/skills/README.md#list_preconfigured) - List preconfigured skills

### [Llm.Speech](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md)

* [transcribe](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#transcribe) - Speech to text transcription
* [speak](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#speak) - Text to speech
* [speak_streaming](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#speak_streaming) - Streaming text to speech
* [livekit_token](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#livekit_token) - Generate LiveKit room token
* [list_tts_history](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#list_tts_history) - List text-to-speech history
* [get_tts_history](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#get_tts_history) - Retrieve text-to-speech history item
* [delete_tts_history](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#delete_tts_history) - Delete text-to-speech history item
* [get_tts_history_content](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#get_tts_history_content) - Retrieve text-to-speech audio
* [list_transcription_history](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#list_transcription_history) - List speech-to-text history
* [get_transcription_history](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#get_transcription_history) - Retrieve speech-to-text history item
* [delete_transcription_history](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#delete_transcription_history) - Delete speech-to-text history item
* [get_transcription_history_content](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/speech/README.md#get_transcription_history_content) - Retrieve speech-to-text audio

### [Llm.Usage](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md)

* [completions](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#completions) - Get completions usage
* [responses](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#responses) - Get responses usage
* [conversations](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#conversations) - Get conversations usage
* [embeddings](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#embeddings) - Get embeddings usage
* [extract](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#extract) - Get extract usage
* [classify](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#classify) - Get classify usage
* [vector_stores](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#vector_stores) - Get vector stores usage
* [files](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#files) - Get files usage
* [costs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/llmusage/README.md#costs) - Get cost by model

### [Llm.VectorStores](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#create) - Create a vector store
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#list) - List vector stores
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#get) - Retrieve a vector store
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#update) - Modify a vector store
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#delete) - Delete a vector store
* [search](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#search) - Search a vector store
* [create_file](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#create_file) - Add a file to a vector store
* [list_files](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#list_files) - List files in a vector store
* [get_file](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#get_file) - Retrieve a vector store file
* [update_file](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#update_file) - Update file attributes
* [delete_file](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#delete_file) - Remove file from vector store
* [get_file_content](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#get_file_content) - Retrieve parsed file content
* [create_file_batch](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#create_file_batch) - Batch add multiple files to vector store
* [get_file_batch](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#get_file_batch) - Retrieve file batch status
* [cancel_file_batch](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#cancel_file_batch) - Cancel batch file processing
* [list_files_in_batch](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/vectorstores/README.md#list_files_in_batch) - List files in a batch

### [Permissions.Llm](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/permissionsllm/README.md)

* [grant](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/permissionsllm/README.md#grant) - Grant permission to a user or make public
* [revoke](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/permissionsllm/README.md#revoke) - Revoke permission from a user or remove public access
* [check](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/permissionsllm/README.md#check) - Check user permission

### [Repos](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/repos/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/repos/README.md#list) - List the caller's org's repositories
* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/repos/README.md#create) - Create a repository
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/repos/README.md#delete) - Delete a repository
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/repos/README.md#get) - Get a repository
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/repos/README.md#update) - Update a repository's labels

#### [Repos.Tags](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/tags/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/tags/README.md#list) - List an image repository's tags
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/tags/README.md#delete) - Delete an image tag

### [Sandbox](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#create) - Create Session
* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#list) - List Sessions
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#get) - Get Session
* [get_pricing](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#get_pricing) - Get Sandbox Pricing
* [set_pricing](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#set_pricing) - Set Sandbox Pricing
* [get_browser_url](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#get_browser_url) - Get Browser Session URL
* [~~get_url~~](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#get_url) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [get_browser_url](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#get_browser_url) instead.
* [proxy_browser_port_request](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#proxy_browser_port_request) - Proxy Browser Port Request
* [run_command](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#run_command) - Run Command
* [run_code](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#run_code) - Run Code
* [terminate](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#terminate) - Terminate Session
* [get_workspace](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#get_workspace) - Get Workspace Manifest
* [download_file](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#download_file) - Download Workspace File
* [upload_file](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#upload_file) - Upload Workspace File
* [download_archive](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#download_archive) - Download Workspace Archive
* [upload_archive](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandbox/README.md#upload_archive) - Upload Workspace Archive

#### [Sandbox.Environments](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandboxenvironments/README.md)

* [list](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandboxenvironments/README.md#list) - List Environments
* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandboxenvironments/README.md#create) - Create Environment
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandboxenvironments/README.md#get) - Get Environment
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandboxenvironments/README.md#update) - Update Environment
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandboxenvironments/README.md#delete) - Delete Environment
* [run_setup](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/sandboxenvironments/README.md#run_setup) - Run Environment Setup

#### [Sandbox.Github](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md)

* [create_authorization_intent](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#create_authorization_intent) - Start GitHub Authorization
* [connect](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#connect) - Connect GitHub Account
* [get_connection](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#get_connection) - Get GitHub Connection
* [disconnect](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#disconnect) - Disconnect GitHub Account
* [list_repositories](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#list_repositories) - List GitHub Repositories
* [refresh_repositories](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#refresh_repositories) - Refresh GitHub Repositories
* [resolve_reference](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#resolve_reference) - Resolve GitHub Reference
* [clone_repository](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#clone_repository) - Clone GitHub Repository into Session
* [list_session_repositories](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#list_session_repositories) - List Session Repositories
* [add_session_repository](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#add_session_repository) - Add Session Repository
* [dismiss_session_repository](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#dismiss_session_repository) - Dismiss Failed Session Repository
* [push](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#push) - Push Session to GitHub
* [create_or_update_pull_request](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/github/README.md#create_or_update_pull_request) - Create or Update Pull Request

### [Session](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/session/README.md)

* [get_pending_invitation](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/session/README.md#get_pending_invitation) - Find an unfinished invitation for the signed-in recipient
* [exchange_session_token](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/session/README.md#exchange_session_token) - Exchange a live session for a delegated access token

### [Tracking.Experiments](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/experiments/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/experiments/README.md#create) - Create
* [search](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/experiments/README.md#search) - Search
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/experiments/README.md#get) - Get
* [get_by_name](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/experiments/README.md#get_by_name) - GetByName
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/experiments/README.md#delete) - Delete

### [Tracking.Runs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md)

* [create](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#create) - Create
* [get](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#get) - Get
* [search](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#search) - Search
* [update](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#update) - Update
* [delete](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#delete) - Delete
* [restore](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#restore) - Restore
* [log_metric](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#log_metric) - LogMetric
* [log_parameter](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#log_parameter) - LogParameter
* [set_tag](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#set_tag) - SetTag
* [delete_tag](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#delete_tag) - DeleteTag
* [log_batch](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#log_batch) - LogBatch
* [log_inputs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#log_inputs) - LogInputs
* [get_metric_history](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/runs/README.md#get_metric_history) - GetMetricHistory

### [Usage](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/usagesdk/README.md)

* [sandbox](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/usagesdk/README.md#sandbox) - Get Sandbox Usage
* [costs](https://github.com/MeetKai/mka1-sdks/blob/master/python/docs/sdks/usagesdk/README.md#costs) - Aggregate cost by dimension

</details>
<!-- End Available Resources and Operations [operations] -->

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

[`SDKError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/sdkerror.py) is the base class for all HTTP error responses. It has the following properties:

| Property           | Type             | Description                                                                             |
| ------------------ | ---------------- | --------------------------------------------------------------------------------------- |
| `err.message`      | `str`            | Error message                                                                           |
| `err.status_code`  | `int`            | HTTP response status code eg `404`                                                      |
| `err.headers`      | `httpx.Headers`  | HTTP response headers                                                                   |
| `err.body`         | `str`            | HTTP body. Can be empty string if no body is returned.                                  |
| `err.raw_response` | `httpx.Response` | Raw HTTP response                                                                       |
| `err.data`         |                  | Optional. Some errors may contain structured data. [See Error Classes](https://github.com/MeetKai/mka1-sdks/blob/master/python/#error-classes). |

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
* [`SDKError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/sdkerror.py): The base class for HTTP error responses.

<details><summary>Less common errors (309)</summary>

<br />

**Network errors:**
* [`httpx.RequestError`](https://www.python-httpx.org/exceptions/#httpx.RequestError): Base class for request errors.
    * [`httpx.ConnectError`](https://www.python-httpx.org/exceptions/#httpx.ConnectError): HTTP client was unable to make a request to a server.
    * [`httpx.TimeoutException`](https://www.python-httpx.org/exceptions/#httpx.TimeoutException): HTTP request timed out.


**Inherit from [`SDKError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/sdkerror.py)**:
* [`HTTPValidationError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/httpvalidationerror.py): Validation Error. Status code `422`. Applicable to 39 of 459 methods.*
* [`ErrorEnvelope`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/errorenvelope.py): Error response. Applicable to 27 of 459 methods.*
* [`FeatureFlagError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/featureflagerror.py): The request is malformed or fails validation. Applicable to 22 of 459 methods.*
* [`AnalyticsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/analyticserror.py): Request failed. Applicable to 12 of 459 methods.*
* [`RepoError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/repoerror.py): The uniform error envelope. `error` is a stable machine-readable code (never an internal reason); `correlation_id` echoes the request's `X-Correlation-ID` for log correlation. Applicable to 7 of 459 methods.*
* [`ExchangeSessionTokenBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangesessiontokenbadrequesterror.py): Invalid request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetFileContentBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getfilecontentbadrequesterror.py): Invalid request - File ID is required. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createscopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listscopedapikeysbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updatescopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regeneratescopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangeapikeytokenbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateTeamBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListTeamsBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteamsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetTeamBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateTeamBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteTeamBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/addteammemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteammembersbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/removeteammemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountapikeysbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regenerateserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationbadrequesterror.py): Invalid JSON or metadata patch. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgquotabadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgquotabadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgratelimitbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgratelimitbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterinvitesbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/revokeclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterorgsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/inviteclusterorgmembersbadrequesterror.py): Invalid body or batch size. Status code `400`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/suspendclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/unsuspendclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/reissueownerkeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterinviteinfobadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/acceptclusterinvitebadrequesterror.py): Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyBadRequestError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getjwtfromkeybadrequesterror.py): Invalid request body. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetPendingInvitationUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getpendinginvitationunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangesessiontokenunauthorizederror.py): Missing, invalid, revoked or expiring session. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetFileContentUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getfilecontentunauthorizederror.py): Unauthorized - Invalid or missing authentication. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createscopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listscopedapikeysunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updatescopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regeneratescopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangeapikeytokenunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateTeamUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListTeamsUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteamsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetTeamUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateTeamUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteTeamUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/addteammemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteammembersunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/removeteammemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountapikeysunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regenerateserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgquotaunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgquotaunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgratelimitunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgratelimitunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterinvitesunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/revokeclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterorgsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/inviteclusterorgmembersunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/suspendclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/unsuspendclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/reissueownerkeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterinviteinfounauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/acceptclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyUnauthorizedError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getjwtfromkeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetPendingInvitationForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getpendinginvitationforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangesessiontokenforbiddenerror.py): Active organization or team is missing or inaccessible. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createscopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listscopedapikeysforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updatescopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regeneratescopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangeapikeytokenforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateTeamForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListTeamsForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteamsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetTeamForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateTeamForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteTeamForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/addteammemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteammembersforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/removeteammemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountapikeysforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regenerateserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgquotaforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgquotaforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgratelimitforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgratelimitforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterinvitesforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/revokeclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterorgsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/inviteclusterorgmembersforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/suspendclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/unsuspendclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/reissueownerkeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterinviteinfoforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteForbiddenError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/acceptclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetFileContentNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getfilecontentnotfounderror.py): File not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createscopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listscopedapikeysnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updatescopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regeneratescopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangeapikeytokennotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateTeamNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListTeamsNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteamsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetTeamNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateTeamNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteTeamNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/addteammembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteammembersnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/removeteammembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountapikeysnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regenerateserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgquotanotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgquotanotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgratelimitnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgratelimitnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterinvitesnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/revokeclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterorgsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/inviteclusterorgmembersnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/suspendclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/unsuspendclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/reissueownerkeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterinviteinfonotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteNotFoundError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/acceptclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createscopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listscopedapikeysconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updatescopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regeneratescopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangeapikeytokenconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateTeamConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListTeamsConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteamsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetTeamConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateTeamConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteTeamConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/addteammemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteammembersconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/removeteammemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountapikeysconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regenerateserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgquotaconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgquotaconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgratelimitconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgratelimitconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterinvitesconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/revokeclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterorgsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/inviteclusterorgmembersconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/suspendclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/unsuspendclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/reissueownerkeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterinviteinfoconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteConflictError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/acceptclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createscopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listscopedapikeysgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updatescopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regeneratescopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangeapikeytokengoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateTeamGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListTeamsGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteamsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetTeamGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateTeamGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteTeamGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/addteammembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteammembersgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/removeteammembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountapikeysgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regenerateserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgquotagoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgquotagoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgratelimitgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgratelimitgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterinvitesgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/revokeclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterorgsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/inviteclusterorgmembersgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/suspendclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/unsuspendclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/reissueownerkeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterinviteinfogoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteGoneError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/acceptclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenRequestEntityTooLargeError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangesessiontokenrequestentitytoolargeerror.py): Request body exceeds the endpoint's 4 KiB limit. Status code `413`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationRequestEntityTooLargeError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationrequestentitytoolargeerror.py): Request or merged metadata exceeds 64 KiB. Status code `413`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangesessiontokentoomanyrequestserror.py): Per-session or per-user mint rate exceeded. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createscopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listscopedapikeystoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updatescopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regeneratescopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangeapikeytokentoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateTeamTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListTeamsTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteamstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetTeamTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateTeamTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteTeamTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/addteammembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listteammemberstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/removeteammembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listserviceaccountapikeystoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/regenerateserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgquotatoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgquotatoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgratelimittoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorgratelimittoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/createclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterinvitestoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/revokeclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/listclusterorgstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/deleteclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/inviteclusterorgmemberstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/suspendclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/unsuspendclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/reissueownerkeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getclusterinviteinfotoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteTooManyRequestsError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/acceptclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenInternalServerError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/exchangesessiontokeninternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetFileContentInternalServerError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getfilecontentinternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDInternalServerError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getorgbyidinternalservererror.py): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationInternalServerError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/updateorganizationinternalservererror.py): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyInternalServerError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/getjwtfromkeyinternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`ServiceUnavailableError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/serviceunavailableerror.py): The invitation spend limit could not be confirmed. The organization and invitation claim were rolled back; retry acceptance. Status code `503`. Applicable to 1 of 459 methods.*
* [`ResponseValidationError`](https://github.com/MeetKai/mka1-sdks/blob/master/python/./src/meetkai_mka1/errors/responsevalidationerror.py): Type mismatch between the response data and the expected Pydantic model. Provides access to the Pydantic validation error via the `cause` attribute.

</details>

\* Check [the method documentation](https://github.com/MeetKai/mka1-sdks/blob/master/python/#available-resources-and-operations) to see if the error is applicable.
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
