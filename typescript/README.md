# MKA1 TypeScript SDK

Official TypeScript SDK for the MKA1 API.

Use `@meetkai/mka1` to call MKA1 from Node.js, browsers, React apps, and agent tooling. The SDK includes typed clients for responses, agents, files, vector stores, evals, usage, model registry operations, guardrails, sandbox APIs, and more.

Full product and API documentation lives at [docs.mka1.com](https://docs.mka1.com).

## Install

```bash
npm add @meetkai/mka1
```

```bash
pnpm add @meetkai/mka1
```

```bash
bun add @meetkai/mka1
```

```bash
yarn add @meetkai/mka1
```

The package ships both ESM and CommonJS builds. For supported runtimes, see [RUNTIMES.md](RUNTIMES.md).

## Quick Start

```typescript
import { SDK } from "@meetkai/mka1";

const mka1 = new SDK({
  bearerAuth: process.env.MKA1_API_KEY,
});

const models = await mka1.llm.models.list({});

console.log(models.data.map((model) => model.id));
```

Most write APIs use the same client:

```typescript
import { SDK } from "@meetkai/mka1";

const mka1 = new SDK({
  bearerAuth: process.env.MKA1_API_KEY,
});

const response = await mka1.llm.responses.create({
  responsesCreateRequest: {
    model: "<MODEL_ID>",
    input: "Summarize the latest MKA1 eval run.",
  },
});

console.log(response);
```

## Authentication

Pass an MKA1 API key or bearer token when constructing the client:

```typescript
const mka1 = new SDK({
  bearerAuth: process.env.MKA1_API_KEY,
});
```

You can also provide an async token resolver:

```typescript
const mka1 = new SDK({
  bearerAuth: async () => refreshMka1Token(),
});
```

For account setup, API keys, and endpoint-specific examples, see [docs.mka1.com](https://docs.mka1.com).

## Common Entry Points

```typescript
mka1.llm.responses
mka1.llm.conversations
mka1.llm.files
mka1.llm.vectorStores
mka1.llm.evals
mka1.llm.models
mka1.llm.usage
mka1.agents
mka1.agentRuns
mka1.sandbox
mka1.permissions
```

The generated method reference below lists every resource and operation included in this SDK.

## React Query

React hooks are available from `@meetkai/mka1/react-query`. Install the optional peer dependencies only if you plan to use those hooks:

```bash
npm add @tanstack/react-query react react-dom
```

See [REACT_QUERY.md](REACT_QUERY.md) for provider setup, suspense hooks, invalidation helpers, and mutation examples.

## MCP Server

This package also exposes the MKA1 API as an installable Model Context Protocol server.

Node.js v20 or newer is required for the MCP server.

```json
{
  "mcpServers": {
    "mka1": {
      "command": "npx",
      "args": [
        "-y",
        "--package",
        "@meetkai/mka1",
        "--",
        "mcp",
        "start",
        "--bearer-auth",
        "..."
      ]
    }
  }
}
```

For available server flags:

```bash
npx -y --package @meetkai/mka1 -- mcp start --help
```

<!-- Start Summary [summary] -->
## Summary

MKA1 API: The MKA1 API is a RESTful API that provides access to the MKA1 platform. Learn how to get started with the API and the TypeScript SDK [here](https://mka1.apidocumentation.com/guides/getting-started).
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [MKA1 TypeScript SDK](#mka1-typescript-sdk)
  * [Install](#install)
  * [Quick Start](#quick-start)
  * [Authentication](#authentication)
  * [Common Entry Points](#common-entry-points)
  * [React Query](#react-query)
  * [MCP Server](#mcp-server)
  * [SDK Installation](#sdk-installation)
  * [Requirements](#requirements)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication-1)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Standalone functions](#standalone-functions)
  * [React hooks with TanStack Query](#react-hooks-with-tanstack-query)
  * [Server-sent event streaming](#server-sent-event-streaming)
  * [File uploads](#file-uploads)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
  * [Custom HTTP Client](#custom-http-client)
  * [Debugging](#debugging)
  * [Versioning](#versioning)
  * [Generated Code](#generated-code)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

> [!TIP]
> To finish publishing your SDK to npm and others you must [run your first generation action](https://www.speakeasy.com/docs/github-setup#step-by-step-guide).


The SDK can be installed with either [npm](https://www.npmjs.com/), [pnpm](https://pnpm.io/), [bun](https://bun.sh/) or [yarn](https://classic.yarnpkg.com/en/) package managers.

### NPM

```bash
npm add git+https://github.com/MeetKai/mka1-sdks.git?subdir=typescript
# Install optional peer dependencies if you plan to use React hooks
npm add @tanstack/react-query react react-dom
```

### PNPM

```bash
pnpm add https://github.com/MeetKai/mka1-sdks#path:typescript
# Install optional peer dependencies if you plan to use React hooks
pnpm add @tanstack/react-query react react-dom
```

### Bun

```bash
bun add https://github.com/MeetKai/mka1-sdks
# Install optional peer dependencies if you plan to use React hooks
bun add @tanstack/react-query react react-dom
```

### Yarn

```bash
yarn add https://github.com/MeetKai/mka1-sdks
# Install optional peer dependencies if you plan to use React hooks
yarn add @tanstack/react-query react react-dom
```

> [!NOTE]
> This package is published with CommonJS and ES Modules (ESM) support.


### Model Context Protocol (MCP) Server

This SDK is also an installable MCP server where the various SDK methods are
exposed as tools that can be invoked by AI applications.

> Node.js v20 or greater is required to run the MCP server from npm.

<details>
<summary>Claude installation steps</summary>

Add the following server definition to your `claude_desktop_config.json` file:

```json
{
  "mcpServers": {
    "SDK": {
      "command": "npx",
      "args": [
        "-y", "--package", "@meetkai/mka1",
        "--",
        "mcp", "start",
        "--bearer-auth", "..."
      ]
    }
  }
}
```

</details>

<details>
<summary>Cursor installation steps</summary>

Create a `.cursor/mcp.json` file in your project root with the following content:

```json
{
  "mcpServers": {
    "SDK": {
      "command": "npx",
      "args": [
        "-y", "--package", "@meetkai/mka1",
        "--",
        "mcp", "start",
        "--bearer-auth", "..."
      ]
    }
  }
}
```

</details>

You can also run MCP servers as a standalone binary with no additional dependencies. You must pull these binaries from available Github releases:

```bash
curl -L -o mcp-server \
    https://github.com/{org}/{repo}/releases/download/{tag}/mcp-server-bun-darwin-arm64 && \
chmod +x mcp-server
```

If the repo is a private repo you must add your Github PAT to download a release `-H "Authorization: Bearer {GITHUB_PAT}"`.


```json
{
  "mcpServers": {
    "Todos": {
      "command": "./DOWNLOAD/PATH/mcp-server",
      "args": [
        "start"
      ]
    }
  }
}
```

For a full list of server arguments, run:

```sh
npx -y --package @meetkai/mka1 -- mcp start --help
```
<!-- End SDK Installation [installation] -->

<!-- Start Requirements [requirements] -->
## Requirements

For supported JavaScript runtimes, please consult [RUNTIMES.md](RUNTIMES.md).
<!-- End Requirements [requirements] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type | Scheme      |
| ------------ | ---- | ----------- |
| `bearerAuth` | http | HTTP Bearer |

To authenticate with the API the `bearerAuth` parameter must be set when initializing the SDK client instance. For example:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.auth.orgs.getById({}, {
    orgId: "<id>",
  });

  console.log(result);
}

run();

```
<!-- End Authentication [security] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AgentConnectors](docs/sdks/agentconnectors/README.md)

* [listAgentConnectors](docs/sdks/agentconnectors/README.md#listagentconnectors) - List connectors for an agent
* [createAgentConnector](docs/sdks/agentconnectors/README.md#createagentconnector) - Create a connector
* [setupWhatsAppAppWebhook](docs/sdks/agentconnectors/README.md#setupwhatsappappwebhook) - Set up a WhatsApp app webhook (Beta)
* [getAgentConnector](docs/sdks/agentconnectors/README.md#getagentconnector) - Retrieve a connector
* [deleteAgentConnector](docs/sdks/agentconnectors/README.md#deleteagentconnector) - Delete a connector
* [activateAgentConnector](docs/sdks/agentconnectors/README.md#activateagentconnector) - Activate a connector

### [AgentRuns](docs/sdks/agentruns/README.md)

* [listAgentRuns](docs/sdks/agentruns/README.md#listagentruns) - List runs for an agent
* [createAgentRun](docs/sdks/agentruns/README.md#createagentrun) - Start a saved agent run
* [streamAgentRunEvents](docs/sdks/agentruns/README.md#streamagentrunevents) - Stream agent run events
* [wakeAgentRun](docs/sdks/agentruns/README.md#wakeagentrun) - Wake a sleeping agent run
* [decideAgentRunMcpApproval](docs/sdks/agentruns/README.md#decideagentrunmcpapproval) - Approve or deny a pending MCP tool call
* [getAgentRun](docs/sdks/agentruns/README.md#getagentrun) - Retrieve an agent run

### [AgentSchedules](docs/sdks/agentschedules/README.md)

* [listAgentSchedules](docs/sdks/agentschedules/README.md#listagentschedules) - List schedules for an agent
* [createAgentSchedule](docs/sdks/agentschedules/README.md#createagentschedule) - Create an agent schedule
* [getAgentSchedule](docs/sdks/agentschedules/README.md#getagentschedule) - Retrieve an agent schedule
* [updateAgentSchedule](docs/sdks/agentschedules/README.md#updateagentschedule) - Update an agent schedule
* [deleteAgentSchedule](docs/sdks/agentschedules/README.md#deleteagentschedule) - Delete an agent schedule
* [pauseAgentSchedule](docs/sdks/agentschedules/README.md#pauseagentschedule) - Pause an agent schedule
* [resumeAgentSchedule](docs/sdks/agentschedules/README.md#resumeagentschedule) - Resume an agent schedule

### [AgentVersions](docs/sdks/agentversions/README.md)

* [listAgentVersions](docs/sdks/agentversions/README.md#listagentversions) - List agent versions
* [getAgentVersion](docs/sdks/agentversions/README.md#getagentversion) - Retrieve an agent version
* [rollbackAgentVersion](docs/sdks/agentversions/README.md#rollbackagentversion) - Roll back an agent to a version

### [Agents](docs/sdks/agents/README.md)

* [listAgents](docs/sdks/agents/README.md#listagents) - List agents
* [createAgent](docs/sdks/agents/README.md#createagent) - Create an agent
* [getAgent](docs/sdks/agents/README.md#getagent) - Retrieve an agent
* [updateAgent](docs/sdks/agents/README.md#updateagent) - Update an agent
* [deleteAgent](docs/sdks/agents/README.md#deleteagent) - Delete an agent

### [Analytics](docs/sdks/analytics/README.md)

* [capture](docs/sdks/analytics/README.md#capture) - Durably accept a batch of events
* [query](docs/sdks/analytics/README.md#query) - Query event counts or unique visitors

#### [Analytics.Events](docs/sdks/events/README.md)

* [search](docs/sdks/events/README.md#search) - Search events in a time range

#### [Analytics.Keys](docs/sdks/keys/README.md)

* [create](docs/sdks/keys/README.md#create) - Create a capture key and return its secret once
* [list](docs/sdks/keys/README.md#list) - List capture key metadata
* [revoke](docs/sdks/keys/README.md#revoke) - Revoke a capture key

#### [Analytics.Projects](docs/sdks/projects/README.md)

* [create](docs/sdks/projects/README.md#create) - Create an analytics project
* [list](docs/sdks/projects/README.md#list) - List accessible analytics projects
* [get](docs/sdks/projects/README.md#get) - Get an analytics project
* [update](docs/sdks/projects/README.md#update) - Rename an active analytics project
* [archive](docs/sdks/projects/README.md#archive) - Archive an analytics project

#### [Analytics.Visitors](docs/sdks/visitors/README.md)

* [search](docs/sdks/visitors/README.md#search) - Search visitors in a time range

### [~~Auth.ApiKey~~](docs/sdks/apikey/README.md)

* [~~getJwtFromKey~~](docs/sdks/apikey/README.md#getjwtfromkey) - Exchange API key for a JWT token :warning: **Deprecated** Use [exchangeToken](docs/sdks/apikeys/README.md#exchangetoken) instead.

### [Auth.ApiKeys](docs/sdks/apikeys/README.md)

* [create](docs/sdks/apikeys/README.md#create) - Mint a scoped API key
* [list](docs/sdks/apikeys/README.md#list) - List scoped API keys
* [update](docs/sdks/apikeys/README.md#update) - Update a scoped API key
* [regenerate](docs/sdks/apikeys/README.md#regenerate) - Rotate a scoped API key's secret
* [exchangeToken](docs/sdks/apikeys/README.md#exchangetoken) - Exchange API key for a JWT token

### [Auth.Cluster](docs/sdks/cluster/README.md)

* [createInvite](docs/sdks/cluster/README.md#createinvite) - Create a cluster invitation
* [listInvites](docs/sdks/cluster/README.md#listinvites) - List cluster invitations
* [updateInvite](docs/sdks/cluster/README.md#updateinvite) - Update a pending cluster invitation
* [revokeInvite](docs/sdks/cluster/README.md#revokeinvite) - Revoke a cluster invitation
* [listOrgs](docs/sdks/cluster/README.md#listorgs) - List all organizations
* [getOrg](docs/sdks/cluster/README.md#getorg) - Get an organization
* [deleteOrg](docs/sdks/cluster/README.md#deleteorg) - Soft-delete an organization
* [inviteOrgMembers](docs/sdks/cluster/README.md#inviteorgmembers) - Invite members on behalf of an organization
* [suspendOrg](docs/sdks/cluster/README.md#suspendorg) - Suspend an organization
* [unsuspendOrg](docs/sdks/cluster/README.md#unsuspendorg) - Unsuspend an organization
* [reissueOwnerKey](docs/sdks/cluster/README.md#reissueownerkey) - Re-issue an org owner key (recovery)
* [inviteInfo](docs/sdks/cluster/README.md#inviteinfo) - Read cluster-invite info (public)
* [acceptInvite](docs/sdks/cluster/README.md#acceptinvite) - Accept a cluster invitation (public)

### [Auth.Orgs](docs/sdks/orgs/README.md)

* [getById](docs/sdks/orgs/README.md#getbyid) - Get basic organization details
* [update](docs/sdks/orgs/README.md#update) - Patch organization metadata (cluster-admin)
* [getQuota](docs/sdks/orgs/README.md#getquota) - Get an org's usage quota
* [updateQuota](docs/sdks/orgs/README.md#updatequota) - Set an org's usage quota (cluster-admin)
* [getRateLimit](docs/sdks/orgs/README.md#getratelimit) - Get an org's rate limit
* [updateRateLimit](docs/sdks/orgs/README.md#updateratelimit) - Set an org's rate limit (cluster-admin)

### [Auth.ServiceAccounts](docs/sdks/serviceaccounts/README.md)

* [create](docs/sdks/serviceaccounts/README.md#create) - Create a service account
* [list](docs/sdks/serviceaccounts/README.md#list) - List service accounts
* [get](docs/sdks/serviceaccounts/README.md#get) - Get a service account
* [delete](docs/sdks/serviceaccounts/README.md#delete) - Delete a service account
* [listApiKeys](docs/sdks/serviceaccounts/README.md#listapikeys) - List a service account's API keys
* [updateApiKey](docs/sdks/serviceaccounts/README.md#updateapikey) - Update a service-account API key
* [deleteApiKey](docs/sdks/serviceaccounts/README.md#deleteapikey) - Delete a service-account API key
* [regenerateApiKey](docs/sdks/serviceaccounts/README.md#regenerateapikey) - Rotate a service-account API key's secret

### [Auth.Teams](docs/sdks/teams/README.md)

* [create](docs/sdks/teams/README.md#create) - Create a team
* [list](docs/sdks/teams/README.md#list) - List teams in an org
* [get](docs/sdks/teams/README.md#get) - Get a team
* [update](docs/sdks/teams/README.md#update) - Rename a team
* [delete](docs/sdks/teams/README.md#delete) - Delete a team
* [addMember](docs/sdks/teams/README.md#addmember) - Add a team member
* [listMembers](docs/sdks/teams/README.md#listmembers) - List team members
* [removeMember](docs/sdks/teams/README.md#removemember) - Remove a team member

### [Billing](docs/sdks/billing/README.md)

* [getOrganizationBilling](docs/sdks/billing/README.md#getorganizationbilling)
* [setOrganizationBillingEnabled](docs/sdks/billing/README.md#setorganizationbillingenabled)
* [updateOrganizationBillingProfile](docs/sdks/billing/README.md#updateorganizationbillingprofile)
* [createOrganizationBillingSetup](docs/sdks/billing/README.md#createorganizationbillingsetup)
* [createOrganizationBillingPortal](docs/sdks/billing/README.md#createorganizationbillingportal)
* [listOrganizationBillingInvoices](docs/sdks/billing/README.md#listorganizationbillinginvoices)

### [Budgets](docs/sdks/budgets/README.md)

* [list](docs/sdks/budgets/README.md#list) - List budgets
* [getOrg](docs/sdks/budgets/README.md#getorg) - List org budgets
* [setOrg](docs/sdks/budgets/README.md#setorg) - Set an org budget
* [deleteOrg](docs/sdks/budgets/README.md#deleteorg) - Delete an org budget
* [orgEvents](docs/sdks/budgets/README.md#orgevents) - List org budget events
* [getApiKey](docs/sdks/budgets/README.md#getapikey) - List apikey budgets
* [setApiKey](docs/sdks/budgets/README.md#setapikey) - Set an apikey budget
* [deleteApiKey](docs/sdks/budgets/README.md#deleteapikey) - Delete an apikey budget
* [apiKeyEvents](docs/sdks/budgets/README.md#apikeyevents) - List apikey budget events
* [getUser](docs/sdks/budgets/README.md#getuser) - List user budgets
* [setUser](docs/sdks/budgets/README.md#setuser) - Set a user budget
* [deleteUser](docs/sdks/budgets/README.md#deleteuser) - Delete a user budget
* [userEvents](docs/sdks/budgets/README.md#userevents) - List user budget events
* [getTeam](docs/sdks/budgets/README.md#getteam) - List team budgets
* [setTeam](docs/sdks/budgets/README.md#setteam) - Set a team budget
* [deleteTeam](docs/sdks/budgets/README.md#deleteteam) - Delete a team budget
* [teamEvents](docs/sdks/budgets/README.md#teamevents) - List team budget events
* [getExternalUser](docs/sdks/budgets/README.md#getexternaluser) - List external user budgets
* [setExternalUser](docs/sdks/budgets/README.md#setexternaluser) - Set a external user budget
* [deleteExternalUser](docs/sdks/budgets/README.md#deleteexternaluser) - Delete a external user budget
* [externalUserEvents](docs/sdks/budgets/README.md#externaluserevents) - List external user budget events
* [getUserDefault](docs/sdks/budgets/README.md#getuserdefault) - List per-user default budgets
* [setUserDefault](docs/sdks/budgets/README.md#setuserdefault) - Set a per-user default budget
* [deleteUserDefault](docs/sdks/budgets/README.md#deleteuserdefault) - Delete a per-user default budget
* [userDefaultEvents](docs/sdks/budgets/README.md#userdefaultevents) - List per-user default budget events
* [getTeamDefault](docs/sdks/budgets/README.md#getteamdefault) - List per-team default budgets
* [setTeamDefault](docs/sdks/budgets/README.md#setteamdefault) - Set a per-team default budget
* [deleteTeamDefault](docs/sdks/budgets/README.md#deleteteamdefault) - Delete a per-team default budget
* [teamDefaultEvents](docs/sdks/budgets/README.md#teamdefaultevents) - List per-team default budget events
* [getExternalUserDefault](docs/sdks/budgets/README.md#getexternaluserdefault) - List per-external user default budgets
* [setExternalUserDefault](docs/sdks/budgets/README.md#setexternaluserdefault) - Set a per-external user default budget
* [deleteExternalUserDefault](docs/sdks/budgets/README.md#deleteexternaluserdefault) - Delete a per-external user default budget
* [externalUserDefaultEvents](docs/sdks/budgets/README.md#externaluserdefaultevents) - List per-external user default budget events
* [getCurrency](docs/sdks/budgets/README.md#getcurrency) - Get display currency
* [setCurrency](docs/sdks/budgets/README.md#setcurrency) - Set display currency

### [ComputeCatalog](docs/sdks/computecatalog/README.md)

* [listAccelerators](docs/sdks/computecatalog/README.md#listaccelerators) - List accelerators
* [getAccelerator](docs/sdks/computecatalog/README.md#getaccelerator) - Get an accelerator
* [listComputeOffers](docs/sdks/computecatalog/README.md#listcomputeoffers) - List provider offers
* [listComputeProviders](docs/sdks/computecatalog/README.md#listcomputeproviders) - List provider health
* [createComputeQuote](docs/sdks/computecatalog/README.md#createcomputequote) - Create a quote

### [ComputeJobs](docs/sdks/computejobs/README.md)

* [listJobs](docs/sdks/computejobs/README.md#listjobs) - List jobs
* [createJob](docs/sdks/computejobs/README.md#createjob) - Create a job
* [getJob](docs/sdks/computejobs/README.md#getjob) - Get a job
* [listJobEvents](docs/sdks/computejobs/README.md#listjobevents) - List job events
* [listJobInstances](docs/sdks/computejobs/README.md#listjobinstances) - List observed job instances
* [listJobLogs](docs/sdks/computejobs/README.md#listjoblogs) - List job logs
* [terminateJob](docs/sdks/computejobs/README.md#terminatejob) - Terminate a job

### [ComputePricing](docs/sdks/computepricing/README.md)

* [getPricing](docs/sdks/computepricing/README.md#getpricing) - Get the latest committed storage price
* [putPricing](docs/sdks/computepricing/README.md#putpricing) - Create an immutable storage-price version

### [ComputeSecrets](docs/sdks/computesecrets/README.md)

* [listComputeSecrets](docs/sdks/computesecrets/README.md#listcomputesecrets) - List secrets
* [createComputeSecret](docs/sdks/computesecrets/README.md#createcomputesecret) - Create a secret
* [deleteComputeSecret](docs/sdks/computesecrets/README.md#deletecomputesecret) - Delete a secret
* [getComputeSecret](docs/sdks/computesecrets/README.md#getcomputesecret) - Get a secret

### [ComputeServices](docs/sdks/computeservices/README.md)

* [listServices](docs/sdks/computeservices/README.md#listservices) - List services
* [createService](docs/sdks/computeservices/README.md#createservice) - Create a service
* [getService](docs/sdks/computeservices/README.md#getservice) - Get a service
* [listServiceEvents](docs/sdks/computeservices/README.md#listserviceevents) - List service events
* [listServiceInstances](docs/sdks/computeservices/README.md#listserviceinstances) - List observed service instances
* [listServiceLogs](docs/sdks/computeservices/README.md#listservicelogs) - List service logs
* [updateServiceScaling](docs/sdks/computeservices/README.md#updateservicescaling) - Replace a service scaling policy
* [terminateService](docs/sdks/computeservices/README.md#terminateservice) - Terminate a service

### [ComputeTenants](docs/sdks/computetenants/README.md)

* [listComputeTenants](docs/sdks/computetenants/README.md#listcomputetenants) - List tenants
* [getComputeTenant](docs/sdks/computetenants/README.md#getcomputetenant) - Get a tenant
* [putComputeTenant](docs/sdks/computetenants/README.md#putcomputetenant) - Update a tenant

### [ComputeUsage](docs/sdks/computeusage/README.md)

* [getComputeUsage](docs/sdks/computeusage/README.md#getcomputeusage) - Get usage

### [ComputeVolumes](docs/sdks/computevolumes/README.md)

* [listStandaloneVolumes](docs/sdks/computevolumes/README.md#liststandalonevolumes) - List organization volumes
* [createStandaloneVolume](docs/sdks/computevolumes/README.md#createstandalonevolume) - Create a standalone shared volume
* [deleteStandaloneVolume](docs/sdks/computevolumes/README.md#deletestandalonevolume) - Permanently delete a standalone volume
* [getStandaloneVolume](docs/sdks/computevolumes/README.md#getstandalonevolume) - Get a standalone volume
* [listStandaloneVolumeAttachments](docs/sdks/computevolumes/README.md#liststandalonevolumeattachments) - List volume attachments

### [Datasets](docs/sdks/datasets/README.md)

* [listGenerators](docs/sdks/datasets/README.md#listgenerators) - List Generators
* [getGenerator](docs/sdks/datasets/README.md#getgenerator) - Get Generator
* [quoteGenerator](docs/sdks/datasets/README.md#quotegenerator) - Quote Generator
* [listGenerations](docs/sdks/datasets/README.md#listgenerations) - List Generations
* [createGeneration](docs/sdks/datasets/README.md#creategeneration) - Create Generation
* [getGeneration](docs/sdks/datasets/README.md#getgeneration) - Get Generation
* [getGenerationLogs](docs/sdks/datasets/README.md#getgenerationlogs) - Get Logs
* [getGenerationEvents](docs/sdks/datasets/README.md#getgenerationevents) - Get Events
* [cancelGeneration](docs/sdks/datasets/README.md#cancelgeneration) - Cancel Generation
* [listFormats](docs/sdks/datasets/README.md#listformats) - List Formats
* [getFormat](docs/sdks/datasets/README.md#getformat) - Get Format

### [Flags](docs/sdks/flags/README.md)

* [list](docs/sdks/flags/README.md#list) - List flags
* [create](docs/sdks/flags/README.md#create) - Create a flag
* [delete](docs/sdks/flags/README.md#delete) - Delete a flag and its settings in every environment
* [get](docs/sdks/flags/README.md#get) - Get a flag
* [update](docs/sdks/flags/README.md#update) - Update a flag's name, description, default value, or project
* [archive](docs/sdks/flags/README.md#archive) - Archive a flag
* [setEnvironmentState](docs/sdks/flags/README.md#setenvironmentstate) - Replace a flag's settings in one environment
* [unarchive](docs/sdks/flags/README.md#unarchive) - Restore an archived flag

#### [Flags.Audit](docs/sdks/audit/README.md)

* [list](docs/sdks/audit/README.md#list) - List audit entries, newest first

#### [Flags.Environments](docs/sdks/sdkenvironments/README.md)

* [list](docs/sdks/sdkenvironments/README.md#list) - List environments
* [create](docs/sdks/sdkenvironments/README.md#create) - Create an environment
* [delete](docs/sdks/sdkenvironments/README.md#delete) - Delete an environment and every flag setting in it
* [update](docs/sdks/sdkenvironments/README.md#update) - Rename an environment
* [evaluate](docs/sdks/sdkenvironments/README.md#evaluate) - Evaluate every flag for an identity
* [evaluateWithTraits](docs/sdks/sdkenvironments/README.md#evaluatewithtraits) - Evaluate every flag for an identity with traits
* [revokeEvaluationKey](docs/sdks/sdkenvironments/README.md#revokeevaluationkey) - Revoke an environment evaluation key
* [generateEvaluationKey](docs/sdks/sdkenvironments/README.md#generateevaluationkey) - Generate or replace an environment evaluation key

#### [Flags.Projects](docs/sdks/sdkprojects/README.md)

* [list](docs/sdks/sdkprojects/README.md#list) - List projects
* [create](docs/sdks/sdkprojects/README.md#create) - Create a project
* [delete](docs/sdks/sdkprojects/README.md#delete) - Delete an empty project
* [get](docs/sdks/sdkprojects/README.md#get) - Get a project
* [update](docs/sdks/sdkprojects/README.md#update) - Rename a project

### [Guardrails](docs/sdks/guardrails/README.md)

* [getGuardrails](docs/sdks/guardrails/README.md#getguardrails) - Get effective guardrails
* [updateGuardrails](docs/sdks/guardrails/README.md#updateguardrails) - Update guardrails policy
* [deleteGuardrails](docs/sdks/guardrails/README.md#deleteguardrails) - Delete guardrails policy
* [listGuardrailsPolicies](docs/sdks/guardrails/README.md#listguardrailspolicies) - List guardrails policies
* [testGuardrails](docs/sdks/guardrails/README.md#testguardrails) - Test content against guardrails

### [Llm.Batches](docs/sdks/batches/README.md)

* [create](docs/sdks/batches/README.md#create) - Create a batch
* [list](docs/sdks/batches/README.md#list) - List batches
* [get](docs/sdks/batches/README.md#get) - Get a batch
* [cancel](docs/sdks/batches/README.md#cancel) - Cancel a batch

### [~~Llm.Chat~~](docs/sdks/chat/README.md)

* [~~createChat~~](docs/sdks/chat/README.md#createchat) - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
* [~~stream~~](docs/sdks/chat/README.md#stream) - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**

### [Llm.Classify](docs/sdks/classify/README.md)

* [classify](docs/sdks/classify/README.md#classify) - Classify text into predefined categories

### [Llm.Conversations](docs/sdks/conversations/README.md)

* [create](docs/sdks/conversations/README.md#create) - Create a conversation
* [list](docs/sdks/conversations/README.md#list) - List conversations
* [get](docs/sdks/conversations/README.md#get) - Retrieve a conversation
* [update](docs/sdks/conversations/README.md#update) - Update a conversation
* [delete](docs/sdks/conversations/README.md#delete) - Delete a conversation
* [listItems](docs/sdks/conversations/README.md#listitems) - List conversation items
* [createItems](docs/sdks/conversations/README.md#createitems) - Create conversation items
* [deleteItems](docs/sdks/conversations/README.md#deleteitems) - Delete multiple conversation items
* [getItem](docs/sdks/conversations/README.md#getitem) - Retrieve a conversation item
* [deleteItem](docs/sdks/conversations/README.md#deleteitem) - Delete a conversation item

### [Llm.Embeddings](docs/sdks/embeddings/README.md)

* [listModels](docs/sdks/embeddings/README.md#listmodels) - List available embedding models
* [embed](docs/sdks/embeddings/README.md#embed) - Create text embeddings

### [Llm.Evals](docs/sdks/evals/README.md)

* [createSuite](docs/sdks/evals/README.md#createsuite) - Create an eval suite
* [listSuites](docs/sdks/evals/README.md#listsuites) - List eval suites
* [getSuite](docs/sdks/evals/README.md#getsuite) - Get an eval suite
* [deleteSuite](docs/sdks/evals/README.md#deletesuite) - Delete an eval suite
* [createSuiteVersion](docs/sdks/evals/README.md#createsuiteversion) - Create an eval suite version
* [listSuiteVersions](docs/sdks/evals/README.md#listsuiteversions) - List eval suite versions
* [getSuiteVersion](docs/sdks/evals/README.md#getsuiteversion) - Get an eval suite version
* [listSuiteLeaderboardRuns](docs/sdks/evals/README.md#listsuiteleaderboardruns) - List leaderboard runs for an eval suite
* [getSuiteLeaderboard](docs/sdks/evals/README.md#getsuiteleaderboard) - Get the coding-agent leaderboard for an eval suite
* [measureSuiteTokens](docs/sdks/evals/README.md#measuresuitetokens) - Count tokens from stored text for a suite's unmeasured samples
* [createRun](docs/sdks/evals/README.md#createrun) - Create an eval run
* [listRuns](docs/sdks/evals/README.md#listruns) - List eval runs
* [getRun](docs/sdks/evals/README.md#getrun) - Get an eval run
* [deleteRun](docs/sdks/evals/README.md#deleterun) - Delete an eval run
* [cancelRun](docs/sdks/evals/README.md#cancelrun) - Cancel an eval run
* [rerunFailedSamples](docs/sdks/evals/README.md#rerunfailedsamples) - Rerun failed eval samples
* [retryFailedRun](docs/sdks/evals/README.md#retryfailedrun) - Retry an eval run
* [getRunOverview](docs/sdks/evals/README.md#getrunoverview) - Get an eval run overview
* [listSamples](docs/sdks/evals/README.md#listsamples) - List eval samples
* [getSampleAudio](docs/sdks/evals/README.md#getsampleaudio) - Get eval sample audio
* [getSampleTrajectory](docs/sdks/evals/README.md#getsampletrajectory) - Get an eval sample trajectory
* [uploadSampleTrajectory](docs/sdks/evals/README.md#uploadsampletrajectory) - Upload an eval sample trajectory
* [getArtifacts](docs/sdks/evals/README.md#getartifacts) - Get eval run artifacts
* [importAgentRun](docs/sdks/evals/README.md#importagentrun) - Import a finished coding-agent run
* [appendAgentTrials](docs/sdks/evals/README.md#appendagenttrials) - Append trials to an open coding-agent run
* [importHistoricalResults](docs/sdks/evals/README.md#importhistoricalresults) - Import historical eval results from Hugging Face
* [createSchedule](docs/sdks/evals/README.md#createschedule) - Create an eval schedule
* [listSchedules](docs/sdks/evals/README.md#listschedules) - List eval schedules
* [getSchedule](docs/sdks/evals/README.md#getschedule) - Get an eval schedule
* [updateSchedule](docs/sdks/evals/README.md#updateschedule) - Update an eval schedule
* [deleteSchedule](docs/sdks/evals/README.md#deleteschedule) - Delete an eval schedule
* [triggerSchedule](docs/sdks/evals/README.md#triggerschedule) - Trigger an eval schedule now
* [listScheduleRuns](docs/sdks/evals/README.md#listscheduleruns) - List runs created by an eval schedule

### [Llm.Extract](docs/sdks/extract/README.md)

* [extract](docs/sdks/extract/README.md#extract) - Extract structured data with inline JSON Schema
* [createSchema](docs/sdks/extract/README.md#createschema) - Create reusable extraction schema template
* [getSchema](docs/sdks/extract/README.md#getschema) - Get extraction schema by ID
* [updateSchema](docs/sdks/extract/README.md#updateschema) - Update extraction schema by ID
* [deleteSchema](docs/sdks/extract/README.md#deleteschema) - Delete extraction schema by ID
* [extractWithSchema](docs/sdks/extract/README.md#extractwithschema) - Extract data using saved schema template

### [Llm.Feedback](docs/sdks/feedback/README.md)

* [createCompletionFeedback](docs/sdks/feedback/README.md#createcompletionfeedback) - Submit feedback for chat completion
* [listCompletionFeedback](docs/sdks/feedback/README.md#listcompletionfeedback) - List chat completion feedback
* [getCompletionFeedback](docs/sdks/feedback/README.md#getcompletionfeedback) - Retrieve feedback by completion ID
* [updateCompletionFeedback](docs/sdks/feedback/README.md#updatecompletionfeedback) - Update existing completion feedback
* [batchGetCompletionFeedback](docs/sdks/feedback/README.md#batchgetcompletionfeedback) - Batch retrieve feedback for multiple completions
* [createResponseFeedback](docs/sdks/feedback/README.md#createresponsefeedback) - Submit feedback for response
* [listResponseFeedback](docs/sdks/feedback/README.md#listresponsefeedback) - List response feedback
* [getResponseFeedback](docs/sdks/feedback/README.md#getresponsefeedback) - Retrieve feedback by response ID
* [updateResponseFeedback](docs/sdks/feedback/README.md#updateresponsefeedback) - Update existing response feedback
* [batchGetResponseFeedback](docs/sdks/feedback/README.md#batchgetresponsefeedback) - Batch retrieve feedback for multiple responses
* [exportCompletionFeedback](docs/sdks/feedback/README.md#exportcompletionfeedback) - Export completion feedback as CSV
* [exportResponseFeedback](docs/sdks/feedback/README.md#exportresponsefeedback) - Export response feedback as CSV
* [startExport](docs/sdks/feedback/README.md#startexport) - Start feedback export
* [getExportStatus](docs/sdks/feedback/README.md#getexportstatus) - Get feedback export status

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
* [~~listEvents~~](docs/sdks/finetuning/README.md#listevents) - [Deprecated] List fine-tuning events :warning: **Deprecated**
* [~~listCheckpoints~~](docs/sdks/finetuning/README.md#listcheckpoints) - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**

### [Llm.Images](docs/sdks/images/README.md)

* [create](docs/sdks/images/README.md#create) - Generate images from text descriptions

### [Llm.McpVault](docs/sdks/mcpvault/README.md)

* [createServer](docs/sdks/mcpvault/README.md#createserver) - Create MCP server
* [listServers](docs/sdks/mcpvault/README.md#listservers) - List MCP servers
* [getServer](docs/sdks/mcpvault/README.md#getserver) - Retrieve MCP server
* [updateServer](docs/sdks/mcpvault/README.md#updateserver) - Update MCP server
* [deleteServer](docs/sdks/mcpvault/README.md#deleteserver) - Delete MCP server
* [createCredential](docs/sdks/mcpvault/README.md#createcredential) - Create MCP credential
* [listCredentials](docs/sdks/mcpvault/README.md#listcredentials) - List MCP credentials
* [deleteCredential](docs/sdks/mcpvault/README.md#deletecredential) - Delete MCP credential
* [testServer](docs/sdks/mcpvault/README.md#testserver) - Test MCP server

### [Llm.MemoryStores](docs/sdks/memorystores/README.md)

* [create](docs/sdks/memorystores/README.md#create) - Create memory store
* [list](docs/sdks/memorystores/README.md#list) - List memory stores
* [get](docs/sdks/memorystores/README.md#get) - Retrieve memory store
* [update](docs/sdks/memorystores/README.md#update) - Update memory store
* [delete](docs/sdks/memorystores/README.md#delete) - Delete memory store
* [createEntry](docs/sdks/memorystores/README.md#createentry) - Create memory entry
* [listEntries](docs/sdks/memorystores/README.md#listentries) - List memory entries
* [getEntry](docs/sdks/memorystores/README.md#getentry) - Retrieve memory entry
* [updateEntry](docs/sdks/memorystores/README.md#updateentry) - Update memory entry
* [deleteEntry](docs/sdks/memorystores/README.md#deleteentry) - Delete memory entry

### [Llm.Models](docs/sdks/models/README.md)

* [list](docs/sdks/models/README.md#list) - List available models
* [get](docs/sdks/models/README.md#get) - Retrieve a model
* [listCatalog](docs/sdks/models/README.md#listcatalog) - List the organization's model catalog
* [addCatalogEntry](docs/sdks/models/README.md#addcatalogentry) - Define a BYO catalog model
* [updateCatalogEntry](docs/sdks/models/README.md#updatecatalogentry) - Update a BYO catalog model
* [deleteCatalogEntry](docs/sdks/models/README.md#deletecatalogentry) - Remove a BYO catalog model
* [checkCatalogHealth](docs/sdks/models/README.md#checkcataloghealth) - Check a BYO catalog model's health
* [listCatalogOrgAccess](docs/sdks/models/README.md#listcatalogorgaccess) - List an organization's cluster model access
* [addCatalogOrgAccess](docs/sdks/models/README.md#addcatalogorgaccess) - Add cluster model access for an organization
* [replaceCatalogOrgAccess](docs/sdks/models/README.md#replacecatalogorgaccess) - Replace an organization's cluster model access
* [listCatalogModelAccess](docs/sdks/models/README.md#listcatalogmodelaccess) - List organizations with access to a cluster model
* [listRegistry](docs/sdks/models/README.md#listregistry) - List the organization's active model registry
* [activateRegistryEntry](docs/sdks/models/README.md#activateregistryentry) - Activate a catalog entry
* [deactivateRegistryEntry](docs/sdks/models/README.md#deactivateregistryentry) - Deactivate a model registry name
* [listOrgAutoModels](docs/sdks/models/README.md#listorgautomodels) - List this org's auto-model overrides
* [putOrgAutoModel](docs/sdks/models/README.md#putorgautomodel) - Set this org's auto policy for an endpoint
* [deleteOrgAutoModel](docs/sdks/models/README.md#deleteorgautomodel) - Clear this org's auto-model override for an endpoint
* [getClusterCurrency](docs/sdks/models/README.md#getclustercurrency) - Get the cluster currency
* [setClusterCurrency](docs/sdks/models/README.md#setclustercurrency) - Set the cluster currency
* [listClusterPrices](docs/sdks/models/README.md#listclusterprices) - List cluster-default model prices
* [setClusterPrice](docs/sdks/models/README.md#setclusterprice) - Set a cluster-default model price
* [clearClusterPrice](docs/sdks/models/README.md#clearclusterprice) - Clear a cluster-default model price
* [listOrgPrices](docs/sdks/models/README.md#listorgprices) - List an org's price overrides
* [setOrgPrice](docs/sdks/models/README.md#setorgprice) - Set an org price override
* [clearOrgPrice](docs/sdks/models/README.md#clearorgprice) - Clear an org price override
* [listEffectivePrices](docs/sdks/models/README.md#listeffectiveprices) - List effective prices for the caller's models

### [Llm.Prompts](docs/sdks/prompts/README.md)

* [create](docs/sdks/prompts/README.md#create) - Create a prompt
* [list](docs/sdks/prompts/README.md#list) - List prompts
* [get](docs/sdks/prompts/README.md#get) - Get a prompt
* [update](docs/sdks/prompts/README.md#update) - Update a prompt
* [delete](docs/sdks/prompts/README.md#delete) - Delete a prompt
* [createVersion](docs/sdks/prompts/README.md#createversion) - Create a new version
* [listVersions](docs/sdks/prompts/README.md#listversions) - List versions
* [getVersion](docs/sdks/prompts/README.md#getversion) - Get a specific version
* [rollback](docs/sdks/prompts/README.md#rollback) - Rollback to a version

### [Llm.Responses](docs/sdks/responses/README.md)

* [create](docs/sdks/responses/README.md#create) - Create an agent-powered response with tool support
* [list](docs/sdks/responses/README.md#list) - List all responses with pagination
* [get](docs/sdks/responses/README.md#get) - Retrieve response by ID with status and results
* [update](docs/sdks/responses/README.md#update) - Update a response
* [delete](docs/sdks/responses/README.md#delete) - Permanently delete a response and its data
* [cancel](docs/sdks/responses/README.md#cancel) - Cancel an in-progress background response
* [wake](docs/sdks/responses/README.md#wake) - Wake a sleeping background response
* [listInputItems](docs/sdks/responses/README.md#listinputitems) - List paginated input items for a response
* [compact](docs/sdks/responses/README.md#compact) - Compact a conversation

### [Llm.Skills](docs/sdks/skills/README.md)

* [create](docs/sdks/skills/README.md#create) - Create skill
* [list](docs/sdks/skills/README.md#list) - List skills
* [get](docs/sdks/skills/README.md#get) - Retrieve skill
* [update](docs/sdks/skills/README.md#update) - Update skill
* [delete](docs/sdks/skills/README.md#delete) - Delete skill
* [content](docs/sdks/skills/README.md#content) - Download skill content
* [createVersion](docs/sdks/skills/README.md#createversion) - Create skill version
* [listVersions](docs/sdks/skills/README.md#listversions) - List skill versions
* [getVersion](docs/sdks/skills/README.md#getversion) - Retrieve skill version
* [deleteVersion](docs/sdks/skills/README.md#deleteversion) - Delete skill version
* [versionContent](docs/sdks/skills/README.md#versioncontent) - Download skill version content
* [listPreconfigured](docs/sdks/skills/README.md#listpreconfigured) - List preconfigured skills

### [Llm.Speech](docs/sdks/speech/README.md)

* [transcribe](docs/sdks/speech/README.md#transcribe) - Speech to text transcription
* [speak](docs/sdks/speech/README.md#speak) - Text to speech
* [speakStreaming](docs/sdks/speech/README.md#speakstreaming) - Streaming text to speech
* [livekitToken](docs/sdks/speech/README.md#livekittoken) - Generate LiveKit room token
* [listTtsHistory](docs/sdks/speech/README.md#listttshistory) - List text-to-speech history
* [getTtsHistory](docs/sdks/speech/README.md#getttshistory) - Retrieve text-to-speech history item
* [deleteTtsHistory](docs/sdks/speech/README.md#deletettshistory) - Delete text-to-speech history item
* [getTtsHistoryContent](docs/sdks/speech/README.md#getttshistorycontent) - Retrieve text-to-speech audio
* [listTranscriptionHistory](docs/sdks/speech/README.md#listtranscriptionhistory) - List speech-to-text history
* [getTranscriptionHistory](docs/sdks/speech/README.md#gettranscriptionhistory) - Retrieve speech-to-text history item
* [deleteTranscriptionHistory](docs/sdks/speech/README.md#deletetranscriptionhistory) - Delete speech-to-text history item
* [getTranscriptionHistoryContent](docs/sdks/speech/README.md#gettranscriptionhistorycontent) - Retrieve speech-to-text audio

### [Llm.Usage](docs/sdks/sdkusage/README.md)

* [completions](docs/sdks/sdkusage/README.md#completions) - Get completions usage
* [responses](docs/sdks/sdkusage/README.md#responses) - Get responses usage
* [conversations](docs/sdks/sdkusage/README.md#conversations) - Get conversations usage
* [embeddings](docs/sdks/sdkusage/README.md#embeddings) - Get embeddings usage
* [extract](docs/sdks/sdkusage/README.md#extract) - Get extract usage
* [classify](docs/sdks/sdkusage/README.md#classify) - Get classify usage
* [vectorStores](docs/sdks/sdkusage/README.md#vectorstores) - Get vector stores usage
* [files](docs/sdks/sdkusage/README.md#files) - Get files usage
* [costs](docs/sdks/sdkusage/README.md#costs) - Get cost by model

### [Llm.VectorStores](docs/sdks/vectorstores/README.md)

* [create](docs/sdks/vectorstores/README.md#create) - Create a vector store
* [list](docs/sdks/vectorstores/README.md#list) - List vector stores
* [get](docs/sdks/vectorstores/README.md#get) - Retrieve a vector store
* [update](docs/sdks/vectorstores/README.md#update) - Modify a vector store
* [delete](docs/sdks/vectorstores/README.md#delete) - Delete a vector store
* [search](docs/sdks/vectorstores/README.md#search) - Search a vector store
* [createFile](docs/sdks/vectorstores/README.md#createfile) - Add a file to a vector store
* [listFiles](docs/sdks/vectorstores/README.md#listfiles) - List files in a vector store
* [getFile](docs/sdks/vectorstores/README.md#getfile) - Retrieve a vector store file
* [updateFile](docs/sdks/vectorstores/README.md#updatefile) - Update file attributes
* [deleteFile](docs/sdks/vectorstores/README.md#deletefile) - Remove file from vector store
* [getFileContent](docs/sdks/vectorstores/README.md#getfilecontent) - Retrieve parsed file content
* [createFileBatch](docs/sdks/vectorstores/README.md#createfilebatch) - Batch add multiple files to vector store
* [getFileBatch](docs/sdks/vectorstores/README.md#getfilebatch) - Retrieve file batch status
* [cancelFileBatch](docs/sdks/vectorstores/README.md#cancelfilebatch) - Cancel batch file processing
* [listFilesInBatch](docs/sdks/vectorstores/README.md#listfilesinbatch) - List files in a batch

### [Permissions.Llm](docs/sdks/sdkllm/README.md)

* [grant](docs/sdks/sdkllm/README.md#grant) - Grant permission to a user or make public
* [revoke](docs/sdks/sdkllm/README.md#revoke) - Revoke permission from a user or remove public access
* [check](docs/sdks/sdkllm/README.md#check) - Check user permission

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
* [getPricing](docs/sdks/sandbox/README.md#getpricing) - Get Sandbox Pricing
* [setPricing](docs/sdks/sandbox/README.md#setpricing) - Set Sandbox Pricing
* [getBrowserUrl](docs/sdks/sandbox/README.md#getbrowserurl) - Get Browser Session URL
* [~~getUrl~~](docs/sdks/sandbox/README.md#geturl) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [getBrowserUrl](docs/sdks/sandbox/README.md#getbrowserurl) instead.
* [proxyBrowserPortRequest](docs/sdks/sandbox/README.md#proxybrowserportrequest) - Proxy Browser Port Request
* [runCommand](docs/sdks/sandbox/README.md#runcommand) - Run Command
* [runCode](docs/sdks/sandbox/README.md#runcode) - Run Code
* [terminate](docs/sdks/sandbox/README.md#terminate) - Terminate Session
* [getWorkspace](docs/sdks/sandbox/README.md#getworkspace) - Get Workspace Manifest
* [downloadFile](docs/sdks/sandbox/README.md#downloadfile) - Download Workspace File
* [uploadFile](docs/sdks/sandbox/README.md#uploadfile) - Upload Workspace File
* [downloadArchive](docs/sdks/sandbox/README.md#downloadarchive) - Download Workspace Archive
* [uploadArchive](docs/sdks/sandbox/README.md#uploadarchive) - Upload Workspace Archive

#### [Sandbox.Environments](docs/sdks/environments/README.md)

* [list](docs/sdks/environments/README.md#list) - List Environments
* [create](docs/sdks/environments/README.md#create) - Create Environment
* [get](docs/sdks/environments/README.md#get) - Get Environment
* [update](docs/sdks/environments/README.md#update) - Update Environment
* [delete](docs/sdks/environments/README.md#delete) - Delete Environment
* [runSetup](docs/sdks/environments/README.md#runsetup) - Run Environment Setup

#### [Sandbox.Github](docs/sdks/github/README.md)

* [createAuthorizationIntent](docs/sdks/github/README.md#createauthorizationintent) - Start GitHub Authorization
* [connect](docs/sdks/github/README.md#connect) - Connect GitHub Account
* [getConnection](docs/sdks/github/README.md#getconnection) - Get GitHub Connection
* [disconnect](docs/sdks/github/README.md#disconnect) - Disconnect GitHub Account
* [listRepositories](docs/sdks/github/README.md#listrepositories) - List GitHub Repositories
* [refreshRepositories](docs/sdks/github/README.md#refreshrepositories) - Refresh GitHub Repositories
* [resolveReference](docs/sdks/github/README.md#resolvereference) - Resolve GitHub Reference
* [cloneRepository](docs/sdks/github/README.md#clonerepository) - Clone GitHub Repository into Session
* [listSessionRepositories](docs/sdks/github/README.md#listsessionrepositories) - List Session Repositories
* [addSessionRepository](docs/sdks/github/README.md#addsessionrepository) - Add Session Repository
* [dismissSessionRepository](docs/sdks/github/README.md#dismisssessionrepository) - Dismiss Failed Session Repository
* [push](docs/sdks/github/README.md#push) - Push Session to GitHub
* [createOrUpdatePullRequest](docs/sdks/github/README.md#createorupdatepullrequest) - Create or Update Pull Request

### [Session](docs/sdks/session/README.md)

* [getPendingInvitation](docs/sdks/session/README.md#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
* [exchangeSessionToken](docs/sdks/session/README.md#exchangesessiontoken) - Exchange a live session for a delegated access token

### [Tracking.Experiments](docs/sdks/experiments/README.md)

* [create](docs/sdks/experiments/README.md#create) - Create
* [search](docs/sdks/experiments/README.md#search) - Search
* [get](docs/sdks/experiments/README.md#get) - Get
* [getByName](docs/sdks/experiments/README.md#getbyname) - GetByName
* [delete](docs/sdks/experiments/README.md#delete) - Delete

### [Tracking.Runs](docs/sdks/runs/README.md)

* [create](docs/sdks/runs/README.md#create) - Create
* [get](docs/sdks/runs/README.md#get) - Get
* [search](docs/sdks/runs/README.md#search) - Search
* [update](docs/sdks/runs/README.md#update) - Update
* [delete](docs/sdks/runs/README.md#delete) - Delete
* [restore](docs/sdks/runs/README.md#restore) - Restore
* [logMetric](docs/sdks/runs/README.md#logmetric) - LogMetric
* [logParameter](docs/sdks/runs/README.md#logparameter) - LogParameter
* [setTag](docs/sdks/runs/README.md#settag) - SetTag
* [deleteTag](docs/sdks/runs/README.md#deletetag) - DeleteTag
* [logBatch](docs/sdks/runs/README.md#logbatch) - LogBatch
* [logInputs](docs/sdks/runs/README.md#loginputs) - LogInputs
* [getMetricHistory](docs/sdks/runs/README.md#getmetrichistory) - GetMetricHistory

### [Usage](docs/sdks/usage/README.md)

* [sandbox](docs/sdks/usage/README.md#sandbox) - Get Sandbox Usage
* [costs](docs/sdks/usage/README.md#costs) - Aggregate cost by dimension

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Standalone functions [standalone-funcs] -->
## Standalone functions

All the methods listed above are available as standalone functions. These
functions are ideal for use in applications running in the browser, serverless
runtimes or other environments where application bundle size is a primary
concern. When using a bundler to build your application, all unused
functionality will be either excluded from the final bundle or tree-shaken away.

To read more about standalone functions, check [FUNCTIONS.md](./FUNCTIONS.md).

<details>

<summary>Available standalone functions</summary>

- [`agentConnectorsActivateAgentConnector`](docs/sdks/agentconnectors/README.md#activateagentconnector) - Activate a connector
- [`agentConnectorsCreateAgentConnector`](docs/sdks/agentconnectors/README.md#createagentconnector) - Create a connector
- [`agentConnectorsDeleteAgentConnector`](docs/sdks/agentconnectors/README.md#deleteagentconnector) - Delete a connector
- [`agentConnectorsGetAgentConnector`](docs/sdks/agentconnectors/README.md#getagentconnector) - Retrieve a connector
- [`agentConnectorsListAgentConnectors`](docs/sdks/agentconnectors/README.md#listagentconnectors) - List connectors for an agent
- [`agentConnectorsSetupWhatsAppAppWebhook`](docs/sdks/agentconnectors/README.md#setupwhatsappappwebhook) - Set up a WhatsApp app webhook (Beta)
- [`agentRunsCreateAgentRun`](docs/sdks/agentruns/README.md#createagentrun) - Start a saved agent run
- [`agentRunsDecideAgentRunMcpApproval`](docs/sdks/agentruns/README.md#decideagentrunmcpapproval) - Approve or deny a pending MCP tool call
- [`agentRunsGetAgentRun`](docs/sdks/agentruns/README.md#getagentrun) - Retrieve an agent run
- [`agentRunsListAgentRuns`](docs/sdks/agentruns/README.md#listagentruns) - List runs for an agent
- [`agentRunsStreamAgentRunEvents`](docs/sdks/agentruns/README.md#streamagentrunevents) - Stream agent run events
- [`agentRunsWakeAgentRun`](docs/sdks/agentruns/README.md#wakeagentrun) - Wake a sleeping agent run
- [`agentSchedulesCreateAgentSchedule`](docs/sdks/agentschedules/README.md#createagentschedule) - Create an agent schedule
- [`agentSchedulesDeleteAgentSchedule`](docs/sdks/agentschedules/README.md#deleteagentschedule) - Delete an agent schedule
- [`agentSchedulesGetAgentSchedule`](docs/sdks/agentschedules/README.md#getagentschedule) - Retrieve an agent schedule
- [`agentSchedulesListAgentSchedules`](docs/sdks/agentschedules/README.md#listagentschedules) - List schedules for an agent
- [`agentSchedulesPauseAgentSchedule`](docs/sdks/agentschedules/README.md#pauseagentschedule) - Pause an agent schedule
- [`agentSchedulesResumeAgentSchedule`](docs/sdks/agentschedules/README.md#resumeagentschedule) - Resume an agent schedule
- [`agentSchedulesUpdateAgentSchedule`](docs/sdks/agentschedules/README.md#updateagentschedule) - Update an agent schedule
- [`agentsCreateAgent`](docs/sdks/agents/README.md#createagent) - Create an agent
- [`agentsDeleteAgent`](docs/sdks/agents/README.md#deleteagent) - Delete an agent
- [`agentsGetAgent`](docs/sdks/agents/README.md#getagent) - Retrieve an agent
- [`agentsListAgents`](docs/sdks/agents/README.md#listagents) - List agents
- [`agentsUpdateAgent`](docs/sdks/agents/README.md#updateagent) - Update an agent
- [`agentVersionsGetAgentVersion`](docs/sdks/agentversions/README.md#getagentversion) - Retrieve an agent version
- [`agentVersionsListAgentVersions`](docs/sdks/agentversions/README.md#listagentversions) - List agent versions
- [`agentVersionsRollbackAgentVersion`](docs/sdks/agentversions/README.md#rollbackagentversion) - Roll back an agent to a version
- [`analyticsCapture`](docs/sdks/analytics/README.md#capture) - Durably accept a batch of events
- [`analyticsEventsSearch`](docs/sdks/events/README.md#search) - Search events in a time range
- [`analyticsKeysCreate`](docs/sdks/keys/README.md#create) - Create a capture key and return its secret once
- [`analyticsKeysList`](docs/sdks/keys/README.md#list) - List capture key metadata
- [`analyticsKeysRevoke`](docs/sdks/keys/README.md#revoke) - Revoke a capture key
- [`analyticsProjectsArchive`](docs/sdks/projects/README.md#archive) - Archive an analytics project
- [`analyticsProjectsCreate`](docs/sdks/projects/README.md#create) - Create an analytics project
- [`analyticsProjectsGet`](docs/sdks/projects/README.md#get) - Get an analytics project
- [`analyticsProjectsList`](docs/sdks/projects/README.md#list) - List accessible analytics projects
- [`analyticsProjectsUpdate`](docs/sdks/projects/README.md#update) - Rename an active analytics project
- [`analyticsQuery`](docs/sdks/analytics/README.md#query) - Query event counts or unique visitors
- [`analyticsVisitorsSearch`](docs/sdks/visitors/README.md#search) - Search visitors in a time range
- [`authApiKeysCreate`](docs/sdks/apikeys/README.md#create) - Mint a scoped API key
- [`authApiKeysExchangeToken`](docs/sdks/apikeys/README.md#exchangetoken) - Exchange API key for a JWT token
- [`authApiKeysList`](docs/sdks/apikeys/README.md#list) - List scoped API keys
- [`authApiKeysRegenerate`](docs/sdks/apikeys/README.md#regenerate) - Rotate a scoped API key's secret
- [`authApiKeysUpdate`](docs/sdks/apikeys/README.md#update) - Update a scoped API key
- [`authClusterAcceptInvite`](docs/sdks/cluster/README.md#acceptinvite) - Accept a cluster invitation (public)
- [`authClusterCreateInvite`](docs/sdks/cluster/README.md#createinvite) - Create a cluster invitation
- [`authClusterDeleteOrg`](docs/sdks/cluster/README.md#deleteorg) - Soft-delete an organization
- [`authClusterGetOrg`](docs/sdks/cluster/README.md#getorg) - Get an organization
- [`authClusterInviteInfo`](docs/sdks/cluster/README.md#inviteinfo) - Read cluster-invite info (public)
- [`authClusterInviteOrgMembers`](docs/sdks/cluster/README.md#inviteorgmembers) - Invite members on behalf of an organization
- [`authClusterListInvites`](docs/sdks/cluster/README.md#listinvites) - List cluster invitations
- [`authClusterListOrgs`](docs/sdks/cluster/README.md#listorgs) - List all organizations
- [`authClusterReissueOwnerKey`](docs/sdks/cluster/README.md#reissueownerkey) - Re-issue an org owner key (recovery)
- [`authClusterRevokeInvite`](docs/sdks/cluster/README.md#revokeinvite) - Revoke a cluster invitation
- [`authClusterSuspendOrg`](docs/sdks/cluster/README.md#suspendorg) - Suspend an organization
- [`authClusterUnsuspendOrg`](docs/sdks/cluster/README.md#unsuspendorg) - Unsuspend an organization
- [`authClusterUpdateInvite`](docs/sdks/cluster/README.md#updateinvite) - Update a pending cluster invitation
- [`authOrgsGetById`](docs/sdks/orgs/README.md#getbyid) - Get basic organization details
- [`authOrgsGetQuota`](docs/sdks/orgs/README.md#getquota) - Get an org's usage quota
- [`authOrgsGetRateLimit`](docs/sdks/orgs/README.md#getratelimit) - Get an org's rate limit
- [`authOrgsUpdate`](docs/sdks/orgs/README.md#update) - Patch organization metadata (cluster-admin)
- [`authOrgsUpdateQuota`](docs/sdks/orgs/README.md#updatequota) - Set an org's usage quota (cluster-admin)
- [`authOrgsUpdateRateLimit`](docs/sdks/orgs/README.md#updateratelimit) - Set an org's rate limit (cluster-admin)
- [`authServiceAccountsCreate`](docs/sdks/serviceaccounts/README.md#create) - Create a service account
- [`authServiceAccountsDelete`](docs/sdks/serviceaccounts/README.md#delete) - Delete a service account
- [`authServiceAccountsDeleteApiKey`](docs/sdks/serviceaccounts/README.md#deleteapikey) - Delete a service-account API key
- [`authServiceAccountsGet`](docs/sdks/serviceaccounts/README.md#get) - Get a service account
- [`authServiceAccountsList`](docs/sdks/serviceaccounts/README.md#list) - List service accounts
- [`authServiceAccountsListApiKeys`](docs/sdks/serviceaccounts/README.md#listapikeys) - List a service account's API keys
- [`authServiceAccountsRegenerateApiKey`](docs/sdks/serviceaccounts/README.md#regenerateapikey) - Rotate a service-account API key's secret
- [`authServiceAccountsUpdateApiKey`](docs/sdks/serviceaccounts/README.md#updateapikey) - Update a service-account API key
- [`authTeamsAddMember`](docs/sdks/teams/README.md#addmember) - Add a team member
- [`authTeamsCreate`](docs/sdks/teams/README.md#create) - Create a team
- [`authTeamsDelete`](docs/sdks/teams/README.md#delete) - Delete a team
- [`authTeamsGet`](docs/sdks/teams/README.md#get) - Get a team
- [`authTeamsList`](docs/sdks/teams/README.md#list) - List teams in an org
- [`authTeamsListMembers`](docs/sdks/teams/README.md#listmembers) - List team members
- [`authTeamsRemoveMember`](docs/sdks/teams/README.md#removemember) - Remove a team member
- [`authTeamsUpdate`](docs/sdks/teams/README.md#update) - Rename a team
- [`billingCreateOrganizationBillingPortal`](docs/sdks/billing/README.md#createorganizationbillingportal)
- [`billingCreateOrganizationBillingSetup`](docs/sdks/billing/README.md#createorganizationbillingsetup)
- [`billingGetOrganizationBilling`](docs/sdks/billing/README.md#getorganizationbilling)
- [`billingListOrganizationBillingInvoices`](docs/sdks/billing/README.md#listorganizationbillinginvoices)
- [`billingSetOrganizationBillingEnabled`](docs/sdks/billing/README.md#setorganizationbillingenabled)
- [`billingUpdateOrganizationBillingProfile`](docs/sdks/billing/README.md#updateorganizationbillingprofile)
- [`budgetsApiKeyEvents`](docs/sdks/budgets/README.md#apikeyevents) - List apikey budget events
- [`budgetsDeleteApiKey`](docs/sdks/budgets/README.md#deleteapikey) - Delete an apikey budget
- [`budgetsDeleteExternalUser`](docs/sdks/budgets/README.md#deleteexternaluser) - Delete a external user budget
- [`budgetsDeleteExternalUserDefault`](docs/sdks/budgets/README.md#deleteexternaluserdefault) - Delete a per-external user default budget
- [`budgetsDeleteOrg`](docs/sdks/budgets/README.md#deleteorg) - Delete an org budget
- [`budgetsDeleteTeam`](docs/sdks/budgets/README.md#deleteteam) - Delete a team budget
- [`budgetsDeleteTeamDefault`](docs/sdks/budgets/README.md#deleteteamdefault) - Delete a per-team default budget
- [`budgetsDeleteUser`](docs/sdks/budgets/README.md#deleteuser) - Delete a user budget
- [`budgetsDeleteUserDefault`](docs/sdks/budgets/README.md#deleteuserdefault) - Delete a per-user default budget
- [`budgetsExternalUserDefaultEvents`](docs/sdks/budgets/README.md#externaluserdefaultevents) - List per-external user default budget events
- [`budgetsExternalUserEvents`](docs/sdks/budgets/README.md#externaluserevents) - List external user budget events
- [`budgetsGetApiKey`](docs/sdks/budgets/README.md#getapikey) - List apikey budgets
- [`budgetsGetCurrency`](docs/sdks/budgets/README.md#getcurrency) - Get display currency
- [`budgetsGetExternalUser`](docs/sdks/budgets/README.md#getexternaluser) - List external user budgets
- [`budgetsGetExternalUserDefault`](docs/sdks/budgets/README.md#getexternaluserdefault) - List per-external user default budgets
- [`budgetsGetOrg`](docs/sdks/budgets/README.md#getorg) - List org budgets
- [`budgetsGetTeam`](docs/sdks/budgets/README.md#getteam) - List team budgets
- [`budgetsGetTeamDefault`](docs/sdks/budgets/README.md#getteamdefault) - List per-team default budgets
- [`budgetsGetUser`](docs/sdks/budgets/README.md#getuser) - List user budgets
- [`budgetsGetUserDefault`](docs/sdks/budgets/README.md#getuserdefault) - List per-user default budgets
- [`budgetsList`](docs/sdks/budgets/README.md#list) - List budgets
- [`budgetsOrgEvents`](docs/sdks/budgets/README.md#orgevents) - List org budget events
- [`budgetsSetApiKey`](docs/sdks/budgets/README.md#setapikey) - Set an apikey budget
- [`budgetsSetCurrency`](docs/sdks/budgets/README.md#setcurrency) - Set display currency
- [`budgetsSetExternalUser`](docs/sdks/budgets/README.md#setexternaluser) - Set a external user budget
- [`budgetsSetExternalUserDefault`](docs/sdks/budgets/README.md#setexternaluserdefault) - Set a per-external user default budget
- [`budgetsSetOrg`](docs/sdks/budgets/README.md#setorg) - Set an org budget
- [`budgetsSetTeam`](docs/sdks/budgets/README.md#setteam) - Set a team budget
- [`budgetsSetTeamDefault`](docs/sdks/budgets/README.md#setteamdefault) - Set a per-team default budget
- [`budgetsSetUser`](docs/sdks/budgets/README.md#setuser) - Set a user budget
- [`budgetsSetUserDefault`](docs/sdks/budgets/README.md#setuserdefault) - Set a per-user default budget
- [`budgetsTeamDefaultEvents`](docs/sdks/budgets/README.md#teamdefaultevents) - List per-team default budget events
- [`budgetsTeamEvents`](docs/sdks/budgets/README.md#teamevents) - List team budget events
- [`budgetsUserDefaultEvents`](docs/sdks/budgets/README.md#userdefaultevents) - List per-user default budget events
- [`budgetsUserEvents`](docs/sdks/budgets/README.md#userevents) - List user budget events
- [`computeCatalogCreateComputeQuote`](docs/sdks/computecatalog/README.md#createcomputequote) - Create a quote
- [`computeCatalogGetAccelerator`](docs/sdks/computecatalog/README.md#getaccelerator) - Get an accelerator
- [`computeCatalogListAccelerators`](docs/sdks/computecatalog/README.md#listaccelerators) - List accelerators
- [`computeCatalogListComputeOffers`](docs/sdks/computecatalog/README.md#listcomputeoffers) - List provider offers
- [`computeCatalogListComputeProviders`](docs/sdks/computecatalog/README.md#listcomputeproviders) - List provider health
- [`computeJobsCreateJob`](docs/sdks/computejobs/README.md#createjob) - Create a job
- [`computeJobsGetJob`](docs/sdks/computejobs/README.md#getjob) - Get a job
- [`computeJobsListJobEvents`](docs/sdks/computejobs/README.md#listjobevents) - List job events
- [`computeJobsListJobInstances`](docs/sdks/computejobs/README.md#listjobinstances) - List observed job instances
- [`computeJobsListJobLogs`](docs/sdks/computejobs/README.md#listjoblogs) - List job logs
- [`computeJobsListJobs`](docs/sdks/computejobs/README.md#listjobs) - List jobs
- [`computeJobsTerminateJob`](docs/sdks/computejobs/README.md#terminatejob) - Terminate a job
- [`computePricingGetPricing`](docs/sdks/computepricing/README.md#getpricing) - Get the latest committed storage price
- [`computePricingPutPricing`](docs/sdks/computepricing/README.md#putpricing) - Create an immutable storage-price version
- [`computeSecretsCreateComputeSecret`](docs/sdks/computesecrets/README.md#createcomputesecret) - Create a secret
- [`computeSecretsDeleteComputeSecret`](docs/sdks/computesecrets/README.md#deletecomputesecret) - Delete a secret
- [`computeSecretsGetComputeSecret`](docs/sdks/computesecrets/README.md#getcomputesecret) - Get a secret
- [`computeSecretsListComputeSecrets`](docs/sdks/computesecrets/README.md#listcomputesecrets) - List secrets
- [`computeServicesCreateService`](docs/sdks/computeservices/README.md#createservice) - Create a service
- [`computeServicesGetService`](docs/sdks/computeservices/README.md#getservice) - Get a service
- [`computeServicesListServiceEvents`](docs/sdks/computeservices/README.md#listserviceevents) - List service events
- [`computeServicesListServiceInstances`](docs/sdks/computeservices/README.md#listserviceinstances) - List observed service instances
- [`computeServicesListServiceLogs`](docs/sdks/computeservices/README.md#listservicelogs) - List service logs
- [`computeServicesListServices`](docs/sdks/computeservices/README.md#listservices) - List services
- [`computeServicesTerminateService`](docs/sdks/computeservices/README.md#terminateservice) - Terminate a service
- [`computeServicesUpdateServiceScaling`](docs/sdks/computeservices/README.md#updateservicescaling) - Replace a service scaling policy
- [`computeTenantsGetComputeTenant`](docs/sdks/computetenants/README.md#getcomputetenant) - Get a tenant
- [`computeTenantsListComputeTenants`](docs/sdks/computetenants/README.md#listcomputetenants) - List tenants
- [`computeTenantsPutComputeTenant`](docs/sdks/computetenants/README.md#putcomputetenant) - Update a tenant
- [`computeUsageGetComputeUsage`](docs/sdks/computeusage/README.md#getcomputeusage) - Get usage
- [`computeVolumesCreateStandaloneVolume`](docs/sdks/computevolumes/README.md#createstandalonevolume) - Create a standalone shared volume
- [`computeVolumesDeleteStandaloneVolume`](docs/sdks/computevolumes/README.md#deletestandalonevolume) - Permanently delete a standalone volume
- [`computeVolumesGetStandaloneVolume`](docs/sdks/computevolumes/README.md#getstandalonevolume) - Get a standalone volume
- [`computeVolumesListStandaloneVolumeAttachments`](docs/sdks/computevolumes/README.md#liststandalonevolumeattachments) - List volume attachments
- [`computeVolumesListStandaloneVolumes`](docs/sdks/computevolumes/README.md#liststandalonevolumes) - List organization volumes
- [`datasetsCancelGeneration`](docs/sdks/datasets/README.md#cancelgeneration) - Cancel Generation
- [`datasetsCreateGeneration`](docs/sdks/datasets/README.md#creategeneration) - Create Generation
- [`datasetsGetFormat`](docs/sdks/datasets/README.md#getformat) - Get Format
- [`datasetsGetGeneration`](docs/sdks/datasets/README.md#getgeneration) - Get Generation
- [`datasetsGetGenerationEvents`](docs/sdks/datasets/README.md#getgenerationevents) - Get Events
- [`datasetsGetGenerationLogs`](docs/sdks/datasets/README.md#getgenerationlogs) - Get Logs
- [`datasetsGetGenerator`](docs/sdks/datasets/README.md#getgenerator) - Get Generator
- [`datasetsListFormats`](docs/sdks/datasets/README.md#listformats) - List Formats
- [`datasetsListGenerations`](docs/sdks/datasets/README.md#listgenerations) - List Generations
- [`datasetsListGenerators`](docs/sdks/datasets/README.md#listgenerators) - List Generators
- [`datasetsQuoteGenerator`](docs/sdks/datasets/README.md#quotegenerator) - Quote Generator
- [`flagsArchive`](docs/sdks/flags/README.md#archive) - Archive a flag
- [`flagsAuditList`](docs/sdks/audit/README.md#list) - List audit entries, newest first
- [`flagsCreate`](docs/sdks/flags/README.md#create) - Create a flag
- [`flagsDelete`](docs/sdks/flags/README.md#delete) - Delete a flag and its settings in every environment
- [`flagsEnvironmentsCreate`](docs/sdks/sdkenvironments/README.md#create) - Create an environment
- [`flagsEnvironmentsDelete`](docs/sdks/sdkenvironments/README.md#delete) - Delete an environment and every flag setting in it
- [`flagsEnvironmentsEvaluate`](docs/sdks/sdkenvironments/README.md#evaluate) - Evaluate every flag for an identity
- [`flagsEnvironmentsEvaluateWithTraits`](docs/sdks/sdkenvironments/README.md#evaluatewithtraits) - Evaluate every flag for an identity with traits
- [`flagsEnvironmentsGenerateEvaluationKey`](docs/sdks/sdkenvironments/README.md#generateevaluationkey) - Generate or replace an environment evaluation key
- [`flagsEnvironmentsList`](docs/sdks/sdkenvironments/README.md#list) - List environments
- [`flagsEnvironmentsRevokeEvaluationKey`](docs/sdks/sdkenvironments/README.md#revokeevaluationkey) - Revoke an environment evaluation key
- [`flagsEnvironmentsUpdate`](docs/sdks/sdkenvironments/README.md#update) - Rename an environment
- [`flagsGet`](docs/sdks/flags/README.md#get) - Get a flag
- [`flagsList`](docs/sdks/flags/README.md#list) - List flags
- [`flagsProjectsCreate`](docs/sdks/sdkprojects/README.md#create) - Create a project
- [`flagsProjectsDelete`](docs/sdks/sdkprojects/README.md#delete) - Delete an empty project
- [`flagsProjectsGet`](docs/sdks/sdkprojects/README.md#get) - Get a project
- [`flagsProjectsList`](docs/sdks/sdkprojects/README.md#list) - List projects
- [`flagsProjectsUpdate`](docs/sdks/sdkprojects/README.md#update) - Rename a project
- [`flagsSetEnvironmentState`](docs/sdks/flags/README.md#setenvironmentstate) - Replace a flag's settings in one environment
- [`flagsUnarchive`](docs/sdks/flags/README.md#unarchive) - Restore an archived flag
- [`flagsUpdate`](docs/sdks/flags/README.md#update) - Update a flag's name, description, default value, or project
- [`guardrailsDeleteGuardrails`](docs/sdks/guardrails/README.md#deleteguardrails) - Delete guardrails policy
- [`guardrailsGetGuardrails`](docs/sdks/guardrails/README.md#getguardrails) - Get effective guardrails
- [`guardrailsListGuardrailsPolicies`](docs/sdks/guardrails/README.md#listguardrailspolicies) - List guardrails policies
- [`guardrailsTestGuardrails`](docs/sdks/guardrails/README.md#testguardrails) - Test content against guardrails
- [`guardrailsUpdateGuardrails`](docs/sdks/guardrails/README.md#updateguardrails) - Update guardrails policy
- [`llmBatchesCancel`](docs/sdks/batches/README.md#cancel) - Cancel a batch
- [`llmBatchesCreate`](docs/sdks/batches/README.md#create) - Create a batch
- [`llmBatchesGet`](docs/sdks/batches/README.md#get) - Get a batch
- [`llmBatchesList`](docs/sdks/batches/README.md#list) - List batches
- [`llmClassifyClassify`](docs/sdks/classify/README.md#classify) - Classify text into predefined categories
- [`llmConversationsCreate`](docs/sdks/conversations/README.md#create) - Create a conversation
- [`llmConversationsCreateItems`](docs/sdks/conversations/README.md#createitems) - Create conversation items
- [`llmConversationsDelete`](docs/sdks/conversations/README.md#delete) - Delete a conversation
- [`llmConversationsDeleteItem`](docs/sdks/conversations/README.md#deleteitem) - Delete a conversation item
- [`llmConversationsDeleteItems`](docs/sdks/conversations/README.md#deleteitems) - Delete multiple conversation items
- [`llmConversationsGet`](docs/sdks/conversations/README.md#get) - Retrieve a conversation
- [`llmConversationsGetItem`](docs/sdks/conversations/README.md#getitem) - Retrieve a conversation item
- [`llmConversationsList`](docs/sdks/conversations/README.md#list) - List conversations
- [`llmConversationsListItems`](docs/sdks/conversations/README.md#listitems) - List conversation items
- [`llmConversationsUpdate`](docs/sdks/conversations/README.md#update) - Update a conversation
- [`llmEmbeddingsEmbed`](docs/sdks/embeddings/README.md#embed) - Create text embeddings
- [`llmEmbeddingsListModels`](docs/sdks/embeddings/README.md#listmodels) - List available embedding models
- [`llmEvalsAppendAgentTrials`](docs/sdks/evals/README.md#appendagenttrials) - Append trials to an open coding-agent run
- [`llmEvalsCancelRun`](docs/sdks/evals/README.md#cancelrun) - Cancel an eval run
- [`llmEvalsCreateRun`](docs/sdks/evals/README.md#createrun) - Create an eval run
- [`llmEvalsCreateSchedule`](docs/sdks/evals/README.md#createschedule) - Create an eval schedule
- [`llmEvalsCreateSuite`](docs/sdks/evals/README.md#createsuite) - Create an eval suite
- [`llmEvalsCreateSuiteVersion`](docs/sdks/evals/README.md#createsuiteversion) - Create an eval suite version
- [`llmEvalsDeleteRun`](docs/sdks/evals/README.md#deleterun) - Delete an eval run
- [`llmEvalsDeleteSchedule`](docs/sdks/evals/README.md#deleteschedule) - Delete an eval schedule
- [`llmEvalsDeleteSuite`](docs/sdks/evals/README.md#deletesuite) - Delete an eval suite
- [`llmEvalsGetArtifacts`](docs/sdks/evals/README.md#getartifacts) - Get eval run artifacts
- [`llmEvalsGetRun`](docs/sdks/evals/README.md#getrun) - Get an eval run
- [`llmEvalsGetRunOverview`](docs/sdks/evals/README.md#getrunoverview) - Get an eval run overview
- [`llmEvalsGetSampleAudio`](docs/sdks/evals/README.md#getsampleaudio) - Get eval sample audio
- [`llmEvalsGetSampleTrajectory`](docs/sdks/evals/README.md#getsampletrajectory) - Get an eval sample trajectory
- [`llmEvalsGetSchedule`](docs/sdks/evals/README.md#getschedule) - Get an eval schedule
- [`llmEvalsGetSuite`](docs/sdks/evals/README.md#getsuite) - Get an eval suite
- [`llmEvalsGetSuiteLeaderboard`](docs/sdks/evals/README.md#getsuiteleaderboard) - Get the coding-agent leaderboard for an eval suite
- [`llmEvalsGetSuiteVersion`](docs/sdks/evals/README.md#getsuiteversion) - Get an eval suite version
- [`llmEvalsImportAgentRun`](docs/sdks/evals/README.md#importagentrun) - Import a finished coding-agent run
- [`llmEvalsImportHistoricalResults`](docs/sdks/evals/README.md#importhistoricalresults) - Import historical eval results from Hugging Face
- [`llmEvalsListRuns`](docs/sdks/evals/README.md#listruns) - List eval runs
- [`llmEvalsListSamples`](docs/sdks/evals/README.md#listsamples) - List eval samples
- [`llmEvalsListScheduleRuns`](docs/sdks/evals/README.md#listscheduleruns) - List runs created by an eval schedule
- [`llmEvalsListSchedules`](docs/sdks/evals/README.md#listschedules) - List eval schedules
- [`llmEvalsListSuiteLeaderboardRuns`](docs/sdks/evals/README.md#listsuiteleaderboardruns) - List leaderboard runs for an eval suite
- [`llmEvalsListSuites`](docs/sdks/evals/README.md#listsuites) - List eval suites
- [`llmEvalsListSuiteVersions`](docs/sdks/evals/README.md#listsuiteversions) - List eval suite versions
- [`llmEvalsMeasureSuiteTokens`](docs/sdks/evals/README.md#measuresuitetokens) - Count tokens from stored text for a suite's unmeasured samples
- [`llmEvalsRerunFailedSamples`](docs/sdks/evals/README.md#rerunfailedsamples) - Rerun failed eval samples
- [`llmEvalsRetryFailedRun`](docs/sdks/evals/README.md#retryfailedrun) - Retry an eval run
- [`llmEvalsTriggerSchedule`](docs/sdks/evals/README.md#triggerschedule) - Trigger an eval schedule now
- [`llmEvalsUpdateSchedule`](docs/sdks/evals/README.md#updateschedule) - Update an eval schedule
- [`llmEvalsUploadSampleTrajectory`](docs/sdks/evals/README.md#uploadsampletrajectory) - Upload an eval sample trajectory
- [`llmExtractCreateSchema`](docs/sdks/extract/README.md#createschema) - Create reusable extraction schema template
- [`llmExtractDeleteSchema`](docs/sdks/extract/README.md#deleteschema) - Delete extraction schema by ID
- [`llmExtractExtract`](docs/sdks/extract/README.md#extract) - Extract structured data with inline JSON Schema
- [`llmExtractExtractWithSchema`](docs/sdks/extract/README.md#extractwithschema) - Extract data using saved schema template
- [`llmExtractGetSchema`](docs/sdks/extract/README.md#getschema) - Get extraction schema by ID
- [`llmExtractUpdateSchema`](docs/sdks/extract/README.md#updateschema) - Update extraction schema by ID
- [`llmFeedbackBatchGetCompletionFeedback`](docs/sdks/feedback/README.md#batchgetcompletionfeedback) - Batch retrieve feedback for multiple completions
- [`llmFeedbackBatchGetResponseFeedback`](docs/sdks/feedback/README.md#batchgetresponsefeedback) - Batch retrieve feedback for multiple responses
- [`llmFeedbackCreateCompletionFeedback`](docs/sdks/feedback/README.md#createcompletionfeedback) - Submit feedback for chat completion
- [`llmFeedbackCreateResponseFeedback`](docs/sdks/feedback/README.md#createresponsefeedback) - Submit feedback for response
- [`llmFeedbackExportCompletionFeedback`](docs/sdks/feedback/README.md#exportcompletionfeedback) - Export completion feedback as CSV
- [`llmFeedbackExportResponseFeedback`](docs/sdks/feedback/README.md#exportresponsefeedback) - Export response feedback as CSV
- [`llmFeedbackGetCompletionFeedback`](docs/sdks/feedback/README.md#getcompletionfeedback) - Retrieve feedback by completion ID
- [`llmFeedbackGetExportStatus`](docs/sdks/feedback/README.md#getexportstatus) - Get feedback export status
- [`llmFeedbackGetResponseFeedback`](docs/sdks/feedback/README.md#getresponsefeedback) - Retrieve feedback by response ID
- [`llmFeedbackListCompletionFeedback`](docs/sdks/feedback/README.md#listcompletionfeedback) - List chat completion feedback
- [`llmFeedbackListResponseFeedback`](docs/sdks/feedback/README.md#listresponsefeedback) - List response feedback
- [`llmFeedbackStartExport`](docs/sdks/feedback/README.md#startexport) - Start feedback export
- [`llmFeedbackUpdateCompletionFeedback`](docs/sdks/feedback/README.md#updatecompletionfeedback) - Update existing completion feedback
- [`llmFeedbackUpdateResponseFeedback`](docs/sdks/feedback/README.md#updateresponsefeedback) - Update existing response feedback
- [`llmFilesContent`](docs/sdks/files/README.md#content) - Retrieve file content
- [`llmFilesDelete`](docs/sdks/files/README.md#delete) - Delete file
- [`llmFilesGet`](docs/sdks/files/README.md#get) - Retrieve file
- [`llmFilesList`](docs/sdks/files/README.md#list) - List files
- [`llmFilesUpload`](docs/sdks/files/README.md#upload) - Upload file
- [`llmImagesCreate`](docs/sdks/images/README.md#create) - Generate images from text descriptions
- [`llmMcpVaultCreateCredential`](docs/sdks/mcpvault/README.md#createcredential) - Create MCP credential
- [`llmMcpVaultCreateServer`](docs/sdks/mcpvault/README.md#createserver) - Create MCP server
- [`llmMcpVaultDeleteCredential`](docs/sdks/mcpvault/README.md#deletecredential) - Delete MCP credential
- [`llmMcpVaultDeleteServer`](docs/sdks/mcpvault/README.md#deleteserver) - Delete MCP server
- [`llmMcpVaultGetServer`](docs/sdks/mcpvault/README.md#getserver) - Retrieve MCP server
- [`llmMcpVaultListCredentials`](docs/sdks/mcpvault/README.md#listcredentials) - List MCP credentials
- [`llmMcpVaultListServers`](docs/sdks/mcpvault/README.md#listservers) - List MCP servers
- [`llmMcpVaultTestServer`](docs/sdks/mcpvault/README.md#testserver) - Test MCP server
- [`llmMcpVaultUpdateServer`](docs/sdks/mcpvault/README.md#updateserver) - Update MCP server
- [`llmMemoryStoresCreate`](docs/sdks/memorystores/README.md#create) - Create memory store
- [`llmMemoryStoresCreateEntry`](docs/sdks/memorystores/README.md#createentry) - Create memory entry
- [`llmMemoryStoresDelete`](docs/sdks/memorystores/README.md#delete) - Delete memory store
- [`llmMemoryStoresDeleteEntry`](docs/sdks/memorystores/README.md#deleteentry) - Delete memory entry
- [`llmMemoryStoresGet`](docs/sdks/memorystores/README.md#get) - Retrieve memory store
- [`llmMemoryStoresGetEntry`](docs/sdks/memorystores/README.md#getentry) - Retrieve memory entry
- [`llmMemoryStoresList`](docs/sdks/memorystores/README.md#list) - List memory stores
- [`llmMemoryStoresListEntries`](docs/sdks/memorystores/README.md#listentries) - List memory entries
- [`llmMemoryStoresUpdate`](docs/sdks/memorystores/README.md#update) - Update memory store
- [`llmMemoryStoresUpdateEntry`](docs/sdks/memorystores/README.md#updateentry) - Update memory entry
- [`llmModelsActivateRegistryEntry`](docs/sdks/models/README.md#activateregistryentry) - Activate a catalog entry
- [`llmModelsAddCatalogEntry`](docs/sdks/models/README.md#addcatalogentry) - Define a BYO catalog model
- [`llmModelsAddCatalogOrgAccess`](docs/sdks/models/README.md#addcatalogorgaccess) - Add cluster model access for an organization
- [`llmModelsCheckCatalogHealth`](docs/sdks/models/README.md#checkcataloghealth) - Check a BYO catalog model's health
- [`llmModelsClearClusterPrice`](docs/sdks/models/README.md#clearclusterprice) - Clear a cluster-default model price
- [`llmModelsClearOrgPrice`](docs/sdks/models/README.md#clearorgprice) - Clear an org price override
- [`llmModelsDeactivateRegistryEntry`](docs/sdks/models/README.md#deactivateregistryentry) - Deactivate a model registry name
- [`llmModelsDeleteCatalogEntry`](docs/sdks/models/README.md#deletecatalogentry) - Remove a BYO catalog model
- [`llmModelsDeleteOrgAutoModel`](docs/sdks/models/README.md#deleteorgautomodel) - Clear this org's auto-model override for an endpoint
- [`llmModelsGet`](docs/sdks/models/README.md#get) - Retrieve a model
- [`llmModelsGetClusterCurrency`](docs/sdks/models/README.md#getclustercurrency) - Get the cluster currency
- [`llmModelsList`](docs/sdks/models/README.md#list) - List available models
- [`llmModelsListCatalog`](docs/sdks/models/README.md#listcatalog) - List the organization's model catalog
- [`llmModelsListCatalogModelAccess`](docs/sdks/models/README.md#listcatalogmodelaccess) - List organizations with access to a cluster model
- [`llmModelsListCatalogOrgAccess`](docs/sdks/models/README.md#listcatalogorgaccess) - List an organization's cluster model access
- [`llmModelsListClusterPrices`](docs/sdks/models/README.md#listclusterprices) - List cluster-default model prices
- [`llmModelsListEffectivePrices`](docs/sdks/models/README.md#listeffectiveprices) - List effective prices for the caller's models
- [`llmModelsListOrgAutoModels`](docs/sdks/models/README.md#listorgautomodels) - List this org's auto-model overrides
- [`llmModelsListOrgPrices`](docs/sdks/models/README.md#listorgprices) - List an org's price overrides
- [`llmModelsListRegistry`](docs/sdks/models/README.md#listregistry) - List the organization's active model registry
- [`llmModelsPutOrgAutoModel`](docs/sdks/models/README.md#putorgautomodel) - Set this org's auto policy for an endpoint
- [`llmModelsReplaceCatalogOrgAccess`](docs/sdks/models/README.md#replacecatalogorgaccess) - Replace an organization's cluster model access
- [`llmModelsSetClusterCurrency`](docs/sdks/models/README.md#setclustercurrency) - Set the cluster currency
- [`llmModelsSetClusterPrice`](docs/sdks/models/README.md#setclusterprice) - Set a cluster-default model price
- [`llmModelsSetOrgPrice`](docs/sdks/models/README.md#setorgprice) - Set an org price override
- [`llmModelsUpdateCatalogEntry`](docs/sdks/models/README.md#updatecatalogentry) - Update a BYO catalog model
- [`llmPromptsCreate`](docs/sdks/prompts/README.md#create) - Create a prompt
- [`llmPromptsCreateVersion`](docs/sdks/prompts/README.md#createversion) - Create a new version
- [`llmPromptsDelete`](docs/sdks/prompts/README.md#delete) - Delete a prompt
- [`llmPromptsGet`](docs/sdks/prompts/README.md#get) - Get a prompt
- [`llmPromptsGetVersion`](docs/sdks/prompts/README.md#getversion) - Get a specific version
- [`llmPromptsList`](docs/sdks/prompts/README.md#list) - List prompts
- [`llmPromptsListVersions`](docs/sdks/prompts/README.md#listversions) - List versions
- [`llmPromptsRollback`](docs/sdks/prompts/README.md#rollback) - Rollback to a version
- [`llmPromptsUpdate`](docs/sdks/prompts/README.md#update) - Update a prompt
- [`llmResponsesCancel`](docs/sdks/responses/README.md#cancel) - Cancel an in-progress background response
- [`llmResponsesCompact`](docs/sdks/responses/README.md#compact) - Compact a conversation
- [`llmResponsesCreate`](docs/sdks/responses/README.md#create) - Create an agent-powered response with tool support
- [`llmResponsesDelete`](docs/sdks/responses/README.md#delete) - Permanently delete a response and its data
- [`llmResponsesGet`](docs/sdks/responses/README.md#get) - Retrieve response by ID with status and results
- [`llmResponsesList`](docs/sdks/responses/README.md#list) - List all responses with pagination
- [`llmResponsesListInputItems`](docs/sdks/responses/README.md#listinputitems) - List paginated input items for a response
- [`llmResponsesUpdate`](docs/sdks/responses/README.md#update) - Update a response
- [`llmResponsesWake`](docs/sdks/responses/README.md#wake) - Wake a sleeping background response
- [`llmSkillsContent`](docs/sdks/skills/README.md#content) - Download skill content
- [`llmSkillsCreate`](docs/sdks/skills/README.md#create) - Create skill
- [`llmSkillsCreateVersion`](docs/sdks/skills/README.md#createversion) - Create skill version
- [`llmSkillsDelete`](docs/sdks/skills/README.md#delete) - Delete skill
- [`llmSkillsDeleteVersion`](docs/sdks/skills/README.md#deleteversion) - Delete skill version
- [`llmSkillsGet`](docs/sdks/skills/README.md#get) - Retrieve skill
- [`llmSkillsGetVersion`](docs/sdks/skills/README.md#getversion) - Retrieve skill version
- [`llmSkillsList`](docs/sdks/skills/README.md#list) - List skills
- [`llmSkillsListPreconfigured`](docs/sdks/skills/README.md#listpreconfigured) - List preconfigured skills
- [`llmSkillsListVersions`](docs/sdks/skills/README.md#listversions) - List skill versions
- [`llmSkillsUpdate`](docs/sdks/skills/README.md#update) - Update skill
- [`llmSkillsVersionContent`](docs/sdks/skills/README.md#versioncontent) - Download skill version content
- [`llmSpeechDeleteTranscriptionHistory`](docs/sdks/speech/README.md#deletetranscriptionhistory) - Delete speech-to-text history item
- [`llmSpeechDeleteTtsHistory`](docs/sdks/speech/README.md#deletettshistory) - Delete text-to-speech history item
- [`llmSpeechGetTranscriptionHistory`](docs/sdks/speech/README.md#gettranscriptionhistory) - Retrieve speech-to-text history item
- [`llmSpeechGetTranscriptionHistoryContent`](docs/sdks/speech/README.md#gettranscriptionhistorycontent) - Retrieve speech-to-text audio
- [`llmSpeechGetTtsHistory`](docs/sdks/speech/README.md#getttshistory) - Retrieve text-to-speech history item
- [`llmSpeechGetTtsHistoryContent`](docs/sdks/speech/README.md#getttshistorycontent) - Retrieve text-to-speech audio
- [`llmSpeechListTranscriptionHistory`](docs/sdks/speech/README.md#listtranscriptionhistory) - List speech-to-text history
- [`llmSpeechListTtsHistory`](docs/sdks/speech/README.md#listttshistory) - List text-to-speech history
- [`llmSpeechLivekitToken`](docs/sdks/speech/README.md#livekittoken) - Generate LiveKit room token
- [`llmSpeechSpeak`](docs/sdks/speech/README.md#speak) - Text to speech
- [`llmSpeechSpeakStreaming`](docs/sdks/speech/README.md#speakstreaming) - Streaming text to speech
- [`llmSpeechTranscribe`](docs/sdks/speech/README.md#transcribe) - Speech to text transcription
- [`llmUsageClassify`](docs/sdks/sdkusage/README.md#classify) - Get classify usage
- [`llmUsageCompletions`](docs/sdks/sdkusage/README.md#completions) - Get completions usage
- [`llmUsageConversations`](docs/sdks/sdkusage/README.md#conversations) - Get conversations usage
- [`llmUsageCosts`](docs/sdks/sdkusage/README.md#costs) - Get cost by model
- [`llmUsageEmbeddings`](docs/sdks/sdkusage/README.md#embeddings) - Get embeddings usage
- [`llmUsageExtract`](docs/sdks/sdkusage/README.md#extract) - Get extract usage
- [`llmUsageFiles`](docs/sdks/sdkusage/README.md#files) - Get files usage
- [`llmUsageResponses`](docs/sdks/sdkusage/README.md#responses) - Get responses usage
- [`llmUsageVectorStores`](docs/sdks/sdkusage/README.md#vectorstores) - Get vector stores usage
- [`llmVectorStoresCancelFileBatch`](docs/sdks/vectorstores/README.md#cancelfilebatch) - Cancel batch file processing
- [`llmVectorStoresCreate`](docs/sdks/vectorstores/README.md#create) - Create a vector store
- [`llmVectorStoresCreateFile`](docs/sdks/vectorstores/README.md#createfile) - Add a file to a vector store
- [`llmVectorStoresCreateFileBatch`](docs/sdks/vectorstores/README.md#createfilebatch) - Batch add multiple files to vector store
- [`llmVectorStoresDelete`](docs/sdks/vectorstores/README.md#delete) - Delete a vector store
- [`llmVectorStoresDeleteFile`](docs/sdks/vectorstores/README.md#deletefile) - Remove file from vector store
- [`llmVectorStoresGet`](docs/sdks/vectorstores/README.md#get) - Retrieve a vector store
- [`llmVectorStoresGetFile`](docs/sdks/vectorstores/README.md#getfile) - Retrieve a vector store file
- [`llmVectorStoresGetFileBatch`](docs/sdks/vectorstores/README.md#getfilebatch) - Retrieve file batch status
- [`llmVectorStoresGetFileContent`](docs/sdks/vectorstores/README.md#getfilecontent) - Retrieve parsed file content
- [`llmVectorStoresList`](docs/sdks/vectorstores/README.md#list) - List vector stores
- [`llmVectorStoresListFiles`](docs/sdks/vectorstores/README.md#listfiles) - List files in a vector store
- [`llmVectorStoresListFilesInBatch`](docs/sdks/vectorstores/README.md#listfilesinbatch) - List files in a batch
- [`llmVectorStoresSearch`](docs/sdks/vectorstores/README.md#search) - Search a vector store
- [`llmVectorStoresUpdate`](docs/sdks/vectorstores/README.md#update) - Modify a vector store
- [`llmVectorStoresUpdateFile`](docs/sdks/vectorstores/README.md#updatefile) - Update file attributes
- [`permissionsLlmCheck`](docs/sdks/sdkllm/README.md#check) - Check user permission
- [`permissionsLlmGrant`](docs/sdks/sdkllm/README.md#grant) - Grant permission to a user or make public
- [`permissionsLlmRevoke`](docs/sdks/sdkllm/README.md#revoke) - Revoke permission from a user or remove public access
- [`reposCreate`](docs/sdks/repos/README.md#create) - Create a repository
- [`reposDelete`](docs/sdks/repos/README.md#delete) - Delete a repository
- [`reposGet`](docs/sdks/repos/README.md#get) - Get a repository
- [`reposList`](docs/sdks/repos/README.md#list) - List the caller's org's repositories
- [`reposTagsDelete`](docs/sdks/tags/README.md#delete) - Delete an image tag
- [`reposTagsList`](docs/sdks/tags/README.md#list) - List an image repository's tags
- [`reposUpdate`](docs/sdks/repos/README.md#update) - Update a repository's labels
- [`sandboxCreate`](docs/sdks/sandbox/README.md#create) - Create Session
- [`sandboxDownloadArchive`](docs/sdks/sandbox/README.md#downloadarchive) - Download Workspace Archive
- [`sandboxDownloadFile`](docs/sdks/sandbox/README.md#downloadfile) - Download Workspace File
- [`sandboxEnvironmentsCreate`](docs/sdks/environments/README.md#create) - Create Environment
- [`sandboxEnvironmentsDelete`](docs/sdks/environments/README.md#delete) - Delete Environment
- [`sandboxEnvironmentsGet`](docs/sdks/environments/README.md#get) - Get Environment
- [`sandboxEnvironmentsList`](docs/sdks/environments/README.md#list) - List Environments
- [`sandboxEnvironmentsRunSetup`](docs/sdks/environments/README.md#runsetup) - Run Environment Setup
- [`sandboxEnvironmentsUpdate`](docs/sdks/environments/README.md#update) - Update Environment
- [`sandboxGet`](docs/sdks/sandbox/README.md#get) - Get Session
- [`sandboxGetBrowserUrl`](docs/sdks/sandbox/README.md#getbrowserurl) - Get Browser Session URL
- [`sandboxGetPricing`](docs/sdks/sandbox/README.md#getpricing) - Get Sandbox Pricing
- [`sandboxGetWorkspace`](docs/sdks/sandbox/README.md#getworkspace) - Get Workspace Manifest
- [`sandboxGithubAddSessionRepository`](docs/sdks/github/README.md#addsessionrepository) - Add Session Repository
- [`sandboxGithubCloneRepository`](docs/sdks/github/README.md#clonerepository) - Clone GitHub Repository into Session
- [`sandboxGithubConnect`](docs/sdks/github/README.md#connect) - Connect GitHub Account
- [`sandboxGithubCreateAuthorizationIntent`](docs/sdks/github/README.md#createauthorizationintent) - Start GitHub Authorization
- [`sandboxGithubCreateOrUpdatePullRequest`](docs/sdks/github/README.md#createorupdatepullrequest) - Create or Update Pull Request
- [`sandboxGithubDisconnect`](docs/sdks/github/README.md#disconnect) - Disconnect GitHub Account
- [`sandboxGithubDismissSessionRepository`](docs/sdks/github/README.md#dismisssessionrepository) - Dismiss Failed Session Repository
- [`sandboxGithubGetConnection`](docs/sdks/github/README.md#getconnection) - Get GitHub Connection
- [`sandboxGithubListRepositories`](docs/sdks/github/README.md#listrepositories) - List GitHub Repositories
- [`sandboxGithubListSessionRepositories`](docs/sdks/github/README.md#listsessionrepositories) - List Session Repositories
- [`sandboxGithubPush`](docs/sdks/github/README.md#push) - Push Session to GitHub
- [`sandboxGithubRefreshRepositories`](docs/sdks/github/README.md#refreshrepositories) - Refresh GitHub Repositories
- [`sandboxGithubResolveReference`](docs/sdks/github/README.md#resolvereference) - Resolve GitHub Reference
- [`sandboxList`](docs/sdks/sandbox/README.md#list) - List Sessions
- [`sandboxProxyBrowserPortRequest`](docs/sdks/sandbox/README.md#proxybrowserportrequest) - Proxy Browser Port Request
- [`sandboxRunCode`](docs/sdks/sandbox/README.md#runcode) - Run Code
- [`sandboxRunCommand`](docs/sdks/sandbox/README.md#runcommand) - Run Command
- [`sandboxSetPricing`](docs/sdks/sandbox/README.md#setpricing) - Set Sandbox Pricing
- [`sandboxTerminate`](docs/sdks/sandbox/README.md#terminate) - Terminate Session
- [`sandboxUploadArchive`](docs/sdks/sandbox/README.md#uploadarchive) - Upload Workspace Archive
- [`sandboxUploadFile`](docs/sdks/sandbox/README.md#uploadfile) - Upload Workspace File
- [`sessionExchangeSessionToken`](docs/sdks/session/README.md#exchangesessiontoken) - Exchange a live session for a delegated access token
- [`sessionGetPendingInvitation`](docs/sdks/session/README.md#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
- [`trackingExperimentsCreate`](docs/sdks/experiments/README.md#create) - Create
- [`trackingExperimentsDelete`](docs/sdks/experiments/README.md#delete) - Delete
- [`trackingExperimentsGet`](docs/sdks/experiments/README.md#get) - Get
- [`trackingExperimentsGetByName`](docs/sdks/experiments/README.md#getbyname) - GetByName
- [`trackingExperimentsSearch`](docs/sdks/experiments/README.md#search) - Search
- [`trackingRunsCreate`](docs/sdks/runs/README.md#create) - Create
- [`trackingRunsDelete`](docs/sdks/runs/README.md#delete) - Delete
- [`trackingRunsDeleteTag`](docs/sdks/runs/README.md#deletetag) - DeleteTag
- [`trackingRunsGet`](docs/sdks/runs/README.md#get) - Get
- [`trackingRunsGetMetricHistory`](docs/sdks/runs/README.md#getmetrichistory) - GetMetricHistory
- [`trackingRunsLogBatch`](docs/sdks/runs/README.md#logbatch) - LogBatch
- [`trackingRunsLogInputs`](docs/sdks/runs/README.md#loginputs) - LogInputs
- [`trackingRunsLogMetric`](docs/sdks/runs/README.md#logmetric) - LogMetric
- [`trackingRunsLogParameter`](docs/sdks/runs/README.md#logparameter) - LogParameter
- [`trackingRunsRestore`](docs/sdks/runs/README.md#restore) - Restore
- [`trackingRunsSearch`](docs/sdks/runs/README.md#search) - Search
- [`trackingRunsSetTag`](docs/sdks/runs/README.md#settag) - SetTag
- [`trackingRunsUpdate`](docs/sdks/runs/README.md#update) - Update
- [`usageCosts`](docs/sdks/usage/README.md#costs) - Aggregate cost by dimension
- [`usageSandbox`](docs/sdks/usage/README.md#sandbox) - Get Sandbox Usage
- ~~[`authApiKeyGetJwtFromKey`](docs/sdks/apikey/README.md#getjwtfromkey)~~ - Exchange API key for a JWT token :warning: **Deprecated** Use [`authApiKeysExchangeToken`](docs/sdks/apikeys/README.md#exchangetoken) instead.
- ~~[`llmChatCreateChat`](docs/sdks/chat/README.md#createchat)~~ - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
- ~~[`llmChatStream`](docs/sdks/chat/README.md#stream)~~ - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**
- ~~[`llmFineTuningCancel`](docs/sdks/finetuning/README.md#cancel)~~ - [Deprecated] Cancel a fine-tuning job :warning: **Deprecated**
- ~~[`llmFineTuningCreate`](docs/sdks/finetuning/README.md#create)~~ - [Deprecated] Create a fine-tuning job :warning: **Deprecated**
- ~~[`llmFineTuningList`](docs/sdks/finetuning/README.md#list)~~ - [Deprecated] List fine-tuning jobs :warning: **Deprecated**
- ~~[`llmFineTuningListCheckpoints`](docs/sdks/finetuning/README.md#listcheckpoints)~~ - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**
- ~~[`llmFineTuningListEvents`](docs/sdks/finetuning/README.md#listevents)~~ - [Deprecated] List fine-tuning events :warning: **Deprecated**
- ~~[`llmFineTuningPause`](docs/sdks/finetuning/README.md#pause)~~ - [Deprecated] Pause a fine-tuning job :warning: **Deprecated**
- ~~[`llmFineTuningResume`](docs/sdks/finetuning/README.md#resume)~~ - [Deprecated] Resume a fine-tuning job :warning: **Deprecated**
- ~~[`llmFineTuningRetrieve`](docs/sdks/finetuning/README.md#retrieve)~~ - [Deprecated] Retrieve a fine-tuning job :warning: **Deprecated**
- ~~[`sandboxGetUrl`](docs/sdks/sandbox/README.md#geturl)~~ - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [`sandboxGetBrowserUrl`](docs/sdks/sandbox/README.md#getbrowserurl) instead.

</details>
<!-- End Standalone functions [standalone-funcs] -->

<!-- Start React hooks with TanStack Query [react-query] -->
## React hooks with TanStack Query

React hooks built on [TanStack Query][tanstack-query] are included in this SDK.
These hooks and the utility functions provided alongside them can be used to
build rich applications that pull data from the API using one of the most
popular asynchronous state management library.

[tanstack-query]: https://tanstack.com/query/v5/docs/framework/react/overview

To learn about this feature and how to get started, check
[REACT_QUERY.md](./REACT_QUERY.md).

> [!WARNING]
>
> This feature is currently in **preview** and is subject to breaking changes
> within the current major version of the SDK as we gather user feedback on it.

<details>

<summary>Available React hooks</summary>

- [`useAgentConnectorsActivateAgentConnectorMutation`](docs/sdks/agentconnectors/README.md#activateagentconnector) - Activate a connector
- [`useAgentConnectorsCreateAgentConnectorMutation`](docs/sdks/agentconnectors/README.md#createagentconnector) - Create a connector
- [`useAgentConnectorsDeleteAgentConnectorMutation`](docs/sdks/agentconnectors/README.md#deleteagentconnector) - Delete a connector
- [`useAgentConnectorsGetAgentConnector`](docs/sdks/agentconnectors/README.md#getagentconnector) - Retrieve a connector
- [`useAgentConnectorsListAgentConnectors`](docs/sdks/agentconnectors/README.md#listagentconnectors) - List connectors for an agent
- [`useAgentConnectorsSetupWhatsAppAppWebhookMutation`](docs/sdks/agentconnectors/README.md#setupwhatsappappwebhook) - Set up a WhatsApp app webhook (Beta)
- [`useAgentRunsCreateAgentRunMutation`](docs/sdks/agentruns/README.md#createagentrun) - Start a saved agent run
- [`useAgentRunsDecideAgentRunMcpApprovalMutation`](docs/sdks/agentruns/README.md#decideagentrunmcpapproval) - Approve or deny a pending MCP tool call
- [`useAgentRunsGetAgentRun`](docs/sdks/agentruns/README.md#getagentrun) - Retrieve an agent run
- [`useAgentRunsListAgentRuns`](docs/sdks/agentruns/README.md#listagentruns) - List runs for an agent
- [`useAgentRunsStreamAgentRunEvents`](docs/sdks/agentruns/README.md#streamagentrunevents) - Stream agent run events
- [`useAgentRunsWakeAgentRunMutation`](docs/sdks/agentruns/README.md#wakeagentrun) - Wake a sleeping agent run
- [`useAgentSchedulesCreateAgentScheduleMutation`](docs/sdks/agentschedules/README.md#createagentschedule) - Create an agent schedule
- [`useAgentSchedulesDeleteAgentScheduleMutation`](docs/sdks/agentschedules/README.md#deleteagentschedule) - Delete an agent schedule
- [`useAgentSchedulesGetAgentSchedule`](docs/sdks/agentschedules/README.md#getagentschedule) - Retrieve an agent schedule
- [`useAgentSchedulesListAgentSchedules`](docs/sdks/agentschedules/README.md#listagentschedules) - List schedules for an agent
- [`useAgentSchedulesPauseAgentScheduleMutation`](docs/sdks/agentschedules/README.md#pauseagentschedule) - Pause an agent schedule
- [`useAgentSchedulesResumeAgentScheduleMutation`](docs/sdks/agentschedules/README.md#resumeagentschedule) - Resume an agent schedule
- [`useAgentSchedulesUpdateAgentScheduleMutation`](docs/sdks/agentschedules/README.md#updateagentschedule) - Update an agent schedule
- [`useAgentsCreateAgentMutation`](docs/sdks/agents/README.md#createagent) - Create an agent
- [`useAgentsDeleteAgentMutation`](docs/sdks/agents/README.md#deleteagent) - Delete an agent
- [`useAgentsGetAgent`](docs/sdks/agents/README.md#getagent) - Retrieve an agent
- [`useAgentsListAgents`](docs/sdks/agents/README.md#listagents) - List agents
- [`useAgentsUpdateAgentMutation`](docs/sdks/agents/README.md#updateagent) - Update an agent
- [`useAgentVersionsGetAgentVersion`](docs/sdks/agentversions/README.md#getagentversion) - Retrieve an agent version
- [`useAgentVersionsListAgentVersions`](docs/sdks/agentversions/README.md#listagentversions) - List agent versions
- [`useAgentVersionsRollbackAgentVersionMutation`](docs/sdks/agentversions/README.md#rollbackagentversion) - Roll back an agent to a version
- [`useAnalyticsCaptureMutation`](docs/sdks/analytics/README.md#capture) - Durably accept a batch of events
- [`useAnalyticsEventsSearchMutation`](docs/sdks/events/README.md#search) - Search events in a time range
- [`useAnalyticsKeysCreateMutation`](docs/sdks/keys/README.md#create) - Create a capture key and return its secret once
- [`useAnalyticsKeysList`](docs/sdks/keys/README.md#list) - List capture key metadata
- [`useAnalyticsKeysRevokeMutation`](docs/sdks/keys/README.md#revoke) - Revoke a capture key
- [`useAnalyticsProjectsArchiveMutation`](docs/sdks/projects/README.md#archive) - Archive an analytics project
- [`useAnalyticsProjectsCreateMutation`](docs/sdks/projects/README.md#create) - Create an analytics project
- [`useAnalyticsProjectsGet`](docs/sdks/projects/README.md#get) - Get an analytics project
- [`useAnalyticsProjectsList`](docs/sdks/projects/README.md#list) - List accessible analytics projects
- [`useAnalyticsProjectsUpdateMutation`](docs/sdks/projects/README.md#update) - Rename an active analytics project
- [`useAnalyticsQueryMutation`](docs/sdks/analytics/README.md#query) - Query event counts or unique visitors
- [`useAnalyticsVisitorsSearchMutation`](docs/sdks/visitors/README.md#search) - Search visitors in a time range
- [`useAuthApiKeysCreateMutation`](docs/sdks/apikeys/README.md#create) - Mint a scoped API key
- [`useAuthApiKeysExchangeTokenMutation`](docs/sdks/apikeys/README.md#exchangetoken) - Exchange API key for a JWT token
- [`useAuthApiKeysList`](docs/sdks/apikeys/README.md#list) - List scoped API keys
- [`useAuthApiKeysRegenerateMutation`](docs/sdks/apikeys/README.md#regenerate) - Rotate a scoped API key's secret
- [`useAuthApiKeysUpdateMutation`](docs/sdks/apikeys/README.md#update) - Update a scoped API key
- [`useAuthClusterAcceptInviteMutation`](docs/sdks/cluster/README.md#acceptinvite) - Accept a cluster invitation (public)
- [`useAuthClusterCreateInviteMutation`](docs/sdks/cluster/README.md#createinvite) - Create a cluster invitation
- [`useAuthClusterDeleteOrgMutation`](docs/sdks/cluster/README.md#deleteorg) - Soft-delete an organization
- [`useAuthClusterGetOrg`](docs/sdks/cluster/README.md#getorg) - Get an organization
- [`useAuthClusterInviteInfo`](docs/sdks/cluster/README.md#inviteinfo) - Read cluster-invite info (public)
- [`useAuthClusterInviteOrgMembersMutation`](docs/sdks/cluster/README.md#inviteorgmembers) - Invite members on behalf of an organization
- [`useAuthClusterListInvites`](docs/sdks/cluster/README.md#listinvites) - List cluster invitations
- [`useAuthClusterListOrgs`](docs/sdks/cluster/README.md#listorgs) - List all organizations
- [`useAuthClusterReissueOwnerKeyMutation`](docs/sdks/cluster/README.md#reissueownerkey) - Re-issue an org owner key (recovery)
- [`useAuthClusterRevokeInviteMutation`](docs/sdks/cluster/README.md#revokeinvite) - Revoke a cluster invitation
- [`useAuthClusterSuspendOrgMutation`](docs/sdks/cluster/README.md#suspendorg) - Suspend an organization
- [`useAuthClusterUnsuspendOrgMutation`](docs/sdks/cluster/README.md#unsuspendorg) - Unsuspend an organization
- [`useAuthClusterUpdateInviteMutation`](docs/sdks/cluster/README.md#updateinvite) - Update a pending cluster invitation
- [`useAuthOrgsGetById`](docs/sdks/orgs/README.md#getbyid) - Get basic organization details
- [`useAuthOrgsGetQuota`](docs/sdks/orgs/README.md#getquota) - Get an org's usage quota
- [`useAuthOrgsGetRateLimit`](docs/sdks/orgs/README.md#getratelimit) - Get an org's rate limit
- [`useAuthOrgsUpdateMutation`](docs/sdks/orgs/README.md#update) - Patch organization metadata (cluster-admin)
- [`useAuthOrgsUpdateQuotaMutation`](docs/sdks/orgs/README.md#updatequota) - Set an org's usage quota (cluster-admin)
- [`useAuthOrgsUpdateRateLimitMutation`](docs/sdks/orgs/README.md#updateratelimit) - Set an org's rate limit (cluster-admin)
- [`useAuthServiceAccountsCreateMutation`](docs/sdks/serviceaccounts/README.md#create) - Create a service account
- [`useAuthServiceAccountsDeleteApiKeyMutation`](docs/sdks/serviceaccounts/README.md#deleteapikey) - Delete a service-account API key
- [`useAuthServiceAccountsDeleteMutation`](docs/sdks/serviceaccounts/README.md#delete) - Delete a service account
- [`useAuthServiceAccountsGet`](docs/sdks/serviceaccounts/README.md#get) - Get a service account
- [`useAuthServiceAccountsList`](docs/sdks/serviceaccounts/README.md#list) - List service accounts
- [`useAuthServiceAccountsListApiKeys`](docs/sdks/serviceaccounts/README.md#listapikeys) - List a service account's API keys
- [`useAuthServiceAccountsRegenerateApiKeyMutation`](docs/sdks/serviceaccounts/README.md#regenerateapikey) - Rotate a service-account API key's secret
- [`useAuthServiceAccountsUpdateApiKeyMutation`](docs/sdks/serviceaccounts/README.md#updateapikey) - Update a service-account API key
- [`useAuthTeamsAddMemberMutation`](docs/sdks/teams/README.md#addmember) - Add a team member
- [`useAuthTeamsCreateMutation`](docs/sdks/teams/README.md#create) - Create a team
- [`useAuthTeamsDeleteMutation`](docs/sdks/teams/README.md#delete) - Delete a team
- [`useAuthTeamsGet`](docs/sdks/teams/README.md#get) - Get a team
- [`useAuthTeamsList`](docs/sdks/teams/README.md#list) - List teams in an org
- [`useAuthTeamsListMembers`](docs/sdks/teams/README.md#listmembers) - List team members
- [`useAuthTeamsRemoveMemberMutation`](docs/sdks/teams/README.md#removemember) - Remove a team member
- [`useAuthTeamsUpdateMutation`](docs/sdks/teams/README.md#update) - Rename a team
- [`useBillingCreateOrganizationBillingPortalMutation`](docs/sdks/billing/README.md#createorganizationbillingportal)
- [`useBillingCreateOrganizationBillingSetupMutation`](docs/sdks/billing/README.md#createorganizationbillingsetup)
- [`useBillingGetOrganizationBilling`](docs/sdks/billing/README.md#getorganizationbilling)
- [`useBillingListOrganizationBillingInvoices`](docs/sdks/billing/README.md#listorganizationbillinginvoices)
- [`useBillingSetOrganizationBillingEnabledMutation`](docs/sdks/billing/README.md#setorganizationbillingenabled)
- [`useBillingUpdateOrganizationBillingProfileMutation`](docs/sdks/billing/README.md#updateorganizationbillingprofile)
- [`useBudgetsApiKeyEvents`](docs/sdks/budgets/README.md#apikeyevents) - List apikey budget events
- [`useBudgetsDeleteApiKeyMutation`](docs/sdks/budgets/README.md#deleteapikey) - Delete an apikey budget
- [`useBudgetsDeleteExternalUserDefaultMutation`](docs/sdks/budgets/README.md#deleteexternaluserdefault) - Delete a per-external user default budget
- [`useBudgetsDeleteExternalUserMutation`](docs/sdks/budgets/README.md#deleteexternaluser) - Delete a external user budget
- [`useBudgetsDeleteOrgMutation`](docs/sdks/budgets/README.md#deleteorg) - Delete an org budget
- [`useBudgetsDeleteTeamDefaultMutation`](docs/sdks/budgets/README.md#deleteteamdefault) - Delete a per-team default budget
- [`useBudgetsDeleteTeamMutation`](docs/sdks/budgets/README.md#deleteteam) - Delete a team budget
- [`useBudgetsDeleteUserDefaultMutation`](docs/sdks/budgets/README.md#deleteuserdefault) - Delete a per-user default budget
- [`useBudgetsDeleteUserMutation`](docs/sdks/budgets/README.md#deleteuser) - Delete a user budget
- [`useBudgetsExternalUserDefaultEvents`](docs/sdks/budgets/README.md#externaluserdefaultevents) - List per-external user default budget events
- [`useBudgetsExternalUserEvents`](docs/sdks/budgets/README.md#externaluserevents) - List external user budget events
- [`useBudgetsGetApiKey`](docs/sdks/budgets/README.md#getapikey) - List apikey budgets
- [`useBudgetsGetCurrency`](docs/sdks/budgets/README.md#getcurrency) - Get display currency
- [`useBudgetsGetExternalUser`](docs/sdks/budgets/README.md#getexternaluser) - List external user budgets
- [`useBudgetsGetExternalUserDefault`](docs/sdks/budgets/README.md#getexternaluserdefault) - List per-external user default budgets
- [`useBudgetsGetOrg`](docs/sdks/budgets/README.md#getorg) - List org budgets
- [`useBudgetsGetTeam`](docs/sdks/budgets/README.md#getteam) - List team budgets
- [`useBudgetsGetTeamDefault`](docs/sdks/budgets/README.md#getteamdefault) - List per-team default budgets
- [`useBudgetsGetUser`](docs/sdks/budgets/README.md#getuser) - List user budgets
- [`useBudgetsGetUserDefault`](docs/sdks/budgets/README.md#getuserdefault) - List per-user default budgets
- [`useBudgetsList`](docs/sdks/budgets/README.md#list) - List budgets
- [`useBudgetsOrgEvents`](docs/sdks/budgets/README.md#orgevents) - List org budget events
- [`useBudgetsSetApiKeyMutation`](docs/sdks/budgets/README.md#setapikey) - Set an apikey budget
- [`useBudgetsSetCurrencyMutation`](docs/sdks/budgets/README.md#setcurrency) - Set display currency
- [`useBudgetsSetExternalUserDefaultMutation`](docs/sdks/budgets/README.md#setexternaluserdefault) - Set a per-external user default budget
- [`useBudgetsSetExternalUserMutation`](docs/sdks/budgets/README.md#setexternaluser) - Set a external user budget
- [`useBudgetsSetOrgMutation`](docs/sdks/budgets/README.md#setorg) - Set an org budget
- [`useBudgetsSetTeamDefaultMutation`](docs/sdks/budgets/README.md#setteamdefault) - Set a per-team default budget
- [`useBudgetsSetTeamMutation`](docs/sdks/budgets/README.md#setteam) - Set a team budget
- [`useBudgetsSetUserDefaultMutation`](docs/sdks/budgets/README.md#setuserdefault) - Set a per-user default budget
- [`useBudgetsSetUserMutation`](docs/sdks/budgets/README.md#setuser) - Set a user budget
- [`useBudgetsTeamDefaultEvents`](docs/sdks/budgets/README.md#teamdefaultevents) - List per-team default budget events
- [`useBudgetsTeamEvents`](docs/sdks/budgets/README.md#teamevents) - List team budget events
- [`useBudgetsUserDefaultEvents`](docs/sdks/budgets/README.md#userdefaultevents) - List per-user default budget events
- [`useBudgetsUserEvents`](docs/sdks/budgets/README.md#userevents) - List user budget events
- [`useComputeCatalogCreateComputeQuoteMutation`](docs/sdks/computecatalog/README.md#createcomputequote) - Create a quote
- [`useComputeCatalogGetAccelerator`](docs/sdks/computecatalog/README.md#getaccelerator) - Get an accelerator
- [`useComputeCatalogListAccelerators`](docs/sdks/computecatalog/README.md#listaccelerators) - List accelerators
- [`useComputeCatalogListComputeOffers`](docs/sdks/computecatalog/README.md#listcomputeoffers) - List provider offers
- [`useComputeCatalogListComputeProviders`](docs/sdks/computecatalog/README.md#listcomputeproviders) - List provider health
- [`useComputeJobsCreateJobMutation`](docs/sdks/computejobs/README.md#createjob) - Create a job
- [`useComputeJobsGetJob`](docs/sdks/computejobs/README.md#getjob) - Get a job
- [`useComputeJobsListJobEvents`](docs/sdks/computejobs/README.md#listjobevents) - List job events
- [`useComputeJobsListJobInstances`](docs/sdks/computejobs/README.md#listjobinstances) - List observed job instances
- [`useComputeJobsListJobLogs`](docs/sdks/computejobs/README.md#listjoblogs) - List job logs
- [`useComputeJobsListJobs`](docs/sdks/computejobs/README.md#listjobs) - List jobs
- [`useComputeJobsTerminateJobMutation`](docs/sdks/computejobs/README.md#terminatejob) - Terminate a job
- [`useComputePricingGetPricing`](docs/sdks/computepricing/README.md#getpricing) - Get the latest committed storage price
- [`useComputePricingPutPricingMutation`](docs/sdks/computepricing/README.md#putpricing) - Create an immutable storage-price version
- [`useComputeSecretsCreateComputeSecretMutation`](docs/sdks/computesecrets/README.md#createcomputesecret) - Create a secret
- [`useComputeSecretsDeleteComputeSecretMutation`](docs/sdks/computesecrets/README.md#deletecomputesecret) - Delete a secret
- [`useComputeSecretsGetComputeSecret`](docs/sdks/computesecrets/README.md#getcomputesecret) - Get a secret
- [`useComputeSecretsListComputeSecrets`](docs/sdks/computesecrets/README.md#listcomputesecrets) - List secrets
- [`useComputeServicesCreateServiceMutation`](docs/sdks/computeservices/README.md#createservice) - Create a service
- [`useComputeServicesGetService`](docs/sdks/computeservices/README.md#getservice) - Get a service
- [`useComputeServicesListServiceEvents`](docs/sdks/computeservices/README.md#listserviceevents) - List service events
- [`useComputeServicesListServiceInstances`](docs/sdks/computeservices/README.md#listserviceinstances) - List observed service instances
- [`useComputeServicesListServiceLogs`](docs/sdks/computeservices/README.md#listservicelogs) - List service logs
- [`useComputeServicesListServices`](docs/sdks/computeservices/README.md#listservices) - List services
- [`useComputeServicesTerminateServiceMutation`](docs/sdks/computeservices/README.md#terminateservice) - Terminate a service
- [`useComputeServicesUpdateServiceScalingMutation`](docs/sdks/computeservices/README.md#updateservicescaling) - Replace a service scaling policy
- [`useComputeTenantsGetComputeTenant`](docs/sdks/computetenants/README.md#getcomputetenant) - Get a tenant
- [`useComputeTenantsListComputeTenants`](docs/sdks/computetenants/README.md#listcomputetenants) - List tenants
- [`useComputeTenantsPutComputeTenantMutation`](docs/sdks/computetenants/README.md#putcomputetenant) - Update a tenant
- [`useComputeUsageGetComputeUsage`](docs/sdks/computeusage/README.md#getcomputeusage) - Get usage
- [`useComputeVolumesCreateStandaloneVolumeMutation`](docs/sdks/computevolumes/README.md#createstandalonevolume) - Create a standalone shared volume
- [`useComputeVolumesDeleteStandaloneVolumeMutation`](docs/sdks/computevolumes/README.md#deletestandalonevolume) - Permanently delete a standalone volume
- [`useComputeVolumesGetStandaloneVolume`](docs/sdks/computevolumes/README.md#getstandalonevolume) - Get a standalone volume
- [`useComputeVolumesListStandaloneVolumeAttachments`](docs/sdks/computevolumes/README.md#liststandalonevolumeattachments) - List volume attachments
- [`useComputeVolumesListStandaloneVolumes`](docs/sdks/computevolumes/README.md#liststandalonevolumes) - List organization volumes
- [`useDatasetsCancelGenerationMutation`](docs/sdks/datasets/README.md#cancelgeneration) - Cancel Generation
- [`useDatasetsCreateGenerationMutation`](docs/sdks/datasets/README.md#creategeneration) - Create Generation
- [`useDatasetsGetFormat`](docs/sdks/datasets/README.md#getformat) - Get Format
- [`useDatasetsGetGeneration`](docs/sdks/datasets/README.md#getgeneration) - Get Generation
- [`useDatasetsGetGenerationEvents`](docs/sdks/datasets/README.md#getgenerationevents) - Get Events
- [`useDatasetsGetGenerationLogs`](docs/sdks/datasets/README.md#getgenerationlogs) - Get Logs
- [`useDatasetsGetGenerator`](docs/sdks/datasets/README.md#getgenerator) - Get Generator
- [`useDatasetsListFormats`](docs/sdks/datasets/README.md#listformats) - List Formats
- [`useDatasetsListGenerations`](docs/sdks/datasets/README.md#listgenerations) - List Generations
- [`useDatasetsListGenerators`](docs/sdks/datasets/README.md#listgenerators) - List Generators
- [`useDatasetsQuoteGeneratorMutation`](docs/sdks/datasets/README.md#quotegenerator) - Quote Generator
- [`useFlagsArchiveMutation`](docs/sdks/flags/README.md#archive) - Archive a flag
- [`useFlagsAuditList`](docs/sdks/audit/README.md#list) - List audit entries, newest first
- [`useFlagsCreateMutation`](docs/sdks/flags/README.md#create) - Create a flag
- [`useFlagsDeleteMutation`](docs/sdks/flags/README.md#delete) - Delete a flag and its settings in every environment
- [`useFlagsEnvironmentsCreateMutation`](docs/sdks/sdkenvironments/README.md#create) - Create an environment
- [`useFlagsEnvironmentsDeleteMutation`](docs/sdks/sdkenvironments/README.md#delete) - Delete an environment and every flag setting in it
- [`useFlagsEnvironmentsEvaluate`](docs/sdks/sdkenvironments/README.md#evaluate) - Evaluate every flag for an identity
- [`useFlagsEnvironmentsEvaluateWithTraitsMutation`](docs/sdks/sdkenvironments/README.md#evaluatewithtraits) - Evaluate every flag for an identity with traits
- [`useFlagsEnvironmentsGenerateEvaluationKeyMutation`](docs/sdks/sdkenvironments/README.md#generateevaluationkey) - Generate or replace an environment evaluation key
- [`useFlagsEnvironmentsList`](docs/sdks/sdkenvironments/README.md#list) - List environments
- [`useFlagsEnvironmentsRevokeEvaluationKeyMutation`](docs/sdks/sdkenvironments/README.md#revokeevaluationkey) - Revoke an environment evaluation key
- [`useFlagsEnvironmentsUpdateMutation`](docs/sdks/sdkenvironments/README.md#update) - Rename an environment
- [`useFlagsGet`](docs/sdks/flags/README.md#get) - Get a flag
- [`useFlagsList`](docs/sdks/flags/README.md#list) - List flags
- [`useFlagsProjectsCreateMutation`](docs/sdks/sdkprojects/README.md#create) - Create a project
- [`useFlagsProjectsDeleteMutation`](docs/sdks/sdkprojects/README.md#delete) - Delete an empty project
- [`useFlagsProjectsGet`](docs/sdks/sdkprojects/README.md#get) - Get a project
- [`useFlagsProjectsList`](docs/sdks/sdkprojects/README.md#list) - List projects
- [`useFlagsProjectsUpdateMutation`](docs/sdks/sdkprojects/README.md#update) - Rename a project
- [`useFlagsSetEnvironmentStateMutation`](docs/sdks/flags/README.md#setenvironmentstate) - Replace a flag's settings in one environment
- [`useFlagsUnarchiveMutation`](docs/sdks/flags/README.md#unarchive) - Restore an archived flag
- [`useFlagsUpdateMutation`](docs/sdks/flags/README.md#update) - Update a flag's name, description, default value, or project
- [`useGuardrailsDeleteGuardrailsMutation`](docs/sdks/guardrails/README.md#deleteguardrails) - Delete guardrails policy
- [`useGuardrailsGetGuardrails`](docs/sdks/guardrails/README.md#getguardrails) - Get effective guardrails
- [`useGuardrailsListGuardrailsPolicies`](docs/sdks/guardrails/README.md#listguardrailspolicies) - List guardrails policies
- [`useGuardrailsTestGuardrailsMutation`](docs/sdks/guardrails/README.md#testguardrails) - Test content against guardrails
- [`useGuardrailsUpdateGuardrailsMutation`](docs/sdks/guardrails/README.md#updateguardrails) - Update guardrails policy
- [`useLlmBatchesCancelMutation`](docs/sdks/batches/README.md#cancel) - Cancel a batch
- [`useLlmBatchesCreateMutation`](docs/sdks/batches/README.md#create) - Create a batch
- [`useLlmBatchesGet`](docs/sdks/batches/README.md#get) - Get a batch
- [`useLlmBatchesList`](docs/sdks/batches/README.md#list) - List batches
- [`useLlmClassifyClassifyMutation`](docs/sdks/classify/README.md#classify) - Classify text into predefined categories
- [`useLlmConversationsCreateItemsMutation`](docs/sdks/conversations/README.md#createitems) - Create conversation items
- [`useLlmConversationsCreateMutation`](docs/sdks/conversations/README.md#create) - Create a conversation
- [`useLlmConversationsDeleteItemMutation`](docs/sdks/conversations/README.md#deleteitem) - Delete a conversation item
- [`useLlmConversationsDeleteItemsMutation`](docs/sdks/conversations/README.md#deleteitems) - Delete multiple conversation items
- [`useLlmConversationsDeleteMutation`](docs/sdks/conversations/README.md#delete) - Delete a conversation
- [`useLlmConversationsGet`](docs/sdks/conversations/README.md#get) - Retrieve a conversation
- [`useLlmConversationsGetItem`](docs/sdks/conversations/README.md#getitem) - Retrieve a conversation item
- [`useLlmConversationsList`](docs/sdks/conversations/README.md#list) - List conversations
- [`useLlmConversationsListItems`](docs/sdks/conversations/README.md#listitems) - List conversation items
- [`useLlmConversationsUpdateMutation`](docs/sdks/conversations/README.md#update) - Update a conversation
- [`useLlmEmbeddingsEmbedMutation`](docs/sdks/embeddings/README.md#embed) - Create text embeddings
- [`useLlmEmbeddingsListModels`](docs/sdks/embeddings/README.md#listmodels) - List available embedding models
- [`useLlmEvalsAppendAgentTrialsMutation`](docs/sdks/evals/README.md#appendagenttrials) - Append trials to an open coding-agent run
- [`useLlmEvalsCancelRunMutation`](docs/sdks/evals/README.md#cancelrun) - Cancel an eval run
- [`useLlmEvalsCreateRunMutation`](docs/sdks/evals/README.md#createrun) - Create an eval run
- [`useLlmEvalsCreateScheduleMutation`](docs/sdks/evals/README.md#createschedule) - Create an eval schedule
- [`useLlmEvalsCreateSuiteMutation`](docs/sdks/evals/README.md#createsuite) - Create an eval suite
- [`useLlmEvalsCreateSuiteVersionMutation`](docs/sdks/evals/README.md#createsuiteversion) - Create an eval suite version
- [`useLlmEvalsDeleteRunMutation`](docs/sdks/evals/README.md#deleterun) - Delete an eval run
- [`useLlmEvalsDeleteScheduleMutation`](docs/sdks/evals/README.md#deleteschedule) - Delete an eval schedule
- [`useLlmEvalsDeleteSuiteMutation`](docs/sdks/evals/README.md#deletesuite) - Delete an eval suite
- [`useLlmEvalsGetArtifacts`](docs/sdks/evals/README.md#getartifacts) - Get eval run artifacts
- [`useLlmEvalsGetRun`](docs/sdks/evals/README.md#getrun) - Get an eval run
- [`useLlmEvalsGetRunOverview`](docs/sdks/evals/README.md#getrunoverview) - Get an eval run overview
- [`useLlmEvalsGetSampleAudio`](docs/sdks/evals/README.md#getsampleaudio) - Get eval sample audio
- [`useLlmEvalsGetSampleTrajectory`](docs/sdks/evals/README.md#getsampletrajectory) - Get an eval sample trajectory
- [`useLlmEvalsGetSchedule`](docs/sdks/evals/README.md#getschedule) - Get an eval schedule
- [`useLlmEvalsGetSuite`](docs/sdks/evals/README.md#getsuite) - Get an eval suite
- [`useLlmEvalsGetSuiteLeaderboard`](docs/sdks/evals/README.md#getsuiteleaderboard) - Get the coding-agent leaderboard for an eval suite
- [`useLlmEvalsGetSuiteVersion`](docs/sdks/evals/README.md#getsuiteversion) - Get an eval suite version
- [`useLlmEvalsImportAgentRunMutation`](docs/sdks/evals/README.md#importagentrun) - Import a finished coding-agent run
- [`useLlmEvalsImportHistoricalResultsMutation`](docs/sdks/evals/README.md#importhistoricalresults) - Import historical eval results from Hugging Face
- [`useLlmEvalsListRuns`](docs/sdks/evals/README.md#listruns) - List eval runs
- [`useLlmEvalsListSamples`](docs/sdks/evals/README.md#listsamples) - List eval samples
- [`useLlmEvalsListScheduleRuns`](docs/sdks/evals/README.md#listscheduleruns) - List runs created by an eval schedule
- [`useLlmEvalsListSchedules`](docs/sdks/evals/README.md#listschedules) - List eval schedules
- [`useLlmEvalsListSuiteLeaderboardRuns`](docs/sdks/evals/README.md#listsuiteleaderboardruns) - List leaderboard runs for an eval suite
- [`useLlmEvalsListSuites`](docs/sdks/evals/README.md#listsuites) - List eval suites
- [`useLlmEvalsListSuiteVersions`](docs/sdks/evals/README.md#listsuiteversions) - List eval suite versions
- [`useLlmEvalsMeasureSuiteTokensMutation`](docs/sdks/evals/README.md#measuresuitetokens) - Count tokens from stored text for a suite's unmeasured samples
- [`useLlmEvalsRerunFailedSamplesMutation`](docs/sdks/evals/README.md#rerunfailedsamples) - Rerun failed eval samples
- [`useLlmEvalsRetryFailedRunMutation`](docs/sdks/evals/README.md#retryfailedrun) - Retry an eval run
- [`useLlmEvalsTriggerScheduleMutation`](docs/sdks/evals/README.md#triggerschedule) - Trigger an eval schedule now
- [`useLlmEvalsUpdateScheduleMutation`](docs/sdks/evals/README.md#updateschedule) - Update an eval schedule
- [`useLlmEvalsUploadSampleTrajectoryMutation`](docs/sdks/evals/README.md#uploadsampletrajectory) - Upload an eval sample trajectory
- [`useLlmExtractCreateSchemaMutation`](docs/sdks/extract/README.md#createschema) - Create reusable extraction schema template
- [`useLlmExtractDeleteSchemaMutation`](docs/sdks/extract/README.md#deleteschema) - Delete extraction schema by ID
- [`useLlmExtractExtractMutation`](docs/sdks/extract/README.md#extract) - Extract structured data with inline JSON Schema
- [`useLlmExtractExtractWithSchemaMutation`](docs/sdks/extract/README.md#extractwithschema) - Extract data using saved schema template
- [`useLlmExtractGetSchema`](docs/sdks/extract/README.md#getschema) - Get extraction schema by ID
- [`useLlmExtractUpdateSchemaMutation`](docs/sdks/extract/README.md#updateschema) - Update extraction schema by ID
- [`useLlmFeedbackBatchGetCompletionFeedbackMutation`](docs/sdks/feedback/README.md#batchgetcompletionfeedback) - Batch retrieve feedback for multiple completions
- [`useLlmFeedbackBatchGetResponseFeedbackMutation`](docs/sdks/feedback/README.md#batchgetresponsefeedback) - Batch retrieve feedback for multiple responses
- [`useLlmFeedbackCreateCompletionFeedbackMutation`](docs/sdks/feedback/README.md#createcompletionfeedback) - Submit feedback for chat completion
- [`useLlmFeedbackCreateResponseFeedbackMutation`](docs/sdks/feedback/README.md#createresponsefeedback) - Submit feedback for response
- [`useLlmFeedbackExportCompletionFeedback`](docs/sdks/feedback/README.md#exportcompletionfeedback) - Export completion feedback as CSV
- [`useLlmFeedbackExportResponseFeedback`](docs/sdks/feedback/README.md#exportresponsefeedback) - Export response feedback as CSV
- [`useLlmFeedbackGetCompletionFeedback`](docs/sdks/feedback/README.md#getcompletionfeedback) - Retrieve feedback by completion ID
- [`useLlmFeedbackGetExportStatus`](docs/sdks/feedback/README.md#getexportstatus) - Get feedback export status
- [`useLlmFeedbackGetResponseFeedback`](docs/sdks/feedback/README.md#getresponsefeedback) - Retrieve feedback by response ID
- [`useLlmFeedbackListCompletionFeedback`](docs/sdks/feedback/README.md#listcompletionfeedback) - List chat completion feedback
- [`useLlmFeedbackListResponseFeedback`](docs/sdks/feedback/README.md#listresponsefeedback) - List response feedback
- [`useLlmFeedbackStartExportMutation`](docs/sdks/feedback/README.md#startexport) - Start feedback export
- [`useLlmFeedbackUpdateCompletionFeedbackMutation`](docs/sdks/feedback/README.md#updatecompletionfeedback) - Update existing completion feedback
- [`useLlmFeedbackUpdateResponseFeedbackMutation`](docs/sdks/feedback/README.md#updateresponsefeedback) - Update existing response feedback
- [`useLlmFilesContent`](docs/sdks/files/README.md#content) - Retrieve file content
- [`useLlmFilesDeleteMutation`](docs/sdks/files/README.md#delete) - Delete file
- [`useLlmFilesGet`](docs/sdks/files/README.md#get) - Retrieve file
- [`useLlmFilesList`](docs/sdks/files/README.md#list) - List files
- [`useLlmFilesUploadMutation`](docs/sdks/files/README.md#upload) - Upload file
- [`useLlmImagesCreateMutation`](docs/sdks/images/README.md#create) - Generate images from text descriptions
- [`useLlmMcpVaultCreateCredentialMutation`](docs/sdks/mcpvault/README.md#createcredential) - Create MCP credential
- [`useLlmMcpVaultCreateServerMutation`](docs/sdks/mcpvault/README.md#createserver) - Create MCP server
- [`useLlmMcpVaultDeleteCredentialMutation`](docs/sdks/mcpvault/README.md#deletecredential) - Delete MCP credential
- [`useLlmMcpVaultDeleteServerMutation`](docs/sdks/mcpvault/README.md#deleteserver) - Delete MCP server
- [`useLlmMcpVaultGetServer`](docs/sdks/mcpvault/README.md#getserver) - Retrieve MCP server
- [`useLlmMcpVaultListCredentials`](docs/sdks/mcpvault/README.md#listcredentials) - List MCP credentials
- [`useLlmMcpVaultListServers`](docs/sdks/mcpvault/README.md#listservers) - List MCP servers
- [`useLlmMcpVaultTestServerMutation`](docs/sdks/mcpvault/README.md#testserver) - Test MCP server
- [`useLlmMcpVaultUpdateServerMutation`](docs/sdks/mcpvault/README.md#updateserver) - Update MCP server
- [`useLlmMemoryStoresCreateEntryMutation`](docs/sdks/memorystores/README.md#createentry) - Create memory entry
- [`useLlmMemoryStoresCreateMutation`](docs/sdks/memorystores/README.md#create) - Create memory store
- [`useLlmMemoryStoresDeleteEntryMutation`](docs/sdks/memorystores/README.md#deleteentry) - Delete memory entry
- [`useLlmMemoryStoresDeleteMutation`](docs/sdks/memorystores/README.md#delete) - Delete memory store
- [`useLlmMemoryStoresGet`](docs/sdks/memorystores/README.md#get) - Retrieve memory store
- [`useLlmMemoryStoresGetEntry`](docs/sdks/memorystores/README.md#getentry) - Retrieve memory entry
- [`useLlmMemoryStoresList`](docs/sdks/memorystores/README.md#list) - List memory stores
- [`useLlmMemoryStoresListEntries`](docs/sdks/memorystores/README.md#listentries) - List memory entries
- [`useLlmMemoryStoresUpdateEntryMutation`](docs/sdks/memorystores/README.md#updateentry) - Update memory entry
- [`useLlmMemoryStoresUpdateMutation`](docs/sdks/memorystores/README.md#update) - Update memory store
- [`useLlmModelsActivateRegistryEntryMutation`](docs/sdks/models/README.md#activateregistryentry) - Activate a catalog entry
- [`useLlmModelsAddCatalogEntryMutation`](docs/sdks/models/README.md#addcatalogentry) - Define a BYO catalog model
- [`useLlmModelsAddCatalogOrgAccessMutation`](docs/sdks/models/README.md#addcatalogorgaccess) - Add cluster model access for an organization
- [`useLlmModelsCheckCatalogHealthMutation`](docs/sdks/models/README.md#checkcataloghealth) - Check a BYO catalog model's health
- [`useLlmModelsClearClusterPriceMutation`](docs/sdks/models/README.md#clearclusterprice) - Clear a cluster-default model price
- [`useLlmModelsClearOrgPriceMutation`](docs/sdks/models/README.md#clearorgprice) - Clear an org price override
- [`useLlmModelsDeactivateRegistryEntryMutation`](docs/sdks/models/README.md#deactivateregistryentry) - Deactivate a model registry name
- [`useLlmModelsDeleteCatalogEntryMutation`](docs/sdks/models/README.md#deletecatalogentry) - Remove a BYO catalog model
- [`useLlmModelsDeleteOrgAutoModelMutation`](docs/sdks/models/README.md#deleteorgautomodel) - Clear this org's auto-model override for an endpoint
- [`useLlmModelsGet`](docs/sdks/models/README.md#get) - Retrieve a model
- [`useLlmModelsGetClusterCurrency`](docs/sdks/models/README.md#getclustercurrency) - Get the cluster currency
- [`useLlmModelsList`](docs/sdks/models/README.md#list) - List available models
- [`useLlmModelsListCatalog`](docs/sdks/models/README.md#listcatalog) - List the organization's model catalog
- [`useLlmModelsListCatalogModelAccess`](docs/sdks/models/README.md#listcatalogmodelaccess) - List organizations with access to a cluster model
- [`useLlmModelsListCatalogOrgAccess`](docs/sdks/models/README.md#listcatalogorgaccess) - List an organization's cluster model access
- [`useLlmModelsListClusterPrices`](docs/sdks/models/README.md#listclusterprices) - List cluster-default model prices
- [`useLlmModelsListEffectivePrices`](docs/sdks/models/README.md#listeffectiveprices) - List effective prices for the caller's models
- [`useLlmModelsListOrgAutoModels`](docs/sdks/models/README.md#listorgautomodels) - List this org's auto-model overrides
- [`useLlmModelsListOrgPrices`](docs/sdks/models/README.md#listorgprices) - List an org's price overrides
- [`useLlmModelsListRegistry`](docs/sdks/models/README.md#listregistry) - List the organization's active model registry
- [`useLlmModelsPutOrgAutoModelMutation`](docs/sdks/models/README.md#putorgautomodel) - Set this org's auto policy for an endpoint
- [`useLlmModelsReplaceCatalogOrgAccessMutation`](docs/sdks/models/README.md#replacecatalogorgaccess) - Replace an organization's cluster model access
- [`useLlmModelsSetClusterCurrencyMutation`](docs/sdks/models/README.md#setclustercurrency) - Set the cluster currency
- [`useLlmModelsSetClusterPriceMutation`](docs/sdks/models/README.md#setclusterprice) - Set a cluster-default model price
- [`useLlmModelsSetOrgPriceMutation`](docs/sdks/models/README.md#setorgprice) - Set an org price override
- [`useLlmModelsUpdateCatalogEntryMutation`](docs/sdks/models/README.md#updatecatalogentry) - Update a BYO catalog model
- [`useLlmPromptsCreateMutation`](docs/sdks/prompts/README.md#create) - Create a prompt
- [`useLlmPromptsCreateVersionMutation`](docs/sdks/prompts/README.md#createversion) - Create a new version
- [`useLlmPromptsDeleteMutation`](docs/sdks/prompts/README.md#delete) - Delete a prompt
- [`useLlmPromptsGet`](docs/sdks/prompts/README.md#get) - Get a prompt
- [`useLlmPromptsGetVersion`](docs/sdks/prompts/README.md#getversion) - Get a specific version
- [`useLlmPromptsList`](docs/sdks/prompts/README.md#list) - List prompts
- [`useLlmPromptsListVersions`](docs/sdks/prompts/README.md#listversions) - List versions
- [`useLlmPromptsRollbackMutation`](docs/sdks/prompts/README.md#rollback) - Rollback to a version
- [`useLlmPromptsUpdateMutation`](docs/sdks/prompts/README.md#update) - Update a prompt
- [`useLlmResponsesCancelMutation`](docs/sdks/responses/README.md#cancel) - Cancel an in-progress background response
- [`useLlmResponsesCompactMutation`](docs/sdks/responses/README.md#compact) - Compact a conversation
- [`useLlmResponsesCreateMutation`](docs/sdks/responses/README.md#create) - Create an agent-powered response with tool support
- [`useLlmResponsesDeleteMutation`](docs/sdks/responses/README.md#delete) - Permanently delete a response and its data
- [`useLlmResponsesGet`](docs/sdks/responses/README.md#get) - Retrieve response by ID with status and results
- [`useLlmResponsesList`](docs/sdks/responses/README.md#list) - List all responses with pagination
- [`useLlmResponsesListInputItems`](docs/sdks/responses/README.md#listinputitems) - List paginated input items for a response
- [`useLlmResponsesUpdateMutation`](docs/sdks/responses/README.md#update) - Update a response
- [`useLlmResponsesWakeMutation`](docs/sdks/responses/README.md#wake) - Wake a sleeping background response
- [`useLlmSkillsContent`](docs/sdks/skills/README.md#content) - Download skill content
- [`useLlmSkillsCreateMutation`](docs/sdks/skills/README.md#create) - Create skill
- [`useLlmSkillsCreateVersionMutation`](docs/sdks/skills/README.md#createversion) - Create skill version
- [`useLlmSkillsDeleteMutation`](docs/sdks/skills/README.md#delete) - Delete skill
- [`useLlmSkillsDeleteVersionMutation`](docs/sdks/skills/README.md#deleteversion) - Delete skill version
- [`useLlmSkillsGet`](docs/sdks/skills/README.md#get) - Retrieve skill
- [`useLlmSkillsGetVersion`](docs/sdks/skills/README.md#getversion) - Retrieve skill version
- [`useLlmSkillsList`](docs/sdks/skills/README.md#list) - List skills
- [`useLlmSkillsListPreconfigured`](docs/sdks/skills/README.md#listpreconfigured) - List preconfigured skills
- [`useLlmSkillsListVersions`](docs/sdks/skills/README.md#listversions) - List skill versions
- [`useLlmSkillsUpdateMutation`](docs/sdks/skills/README.md#update) - Update skill
- [`useLlmSkillsVersionContent`](docs/sdks/skills/README.md#versioncontent) - Download skill version content
- [`useLlmSpeechDeleteTranscriptionHistoryMutation`](docs/sdks/speech/README.md#deletetranscriptionhistory) - Delete speech-to-text history item
- [`useLlmSpeechDeleteTtsHistoryMutation`](docs/sdks/speech/README.md#deletettshistory) - Delete text-to-speech history item
- [`useLlmSpeechGetTranscriptionHistory`](docs/sdks/speech/README.md#gettranscriptionhistory) - Retrieve speech-to-text history item
- [`useLlmSpeechGetTranscriptionHistoryContent`](docs/sdks/speech/README.md#gettranscriptionhistorycontent) - Retrieve speech-to-text audio
- [`useLlmSpeechGetTtsHistory`](docs/sdks/speech/README.md#getttshistory) - Retrieve text-to-speech history item
- [`useLlmSpeechGetTtsHistoryContent`](docs/sdks/speech/README.md#getttshistorycontent) - Retrieve text-to-speech audio
- [`useLlmSpeechListTranscriptionHistory`](docs/sdks/speech/README.md#listtranscriptionhistory) - List speech-to-text history
- [`useLlmSpeechListTtsHistory`](docs/sdks/speech/README.md#listttshistory) - List text-to-speech history
- [`useLlmSpeechLivekitTokenMutation`](docs/sdks/speech/README.md#livekittoken) - Generate LiveKit room token
- [`useLlmSpeechSpeakMutation`](docs/sdks/speech/README.md#speak) - Text to speech
- [`useLlmSpeechSpeakStreamingMutation`](docs/sdks/speech/README.md#speakstreaming) - Streaming text to speech
- [`useLlmSpeechTranscribeMutation`](docs/sdks/speech/README.md#transcribe) - Speech to text transcription
- [`useLlmUsageClassify`](docs/sdks/sdkusage/README.md#classify) - Get classify usage
- [`useLlmUsageCompletions`](docs/sdks/sdkusage/README.md#completions) - Get completions usage
- [`useLlmUsageConversations`](docs/sdks/sdkusage/README.md#conversations) - Get conversations usage
- [`useLlmUsageCosts`](docs/sdks/sdkusage/README.md#costs) - Get cost by model
- [`useLlmUsageEmbeddings`](docs/sdks/sdkusage/README.md#embeddings) - Get embeddings usage
- [`useLlmUsageExtract`](docs/sdks/sdkusage/README.md#extract) - Get extract usage
- [`useLlmUsageFiles`](docs/sdks/sdkusage/README.md#files) - Get files usage
- [`useLlmUsageResponses`](docs/sdks/sdkusage/README.md#responses) - Get responses usage
- [`useLlmUsageVectorStores`](docs/sdks/sdkusage/README.md#vectorstores) - Get vector stores usage
- [`useLlmVectorStoresCancelFileBatchMutation`](docs/sdks/vectorstores/README.md#cancelfilebatch) - Cancel batch file processing
- [`useLlmVectorStoresCreateFileBatchMutation`](docs/sdks/vectorstores/README.md#createfilebatch) - Batch add multiple files to vector store
- [`useLlmVectorStoresCreateFileMutation`](docs/sdks/vectorstores/README.md#createfile) - Add a file to a vector store
- [`useLlmVectorStoresCreateMutation`](docs/sdks/vectorstores/README.md#create) - Create a vector store
- [`useLlmVectorStoresDeleteFileMutation`](docs/sdks/vectorstores/README.md#deletefile) - Remove file from vector store
- [`useLlmVectorStoresDeleteMutation`](docs/sdks/vectorstores/README.md#delete) - Delete a vector store
- [`useLlmVectorStoresGet`](docs/sdks/vectorstores/README.md#get) - Retrieve a vector store
- [`useLlmVectorStoresGetFile`](docs/sdks/vectorstores/README.md#getfile) - Retrieve a vector store file
- [`useLlmVectorStoresGetFileBatch`](docs/sdks/vectorstores/README.md#getfilebatch) - Retrieve file batch status
- [`useLlmVectorStoresGetFileContent`](docs/sdks/vectorstores/README.md#getfilecontent) - Retrieve parsed file content
- [`useLlmVectorStoresList`](docs/sdks/vectorstores/README.md#list) - List vector stores
- [`useLlmVectorStoresListFiles`](docs/sdks/vectorstores/README.md#listfiles) - List files in a vector store
- [`useLlmVectorStoresListFilesInBatch`](docs/sdks/vectorstores/README.md#listfilesinbatch) - List files in a batch
- [`useLlmVectorStoresSearchMutation`](docs/sdks/vectorstores/README.md#search) - Search a vector store
- [`useLlmVectorStoresUpdateFileMutation`](docs/sdks/vectorstores/README.md#updatefile) - Update file attributes
- [`useLlmVectorStoresUpdateMutation`](docs/sdks/vectorstores/README.md#update) - Modify a vector store
- [`usePermissionsLlmCheck`](docs/sdks/sdkllm/README.md#check) - Check user permission
- [`usePermissionsLlmGrantMutation`](docs/sdks/sdkllm/README.md#grant) - Grant permission to a user or make public
- [`usePermissionsLlmRevokeMutation`](docs/sdks/sdkllm/README.md#revoke) - Revoke permission from a user or remove public access
- [`useReposCreateMutation`](docs/sdks/repos/README.md#create) - Create a repository
- [`useReposDeleteMutation`](docs/sdks/repos/README.md#delete) - Delete a repository
- [`useReposGet`](docs/sdks/repos/README.md#get) - Get a repository
- [`useReposList`](docs/sdks/repos/README.md#list) - List the caller's org's repositories
- [`useReposTagsDeleteMutation`](docs/sdks/tags/README.md#delete) - Delete an image tag
- [`useReposTagsList`](docs/sdks/tags/README.md#list) - List an image repository's tags
- [`useReposUpdateMutation`](docs/sdks/repos/README.md#update) - Update a repository's labels
- [`useSandboxCreateMutation`](docs/sdks/sandbox/README.md#create) - Create Session
- [`useSandboxDownloadArchiveMutation`](docs/sdks/sandbox/README.md#downloadarchive) - Download Workspace Archive
- [`useSandboxDownloadFile`](docs/sdks/sandbox/README.md#downloadfile) - Download Workspace File
- [`useSandboxEnvironmentsCreateMutation`](docs/sdks/environments/README.md#create) - Create Environment
- [`useSandboxEnvironmentsDeleteMutation`](docs/sdks/environments/README.md#delete) - Delete Environment
- [`useSandboxEnvironmentsGet`](docs/sdks/environments/README.md#get) - Get Environment
- [`useSandboxEnvironmentsList`](docs/sdks/environments/README.md#list) - List Environments
- [`useSandboxEnvironmentsRunSetupMutation`](docs/sdks/environments/README.md#runsetup) - Run Environment Setup
- [`useSandboxEnvironmentsUpdateMutation`](docs/sdks/environments/README.md#update) - Update Environment
- [`useSandboxGet`](docs/sdks/sandbox/README.md#get) - Get Session
- [`useSandboxGetBrowserUrl`](docs/sdks/sandbox/README.md#getbrowserurl) - Get Browser Session URL
- [`useSandboxGetPricing`](docs/sdks/sandbox/README.md#getpricing) - Get Sandbox Pricing
- [`useSandboxGetWorkspace`](docs/sdks/sandbox/README.md#getworkspace) - Get Workspace Manifest
- [`useSandboxGithubAddSessionRepositoryMutation`](docs/sdks/github/README.md#addsessionrepository) - Add Session Repository
- [`useSandboxGithubCloneRepositoryMutation`](docs/sdks/github/README.md#clonerepository) - Clone GitHub Repository into Session
- [`useSandboxGithubConnectMutation`](docs/sdks/github/README.md#connect) - Connect GitHub Account
- [`useSandboxGithubCreateAuthorizationIntentMutation`](docs/sdks/github/README.md#createauthorizationintent) - Start GitHub Authorization
- [`useSandboxGithubCreateOrUpdatePullRequestMutation`](docs/sdks/github/README.md#createorupdatepullrequest) - Create or Update Pull Request
- [`useSandboxGithubDisconnectMutation`](docs/sdks/github/README.md#disconnect) - Disconnect GitHub Account
- [`useSandboxGithubDismissSessionRepositoryMutation`](docs/sdks/github/README.md#dismisssessionrepository) - Dismiss Failed Session Repository
- [`useSandboxGithubGetConnection`](docs/sdks/github/README.md#getconnection) - Get GitHub Connection
- [`useSandboxGithubListRepositories`](docs/sdks/github/README.md#listrepositories) - List GitHub Repositories
- [`useSandboxGithubListSessionRepositories`](docs/sdks/github/README.md#listsessionrepositories) - List Session Repositories
- [`useSandboxGithubPushMutation`](docs/sdks/github/README.md#push) - Push Session to GitHub
- [`useSandboxGithubRefreshRepositoriesMutation`](docs/sdks/github/README.md#refreshrepositories) - Refresh GitHub Repositories
- [`useSandboxGithubResolveReferenceMutation`](docs/sdks/github/README.md#resolvereference) - Resolve GitHub Reference
- [`useSandboxList`](docs/sdks/sandbox/README.md#list) - List Sessions
- [`useSandboxProxyBrowserPortRequest`](docs/sdks/sandbox/README.md#proxybrowserportrequest) - Proxy Browser Port Request
- [`useSandboxRunCodeMutation`](docs/sdks/sandbox/README.md#runcode) - Run Code
- [`useSandboxRunCommandMutation`](docs/sdks/sandbox/README.md#runcommand) - Run Command
- [`useSandboxSetPricingMutation`](docs/sdks/sandbox/README.md#setpricing) - Set Sandbox Pricing
- [`useSandboxTerminateMutation`](docs/sdks/sandbox/README.md#terminate) - Terminate Session
- [`useSandboxUploadArchiveMutation`](docs/sdks/sandbox/README.md#uploadarchive) - Upload Workspace Archive
- [`useSandboxUploadFileMutation`](docs/sdks/sandbox/README.md#uploadfile) - Upload Workspace File
- [`useSessionExchangeSessionTokenMutation`](docs/sdks/session/README.md#exchangesessiontoken) - Exchange a live session for a delegated access token
- [`useSessionGetPendingInvitation`](docs/sdks/session/README.md#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
- [`useTrackingExperimentsCreateMutation`](docs/sdks/experiments/README.md#create) - Create
- [`useTrackingExperimentsDeleteMutation`](docs/sdks/experiments/README.md#delete) - Delete
- [`useTrackingExperimentsGet`](docs/sdks/experiments/README.md#get) - Get
- [`useTrackingExperimentsGetByName`](docs/sdks/experiments/README.md#getbyname) - GetByName
- [`useTrackingExperimentsSearchMutation`](docs/sdks/experiments/README.md#search) - Search
- [`useTrackingRunsCreateMutation`](docs/sdks/runs/README.md#create) - Create
- [`useTrackingRunsDeleteMutation`](docs/sdks/runs/README.md#delete) - Delete
- [`useTrackingRunsDeleteTagMutation`](docs/sdks/runs/README.md#deletetag) - DeleteTag
- [`useTrackingRunsGet`](docs/sdks/runs/README.md#get) - Get
- [`useTrackingRunsGetMetricHistory`](docs/sdks/runs/README.md#getmetrichistory) - GetMetricHistory
- [`useTrackingRunsLogBatchMutation`](docs/sdks/runs/README.md#logbatch) - LogBatch
- [`useTrackingRunsLogInputsMutation`](docs/sdks/runs/README.md#loginputs) - LogInputs
- [`useTrackingRunsLogMetricMutation`](docs/sdks/runs/README.md#logmetric) - LogMetric
- [`useTrackingRunsLogParameterMutation`](docs/sdks/runs/README.md#logparameter) - LogParameter
- [`useTrackingRunsRestoreMutation`](docs/sdks/runs/README.md#restore) - Restore
- [`useTrackingRunsSearchMutation`](docs/sdks/runs/README.md#search) - Search
- [`useTrackingRunsSetTagMutation`](docs/sdks/runs/README.md#settag) - SetTag
- [`useTrackingRunsUpdateMutation`](docs/sdks/runs/README.md#update) - Update
- [`useUsageCosts`](docs/sdks/usage/README.md#costs) - Aggregate cost by dimension
- [`useUsageSandbox`](docs/sdks/usage/README.md#sandbox) - Get Sandbox Usage
- ~~[`useAuthApiKeyGetJwtFromKeyMutation`](docs/sdks/apikey/README.md#getjwtfromkey)~~ - Exchange API key for a JWT token :warning: **Deprecated** Use [`useAuthApiKeysExchangeTokenMutation`](docs/sdks/apikeys/README.md#exchangetoken) instead.
- ~~[`useLlmChatCreateChatMutation`](docs/sdks/chat/README.md#createchat)~~ - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
- ~~[`useLlmChatStreamMutation`](docs/sdks/chat/README.md#stream)~~ - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**
- ~~[`useLlmFineTuningCancelMutation`](docs/sdks/finetuning/README.md#cancel)~~ - [Deprecated] Cancel a fine-tuning job :warning: **Deprecated**
- ~~[`useLlmFineTuningCreateMutation`](docs/sdks/finetuning/README.md#create)~~ - [Deprecated] Create a fine-tuning job :warning: **Deprecated**
- ~~[`useLlmFineTuningList`](docs/sdks/finetuning/README.md#list)~~ - [Deprecated] List fine-tuning jobs :warning: **Deprecated**
- ~~[`useLlmFineTuningListCheckpoints`](docs/sdks/finetuning/README.md#listcheckpoints)~~ - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**
- ~~[`useLlmFineTuningListEvents`](docs/sdks/finetuning/README.md#listevents)~~ - [Deprecated] List fine-tuning events :warning: **Deprecated**
- ~~[`useLlmFineTuningPauseMutation`](docs/sdks/finetuning/README.md#pause)~~ - [Deprecated] Pause a fine-tuning job :warning: **Deprecated**
- ~~[`useLlmFineTuningResumeMutation`](docs/sdks/finetuning/README.md#resume)~~ - [Deprecated] Resume a fine-tuning job :warning: **Deprecated**
- ~~[`useLlmFineTuningRetrieve`](docs/sdks/finetuning/README.md#retrieve)~~ - [Deprecated] Retrieve a fine-tuning job :warning: **Deprecated**
- ~~[`useSandboxGetUrl`](docs/sdks/sandbox/README.md#geturl)~~ - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [`useSandboxGetBrowserUrl`](docs/sdks/sandbox/README.md#getbrowserurl) instead.

</details>
<!-- End React hooks with TanStack Query [react-query] -->

<!-- Start Server-sent event streaming [eventstream] -->
## Server-sent event streaming

[Server-sent events][mdn-sse] are used to stream content from certain
operations. These operations will expose the stream as an async iterable that
can be consumed using a [`for await...of`][mdn-for-await-of] loop. The loop will
terminate when the server no longer has any events to send and closes the
underlying connection.

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.responses.create({
    responsesCreateRequest: {
      model: "meetkai:functionary-urdu-mini-pak",
      input: "What is the capital of France?",
    },
  });

  console.log(result);
}

run();

```

[mdn-sse]: https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events
[mdn-for-await-of]: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/for-await...of
<!-- End Server-sent event streaming [eventstream] -->

<!-- Start File uploads [file-upload] -->
## File uploads

Certain SDK methods accept files as part of a multi-part request. It is possible and typically recommended to upload files as a stream rather than reading the entire contents into memory. This avoids excessive memory consumption and potentially crashing with out-of-memory errors when working with very large files. The following example demonstrates how to attach a file stream to a request.

> [!TIP]
>
> Depending on your JavaScript runtime, there are convenient utilities that return a handle to a file without reading the entire contents into memory:
>
> - **Node.js v20+:** Since v20, Node.js comes with a native `openAsBlob` function in [`node:fs`](https://nodejs.org/docs/latest-v20.x/api/fs.html#fsopenasblobpath-options).
> - **Bun:** The native [`Bun.file`](https://bun.sh/docs/api/file-io#reading-files-bun-file) function produces a file handle that can be used for streaming file uploads.
> - **Browsers:** All supported browsers return an instance to a [`File`](https://developer.mozilla.org/en-US/docs/Web/API/File) when reading the value from an `<input type="file">` element.
> - **Node.js v18:** A file stream can be created using the `fileFrom` helper from [`fetch-blob/from.js`](https://www.npmjs.com/package/fetch-blob).

```typescript
import { SDK } from "@meetkai/mka1";
import { openAsBlob } from "node:fs";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.files.upload({
    requestBody: {
      file: await openAsBlob("example.file"),
      purpose: "assistants",
    },
  });

  console.log(result);
}

run();

```
<!-- End File uploads [file-upload] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries.  If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API.  However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply provide a retryConfig object to the call:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  }, {
    retries: {
      strategy: "backoff",
      backoff: {
        initialInterval: 1,
        maxInterval: 50,
        exponent: 1.1,
        maxElapsedTime: 100,
      },
      retryConnectionErrors: false,
    },
  });
}

run();

```

If you'd like to override the default retry strategy for all operations that support retries, you can provide a retryConfig at SDK initialization:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  retryConfig: {
    strategy: "backoff",
    backoff: {
      initialInterval: 1,
      maxInterval: 50,
      exponent: 1.1,
      maxElapsedTime: 100,
    },
    retryConnectionErrors: false,
  },
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`SDKError`](./src/models/errors/sdkerror.ts) is the base class for all HTTP error responses. It has the following properties:

| Property            | Type       | Description                                                                             |
| ------------------- | ---------- | --------------------------------------------------------------------------------------- |
| `error.message`     | `string`   | Error message                                                                           |
| `error.statusCode`  | `number`   | HTTP response status code eg `404`                                                      |
| `error.headers`     | `Headers`  | HTTP response headers                                                                   |
| `error.body`        | `string`   | HTTP body. Can be empty string if no body is returned.                                  |
| `error.rawResponse` | `Response` | Raw HTTP response                                                                       |
| `error.data$`       |            | Optional. Some errors may contain structured data. [See Error Classes](#error-classes). |

### Example
```typescript
import { SDK } from "@meetkai/mka1";
import * as errors from "@meetkai/mka1/models/errors";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  try {
    const result = await sdk.llm.files.content({
      fileId: "file-abc123",
    });

    console.log(result);
  } catch (error) {
    // The base class for HTTP error responses
    if (error instanceof errors.SDKError) {
      console.log(error.message);
      console.log(error.statusCode);
      console.log(error.body);
      console.log(error.headers);

      // Depending on the method different errors may be thrown
      if (error instanceof errors.GetFileContentResponseBody) {
        console.log(error.data$.error); // errors.GetFileContentLlmFilesResponse400Error
      }
    }
  }
}

run();

```

### Error Classes
**Primary error:**
* [`SDKError`](./src/models/errors/sdkerror.ts): The base class for HTTP error responses.

<details><summary>Less common errors (310)</summary>

<br />

**Network errors:**
* [`ConnectionError`](./src/models/errors/httpclienterrors.ts): HTTP client was unable to make a request to a server.
* [`RequestTimeoutError`](./src/models/errors/httpclienterrors.ts): HTTP request timed out due to an AbortSignal signal.
* [`RequestAbortedError`](./src/models/errors/httpclienterrors.ts): HTTP request was aborted by the client.
* [`InvalidRequestError`](./src/models/errors/httpclienterrors.ts): Any input used to create a request is invalid.
* [`UnexpectedClientError`](./src/models/errors/httpclienterrors.ts): Unrecognised or unexpected error.


**Inherit from [`SDKError`](./src/models/errors/sdkerror.ts)**:
* [`HTTPValidationError`](./src/models/errors/httpvalidationerror.ts): Validation Error. Status code `422`. Applicable to 39 of 459 methods.*
* [`ErrorEnvelope`](./src/models/errors/errorenvelope.ts): Error response. Applicable to 27 of 459 methods.*
* [`FeatureFlagError`](./src/models/errors/featureflagerror.ts): The request is malformed or fails validation. Applicable to 22 of 459 methods.*
* [`AnalyticsError`](./src/models/errors/analyticserror.ts): Request failed. Applicable to 12 of 459 methods.*
* [`RepoError`](./src/models/errors/repoerror.ts): The uniform error envelope. `error` is a stable machine-readable code (never an internal reason); `correlation_id` echoes the request's `X-Correlation-ID` for log correlation. Applicable to 7 of 459 methods.*
* [`ExchangeSessionTokenResponseBody`](./src/models/errors/exchangesessiontokenresponsebody.ts): Invalid request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetFileContentResponseBody`](./src/models/errors/getfilecontentresponsebody.ts): Invalid request - File ID is required. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateScopedApiKeyResponseBody`](./src/models/errors/createscopedapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListScopedApiKeysResponseBody`](./src/models/errors/listscopedapikeysresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateScopedApiKeyResponseBody`](./src/models/errors/updatescopedapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedApiKeyResponseBody`](./src/models/errors/regeneratescopedapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ExchangeApiKeyTokenResponseBody`](./src/models/errors/exchangeapikeytokenresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateTeamResponseBody`](./src/models/errors/createteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListTeamsResponseBody`](./src/models/errors/listteamsresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetTeamResponseBody`](./src/models/errors/getteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateTeamResponseBody`](./src/models/errors/updateteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteTeamResponseBody`](./src/models/errors/deleteteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberResponseBody`](./src/models/errors/addteammemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersResponseBody`](./src/models/errors/listteammembersresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberResponseBody`](./src/models/errors/removeteammemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountResponseBody`](./src/models/errors/createserviceaccountresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsResponseBody`](./src/models/errors/listserviceaccountsresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountResponseBody`](./src/models/errors/getserviceaccountresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountResponseBody`](./src/models/errors/deleteserviceaccountresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountApiKeysResponseBody`](./src/models/errors/listserviceaccountapikeysresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountApiKeyResponseBody`](./src/models/errors/updateserviceaccountapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountApiKeyResponseBody`](./src/models/errors/deleteserviceaccountapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountApiKeyResponseBody`](./src/models/errors/regenerateserviceaccountapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdResponseBody`](./src/models/errors/getorgbyidresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationResponseBody`](./src/models/errors/updateorganizationresponsebody.ts): Invalid JSON or metadata patch. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaResponseBody`](./src/models/errors/getorgquotaresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaResponseBody`](./src/models/errors/updateorgquotaresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitResponseBody`](./src/models/errors/getorgratelimitresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitResponseBody`](./src/models/errors/updateorgratelimitresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteResponseBody`](./src/models/errors/createclusterinviteresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesResponseBody`](./src/models/errors/listclusterinvitesresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteResponseBody`](./src/models/errors/updateclusterinviteresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteResponseBody`](./src/models/errors/revokeclusterinviteresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsResponseBody`](./src/models/errors/listclusterorgsresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgResponseBody`](./src/models/errors/getclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgResponseBody`](./src/models/errors/deleteclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersResponseBody`](./src/models/errors/inviteclusterorgmembersresponsebody.ts): Invalid body or batch size. Status code `400`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgResponseBody`](./src/models/errors/suspendclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgResponseBody`](./src/models/errors/unsuspendclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyResponseBody`](./src/models/errors/reissueownerkeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoResponseBody`](./src/models/errors/getclusterinviteinforesponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteResponseBody`](./src/models/errors/acceptclusterinviteresponsebody.ts): Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyResponseBody`](./src/models/errors/getjwtfromkeyresponsebody.ts): Invalid request body. Status code `400`. Applicable to 1 of 459 methods.*
* [`GetPendingInvitationResponseBody`](./src/models/errors/getpendinginvitationresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenSessionResponseBody`](./src/models/errors/exchangesessiontokensessionresponsebody.ts): Missing, invalid, revoked or expiring session. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetFileContentLlmFilesResponseBody`](./src/models/errors/getfilecontentllmfilesresponsebody.ts): Unauthorized - Invalid or missing authentication. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListScopedApiKeysAuthApiKeysResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateTeamAuthTeamsResponseBody`](./src/models/errors/createteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListTeamsAuthTeamsResponseBody`](./src/models/errors/listteamsauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetTeamAuthTeamsResponseBody`](./src/models/errors/getteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateTeamAuthTeamsResponseBody`](./src/models/errors/updateteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteTeamAuthTeamsResponseBody`](./src/models/errors/deleteteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberAuthTeamsResponseBody`](./src/models/errors/addteammemberauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersAuthTeamsResponseBody`](./src/models/errors/listteammembersauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberAuthTeamsResponseBody`](./src/models/errors/removeteammemberauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountAuthServiceAccountsResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdAuthOrgsResponseBody`](./src/models/errors/getorgbyidauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponseBody`](./src/models/errors/updateorganizationauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaAuthOrgsResponseBody`](./src/models/errors/getorgquotaauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaAuthOrgsResponseBody`](./src/models/errors/updateorgquotaauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitAuthOrgsResponseBody`](./src/models/errors/getorgratelimitauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteAuthClusterResponseBody`](./src/models/errors/createclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesAuthClusterResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteAuthClusterResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteAuthClusterResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsAuthClusterResponseBody`](./src/models/errors/listclusterorgsauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgAuthClusterResponseBody`](./src/models/errors/getclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgAuthClusterResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersAuthClusterResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgAuthClusterResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgAuthClusterResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyAuthClusterResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoAuthClusterResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteAuthClusterResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyAuthApiKeyResponseBody`](./src/models/errors/getjwtfromkeyauthapikeyresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
* [`GetPendingInvitationSessionResponseBody`](./src/models/errors/getpendinginvitationsessionresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenSessionResponseResponseBody`](./src/models/errors/exchangesessiontokensessionresponseresponsebody.ts): Active organization or team is missing or inaccessible. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponseResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListScopedApiKeysAuthApiKeysResponseResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponseResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponseResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponseResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateTeamAuthTeamsResponseResponseBody`](./src/models/errors/createteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListTeamsAuthTeamsResponseResponseBody`](./src/models/errors/listteamsauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetTeamAuthTeamsResponseResponseBody`](./src/models/errors/getteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateTeamAuthTeamsResponseResponseBody`](./src/models/errors/updateteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteTeamAuthTeamsResponseResponseBody`](./src/models/errors/deleteteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberAuthTeamsResponseResponseBody`](./src/models/errors/addteammemberauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersAuthTeamsResponseResponseBody`](./src/models/errors/listteammembersauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberAuthTeamsResponseResponseBody`](./src/models/errors/removeteammemberauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponseResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponseResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountAuthServiceAccountsResponseResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponseResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponseResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponseResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponseResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponseResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdAuthOrgsResponseResponseBody`](./src/models/errors/getorgbyidauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponseResponseBody`](./src/models/errors/updateorganizationauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaAuthOrgsResponseResponseBody`](./src/models/errors/getorgquotaauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaAuthOrgsResponseResponseBody`](./src/models/errors/updateorgquotaauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitAuthOrgsResponseResponseBody`](./src/models/errors/getorgratelimitauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponseResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/createclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesAuthClusterResponseResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsAuthClusterResponseResponseBody`](./src/models/errors/listclusterorgsauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/getclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersAuthClusterResponseResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyAuthClusterResponseResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoAuthClusterResponseResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
* [`GetFileContentLlmFilesResponseResponseBody`](./src/models/errors/getfilecontentllmfilesresponseresponsebody.ts): File not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse404ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse404ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse404ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse404ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse404ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/createteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListTeamsAuthTeamsResponse404ResponseBody`](./src/models/errors/listteamsauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/getteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/updateteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/deleteteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberAuthTeamsResponse404ResponseBody`](./src/models/errors/addteammemberauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersAuthTeamsResponse404ResponseBody`](./src/models/errors/listteammembersauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberAuthTeamsResponse404ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdAuthOrgsResponse404ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponse404ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaAuthOrgsResponse404ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse404ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitAuthOrgsResponse404ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse404ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesAuthClusterResponse404ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsAuthClusterResponse404ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse404ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyAuthClusterResponse404ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoAuthClusterResponse404ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 459 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse409ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse409ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse409ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse409ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse409ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/createteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListTeamsAuthTeamsResponse409ResponseBody`](./src/models/errors/listteamsauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/getteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/updateteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/deleteteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberAuthTeamsResponse409ResponseBody`](./src/models/errors/addteammemberauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersAuthTeamsResponse409ResponseBody`](./src/models/errors/listteammembersauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberAuthTeamsResponse409ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdAuthOrgsResponse409ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponse409ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaAuthOrgsResponse409ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse409ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitAuthOrgsResponse409ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse409ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesAuthClusterResponse409ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsAuthClusterResponse409ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse409ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyAuthClusterResponse409ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoAuthClusterResponse409ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse410ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse410ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse410ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse410ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse410ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/createteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListTeamsAuthTeamsResponse410ResponseBody`](./src/models/errors/listteamsauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/getteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/updateteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/deleteteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberAuthTeamsResponse410ResponseBody`](./src/models/errors/addteammemberauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersAuthTeamsResponse410ResponseBody`](./src/models/errors/listteammembersauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberAuthTeamsResponse410ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdAuthOrgsResponse410ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponse410ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaAuthOrgsResponse410ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse410ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitAuthOrgsResponse410ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse410ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesAuthClusterResponse410ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsAuthClusterResponse410ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse410ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyAuthClusterResponse410ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoAuthClusterResponse410ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenSessionResponse413ResponseBody`](./src/models/errors/exchangesessiontokensessionresponse413responsebody.ts): Request body exceeds the endpoint's 4 KiB limit. Status code `413`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponse413ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse413responsebody.ts): Request or merged metadata exceeds 64 KiB. Status code `413`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenSessionResponse429ResponseBody`](./src/models/errors/exchangesessiontokensessionresponse429responsebody.ts): Per-session or per-user mint rate exceeded. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse429ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse429ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse429ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse429ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse429ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/createteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListTeamsAuthTeamsResponse429ResponseBody`](./src/models/errors/listteamsauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/getteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/updateteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/deleteteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`AddTeamMemberAuthTeamsResponse429ResponseBody`](./src/models/errors/addteammemberauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListTeamMembersAuthTeamsResponse429ResponseBody`](./src/models/errors/listteammembersauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RemoveTeamMemberAuthTeamsResponse429ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdAuthOrgsResponse429ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponse429ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgQuotaAuthOrgsResponse429ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse429ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetOrgRateLimitAuthOrgsResponse429ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse429ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`CreateClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListClusterInvitesAuthClusterResponse429ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UpdateClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`RevokeClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ListClusterOrgsAuthClusterResponse429ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`DeleteClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse429ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`SuspendClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ReissueOwnerKeyAuthClusterResponse429ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`GetClusterInviteInfoAuthClusterResponse429ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
* [`ExchangeSessionTokenSessionResponse500ResponseBody`](./src/models/errors/exchangesessiontokensessionresponse500responsebody.ts): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetFileContentLlmFilesResponse500ResponseBody`](./src/models/errors/getfilecontentllmfilesresponse500responsebody.ts): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetOrgByIdAuthOrgsResponse500ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse500responsebody.ts): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
* [`UpdateOrganizationAuthOrgsResponse500ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse500responsebody.ts): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
* [`GetJwtFromKeyAuthApiKeyResponseResponseBody`](./src/models/errors/getjwtfromkeyauthapikeyresponseresponsebody.ts): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
* [`AcceptClusterInviteAuthClusterResponse503ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse503responsebody.ts): The invitation spend limit could not be confirmed. The organization and invitation claim were rolled back; retry acceptance. Status code `503`. Applicable to 1 of 459 methods.*
* [`ResponseValidationError`](./src/models/errors/responsevalidationerror.ts): Type mismatch between the data returned from the server and the structure expected by the SDK. See `error.rawValue` for the raw value and `error.pretty()` for a nicely formatted multi-line string.

</details>

\* Check [the method documentation](#available-resources-and-operations) to see if the error is applicable.
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIdx: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                   | Description                                            |
| --- | ------------------------ | ------------------------------------------------------ |
| 0   | `https://apigw.mka1.com` | MKA1 API Gateway                                       |
| 1   | `/`                      | Relative server URL (configurable via SDK constructor) |

#### Example

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  serverIdx: 0,
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverURL: string` optional parameter when initializing the SDK client instance. For example:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  serverURL: "https://apigw.mka1.com",
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```
<!-- End Server Selection [server] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The TypeScript SDK makes API calls using an `HTTPClient` that wraps the native
[Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API). This
client is a thin wrapper around `fetch` and provides the ability to attach hooks
around the request lifecycle that can be used to modify the request or handle
errors and response.

The `HTTPClient` constructor takes an optional `fetcher` argument that can be
used to integrate a third-party HTTP client or when writing tests to mock out
the HTTP client and feed in fixtures.

The following example shows how to:
- route requests through a proxy server using [undici](https://www.npmjs.com/package/undici)'s ProxyAgent
- use the `"beforeRequest"` hook to add a custom header and a timeout to requests
- use the `"requestError"` hook to log errors

```typescript
import { SDK } from "@meetkai/mka1";
import { ProxyAgent } from "undici";
import { HTTPClient } from "@meetkai/mka1/lib/http";

const dispatcher = new ProxyAgent("http://proxy.example.com:8080");

const httpClient = new HTTPClient({
  // 'fetcher' takes a function that has the same signature as native 'fetch'.
  fetcher: (input, init) =>
    // 'dispatcher' is specific to undici and not part of the standard Fetch API.
    fetch(input, { ...init, dispatcher } as RequestInit),
});

httpClient.addHook("beforeRequest", (request) => {
  const nextRequest = new Request(request, {
    signal: request.signal || AbortSignal.timeout(5000)
  });

  nextRequest.headers.set("x-custom-header", "custom value");

  return nextRequest;
});

httpClient.addHook("requestError", (error, request) => {
  console.group("Request Error");
  console.log("Reason:", `${error}`);
  console.log("Endpoint:", `${request.method} ${request.url}`);
  console.groupEnd();
});

const sdk = new SDK({ httpClient: httpClient });
```
<!-- End Custom HTTP Client [http-client] -->

<!-- Start Debugging [debug] -->
## Debugging

You can setup your SDK to emit debug logs for SDK requests and responses.

You can pass a logger that matches `console`'s interface as an SDK option.

> [!WARNING]
> Beware that debug logging will reveal secrets, like API tokens in headers, in log messages printed to a console or files. It's recommended to use this feature only during local development and not in production.

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({ debugLogger: console });
```
<!-- End Debugging [debug] -->

## Versioning

The SDK is generated from the MKA1 OpenAPI schema and may gain new endpoints frequently. Pin an exact package version when deploying production applications, then upgrade intentionally after reviewing the generated type changes.

## Generated Code

Most files under `src/`, `docs/`, and the generated reference sections in this README are produced from the API schema. Changes to generated implementation files are likely to be overwritten by the next SDK generation. For API behavior questions, integration support, or documentation issues, use the support channels listed at [docs.mka1.com](https://docs.mka1.com).

Generated with [Speakeasy](https://www.speakeasy.com/).

<!-- Placeholder for Future Speakeasy SDK Sections -->
