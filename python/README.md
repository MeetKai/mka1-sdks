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
* [openapi](#openapi)
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

### [AgentConnectors](docs/sdks/agentconnectors/README.md)

* [list_agent_connectors](docs/sdks/agentconnectors/README.md#list_agent_connectors) - List connectors for an agent
* [create_agent_connector](docs/sdks/agentconnectors/README.md#create_agent_connector) - Create a connector
* [setup_whats_app_app_webhook](docs/sdks/agentconnectors/README.md#setup_whats_app_app_webhook) - Set up a WhatsApp app webhook (Beta)
* [get_agent_connector](docs/sdks/agentconnectors/README.md#get_agent_connector) - Retrieve a connector
* [delete_agent_connector](docs/sdks/agentconnectors/README.md#delete_agent_connector) - Delete a connector
* [activate_agent_connector](docs/sdks/agentconnectors/README.md#activate_agent_connector) - Activate a connector

### [AgentRuns](docs/sdks/agentruns/README.md)

* [list_agent_runs](docs/sdks/agentruns/README.md#list_agent_runs) - List runs for an agent
* [create_agent_run](docs/sdks/agentruns/README.md#create_agent_run) - Start a saved agent run
* [stream_agent_run_events](docs/sdks/agentruns/README.md#stream_agent_run_events) - Stream agent run events
* [wake_agent_run](docs/sdks/agentruns/README.md#wake_agent_run) - Wake a sleeping agent run
* [decide_agent_run_mcp_approval](docs/sdks/agentruns/README.md#decide_agent_run_mcp_approval) - Approve or deny a pending MCP tool call
* [get_agent_run](docs/sdks/agentruns/README.md#get_agent_run) - Retrieve an agent run

### [AgentSchedules](docs/sdks/agentschedules/README.md)

* [list_agent_schedules](docs/sdks/agentschedules/README.md#list_agent_schedules) - List schedules for an agent
* [create_agent_schedule](docs/sdks/agentschedules/README.md#create_agent_schedule) - Create an agent schedule
* [get_agent_schedule](docs/sdks/agentschedules/README.md#get_agent_schedule) - Retrieve an agent schedule
* [update_agent_schedule](docs/sdks/agentschedules/README.md#update_agent_schedule) - Update an agent schedule
* [delete_agent_schedule](docs/sdks/agentschedules/README.md#delete_agent_schedule) - Delete an agent schedule
* [pause_agent_schedule](docs/sdks/agentschedules/README.md#pause_agent_schedule) - Pause an agent schedule
* [resume_agent_schedule](docs/sdks/agentschedules/README.md#resume_agent_schedule) - Resume an agent schedule

### [AgentVersions](docs/sdks/agentversions/README.md)

* [list_agent_versions](docs/sdks/agentversions/README.md#list_agent_versions) - List agent versions
* [get_agent_version](docs/sdks/agentversions/README.md#get_agent_version) - Retrieve an agent version
* [rollback_agent_version](docs/sdks/agentversions/README.md#rollback_agent_version) - Roll back an agent to a version

### [Agents](docs/sdks/agents/README.md)

* [list_agents](docs/sdks/agents/README.md#list_agents) - List agents
* [create_agent](docs/sdks/agents/README.md#create_agent) - Create an agent
* [get_agent](docs/sdks/agents/README.md#get_agent) - Retrieve an agent
* [update_agent](docs/sdks/agents/README.md#update_agent) - Update an agent
* [delete_agent](docs/sdks/agents/README.md#delete_agent) - Delete an agent

### [Analytics](docs/sdks/analytics/README.md)

* [capture](docs/sdks/analytics/README.md#capture) - Durably accept a batch of events
* [query](docs/sdks/analytics/README.md#query) - Query event counts or unique visitors

#### [Analytics.Events](docs/sdks/events/README.md)

* [search](docs/sdks/events/README.md#search) - Search events in a time range

#### [Analytics.Keys](docs/sdks/keys/README.md)

* [create](docs/sdks/keys/README.md#create) - Create a capture key and return its secret once
* [list](docs/sdks/keys/README.md#list) - List capture key metadata
* [revoke](docs/sdks/keys/README.md#revoke) - Revoke a capture key

#### [Analytics.Projects](docs/sdks/analyticsprojects/README.md)

* [create](docs/sdks/analyticsprojects/README.md#create) - Create an analytics project
* [list](docs/sdks/analyticsprojects/README.md#list) - List accessible analytics projects
* [get](docs/sdks/analyticsprojects/README.md#get) - Get an analytics project
* [update](docs/sdks/analyticsprojects/README.md#update) - Rename an active analytics project
* [archive](docs/sdks/analyticsprojects/README.md#archive) - Archive an analytics project

#### [Analytics.Visitors](docs/sdks/visitors/README.md)

* [search](docs/sdks/visitors/README.md#search) - Search visitors in a time range

### [~~Auth.ApiKey~~](docs/sdks/authapikey/README.md)

* [~~get_jwt_from_key~~](docs/sdks/authapikey/README.md#get_jwt_from_key) - Exchange API key for a JWT token :warning: **Deprecated** Use [exchange_token](docs/sdks/apikeys/README.md#exchange_token) instead.

### [Auth.ApiKeys](docs/sdks/apikeys/README.md)

* [create](docs/sdks/apikeys/README.md#create) - Mint a scoped API key
* [list](docs/sdks/apikeys/README.md#list) - List scoped API keys
* [update](docs/sdks/apikeys/README.md#update) - Update a scoped API key
* [regenerate](docs/sdks/apikeys/README.md#regenerate) - Rotate a scoped API key's secret
* [exchange_token](docs/sdks/apikeys/README.md#exchange_token) - Exchange API key for a JWT token

### [Auth.Cluster](docs/sdks/cluster/README.md)

* [create_invite](docs/sdks/cluster/README.md#create_invite) - Create a cluster invitation
* [list_invites](docs/sdks/cluster/README.md#list_invites) - List cluster invitations
* [update_invite](docs/sdks/cluster/README.md#update_invite) - Update a pending cluster invitation
* [revoke_invite](docs/sdks/cluster/README.md#revoke_invite) - Revoke a cluster invitation
* [list_orgs](docs/sdks/cluster/README.md#list_orgs) - List all organizations
* [get_org](docs/sdks/cluster/README.md#get_org) - Get an organization
* [delete_org](docs/sdks/cluster/README.md#delete_org) - Soft-delete an organization
* [invite_org_members](docs/sdks/cluster/README.md#invite_org_members) - Invite members on behalf of an organization
* [suspend_org](docs/sdks/cluster/README.md#suspend_org) - Suspend an organization
* [unsuspend_org](docs/sdks/cluster/README.md#unsuspend_org) - Unsuspend an organization
* [reissue_owner_key](docs/sdks/cluster/README.md#reissue_owner_key) - Re-issue an org owner key (recovery)
* [invite_info](docs/sdks/cluster/README.md#invite_info) - Read cluster-invite info (public)
* [accept_invite](docs/sdks/cluster/README.md#accept_invite) - Accept a cluster invitation (public)

### [Auth.Orgs](docs/sdks/orgs/README.md)

* [get_by_id](docs/sdks/orgs/README.md#get_by_id) - Get basic organization details
* [update](docs/sdks/orgs/README.md#update) - Patch organization metadata (cluster-admin)
* [get_quota](docs/sdks/orgs/README.md#get_quota) - Get an org's usage quota
* [update_quota](docs/sdks/orgs/README.md#update_quota) - Set an org's usage quota (cluster-admin)
* [get_rate_limit](docs/sdks/orgs/README.md#get_rate_limit) - Get an org's rate limit
* [update_rate_limit](docs/sdks/orgs/README.md#update_rate_limit) - Set an org's rate limit (cluster-admin)

### [Auth.ServiceAccounts](docs/sdks/serviceaccounts/README.md)

* [create](docs/sdks/serviceaccounts/README.md#create) - Create a service account
* [list](docs/sdks/serviceaccounts/README.md#list) - List service accounts
* [get](docs/sdks/serviceaccounts/README.md#get) - Get a service account
* [delete](docs/sdks/serviceaccounts/README.md#delete) - Delete a service account
* [list_api_keys](docs/sdks/serviceaccounts/README.md#list_api_keys) - List a service account's API keys
* [update_api_key](docs/sdks/serviceaccounts/README.md#update_api_key) - Update a service-account API key
* [delete_api_key](docs/sdks/serviceaccounts/README.md#delete_api_key) - Delete a service-account API key
* [regenerate_api_key](docs/sdks/serviceaccounts/README.md#regenerate_api_key) - Rotate a service-account API key's secret

### [Auth.Teams](docs/sdks/teams/README.md)

* [create](docs/sdks/teams/README.md#create) - Create a team
* [list](docs/sdks/teams/README.md#list) - List teams in an org
* [get](docs/sdks/teams/README.md#get) - Get a team
* [update](docs/sdks/teams/README.md#update) - Rename a team
* [delete](docs/sdks/teams/README.md#delete) - Delete a team
* [add_member](docs/sdks/teams/README.md#add_member) - Add a team member
* [list_members](docs/sdks/teams/README.md#list_members) - List team members
* [remove_member](docs/sdks/teams/README.md#remove_member) - Remove a team member

### [Billing](docs/sdks/billing/README.md)

* [get_organization_billing](docs/sdks/billing/README.md#get_organization_billing)
* [set_organization_billing_enabled](docs/sdks/billing/README.md#set_organization_billing_enabled)
* [update_organization_billing_profile](docs/sdks/billing/README.md#update_organization_billing_profile)
* [create_organization_billing_setup](docs/sdks/billing/README.md#create_organization_billing_setup)
* [create_organization_billing_portal](docs/sdks/billing/README.md#create_organization_billing_portal)
* [list_organization_billing_invoices](docs/sdks/billing/README.md#list_organization_billing_invoices)

### [Budgets](docs/sdks/budgets/README.md)

* [list](docs/sdks/budgets/README.md#list) - List budgets
* [get_org](docs/sdks/budgets/README.md#get_org) - List org budgets
* [set_org](docs/sdks/budgets/README.md#set_org) - Set an org budget
* [delete_org](docs/sdks/budgets/README.md#delete_org) - Delete an org budget
* [org_events](docs/sdks/budgets/README.md#org_events) - List org budget events
* [get_api_key](docs/sdks/budgets/README.md#get_api_key) - List apikey budgets
* [set_api_key](docs/sdks/budgets/README.md#set_api_key) - Set an apikey budget
* [delete_api_key](docs/sdks/budgets/README.md#delete_api_key) - Delete an apikey budget
* [api_key_events](docs/sdks/budgets/README.md#api_key_events) - List apikey budget events
* [get_user](docs/sdks/budgets/README.md#get_user) - List user budgets
* [set_user](docs/sdks/budgets/README.md#set_user) - Set a user budget
* [delete_user](docs/sdks/budgets/README.md#delete_user) - Delete a user budget
* [user_events](docs/sdks/budgets/README.md#user_events) - List user budget events
* [get_team](docs/sdks/budgets/README.md#get_team) - List team budgets
* [set_team](docs/sdks/budgets/README.md#set_team) - Set a team budget
* [delete_team](docs/sdks/budgets/README.md#delete_team) - Delete a team budget
* [team_events](docs/sdks/budgets/README.md#team_events) - List team budget events
* [get_external_user](docs/sdks/budgets/README.md#get_external_user) - List external user budgets
* [set_external_user](docs/sdks/budgets/README.md#set_external_user) - Set a external user budget
* [delete_external_user](docs/sdks/budgets/README.md#delete_external_user) - Delete a external user budget
* [external_user_events](docs/sdks/budgets/README.md#external_user_events) - List external user budget events
* [get_user_default](docs/sdks/budgets/README.md#get_user_default) - List per-user default budgets
* [set_user_default](docs/sdks/budgets/README.md#set_user_default) - Set a per-user default budget
* [delete_user_default](docs/sdks/budgets/README.md#delete_user_default) - Delete a per-user default budget
* [user_default_events](docs/sdks/budgets/README.md#user_default_events) - List per-user default budget events
* [get_team_default](docs/sdks/budgets/README.md#get_team_default) - List per-team default budgets
* [set_team_default](docs/sdks/budgets/README.md#set_team_default) - Set a per-team default budget
* [delete_team_default](docs/sdks/budgets/README.md#delete_team_default) - Delete a per-team default budget
* [team_default_events](docs/sdks/budgets/README.md#team_default_events) - List per-team default budget events
* [get_external_user_default](docs/sdks/budgets/README.md#get_external_user_default) - List per-external user default budgets
* [set_external_user_default](docs/sdks/budgets/README.md#set_external_user_default) - Set a per-external user default budget
* [delete_external_user_default](docs/sdks/budgets/README.md#delete_external_user_default) - Delete a per-external user default budget
* [external_user_default_events](docs/sdks/budgets/README.md#external_user_default_events) - List per-external user default budget events
* [get_currency](docs/sdks/budgets/README.md#get_currency) - Get display currency
* [set_currency](docs/sdks/budgets/README.md#set_currency) - Set display currency

### [ComputeCatalog](docs/sdks/computecatalog/README.md)

* [list_accelerators](docs/sdks/computecatalog/README.md#list_accelerators) - List accelerators
* [get_accelerator](docs/sdks/computecatalog/README.md#get_accelerator) - Get an accelerator
* [list_compute_offers](docs/sdks/computecatalog/README.md#list_compute_offers) - List provider offers
* [list_compute_providers](docs/sdks/computecatalog/README.md#list_compute_providers) - List provider health
* [create_compute_quote](docs/sdks/computecatalog/README.md#create_compute_quote) - Create a quote

### [ComputeJobs](docs/sdks/computejobs/README.md)

* [list_jobs](docs/sdks/computejobs/README.md#list_jobs) - List jobs
* [create_job](docs/sdks/computejobs/README.md#create_job) - Create a job
* [get_job](docs/sdks/computejobs/README.md#get_job) - Get a job
* [list_job_events](docs/sdks/computejobs/README.md#list_job_events) - List job events
* [list_job_instances](docs/sdks/computejobs/README.md#list_job_instances) - List observed job instances
* [list_job_logs](docs/sdks/computejobs/README.md#list_job_logs) - List job logs
* [terminate_job](docs/sdks/computejobs/README.md#terminate_job) - Terminate a job

### [ComputePricing](docs/sdks/computepricingsdk/README.md)

* [get_pricing](docs/sdks/computepricingsdk/README.md#get_pricing) - Get the latest committed storage price
* [put_pricing](docs/sdks/computepricingsdk/README.md#put_pricing) - Create an immutable storage-price version

### [ComputeSecrets](docs/sdks/computesecrets/README.md)

* [list_compute_secrets](docs/sdks/computesecrets/README.md#list_compute_secrets) - List secrets
* [create_compute_secret](docs/sdks/computesecrets/README.md#create_compute_secret) - Create a secret
* [delete_compute_secret](docs/sdks/computesecrets/README.md#delete_compute_secret) - Delete a secret
* [get_compute_secret](docs/sdks/computesecrets/README.md#get_compute_secret) - Get a secret

### [ComputeServices](docs/sdks/computeservices/README.md)

* [list_services](docs/sdks/computeservices/README.md#list_services) - List services
* [create_service](docs/sdks/computeservices/README.md#create_service) - Create a service
* [get_service](docs/sdks/computeservices/README.md#get_service) - Get a service
* [list_service_events](docs/sdks/computeservices/README.md#list_service_events) - List service events
* [list_service_instances](docs/sdks/computeservices/README.md#list_service_instances) - List observed service instances
* [list_service_logs](docs/sdks/computeservices/README.md#list_service_logs) - List service logs
* [update_service_scaling](docs/sdks/computeservices/README.md#update_service_scaling) - Replace a service scaling policy
* [terminate_service](docs/sdks/computeservices/README.md#terminate_service) - Terminate a service

### [ComputeTenants](docs/sdks/computetenants/README.md)

* [list_compute_tenants](docs/sdks/computetenants/README.md#list_compute_tenants) - List tenants
* [get_compute_tenant](docs/sdks/computetenants/README.md#get_compute_tenant) - Get a tenant
* [put_compute_tenant](docs/sdks/computetenants/README.md#put_compute_tenant) - Update a tenant

### [ComputeUsage](docs/sdks/computeusagesdk/README.md)

* [get_compute_usage](docs/sdks/computeusagesdk/README.md#get_compute_usage) - Get usage

### [ComputeVolumes](docs/sdks/computevolumes/README.md)

* [list_standalone_volumes](docs/sdks/computevolumes/README.md#list_standalone_volumes) - List organization volumes
* [create_standalone_volume](docs/sdks/computevolumes/README.md#create_standalone_volume) - Create a standalone shared volume
* [delete_standalone_volume](docs/sdks/computevolumes/README.md#delete_standalone_volume) - Permanently delete a standalone volume
* [get_standalone_volume](docs/sdks/computevolumes/README.md#get_standalone_volume) - Get a standalone volume
* [list_standalone_volume_attachments](docs/sdks/computevolumes/README.md#list_standalone_volume_attachments) - List volume attachments

### [Datasets](docs/sdks/datasets/README.md)

* [list_generators](docs/sdks/datasets/README.md#list_generators) - List Generators
* [get_generator](docs/sdks/datasets/README.md#get_generator) - Get Generator
* [quote_generator](docs/sdks/datasets/README.md#quote_generator) - Quote Generator
* [list_generations](docs/sdks/datasets/README.md#list_generations) - List Generations
* [create_generation](docs/sdks/datasets/README.md#create_generation) - Create Generation
* [get_generation](docs/sdks/datasets/README.md#get_generation) - Get Generation
* [get_generation_logs](docs/sdks/datasets/README.md#get_generation_logs) - Get Logs
* [get_generation_events](docs/sdks/datasets/README.md#get_generation_events) - Get Events
* [cancel_generation](docs/sdks/datasets/README.md#cancel_generation) - Cancel Generation
* [list_formats](docs/sdks/datasets/README.md#list_formats) - List Formats
* [get_format](docs/sdks/datasets/README.md#get_format) - Get Format

### [Flags](docs/sdks/flags/README.md)

* [list](docs/sdks/flags/README.md#list) - List flags
* [create](docs/sdks/flags/README.md#create) - Create a flag
* [delete](docs/sdks/flags/README.md#delete) - Delete a flag and its settings in every environment
* [get](docs/sdks/flags/README.md#get) - Get a flag
* [update](docs/sdks/flags/README.md#update) - Update a flag's name, description, default value, or project
* [archive](docs/sdks/flags/README.md#archive) - Archive a flag
* [set_environment_state](docs/sdks/flags/README.md#set_environment_state) - Replace a flag's settings in one environment
* [unarchive](docs/sdks/flags/README.md#unarchive) - Restore an archived flag

#### [Flags.Audit](docs/sdks/audit/README.md)

* [list](docs/sdks/audit/README.md#list) - List audit entries, newest first

#### [Flags.Environments](docs/sdks/flagsenvironments/README.md)

* [list](docs/sdks/flagsenvironments/README.md#list) - List environments
* [create](docs/sdks/flagsenvironments/README.md#create) - Create an environment
* [delete](docs/sdks/flagsenvironments/README.md#delete) - Delete an environment and every flag setting in it
* [update](docs/sdks/flagsenvironments/README.md#update) - Rename an environment
* [evaluate](docs/sdks/flagsenvironments/README.md#evaluate) - Evaluate every flag for an identity
* [evaluate_with_traits](docs/sdks/flagsenvironments/README.md#evaluate_with_traits) - Evaluate every flag for an identity with traits
* [revoke_evaluation_key](docs/sdks/flagsenvironments/README.md#revoke_evaluation_key) - Revoke an environment evaluation key
* [generate_evaluation_key](docs/sdks/flagsenvironments/README.md#generate_evaluation_key) - Generate or replace an environment evaluation key

#### [Flags.Projects](docs/sdks/flagsprojects/README.md)

* [list](docs/sdks/flagsprojects/README.md#list) - List projects
* [create](docs/sdks/flagsprojects/README.md#create) - Create a project
* [delete](docs/sdks/flagsprojects/README.md#delete) - Delete an empty project
* [get](docs/sdks/flagsprojects/README.md#get) - Get a project
* [update](docs/sdks/flagsprojects/README.md#update) - Rename a project

### [Guardrails](docs/sdks/guardrails/README.md)

* [get_guardrails](docs/sdks/guardrails/README.md#get_guardrails) - Get effective guardrails
* [update_guardrails](docs/sdks/guardrails/README.md#update_guardrails) - Update guardrails policy
* [delete_guardrails](docs/sdks/guardrails/README.md#delete_guardrails) - Delete guardrails policy
* [list_guardrails_policies](docs/sdks/guardrails/README.md#list_guardrails_policies) - List guardrails policies
* [test_guardrails](docs/sdks/guardrails/README.md#test_guardrails) - Test content against guardrails

### [Llm.Batches](docs/sdks/batches/README.md)

* [create](docs/sdks/batches/README.md#create) - Create a batch
* [list](docs/sdks/batches/README.md#list) - List batches
* [get](docs/sdks/batches/README.md#get) - Get a batch
* [cancel](docs/sdks/batches/README.md#cancel) - Cancel a batch

### [~~Llm.Chat~~](docs/sdks/chat/README.md)

* [~~create_chat~~](docs/sdks/chat/README.md#create_chat) - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
* [~~stream~~](docs/sdks/chat/README.md#stream) - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**

### [Llm.Classify](docs/sdks/classify/README.md)

* [classify](docs/sdks/classify/README.md#classify) - Classify text into predefined categories

### [Llm.Conversations](docs/sdks/conversations/README.md)

* [create](docs/sdks/conversations/README.md#create) - Create a conversation
* [list](docs/sdks/conversations/README.md#list) - List conversations
* [get](docs/sdks/conversations/README.md#get) - Retrieve a conversation
* [update](docs/sdks/conversations/README.md#update) - Update a conversation
* [delete](docs/sdks/conversations/README.md#delete) - Delete a conversation
* [list_items](docs/sdks/conversations/README.md#list_items) - List conversation items
* [create_items](docs/sdks/conversations/README.md#create_items) - Create conversation items
* [delete_items](docs/sdks/conversations/README.md#delete_items) - Delete multiple conversation items
* [get_item](docs/sdks/conversations/README.md#get_item) - Retrieve a conversation item
* [delete_item](docs/sdks/conversations/README.md#delete_item) - Delete a conversation item

### [Llm.Embeddings](docs/sdks/embeddings/README.md)

* [list_models](docs/sdks/embeddings/README.md#list_models) - List available embedding models
* [embed](docs/sdks/embeddings/README.md#embed) - Create text embeddings

### [Llm.Evals](docs/sdks/evals/README.md)

* [create_suite](docs/sdks/evals/README.md#create_suite) - Create an eval suite
* [list_suites](docs/sdks/evals/README.md#list_suites) - List eval suites
* [get_suite](docs/sdks/evals/README.md#get_suite) - Get an eval suite
* [delete_suite](docs/sdks/evals/README.md#delete_suite) - Delete an eval suite
* [create_suite_version](docs/sdks/evals/README.md#create_suite_version) - Create an eval suite version
* [list_suite_versions](docs/sdks/evals/README.md#list_suite_versions) - List eval suite versions
* [get_suite_version](docs/sdks/evals/README.md#get_suite_version) - Get an eval suite version
* [list_suite_leaderboard_runs](docs/sdks/evals/README.md#list_suite_leaderboard_runs) - List leaderboard runs for an eval suite
* [get_suite_leaderboard](docs/sdks/evals/README.md#get_suite_leaderboard) - Get the coding-agent leaderboard for an eval suite
* [measure_suite_tokens](docs/sdks/evals/README.md#measure_suite_tokens) - Count tokens from stored text for a suite's unmeasured samples
* [create_run](docs/sdks/evals/README.md#create_run) - Create an eval run
* [list_runs](docs/sdks/evals/README.md#list_runs) - List eval runs
* [get_run](docs/sdks/evals/README.md#get_run) - Get an eval run
* [delete_run](docs/sdks/evals/README.md#delete_run) - Delete an eval run
* [cancel_run](docs/sdks/evals/README.md#cancel_run) - Cancel an eval run
* [rerun_failed_samples](docs/sdks/evals/README.md#rerun_failed_samples) - Rerun failed eval samples
* [retry_failed_run](docs/sdks/evals/README.md#retry_failed_run) - Retry an eval run
* [get_run_overview](docs/sdks/evals/README.md#get_run_overview) - Get an eval run overview
* [list_samples](docs/sdks/evals/README.md#list_samples) - List eval samples
* [get_sample_audio](docs/sdks/evals/README.md#get_sample_audio) - Get eval sample audio
* [get_sample_trajectory](docs/sdks/evals/README.md#get_sample_trajectory) - Get an eval sample trajectory
* [upload_sample_trajectory](docs/sdks/evals/README.md#upload_sample_trajectory) - Upload an eval sample trajectory
* [get_artifacts](docs/sdks/evals/README.md#get_artifacts) - Get eval run artifacts
* [import_agent_run](docs/sdks/evals/README.md#import_agent_run) - Import a finished coding-agent run
* [append_agent_trials](docs/sdks/evals/README.md#append_agent_trials) - Append trials to an open coding-agent run
* [import_historical_results](docs/sdks/evals/README.md#import_historical_results) - Import historical eval results from Hugging Face
* [create_schedule](docs/sdks/evals/README.md#create_schedule) - Create an eval schedule
* [list_schedules](docs/sdks/evals/README.md#list_schedules) - List eval schedules
* [get_schedule](docs/sdks/evals/README.md#get_schedule) - Get an eval schedule
* [update_schedule](docs/sdks/evals/README.md#update_schedule) - Update an eval schedule
* [delete_schedule](docs/sdks/evals/README.md#delete_schedule) - Delete an eval schedule
* [trigger_schedule](docs/sdks/evals/README.md#trigger_schedule) - Trigger an eval schedule now
* [list_schedule_runs](docs/sdks/evals/README.md#list_schedule_runs) - List runs created by an eval schedule

### [Llm.Extract](docs/sdks/extract/README.md)

* [extract](docs/sdks/extract/README.md#extract) - Extract structured data with inline JSON Schema
* [create_schema](docs/sdks/extract/README.md#create_schema) - Create reusable extraction schema template
* [get_schema](docs/sdks/extract/README.md#get_schema) - Get extraction schema by ID
* [update_schema](docs/sdks/extract/README.md#update_schema) - Update extraction schema by ID
* [delete_schema](docs/sdks/extract/README.md#delete_schema) - Delete extraction schema by ID
* [extract_with_schema](docs/sdks/extract/README.md#extract_with_schema) - Extract data using saved schema template

### [Llm.Feedback](docs/sdks/feedback/README.md)

* [create_completion_feedback](docs/sdks/feedback/README.md#create_completion_feedback) - Submit feedback for chat completion
* [list_completion_feedback](docs/sdks/feedback/README.md#list_completion_feedback) - List chat completion feedback
* [get_completion_feedback](docs/sdks/feedback/README.md#get_completion_feedback) - Retrieve feedback by completion ID
* [update_completion_feedback](docs/sdks/feedback/README.md#update_completion_feedback) - Update existing completion feedback
* [batch_get_completion_feedback](docs/sdks/feedback/README.md#batch_get_completion_feedback) - Batch retrieve feedback for multiple completions
* [create_response_feedback](docs/sdks/feedback/README.md#create_response_feedback) - Submit feedback for response
* [list_response_feedback](docs/sdks/feedback/README.md#list_response_feedback) - List response feedback
* [get_response_feedback](docs/sdks/feedback/README.md#get_response_feedback) - Retrieve feedback by response ID
* [update_response_feedback](docs/sdks/feedback/README.md#update_response_feedback) - Update existing response feedback
* [batch_get_response_feedback](docs/sdks/feedback/README.md#batch_get_response_feedback) - Batch retrieve feedback for multiple responses
* [export_completion_feedback](docs/sdks/feedback/README.md#export_completion_feedback) - Export completion feedback as CSV
* [export_response_feedback](docs/sdks/feedback/README.md#export_response_feedback) - Export response feedback as CSV
* [start_export](docs/sdks/feedback/README.md#start_export) - Start feedback export
* [get_export_status](docs/sdks/feedback/README.md#get_export_status) - Get feedback export status

### [Llm.Files](docs/sdks/files/README.md)

* [upload](docs/sdks/files/README.md#upload) - Upload file
* [list](docs/sdks/files/README.md#list) - List files
* [get](docs/sdks/files/README.md#get) - Retrieve file
* [delete](docs/sdks/files/README.md#delete) - Delete file
* [content](docs/sdks/files/README.md#content) - Retrieve file content

### [~~Llm.FineTuning~~](docs/sdks/finetuning/README.md)

* [~~create~~](docs/sdks/finetuning/README.md#create) - [Deprecated] Create a fine-tuning job :warning: **Deprecated**
* [~~list~~](docs/sdks/finetuning/README.md#list) - [Deprecated] List fine-tuning jobs :warning: **Deprecated**
* [~~retrieve~~](docs/sdks/finetuning/README.md#retrieve) - [Deprecated] Retrieve a fine-tuning job :warning: **Deprecated**
* [~~cancel~~](docs/sdks/finetuning/README.md#cancel) - [Deprecated] Cancel a fine-tuning job :warning: **Deprecated**
* [~~pause~~](docs/sdks/finetuning/README.md#pause) - [Deprecated] Pause a fine-tuning job :warning: **Deprecated**
* [~~resume~~](docs/sdks/finetuning/README.md#resume) - [Deprecated] Resume a fine-tuning job :warning: **Deprecated**
* [~~list_events~~](docs/sdks/finetuning/README.md#list_events) - [Deprecated] List fine-tuning events :warning: **Deprecated**
* [~~list_checkpoints~~](docs/sdks/finetuning/README.md#list_checkpoints) - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**

### [Llm.Images](docs/sdks/images/README.md)

* [create](docs/sdks/images/README.md#create) - Generate images from text descriptions

### [Llm.McpVault](docs/sdks/mcpvault/README.md)

* [create_server](docs/sdks/mcpvault/README.md#create_server) - Create MCP server
* [list_servers](docs/sdks/mcpvault/README.md#list_servers) - List MCP servers
* [get_server](docs/sdks/mcpvault/README.md#get_server) - Retrieve MCP server
* [update_server](docs/sdks/mcpvault/README.md#update_server) - Update MCP server
* [delete_server](docs/sdks/mcpvault/README.md#delete_server) - Delete MCP server
* [create_credential](docs/sdks/mcpvault/README.md#create_credential) - Create MCP credential
* [list_credentials](docs/sdks/mcpvault/README.md#list_credentials) - List MCP credentials
* [delete_credential](docs/sdks/mcpvault/README.md#delete_credential) - Delete MCP credential
* [test_server](docs/sdks/mcpvault/README.md#test_server) - Test MCP server

### [Llm.MemoryStores](docs/sdks/memorystores/README.md)

* [create](docs/sdks/memorystores/README.md#create) - Create memory store
* [list](docs/sdks/memorystores/README.md#list) - List memory stores
* [get](docs/sdks/memorystores/README.md#get) - Retrieve memory store
* [update](docs/sdks/memorystores/README.md#update) - Update memory store
* [delete](docs/sdks/memorystores/README.md#delete) - Delete memory store
* [create_entry](docs/sdks/memorystores/README.md#create_entry) - Create memory entry
* [list_entries](docs/sdks/memorystores/README.md#list_entries) - List memory entries
* [get_entry](docs/sdks/memorystores/README.md#get_entry) - Retrieve memory entry
* [update_entry](docs/sdks/memorystores/README.md#update_entry) - Update memory entry
* [delete_entry](docs/sdks/memorystores/README.md#delete_entry) - Delete memory entry

### [Llm.Models](docs/sdks/models/README.md)

* [list](docs/sdks/models/README.md#list) - List available models
* [get](docs/sdks/models/README.md#get) - Retrieve a model
* [list_catalog](docs/sdks/models/README.md#list_catalog) - List the organization's model catalog
* [add_catalog_entry](docs/sdks/models/README.md#add_catalog_entry) - Define a BYO catalog model
* [update_catalog_entry](docs/sdks/models/README.md#update_catalog_entry) - Update a BYO catalog model
* [delete_catalog_entry](docs/sdks/models/README.md#delete_catalog_entry) - Remove a BYO catalog model
* [check_catalog_health](docs/sdks/models/README.md#check_catalog_health) - Check a BYO catalog model's health
* [list_catalog_org_access](docs/sdks/models/README.md#list_catalog_org_access) - List an organization's cluster model access
* [add_catalog_org_access](docs/sdks/models/README.md#add_catalog_org_access) - Add cluster model access for an organization
* [replace_catalog_org_access](docs/sdks/models/README.md#replace_catalog_org_access) - Replace an organization's cluster model access
* [list_catalog_model_access](docs/sdks/models/README.md#list_catalog_model_access) - List organizations with access to a cluster model
* [list_registry](docs/sdks/models/README.md#list_registry) - List the organization's active model registry
* [activate_registry_entry](docs/sdks/models/README.md#activate_registry_entry) - Activate a catalog entry
* [deactivate_registry_entry](docs/sdks/models/README.md#deactivate_registry_entry) - Deactivate a model registry name
* [list_org_auto_models](docs/sdks/models/README.md#list_org_auto_models) - List this org's auto-model overrides
* [put_org_auto_model](docs/sdks/models/README.md#put_org_auto_model) - Set this org's auto policy for an endpoint
* [delete_org_auto_model](docs/sdks/models/README.md#delete_org_auto_model) - Clear this org's auto-model override for an endpoint
* [get_cluster_currency](docs/sdks/models/README.md#get_cluster_currency) - Get the cluster currency
* [set_cluster_currency](docs/sdks/models/README.md#set_cluster_currency) - Set the cluster currency
* [list_cluster_prices](docs/sdks/models/README.md#list_cluster_prices) - List cluster-default model prices
* [set_cluster_price](docs/sdks/models/README.md#set_cluster_price) - Set a cluster-default model price
* [clear_cluster_price](docs/sdks/models/README.md#clear_cluster_price) - Clear a cluster-default model price
* [list_org_prices](docs/sdks/models/README.md#list_org_prices) - List an org's price overrides
* [set_org_price](docs/sdks/models/README.md#set_org_price) - Set an org price override
* [clear_org_price](docs/sdks/models/README.md#clear_org_price) - Clear an org price override
* [list_effective_prices](docs/sdks/models/README.md#list_effective_prices) - List effective prices for the caller's models

### [Llm.Prompts](docs/sdks/prompts/README.md)

* [create](docs/sdks/prompts/README.md#create) - Create a prompt
* [list](docs/sdks/prompts/README.md#list) - List prompts
* [get](docs/sdks/prompts/README.md#get) - Get a prompt
* [update](docs/sdks/prompts/README.md#update) - Update a prompt
* [delete](docs/sdks/prompts/README.md#delete) - Delete a prompt
* [create_version](docs/sdks/prompts/README.md#create_version) - Create a new version
* [list_versions](docs/sdks/prompts/README.md#list_versions) - List versions
* [get_version](docs/sdks/prompts/README.md#get_version) - Get a specific version
* [rollback](docs/sdks/prompts/README.md#rollback) - Rollback to a version

### [Llm.Responses](docs/sdks/responses/README.md)

* [create](docs/sdks/responses/README.md#create) - Create an agent-powered response with tool support
* [list](docs/sdks/responses/README.md#list) - List all responses with pagination
* [get](docs/sdks/responses/README.md#get) - Retrieve response by ID with status and results
* [update](docs/sdks/responses/README.md#update) - Update a response
* [delete](docs/sdks/responses/README.md#delete) - Permanently delete a response and its data
* [cancel](docs/sdks/responses/README.md#cancel) - Cancel an in-progress background response
* [wake](docs/sdks/responses/README.md#wake) - Wake a sleeping background response
* [list_input_items](docs/sdks/responses/README.md#list_input_items) - List paginated input items for a response
* [compact](docs/sdks/responses/README.md#compact) - Compact a conversation

### [Llm.Skills](docs/sdks/skills/README.md)

* [create](docs/sdks/skills/README.md#create) - Create skill
* [list](docs/sdks/skills/README.md#list) - List skills
* [get](docs/sdks/skills/README.md#get) - Retrieve skill
* [update](docs/sdks/skills/README.md#update) - Update skill
* [delete](docs/sdks/skills/README.md#delete) - Delete skill
* [content](docs/sdks/skills/README.md#content) - Download skill content
* [create_version](docs/sdks/skills/README.md#create_version) - Create skill version
* [list_versions](docs/sdks/skills/README.md#list_versions) - List skill versions
* [get_version](docs/sdks/skills/README.md#get_version) - Retrieve skill version
* [delete_version](docs/sdks/skills/README.md#delete_version) - Delete skill version
* [version_content](docs/sdks/skills/README.md#version_content) - Download skill version content
* [list_preconfigured](docs/sdks/skills/README.md#list_preconfigured) - List preconfigured skills

### [Llm.Speech](docs/sdks/speech/README.md)

* [transcribe](docs/sdks/speech/README.md#transcribe) - Speech to text transcription
* [speak](docs/sdks/speech/README.md#speak) - Text to speech
* [speak_streaming](docs/sdks/speech/README.md#speak_streaming) - Streaming text to speech
* [livekit_token](docs/sdks/speech/README.md#livekit_token) - Generate LiveKit room token
* [list_tts_history](docs/sdks/speech/README.md#list_tts_history) - List text-to-speech history
* [get_tts_history](docs/sdks/speech/README.md#get_tts_history) - Retrieve text-to-speech history item
* [delete_tts_history](docs/sdks/speech/README.md#delete_tts_history) - Delete text-to-speech history item
* [get_tts_history_content](docs/sdks/speech/README.md#get_tts_history_content) - Retrieve text-to-speech audio
* [list_transcription_history](docs/sdks/speech/README.md#list_transcription_history) - List speech-to-text history
* [get_transcription_history](docs/sdks/speech/README.md#get_transcription_history) - Retrieve speech-to-text history item
* [delete_transcription_history](docs/sdks/speech/README.md#delete_transcription_history) - Delete speech-to-text history item
* [get_transcription_history_content](docs/sdks/speech/README.md#get_transcription_history_content) - Retrieve speech-to-text audio

### [Llm.Usage](docs/sdks/llmusage/README.md)

* [completions](docs/sdks/llmusage/README.md#completions) - Get completions usage
* [responses](docs/sdks/llmusage/README.md#responses) - Get responses usage
* [conversations](docs/sdks/llmusage/README.md#conversations) - Get conversations usage
* [embeddings](docs/sdks/llmusage/README.md#embeddings) - Get embeddings usage
* [extract](docs/sdks/llmusage/README.md#extract) - Get extract usage
* [classify](docs/sdks/llmusage/README.md#classify) - Get classify usage
* [vector_stores](docs/sdks/llmusage/README.md#vector_stores) - Get vector stores usage
* [files](docs/sdks/llmusage/README.md#files) - Get files usage
* [costs](docs/sdks/llmusage/README.md#costs) - Get cost by model

### [Llm.VectorStores](docs/sdks/vectorstores/README.md)

* [create](docs/sdks/vectorstores/README.md#create) - Create a vector store
* [list](docs/sdks/vectorstores/README.md#list) - List vector stores
* [get](docs/sdks/vectorstores/README.md#get) - Retrieve a vector store
* [update](docs/sdks/vectorstores/README.md#update) - Modify a vector store
* [delete](docs/sdks/vectorstores/README.md#delete) - Delete a vector store
* [search](docs/sdks/vectorstores/README.md#search) - Search a vector store
* [create_file](docs/sdks/vectorstores/README.md#create_file) - Add a file to a vector store
* [list_files](docs/sdks/vectorstores/README.md#list_files) - List files in a vector store
* [get_file](docs/sdks/vectorstores/README.md#get_file) - Retrieve a vector store file
* [update_file](docs/sdks/vectorstores/README.md#update_file) - Update file attributes
* [delete_file](docs/sdks/vectorstores/README.md#delete_file) - Remove file from vector store
* [get_file_content](docs/sdks/vectorstores/README.md#get_file_content) - Retrieve parsed file content
* [create_file_batch](docs/sdks/vectorstores/README.md#create_file_batch) - Batch add multiple files to vector store
* [get_file_batch](docs/sdks/vectorstores/README.md#get_file_batch) - Retrieve file batch status
* [cancel_file_batch](docs/sdks/vectorstores/README.md#cancel_file_batch) - Cancel batch file processing
* [list_files_in_batch](docs/sdks/vectorstores/README.md#list_files_in_batch) - List files in a batch

### [Permissions.Llm](docs/sdks/permissionsllm/README.md)

* [grant](docs/sdks/permissionsllm/README.md#grant) - Grant permission to a user or make public
* [revoke](docs/sdks/permissionsllm/README.md#revoke) - Revoke permission from a user or remove public access
* [check](docs/sdks/permissionsllm/README.md#check) - Check user permission

### [Repos](docs/sdks/repos/README.md)

* [list](docs/sdks/repos/README.md#list) - List the caller's org's repositories
* [create](docs/sdks/repos/README.md#create) - Create a repository
* [delete](docs/sdks/repos/README.md#delete) - Delete a repository
* [get](docs/sdks/repos/README.md#get) - Get a repository
* [update](docs/sdks/repos/README.md#update) - Update a repository's labels

#### [Repos.Tags](docs/sdks/tags/README.md)

* [list](docs/sdks/tags/README.md#list) - List an image repository's tags
* [delete](docs/sdks/tags/README.md#delete) - Delete an image tag

### [Sandbox](docs/sdks/sandbox/README.md)

* [create](docs/sdks/sandbox/README.md#create) - Create Session
* [list](docs/sdks/sandbox/README.md#list) - List Sessions
* [get](docs/sdks/sandbox/README.md#get) - Get Session
* [get_pricing](docs/sdks/sandbox/README.md#get_pricing) - Get Sandbox Pricing
* [set_pricing](docs/sdks/sandbox/README.md#set_pricing) - Set Sandbox Pricing
* [get_browser_url](docs/sdks/sandbox/README.md#get_browser_url) - Get Browser Session URL
* [~~get_url~~](docs/sdks/sandbox/README.md#get_url) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [get_browser_url](docs/sdks/sandbox/README.md#get_browser_url) instead.
* [proxy_browser_port_request](docs/sdks/sandbox/README.md#proxy_browser_port_request) - Proxy Browser Port Request
* [run_command](docs/sdks/sandbox/README.md#run_command) - Run Command
* [run_code](docs/sdks/sandbox/README.md#run_code) - Run Code
* [terminate](docs/sdks/sandbox/README.md#terminate) - Terminate Session
* [get_workspace](docs/sdks/sandbox/README.md#get_workspace) - Get Workspace Manifest
* [download_file](docs/sdks/sandbox/README.md#download_file) - Download Workspace File
* [upload_file](docs/sdks/sandbox/README.md#upload_file) - Upload Workspace File
* [download_archive](docs/sdks/sandbox/README.md#download_archive) - Download Workspace Archive
* [upload_archive](docs/sdks/sandbox/README.md#upload_archive) - Upload Workspace Archive

#### [Sandbox.Environments](docs/sdks/sandboxenvironments/README.md)

* [list](docs/sdks/sandboxenvironments/README.md#list) - List Environments
* [create](docs/sdks/sandboxenvironments/README.md#create) - Create Environment
* [get](docs/sdks/sandboxenvironments/README.md#get) - Get Environment
* [update](docs/sdks/sandboxenvironments/README.md#update) - Update Environment
* [delete](docs/sdks/sandboxenvironments/README.md#delete) - Delete Environment
* [run_setup](docs/sdks/sandboxenvironments/README.md#run_setup) - Run Environment Setup

#### [Sandbox.Github](docs/sdks/github/README.md)

* [create_authorization_intent](docs/sdks/github/README.md#create_authorization_intent) - Start GitHub Authorization
* [connect](docs/sdks/github/README.md#connect) - Connect GitHub Account
* [get_connection](docs/sdks/github/README.md#get_connection) - Get GitHub Connection
* [disconnect](docs/sdks/github/README.md#disconnect) - Disconnect GitHub Account
* [list_repositories](docs/sdks/github/README.md#list_repositories) - List GitHub Repositories
* [refresh_repositories](docs/sdks/github/README.md#refresh_repositories) - Refresh GitHub Repositories
* [resolve_reference](docs/sdks/github/README.md#resolve_reference) - Resolve GitHub Reference
* [clone_repository](docs/sdks/github/README.md#clone_repository) - Clone GitHub Repository into Session
* [list_session_repositories](docs/sdks/github/README.md#list_session_repositories) - List Session Repositories
* [add_session_repository](docs/sdks/github/README.md#add_session_repository) - Add Session Repository
* [dismiss_session_repository](docs/sdks/github/README.md#dismiss_session_repository) - Dismiss Failed Session Repository
* [push](docs/sdks/github/README.md#push) - Push Session to GitHub
* [create_or_update_pull_request](docs/sdks/github/README.md#create_or_update_pull_request) - Create or Update Pull Request

### [Session](docs/sdks/session/README.md)

* [get_pending_invitation](docs/sdks/session/README.md#get_pending_invitation) - Find an unfinished invitation for the signed-in recipient
* [exchange_session_token](docs/sdks/session/README.md#exchange_session_token) - Exchange a live session for a delegated access token

### [Tracking.Experiments](docs/sdks/experiments/README.md)

* [create](docs/sdks/experiments/README.md#create) - Create
* [search](docs/sdks/experiments/README.md#search) - Search
* [get](docs/sdks/experiments/README.md#get) - Get
* [get_by_name](docs/sdks/experiments/README.md#get_by_name) - GetByName
* [delete](docs/sdks/experiments/README.md#delete) - Delete

### [Tracking.Runs](docs/sdks/runs/README.md)

* [create](docs/sdks/runs/README.md#create) - Create
* [get](docs/sdks/runs/README.md#get) - Get
* [search](docs/sdks/runs/README.md#search) - Search
* [update](docs/sdks/runs/README.md#update) - Update
* [delete](docs/sdks/runs/README.md#delete) - Delete
* [restore](docs/sdks/runs/README.md#restore) - Restore
* [log_metric](docs/sdks/runs/README.md#log_metric) - LogMetric
* [log_parameter](docs/sdks/runs/README.md#log_parameter) - LogParameter
* [set_tag](docs/sdks/runs/README.md#set_tag) - SetTag
* [delete_tag](docs/sdks/runs/README.md#delete_tag) - DeleteTag
* [log_batch](docs/sdks/runs/README.md#log_batch) - LogBatch
* [log_inputs](docs/sdks/runs/README.md#log_inputs) - LogInputs
* [get_metric_history](docs/sdks/runs/README.md#get_metric_history) - GetMetricHistory

### [Usage](docs/sdks/usagesdk/README.md)

* [sandbox](docs/sdks/usagesdk/README.md#sandbox) - Get Sandbox Usage
* [costs](docs/sdks/usagesdk/README.md#costs) - Aggregate cost by dimension

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

<details><summary>Less common errors (309)</summary>

<br />

**Network errors:**
* [`httpx.RequestError`](https://www.python-httpx.org/exceptions/#httpx.RequestError): Base class for request errors.
    * [`httpx.ConnectError`](https://www.python-httpx.org/exceptions/#httpx.ConnectError): HTTP client was unable to make a request to a server.
    * [`httpx.TimeoutException`](https://www.python-httpx.org/exceptions/#httpx.TimeoutException): HTTP request timed out.


**Inherit from [`SDKError`](./src/meetkai_mka1/errors/sdkerror.py)**:
* [`HTTPValidationError`](./src/meetkai_mka1/errors/httpvalidationerror.py): Validation Error. Status code `422`. Applicable to 39 of 459 methods.*
* [`ErrorEnvelope`](./src/meetkai_mka1/errors/errorenvelope.py): Error response. Applicable to 27 of 459 methods.*
* [`FeatureFlagError`](./src/meetkai_mka1/errors/featureflagerror.py): The request is malformed or fails validation. Applicable to 22 of 459 methods.*
* [`AnalyticsError`](./src/meetkai_mka1/errors/analyticserror.py): Request failed. Applicable to 12 of 459 methods.*
* [`RepoError`](./src/meetkai_mka1/errors/repoerror.py): The uniform error envelope. `error` is a stable machine-readable code (never an internal reason); `correlation_id` echoes the request's `X-Correlation-ID` for log correlation. Applicable to 7 of 459 methods.*
* [`ExchangeSessionTokenBadRequestError`](./src/meetkai_mka1/errors/exchangesessiontokenbadrequesterror.py): Invalid request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetFileContentBadRequestError`](./src/meetkai_mka1/errors/getfilecontentbadrequesterror.py): Invalid request - File ID is required. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyBadRequestError`](./src/meetkai_mka1/errors/createscopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysBadRequestError`](./src/meetkai_mka1/errors/listscopedapikeysbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyBadRequestError`](./src/meetkai_mka1/errors/updatescopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyBadRequestError`](./src/meetkai_mka1/errors/regeneratescopedapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenBadRequestError`](./src/meetkai_mka1/errors/exchangeapikeytokenbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateTeamBadRequestError`](./src/meetkai_mka1/errors/createteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListTeamsBadRequestError`](./src/meetkai_mka1/errors/listteamsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetTeamBadRequestError`](./src/meetkai_mka1/errors/getteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateTeamBadRequestError`](./src/meetkai_mka1/errors/updateteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteTeamBadRequestError`](./src/meetkai_mka1/errors/deleteteambadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberBadRequestError`](./src/meetkai_mka1/errors/addteammemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersBadRequestError`](./src/meetkai_mka1/errors/listteammembersbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberBadRequestError`](./src/meetkai_mka1/errors/removeteammemberbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountBadRequestError`](./src/meetkai_mka1/errors/createserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsBadRequestError`](./src/meetkai_mka1/errors/listserviceaccountsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountBadRequestError`](./src/meetkai_mka1/errors/getserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountBadRequestError`](./src/meetkai_mka1/errors/deleteserviceaccountbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysBadRequestError`](./src/meetkai_mka1/errors/listserviceaccountapikeysbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyBadRequestError`](./src/meetkai_mka1/errors/updateserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyBadRequestError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyBadRequestError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDBadRequestError`](./src/meetkai_mka1/errors/getorgbyidbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationBadRequestError`](./src/meetkai_mka1/errors/updateorganizationbadrequesterror.py): Invalid JSON or metadata patch. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaBadRequestError`](./src/meetkai_mka1/errors/getorgquotabadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaBadRequestError`](./src/meetkai_mka1/errors/updateorgquotabadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitBadRequestError`](./src/meetkai_mka1/errors/getorgratelimitbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitBadRequestError`](./src/meetkai_mka1/errors/updateorgratelimitbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteBadRequestError`](./src/meetkai_mka1/errors/createclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesBadRequestError`](./src/meetkai_mka1/errors/listclusterinvitesbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteBadRequestError`](./src/meetkai_mka1/errors/updateclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteBadRequestError`](./src/meetkai_mka1/errors/revokeclusterinvitebadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsBadRequestError`](./src/meetkai_mka1/errors/listclusterorgsbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgBadRequestError`](./src/meetkai_mka1/errors/getclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgBadRequestError`](./src/meetkai_mka1/errors/deleteclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersBadRequestError`](./src/meetkai_mka1/errors/inviteclusterorgmembersbadrequesterror.py): Invalid body or batch size. Status code `400`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgBadRequestError`](./src/meetkai_mka1/errors/suspendclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgBadRequestError`](./src/meetkai_mka1/errors/unsuspendclusterorgbadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyBadRequestError`](./src/meetkai_mka1/errors/reissueownerkeybadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoBadRequestError`](./src/meetkai_mka1/errors/getclusterinviteinfobadrequesterror.py): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteBadRequestError`](./src/meetkai_mka1/errors/acceptclusterinvitebadrequesterror.py): Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyBadRequestError`](./src/meetkai_mka1/errors/getjwtfromkeybadrequesterror.py): Invalid request body. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetPendingInvitationUnauthorizedError`](./src/meetkai_mka1/errors/getpendinginvitationunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenUnauthorizedError`](./src/meetkai_mka1/errors/exchangesessiontokenunauthorizederror.py): Missing, invalid, revoked or expiring session. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetFileContentUnauthorizedError`](./src/meetkai_mka1/errors/getfilecontentunauthorizederror.py): Unauthorized - Invalid or missing authentication. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/createscopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysUnauthorizedError`](./src/meetkai_mka1/errors/listscopedapikeysunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/updatescopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/regeneratescopedapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenUnauthorizedError`](./src/meetkai_mka1/errors/exchangeapikeytokenunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateTeamUnauthorizedError`](./src/meetkai_mka1/errors/createteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListTeamsUnauthorizedError`](./src/meetkai_mka1/errors/listteamsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetTeamUnauthorizedError`](./src/meetkai_mka1/errors/getteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateTeamUnauthorizedError`](./src/meetkai_mka1/errors/updateteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteTeamUnauthorizedError`](./src/meetkai_mka1/errors/deleteteamunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberUnauthorizedError`](./src/meetkai_mka1/errors/addteammemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersUnauthorizedError`](./src/meetkai_mka1/errors/listteammembersunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberUnauthorizedError`](./src/meetkai_mka1/errors/removeteammemberunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountUnauthorizedError`](./src/meetkai_mka1/errors/createserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsUnauthorizedError`](./src/meetkai_mka1/errors/listserviceaccountsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountUnauthorizedError`](./src/meetkai_mka1/errors/getserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountUnauthorizedError`](./src/meetkai_mka1/errors/deleteserviceaccountunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysUnauthorizedError`](./src/meetkai_mka1/errors/listserviceaccountapikeysunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/updateserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyUnauthorizedError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDUnauthorizedError`](./src/meetkai_mka1/errors/getorgbyidunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationUnauthorizedError`](./src/meetkai_mka1/errors/updateorganizationunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaUnauthorizedError`](./src/meetkai_mka1/errors/getorgquotaunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaUnauthorizedError`](./src/meetkai_mka1/errors/updateorgquotaunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitUnauthorizedError`](./src/meetkai_mka1/errors/getorgratelimitunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitUnauthorizedError`](./src/meetkai_mka1/errors/updateorgratelimitunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/createclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesUnauthorizedError`](./src/meetkai_mka1/errors/listclusterinvitesunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/updateclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/revokeclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsUnauthorizedError`](./src/meetkai_mka1/errors/listclusterorgsunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/getclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/deleteclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersUnauthorizedError`](./src/meetkai_mka1/errors/inviteclusterorgmembersunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/suspendclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgUnauthorizedError`](./src/meetkai_mka1/errors/unsuspendclusterorgunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyUnauthorizedError`](./src/meetkai_mka1/errors/reissueownerkeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoUnauthorizedError`](./src/meetkai_mka1/errors/getclusterinviteinfounauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteUnauthorizedError`](./src/meetkai_mka1/errors/acceptclusterinviteunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyUnauthorizedError`](./src/meetkai_mka1/errors/getjwtfromkeyunauthorizederror.py): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetPendingInvitationForbiddenError`](./src/meetkai_mka1/errors/getpendinginvitationforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenForbiddenError`](./src/meetkai_mka1/errors/exchangesessiontokenforbiddenerror.py): Active organization or team is missing or inaccessible. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyForbiddenError`](./src/meetkai_mka1/errors/createscopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysForbiddenError`](./src/meetkai_mka1/errors/listscopedapikeysforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyForbiddenError`](./src/meetkai_mka1/errors/updatescopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyForbiddenError`](./src/meetkai_mka1/errors/regeneratescopedapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenForbiddenError`](./src/meetkai_mka1/errors/exchangeapikeytokenforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateTeamForbiddenError`](./src/meetkai_mka1/errors/createteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListTeamsForbiddenError`](./src/meetkai_mka1/errors/listteamsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetTeamForbiddenError`](./src/meetkai_mka1/errors/getteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateTeamForbiddenError`](./src/meetkai_mka1/errors/updateteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteTeamForbiddenError`](./src/meetkai_mka1/errors/deleteteamforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberForbiddenError`](./src/meetkai_mka1/errors/addteammemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersForbiddenError`](./src/meetkai_mka1/errors/listteammembersforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberForbiddenError`](./src/meetkai_mka1/errors/removeteammemberforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountForbiddenError`](./src/meetkai_mka1/errors/createserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsForbiddenError`](./src/meetkai_mka1/errors/listserviceaccountsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountForbiddenError`](./src/meetkai_mka1/errors/getserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountForbiddenError`](./src/meetkai_mka1/errors/deleteserviceaccountforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysForbiddenError`](./src/meetkai_mka1/errors/listserviceaccountapikeysforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyForbiddenError`](./src/meetkai_mka1/errors/updateserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyForbiddenError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyForbiddenError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDForbiddenError`](./src/meetkai_mka1/errors/getorgbyidforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationForbiddenError`](./src/meetkai_mka1/errors/updateorganizationforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaForbiddenError`](./src/meetkai_mka1/errors/getorgquotaforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaForbiddenError`](./src/meetkai_mka1/errors/updateorgquotaforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitForbiddenError`](./src/meetkai_mka1/errors/getorgratelimitforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitForbiddenError`](./src/meetkai_mka1/errors/updateorgratelimitforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteForbiddenError`](./src/meetkai_mka1/errors/createclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesForbiddenError`](./src/meetkai_mka1/errors/listclusterinvitesforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteForbiddenError`](./src/meetkai_mka1/errors/updateclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteForbiddenError`](./src/meetkai_mka1/errors/revokeclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsForbiddenError`](./src/meetkai_mka1/errors/listclusterorgsforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgForbiddenError`](./src/meetkai_mka1/errors/getclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgForbiddenError`](./src/meetkai_mka1/errors/deleteclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersForbiddenError`](./src/meetkai_mka1/errors/inviteclusterorgmembersforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgForbiddenError`](./src/meetkai_mka1/errors/suspendclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgForbiddenError`](./src/meetkai_mka1/errors/unsuspendclusterorgforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyForbiddenError`](./src/meetkai_mka1/errors/reissueownerkeyforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoForbiddenError`](./src/meetkai_mka1/errors/getclusterinviteinfoforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteForbiddenError`](./src/meetkai_mka1/errors/acceptclusterinviteforbiddenerror.py): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetFileContentNotFoundError`](./src/meetkai_mka1/errors/getfilecontentnotfounderror.py): File not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyNotFoundError`](./src/meetkai_mka1/errors/createscopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysNotFoundError`](./src/meetkai_mka1/errors/listscopedapikeysnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyNotFoundError`](./src/meetkai_mka1/errors/updatescopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyNotFoundError`](./src/meetkai_mka1/errors/regeneratescopedapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenNotFoundError`](./src/meetkai_mka1/errors/exchangeapikeytokennotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateTeamNotFoundError`](./src/meetkai_mka1/errors/createteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListTeamsNotFoundError`](./src/meetkai_mka1/errors/listteamsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetTeamNotFoundError`](./src/meetkai_mka1/errors/getteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateTeamNotFoundError`](./src/meetkai_mka1/errors/updateteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteTeamNotFoundError`](./src/meetkai_mka1/errors/deleteteamnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberNotFoundError`](./src/meetkai_mka1/errors/addteammembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersNotFoundError`](./src/meetkai_mka1/errors/listteammembersnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberNotFoundError`](./src/meetkai_mka1/errors/removeteammembernotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountNotFoundError`](./src/meetkai_mka1/errors/createserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsNotFoundError`](./src/meetkai_mka1/errors/listserviceaccountsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountNotFoundError`](./src/meetkai_mka1/errors/getserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountNotFoundError`](./src/meetkai_mka1/errors/deleteserviceaccountnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysNotFoundError`](./src/meetkai_mka1/errors/listserviceaccountapikeysnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyNotFoundError`](./src/meetkai_mka1/errors/updateserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyNotFoundError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyNotFoundError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDNotFoundError`](./src/meetkai_mka1/errors/getorgbyidnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationNotFoundError`](./src/meetkai_mka1/errors/updateorganizationnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaNotFoundError`](./src/meetkai_mka1/errors/getorgquotanotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaNotFoundError`](./src/meetkai_mka1/errors/updateorgquotanotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitNotFoundError`](./src/meetkai_mka1/errors/getorgratelimitnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitNotFoundError`](./src/meetkai_mka1/errors/updateorgratelimitnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteNotFoundError`](./src/meetkai_mka1/errors/createclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesNotFoundError`](./src/meetkai_mka1/errors/listclusterinvitesnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteNotFoundError`](./src/meetkai_mka1/errors/updateclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteNotFoundError`](./src/meetkai_mka1/errors/revokeclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsNotFoundError`](./src/meetkai_mka1/errors/listclusterorgsnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgNotFoundError`](./src/meetkai_mka1/errors/getclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgNotFoundError`](./src/meetkai_mka1/errors/deleteclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersNotFoundError`](./src/meetkai_mka1/errors/inviteclusterorgmembersnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgNotFoundError`](./src/meetkai_mka1/errors/suspendclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgNotFoundError`](./src/meetkai_mka1/errors/unsuspendclusterorgnotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyNotFoundError`](./src/meetkai_mka1/errors/reissueownerkeynotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoNotFoundError`](./src/meetkai_mka1/errors/getclusterinviteinfonotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteNotFoundError`](./src/meetkai_mka1/errors/acceptclusterinvitenotfounderror.py): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyConflictError`](./src/meetkai_mka1/errors/createscopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysConflictError`](./src/meetkai_mka1/errors/listscopedapikeysconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyConflictError`](./src/meetkai_mka1/errors/updatescopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyConflictError`](./src/meetkai_mka1/errors/regeneratescopedapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenConflictError`](./src/meetkai_mka1/errors/exchangeapikeytokenconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateTeamConflictError`](./src/meetkai_mka1/errors/createteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListTeamsConflictError`](./src/meetkai_mka1/errors/listteamsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetTeamConflictError`](./src/meetkai_mka1/errors/getteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateTeamConflictError`](./src/meetkai_mka1/errors/updateteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteTeamConflictError`](./src/meetkai_mka1/errors/deleteteamconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberConflictError`](./src/meetkai_mka1/errors/addteammemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersConflictError`](./src/meetkai_mka1/errors/listteammembersconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberConflictError`](./src/meetkai_mka1/errors/removeteammemberconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountConflictError`](./src/meetkai_mka1/errors/createserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsConflictError`](./src/meetkai_mka1/errors/listserviceaccountsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountConflictError`](./src/meetkai_mka1/errors/getserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountConflictError`](./src/meetkai_mka1/errors/deleteserviceaccountconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysConflictError`](./src/meetkai_mka1/errors/listserviceaccountapikeysconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyConflictError`](./src/meetkai_mka1/errors/updateserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyConflictError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyConflictError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDConflictError`](./src/meetkai_mka1/errors/getorgbyidconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationConflictError`](./src/meetkai_mka1/errors/updateorganizationconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaConflictError`](./src/meetkai_mka1/errors/getorgquotaconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaConflictError`](./src/meetkai_mka1/errors/updateorgquotaconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitConflictError`](./src/meetkai_mka1/errors/getorgratelimitconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitConflictError`](./src/meetkai_mka1/errors/updateorgratelimitconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteConflictError`](./src/meetkai_mka1/errors/createclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesConflictError`](./src/meetkai_mka1/errors/listclusterinvitesconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteConflictError`](./src/meetkai_mka1/errors/updateclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteConflictError`](./src/meetkai_mka1/errors/revokeclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsConflictError`](./src/meetkai_mka1/errors/listclusterorgsconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgConflictError`](./src/meetkai_mka1/errors/getclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgConflictError`](./src/meetkai_mka1/errors/deleteclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersConflictError`](./src/meetkai_mka1/errors/inviteclusterorgmembersconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgConflictError`](./src/meetkai_mka1/errors/suspendclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgConflictError`](./src/meetkai_mka1/errors/unsuspendclusterorgconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyConflictError`](./src/meetkai_mka1/errors/reissueownerkeyconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoConflictError`](./src/meetkai_mka1/errors/getclusterinviteinfoconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteConflictError`](./src/meetkai_mka1/errors/acceptclusterinviteconflicterror.py): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyGoneError`](./src/meetkai_mka1/errors/createscopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysGoneError`](./src/meetkai_mka1/errors/listscopedapikeysgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyGoneError`](./src/meetkai_mka1/errors/updatescopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyGoneError`](./src/meetkai_mka1/errors/regeneratescopedapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenGoneError`](./src/meetkai_mka1/errors/exchangeapikeytokengoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateTeamGoneError`](./src/meetkai_mka1/errors/createteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListTeamsGoneError`](./src/meetkai_mka1/errors/listteamsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetTeamGoneError`](./src/meetkai_mka1/errors/getteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateTeamGoneError`](./src/meetkai_mka1/errors/updateteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteTeamGoneError`](./src/meetkai_mka1/errors/deleteteamgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberGoneError`](./src/meetkai_mka1/errors/addteammembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersGoneError`](./src/meetkai_mka1/errors/listteammembersgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberGoneError`](./src/meetkai_mka1/errors/removeteammembergoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountGoneError`](./src/meetkai_mka1/errors/createserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsGoneError`](./src/meetkai_mka1/errors/listserviceaccountsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountGoneError`](./src/meetkai_mka1/errors/getserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountGoneError`](./src/meetkai_mka1/errors/deleteserviceaccountgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysGoneError`](./src/meetkai_mka1/errors/listserviceaccountapikeysgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyGoneError`](./src/meetkai_mka1/errors/updateserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyGoneError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyGoneError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDGoneError`](./src/meetkai_mka1/errors/getorgbyidgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationGoneError`](./src/meetkai_mka1/errors/updateorganizationgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaGoneError`](./src/meetkai_mka1/errors/getorgquotagoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaGoneError`](./src/meetkai_mka1/errors/updateorgquotagoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitGoneError`](./src/meetkai_mka1/errors/getorgratelimitgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitGoneError`](./src/meetkai_mka1/errors/updateorgratelimitgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteGoneError`](./src/meetkai_mka1/errors/createclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesGoneError`](./src/meetkai_mka1/errors/listclusterinvitesgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteGoneError`](./src/meetkai_mka1/errors/updateclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteGoneError`](./src/meetkai_mka1/errors/revokeclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsGoneError`](./src/meetkai_mka1/errors/listclusterorgsgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgGoneError`](./src/meetkai_mka1/errors/getclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgGoneError`](./src/meetkai_mka1/errors/deleteclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersGoneError`](./src/meetkai_mka1/errors/inviteclusterorgmembersgoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgGoneError`](./src/meetkai_mka1/errors/suspendclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgGoneError`](./src/meetkai_mka1/errors/unsuspendclusterorggoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyGoneError`](./src/meetkai_mka1/errors/reissueownerkeygoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoGoneError`](./src/meetkai_mka1/errors/getclusterinviteinfogoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteGoneError`](./src/meetkai_mka1/errors/acceptclusterinvitegoneerror.py): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenRequestEntityTooLargeError`](./src/meetkai_mka1/errors/exchangesessiontokenrequestentitytoolargeerror.py): Request body exceeds the endpoint's 4 KiB limit. Status code `413`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationRequestEntityTooLargeError`](./src/meetkai_mka1/errors/updateorganizationrequestentitytoolargeerror.py): Request or merged metadata exceeds 64 KiB. Status code `413`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenTooManyRequestsError`](./src/meetkai_mka1/errors/exchangesessiontokentoomanyrequestserror.py): Per-session or per-user mint rate exceeded. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateScopedAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/createscopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListScopedAPIKeysTooManyRequestsError`](./src/meetkai_mka1/errors/listscopedapikeystoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateScopedAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/updatescopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/regeneratescopedapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ExchangeAPIKeyTokenTooManyRequestsError`](./src/meetkai_mka1/errors/exchangeapikeytokentoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateTeamTooManyRequestsError`](./src/meetkai_mka1/errors/createteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListTeamsTooManyRequestsError`](./src/meetkai_mka1/errors/listteamstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetTeamTooManyRequestsError`](./src/meetkai_mka1/errors/getteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateTeamTooManyRequestsError`](./src/meetkai_mka1/errors/updateteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteTeamTooManyRequestsError`](./src/meetkai_mka1/errors/deleteteamtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberTooManyRequestsError`](./src/meetkai_mka1/errors/addteammembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersTooManyRequestsError`](./src/meetkai_mka1/errors/listteammemberstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberTooManyRequestsError`](./src/meetkai_mka1/errors/removeteammembertoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountTooManyRequestsError`](./src/meetkai_mka1/errors/createserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsTooManyRequestsError`](./src/meetkai_mka1/errors/listserviceaccountstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountTooManyRequestsError`](./src/meetkai_mka1/errors/getserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountTooManyRequestsError`](./src/meetkai_mka1/errors/deleteserviceaccounttoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountAPIKeysTooManyRequestsError`](./src/meetkai_mka1/errors/listserviceaccountapikeystoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/updateserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/deleteserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountAPIKeyTooManyRequestsError`](./src/meetkai_mka1/errors/regenerateserviceaccountapikeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDTooManyRequestsError`](./src/meetkai_mka1/errors/getorgbyidtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationTooManyRequestsError`](./src/meetkai_mka1/errors/updateorganizationtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaTooManyRequestsError`](./src/meetkai_mka1/errors/getorgquotatoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaTooManyRequestsError`](./src/meetkai_mka1/errors/updateorgquotatoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitTooManyRequestsError`](./src/meetkai_mka1/errors/getorgratelimittoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitTooManyRequestsError`](./src/meetkai_mka1/errors/updateorgratelimittoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/createclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesTooManyRequestsError`](./src/meetkai_mka1/errors/listclusterinvitestoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/updateclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/revokeclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsTooManyRequestsError`](./src/meetkai_mka1/errors/listclusterorgstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/getclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/deleteclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersTooManyRequestsError`](./src/meetkai_mka1/errors/inviteclusterorgmemberstoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/suspendclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgTooManyRequestsError`](./src/meetkai_mka1/errors/unsuspendclusterorgtoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyTooManyRequestsError`](./src/meetkai_mka1/errors/reissueownerkeytoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoTooManyRequestsError`](./src/meetkai_mka1/errors/getclusterinviteinfotoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteTooManyRequestsError`](./src/meetkai_mka1/errors/acceptclusterinvitetoomanyrequestserror.py): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenInternalServerError`](./src/meetkai_mka1/errors/exchangesessiontokeninternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetFileContentInternalServerError`](./src/meetkai_mka1/errors/getfilecontentinternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetOrgByIDInternalServerError`](./src/meetkai_mka1/errors/getorgbyidinternalservererror.py): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationInternalServerError`](./src/meetkai_mka1/errors/updateorganizationinternalservererror.py): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyInternalServerError`](./src/meetkai_mka1/errors/getjwtfromkeyinternalservererror.py): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`ServiceUnavailableError`](./src/meetkai_mka1/errors/serviceunavailableerror.py): The invitation spend limit could not be confirmed. The organization and invitation claim were rolled back; retry acceptance. Status code `503`. Applicable to 1 of 459 methods.*
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
