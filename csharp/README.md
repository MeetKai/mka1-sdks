# MKA1

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *MKA1* API.

[![Built by Speakeasy](https://img.shields.io/badge/Built_by-SPEAKEASY-374151?style=for-the-badge&labelColor=f3f4f6)](https://www.speakeasy.com/?utm_source=mka1&utm_campaign=csharp)
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
* [MKA1](#mka1)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Server-sent event streaming](#server-sent-event-streaming)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
  * [Custom HTTP Client](#custom-http-client)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/MeetKai/MKA1/MeetKai.MKA1.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Permissions.Llm.GrantAsync(body: new GrantPermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Writer,
});

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type | Scheme      |
| ------------ | ---- | ----------- |
| `BearerAuth` | http | HTTP Bearer |

To authenticate with the API the `BearerAuth` parameter must be set when initializing the SDK client instance. For example:
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Permissions.Llm.GrantAsync(body: new GrantPermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Writer,
});

// handle response
```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK();

var res = await sdk.Auth.Orgs.GetByIdAsync(
    security: new GetOrgByIdSecurity() {

    }, orgId: "<id>"
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AgentConnectors](docs/sdks/agentconnectors/README.md)

* [ListAgentConnectors](docs/sdks/agentconnectors/README.md#listagentconnectors) - List connectors for an agent
* [CreateAgentConnector](docs/sdks/agentconnectors/README.md#createagentconnector) - Create a connector
* [SetupWhatsAppAppWebhook](docs/sdks/agentconnectors/README.md#setupwhatsappappwebhook) - Set up a WhatsApp app webhook (Beta)
* [GetAgentConnector](docs/sdks/agentconnectors/README.md#getagentconnector) - Retrieve a connector
* [DeleteAgentConnector](docs/sdks/agentconnectors/README.md#deleteagentconnector) - Delete a connector
* [ActivateAgentConnector](docs/sdks/agentconnectors/README.md#activateagentconnector) - Activate a connector

### [AgentRuns](docs/sdks/agentruns/README.md)

* [ListAgentRuns](docs/sdks/agentruns/README.md#listagentruns) - List runs for an agent
* [CreateAgentRun](docs/sdks/agentruns/README.md#createagentrun) - Start a saved agent run
* [StreamAgentRunEvents](docs/sdks/agentruns/README.md#streamagentrunevents) - Stream agent run events
* [WakeAgentRun](docs/sdks/agentruns/README.md#wakeagentrun) - Wake a sleeping agent run
* [DecideAgentRunMcpApproval](docs/sdks/agentruns/README.md#decideagentrunmcpapproval) - Approve or deny a pending MCP tool call
* [GetAgentRun](docs/sdks/agentruns/README.md#getagentrun) - Retrieve an agent run

### [AgentSchedules](docs/sdks/agentschedules/README.md)

* [ListAgentSchedules](docs/sdks/agentschedules/README.md#listagentschedules) - List schedules for an agent
* [CreateAgentSchedule](docs/sdks/agentschedules/README.md#createagentschedule) - Create an agent schedule
* [GetAgentSchedule](docs/sdks/agentschedules/README.md#getagentschedule) - Retrieve an agent schedule
* [UpdateAgentSchedule](docs/sdks/agentschedules/README.md#updateagentschedule) - Update an agent schedule
* [DeleteAgentSchedule](docs/sdks/agentschedules/README.md#deleteagentschedule) - Delete an agent schedule
* [PauseAgentSchedule](docs/sdks/agentschedules/README.md#pauseagentschedule) - Pause an agent schedule
* [ResumeAgentSchedule](docs/sdks/agentschedules/README.md#resumeagentschedule) - Resume an agent schedule

### [AgentVersions](docs/sdks/agentversions/README.md)

* [ListAgentVersions](docs/sdks/agentversions/README.md#listagentversions) - List agent versions
* [GetAgentVersion](docs/sdks/agentversions/README.md#getagentversion) - Retrieve an agent version
* [RollbackAgentVersion](docs/sdks/agentversions/README.md#rollbackagentversion) - Roll back an agent to a version

### [Agents](docs/sdks/agents/README.md)

* [ListAgents](docs/sdks/agents/README.md#listagents) - List agents
* [CreateAgent](docs/sdks/agents/README.md#createagent) - Create an agent
* [GetAgent](docs/sdks/agents/README.md#getagent) - Retrieve an agent
* [UpdateAgent](docs/sdks/agents/README.md#updateagent) - Update an agent
* [DeleteAgent](docs/sdks/agents/README.md#deleteagent) - Delete an agent

### [Analytics](docs/sdks/analytics/README.md)

* [Capture](docs/sdks/analytics/README.md#capture) - Durably accept a batch of events
* [Query](docs/sdks/analytics/README.md#query) - Query event counts or unique visitors

#### [Analytics.Events](docs/sdks/events/README.md)

* [Search](docs/sdks/events/README.md#search) - Search events in a time range

#### [Analytics.Keys](docs/sdks/keys/README.md)

* [Create](docs/sdks/keys/README.md#create) - Create a capture key and return its secret once
* [List](docs/sdks/keys/README.md#list) - List capture key metadata
* [Revoke](docs/sdks/keys/README.md#revoke) - Revoke a capture key

#### [Analytics.Projects](docs/sdks/analyticsprojects/README.md)

* [Create](docs/sdks/analyticsprojects/README.md#create) - Create an analytics project
* [List](docs/sdks/analyticsprojects/README.md#list) - List accessible analytics projects
* [Get](docs/sdks/analyticsprojects/README.md#get) - Get an analytics project
* [Update](docs/sdks/analyticsprojects/README.md#update) - Rename an active analytics project
* [Archive](docs/sdks/analyticsprojects/README.md#archive) - Archive an analytics project

#### [Analytics.Visitors](docs/sdks/visitors/README.md)

* [Search](docs/sdks/visitors/README.md#search) - Search visitors in a time range

### [~~Auth.ApiKey~~](docs/sdks/apikey/README.md)

* [~~GetJwtFromKey~~](docs/sdks/apikey/README.md#getjwtfromkey) - Exchange API key for a JWT token :warning: **Deprecated** Use [ExchangeToken](docs/sdks/apikeys/README.md#exchangetoken) instead.

### [Auth.ApiKeys](docs/sdks/apikeys/README.md)

* [Create](docs/sdks/apikeys/README.md#create) - Mint a scoped API key
* [List](docs/sdks/apikeys/README.md#list) - List scoped API keys
* [Update](docs/sdks/apikeys/README.md#update) - Update a scoped API key
* [Regenerate](docs/sdks/apikeys/README.md#regenerate) - Rotate a scoped API key's secret
* [ExchangeToken](docs/sdks/apikeys/README.md#exchangetoken) - Exchange API key for a JWT token

### [Auth.Cluster](docs/sdks/cluster/README.md)

* [CreateInvite](docs/sdks/cluster/README.md#createinvite) - Create a cluster invitation
* [ListInvites](docs/sdks/cluster/README.md#listinvites) - List cluster invitations
* [UpdateInvite](docs/sdks/cluster/README.md#updateinvite) - Update a pending cluster invitation
* [RevokeInvite](docs/sdks/cluster/README.md#revokeinvite) - Revoke a cluster invitation
* [ListOrgs](docs/sdks/cluster/README.md#listorgs) - List all organizations
* [GetOrg](docs/sdks/cluster/README.md#getorg) - Get an organization
* [DeleteOrg](docs/sdks/cluster/README.md#deleteorg) - Soft-delete an organization
* [InviteOrgMembers](docs/sdks/cluster/README.md#inviteorgmembers) - Invite members on behalf of an organization
* [SuspendOrg](docs/sdks/cluster/README.md#suspendorg) - Suspend an organization
* [UnsuspendOrg](docs/sdks/cluster/README.md#unsuspendorg) - Unsuspend an organization
* [ReissueOwnerKey](docs/sdks/cluster/README.md#reissueownerkey) - Re-issue an org owner key (recovery)
* [InviteInfo](docs/sdks/cluster/README.md#inviteinfo) - Read cluster-invite info (public)
* [AcceptInvite](docs/sdks/cluster/README.md#acceptinvite) - Accept a cluster invitation (public)

### [Auth.Orgs](docs/sdks/orgs/README.md)

* [GetById](docs/sdks/orgs/README.md#getbyid) - Get basic organization details
* [Update](docs/sdks/orgs/README.md#update) - Patch organization metadata (cluster-admin)
* [GetQuota](docs/sdks/orgs/README.md#getquota) - Get an org's usage quota
* [UpdateQuota](docs/sdks/orgs/README.md#updatequota) - Set an org's usage quota (cluster-admin)
* [GetRateLimit](docs/sdks/orgs/README.md#getratelimit) - Get an org's rate limit
* [UpdateRateLimit](docs/sdks/orgs/README.md#updateratelimit) - Set an org's rate limit (cluster-admin)

### [Auth.ServiceAccounts](docs/sdks/serviceaccounts/README.md)

* [Create](docs/sdks/serviceaccounts/README.md#create) - Create a service account
* [List](docs/sdks/serviceaccounts/README.md#list) - List service accounts
* [Get](docs/sdks/serviceaccounts/README.md#get) - Get a service account
* [Delete](docs/sdks/serviceaccounts/README.md#delete) - Delete a service account
* [ListApiKeys](docs/sdks/serviceaccounts/README.md#listapikeys) - List a service account's API keys
* [UpdateApiKey](docs/sdks/serviceaccounts/README.md#updateapikey) - Update a service-account API key
* [DeleteApiKey](docs/sdks/serviceaccounts/README.md#deleteapikey) - Delete a service-account API key
* [RegenerateApiKey](docs/sdks/serviceaccounts/README.md#regenerateapikey) - Rotate a service-account API key's secret

### [Auth.Teams](docs/sdks/teams/README.md)

* [Create](docs/sdks/teams/README.md#create) - Create a team
* [List](docs/sdks/teams/README.md#list) - List teams in an org
* [Get](docs/sdks/teams/README.md#get) - Get a team
* [Update](docs/sdks/teams/README.md#update) - Rename a team
* [Delete](docs/sdks/teams/README.md#delete) - Delete a team
* [AddMember](docs/sdks/teams/README.md#addmember) - Add a team member
* [ListMembers](docs/sdks/teams/README.md#listmembers) - List team members
* [RemoveMember](docs/sdks/teams/README.md#removemember) - Remove a team member

### [Billing](docs/sdks/billing/README.md)

* [GetOrganizationBilling](docs/sdks/billing/README.md#getorganizationbilling)
* [SetOrganizationBillingEnabled](docs/sdks/billing/README.md#setorganizationbillingenabled)
* [UpdateOrganizationBillingProfile](docs/sdks/billing/README.md#updateorganizationbillingprofile)
* [CreateOrganizationBillingSetup](docs/sdks/billing/README.md#createorganizationbillingsetup)
* [CreateOrganizationBillingPortal](docs/sdks/billing/README.md#createorganizationbillingportal)
* [ListOrganizationBillingInvoices](docs/sdks/billing/README.md#listorganizationbillinginvoices)

### [Budgets](docs/sdks/budgets/README.md)

* [List](docs/sdks/budgets/README.md#list) - List budgets
* [GetOrg](docs/sdks/budgets/README.md#getorg) - List org budgets
* [SetOrg](docs/sdks/budgets/README.md#setorg) - Set an org budget
* [DeleteOrg](docs/sdks/budgets/README.md#deleteorg) - Delete an org budget
* [OrgEvents](docs/sdks/budgets/README.md#orgevents) - List org budget events
* [GetApiKey](docs/sdks/budgets/README.md#getapikey) - List apikey budgets
* [SetApiKey](docs/sdks/budgets/README.md#setapikey) - Set an apikey budget
* [DeleteApiKey](docs/sdks/budgets/README.md#deleteapikey) - Delete an apikey budget
* [ApiKeyEvents](docs/sdks/budgets/README.md#apikeyevents) - List apikey budget events
* [GetUser](docs/sdks/budgets/README.md#getuser) - List user budgets
* [SetUser](docs/sdks/budgets/README.md#setuser) - Set a user budget
* [DeleteUser](docs/sdks/budgets/README.md#deleteuser) - Delete a user budget
* [UserEvents](docs/sdks/budgets/README.md#userevents) - List user budget events
* [GetTeam](docs/sdks/budgets/README.md#getteam) - List team budgets
* [SetTeam](docs/sdks/budgets/README.md#setteam) - Set a team budget
* [DeleteTeam](docs/sdks/budgets/README.md#deleteteam) - Delete a team budget
* [TeamEvents](docs/sdks/budgets/README.md#teamevents) - List team budget events
* [GetExternalUser](docs/sdks/budgets/README.md#getexternaluser) - List external user budgets
* [SetExternalUser](docs/sdks/budgets/README.md#setexternaluser) - Set a external user budget
* [DeleteExternalUser](docs/sdks/budgets/README.md#deleteexternaluser) - Delete a external user budget
* [ExternalUserEvents](docs/sdks/budgets/README.md#externaluserevents) - List external user budget events
* [GetUserDefault](docs/sdks/budgets/README.md#getuserdefault) - List per-user default budgets
* [SetUserDefault](docs/sdks/budgets/README.md#setuserdefault) - Set a per-user default budget
* [DeleteUserDefault](docs/sdks/budgets/README.md#deleteuserdefault) - Delete a per-user default budget
* [UserDefaultEvents](docs/sdks/budgets/README.md#userdefaultevents) - List per-user default budget events
* [GetTeamDefault](docs/sdks/budgets/README.md#getteamdefault) - List per-team default budgets
* [SetTeamDefault](docs/sdks/budgets/README.md#setteamdefault) - Set a per-team default budget
* [DeleteTeamDefault](docs/sdks/budgets/README.md#deleteteamdefault) - Delete a per-team default budget
* [TeamDefaultEvents](docs/sdks/budgets/README.md#teamdefaultevents) - List per-team default budget events
* [GetExternalUserDefault](docs/sdks/budgets/README.md#getexternaluserdefault) - List per-external user default budgets
* [SetExternalUserDefault](docs/sdks/budgets/README.md#setexternaluserdefault) - Set a per-external user default budget
* [DeleteExternalUserDefault](docs/sdks/budgets/README.md#deleteexternaluserdefault) - Delete a per-external user default budget
* [ExternalUserDefaultEvents](docs/sdks/budgets/README.md#externaluserdefaultevents) - List per-external user default budget events
* [GetCurrency](docs/sdks/budgets/README.md#getcurrency) - Get display currency
* [SetCurrency](docs/sdks/budgets/README.md#setcurrency) - Set display currency

### [ComputeCatalog](docs/sdks/computecatalog/README.md)

* [ListAccelerators](docs/sdks/computecatalog/README.md#listaccelerators) - List accelerators
* [GetAccelerator](docs/sdks/computecatalog/README.md#getaccelerator) - Get an accelerator
* [ListComputeOffers](docs/sdks/computecatalog/README.md#listcomputeoffers) - List provider offers
* [ListComputeProviders](docs/sdks/computecatalog/README.md#listcomputeproviders) - List provider health
* [CreateComputeQuote](docs/sdks/computecatalog/README.md#createcomputequote) - Create a quote

### [ComputeJobs](docs/sdks/computejobs/README.md)

* [ListJobs](docs/sdks/computejobs/README.md#listjobs) - List jobs
* [CreateJob](docs/sdks/computejobs/README.md#createjob) - Create a job
* [GetJob](docs/sdks/computejobs/README.md#getjob) - Get a job
* [ListJobEvents](docs/sdks/computejobs/README.md#listjobevents) - List job events
* [ListJobInstances](docs/sdks/computejobs/README.md#listjobinstances) - List observed job instances
* [ListJobLogs](docs/sdks/computejobs/README.md#listjoblogs) - List job logs
* [TerminateJob](docs/sdks/computejobs/README.md#terminatejob) - Terminate a job

### [ComputePricing](docs/sdks/computepricing/README.md)

* [GetPricing](docs/sdks/computepricing/README.md#getpricing) - Get the latest committed storage price
* [PutPricing](docs/sdks/computepricing/README.md#putpricing) - Create an immutable storage-price version

### [ComputeSecrets](docs/sdks/computesecrets/README.md)

* [ListComputeSecrets](docs/sdks/computesecrets/README.md#listcomputesecrets) - List secrets
* [CreateComputeSecret](docs/sdks/computesecrets/README.md#createcomputesecret) - Create a secret
* [DeleteComputeSecret](docs/sdks/computesecrets/README.md#deletecomputesecret) - Delete a secret
* [GetComputeSecret](docs/sdks/computesecrets/README.md#getcomputesecret) - Get a secret

### [ComputeServices](docs/sdks/computeservices/README.md)

* [ListServices](docs/sdks/computeservices/README.md#listservices) - List services
* [CreateService](docs/sdks/computeservices/README.md#createservice) - Create a service
* [GetService](docs/sdks/computeservices/README.md#getservice) - Get a service
* [ListServiceEvents](docs/sdks/computeservices/README.md#listserviceevents) - List service events
* [ListServiceInstances](docs/sdks/computeservices/README.md#listserviceinstances) - List observed service instances
* [ListServiceLogs](docs/sdks/computeservices/README.md#listservicelogs) - List service logs
* [UpdateServiceScaling](docs/sdks/computeservices/README.md#updateservicescaling) - Replace a service scaling policy
* [TerminateService](docs/sdks/computeservices/README.md#terminateservice) - Terminate a service

### [ComputeTenants](docs/sdks/computetenants/README.md)

* [ListComputeTenants](docs/sdks/computetenants/README.md#listcomputetenants) - List tenants
* [GetComputeTenant](docs/sdks/computetenants/README.md#getcomputetenant) - Get a tenant
* [PutComputeTenant](docs/sdks/computetenants/README.md#putcomputetenant) - Update a tenant

### [ComputeUsage](docs/sdks/computeusage/README.md)

* [GetComputeUsage](docs/sdks/computeusage/README.md#getcomputeusage) - Get usage

### [ComputeVolumes](docs/sdks/computevolumes/README.md)

* [ListStandaloneVolumes](docs/sdks/computevolumes/README.md#liststandalonevolumes) - List organization volumes
* [CreateStandaloneVolume](docs/sdks/computevolumes/README.md#createstandalonevolume) - Create a standalone shared volume
* [DeleteStandaloneVolume](docs/sdks/computevolumes/README.md#deletestandalonevolume) - Permanently delete a standalone volume
* [GetStandaloneVolume](docs/sdks/computevolumes/README.md#getstandalonevolume) - Get a standalone volume
* [ListStandaloneVolumeAttachments](docs/sdks/computevolumes/README.md#liststandalonevolumeattachments) - List volume attachments

### [Datasets](docs/sdks/datasets/README.md)

* [ListGenerators](docs/sdks/datasets/README.md#listgenerators) - List Generators
* [GetGenerator](docs/sdks/datasets/README.md#getgenerator) - Get Generator
* [QuoteGenerator](docs/sdks/datasets/README.md#quotegenerator) - Quote Generator
* [ListGenerations](docs/sdks/datasets/README.md#listgenerations) - List Generations
* [CreateGeneration](docs/sdks/datasets/README.md#creategeneration) - Create Generation
* [GetGeneration](docs/sdks/datasets/README.md#getgeneration) - Get Generation
* [GetGenerationLogs](docs/sdks/datasets/README.md#getgenerationlogs) - Get Logs
* [GetGenerationEvents](docs/sdks/datasets/README.md#getgenerationevents) - Get Events
* [CancelGeneration](docs/sdks/datasets/README.md#cancelgeneration) - Cancel Generation
* [ListFormats](docs/sdks/datasets/README.md#listformats) - List Formats
* [GetFormat](docs/sdks/datasets/README.md#getformat) - Get Format

### [Flags](docs/sdks/flags/README.md)

* [List](docs/sdks/flags/README.md#list) - List flags
* [Create](docs/sdks/flags/README.md#create) - Create a flag
* [Delete](docs/sdks/flags/README.md#delete) - Delete a flag and its settings in every environment
* [Get](docs/sdks/flags/README.md#get) - Get a flag
* [Update](docs/sdks/flags/README.md#update) - Update a flag's name, description, default value, or project
* [Archive](docs/sdks/flags/README.md#archive) - Archive a flag
* [SetEnvironmentState](docs/sdks/flags/README.md#setenvironmentstate) - Replace a flag's settings in one environment
* [Unarchive](docs/sdks/flags/README.md#unarchive) - Restore an archived flag

#### [Flags.Audit](docs/sdks/audit/README.md)

* [List](docs/sdks/audit/README.md#list) - List audit entries, newest first

#### [Flags.Environments](docs/sdks/flagsenvironments/README.md)

* [List](docs/sdks/flagsenvironments/README.md#list) - List environments
* [Create](docs/sdks/flagsenvironments/README.md#create) - Create an environment
* [Delete](docs/sdks/flagsenvironments/README.md#delete) - Delete an environment and every flag setting in it
* [Update](docs/sdks/flagsenvironments/README.md#update) - Rename an environment
* [Evaluate](docs/sdks/flagsenvironments/README.md#evaluate) - Evaluate every flag for an identity
* [EvaluateWithTraits](docs/sdks/flagsenvironments/README.md#evaluatewithtraits) - Evaluate every flag for an identity with traits
* [RevokeEvaluationKey](docs/sdks/flagsenvironments/README.md#revokeevaluationkey) - Revoke an environment evaluation key
* [GenerateEvaluationKey](docs/sdks/flagsenvironments/README.md#generateevaluationkey) - Generate or replace an environment evaluation key

#### [Flags.Projects](docs/sdks/flagsprojects/README.md)

* [List](docs/sdks/flagsprojects/README.md#list) - List projects
* [Create](docs/sdks/flagsprojects/README.md#create) - Create a project
* [Delete](docs/sdks/flagsprojects/README.md#delete) - Delete an empty project
* [Get](docs/sdks/flagsprojects/README.md#get) - Get a project
* [Update](docs/sdks/flagsprojects/README.md#update) - Rename a project

### [Guardrails](docs/sdks/guardrails/README.md)

* [GetGuardrails](docs/sdks/guardrails/README.md#getguardrails) - Get effective guardrails
* [UpdateGuardrails](docs/sdks/guardrails/README.md#updateguardrails) - Update guardrails policy
* [DeleteGuardrails](docs/sdks/guardrails/README.md#deleteguardrails) - Delete guardrails policy
* [ListGuardrailsPolicies](docs/sdks/guardrails/README.md#listguardrailspolicies) - List guardrails policies
* [TestGuardrails](docs/sdks/guardrails/README.md#testguardrails) - Test content against guardrails

### [Llm.Batches](docs/sdks/batches/README.md)

* [Create](docs/sdks/batches/README.md#create) - Create a batch
* [List](docs/sdks/batches/README.md#list) - List batches
* [Get](docs/sdks/batches/README.md#get) - Get a batch
* [Cancel](docs/sdks/batches/README.md#cancel) - Cancel a batch

### [~~Llm.Chat~~](docs/sdks/chat/README.md)

* [~~CreateChat~~](docs/sdks/chat/README.md#createchat) - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
* [~~Stream~~](docs/sdks/chat/README.md#stream) - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**

### [Llm.Classify](docs/sdks/classify/README.md)

* [Classify](docs/sdks/classify/README.md#classify) - Classify text into predefined categories

### [Llm.Conversations](docs/sdks/conversations/README.md)

* [Create](docs/sdks/conversations/README.md#create) - Create a conversation
* [List](docs/sdks/conversations/README.md#list) - List conversations
* [Get](docs/sdks/conversations/README.md#get) - Retrieve a conversation
* [Update](docs/sdks/conversations/README.md#update) - Update a conversation
* [Delete](docs/sdks/conversations/README.md#delete) - Delete a conversation
* [ListItems](docs/sdks/conversations/README.md#listitems) - List conversation items
* [CreateItems](docs/sdks/conversations/README.md#createitems) - Create conversation items
* [DeleteItems](docs/sdks/conversations/README.md#deleteitems) - Delete multiple conversation items
* [GetItem](docs/sdks/conversations/README.md#getitem) - Retrieve a conversation item
* [DeleteItem](docs/sdks/conversations/README.md#deleteitem) - Delete a conversation item

### [Llm.Embeddings](docs/sdks/embeddings/README.md)

* [ListModels](docs/sdks/embeddings/README.md#listmodels) - List available embedding models
* [Embed](docs/sdks/embeddings/README.md#embed) - Create text embeddings

### [Llm.Evals](docs/sdks/evals/README.md)

* [CreateSuite](docs/sdks/evals/README.md#createsuite) - Create an eval suite
* [ListSuites](docs/sdks/evals/README.md#listsuites) - List eval suites
* [GetSuite](docs/sdks/evals/README.md#getsuite) - Get an eval suite
* [DeleteSuite](docs/sdks/evals/README.md#deletesuite) - Delete an eval suite
* [CreateSuiteVersion](docs/sdks/evals/README.md#createsuiteversion) - Create an eval suite version
* [ListSuiteVersions](docs/sdks/evals/README.md#listsuiteversions) - List eval suite versions
* [GetSuiteVersion](docs/sdks/evals/README.md#getsuiteversion) - Get an eval suite version
* [ListSuiteLeaderboardRuns](docs/sdks/evals/README.md#listsuiteleaderboardruns) - List leaderboard runs for an eval suite
* [GetSuiteLeaderboard](docs/sdks/evals/README.md#getsuiteleaderboard) - Get the coding-agent leaderboard for an eval suite
* [MeasureSuiteTokens](docs/sdks/evals/README.md#measuresuitetokens) - Count tokens from stored text for a suite's unmeasured samples
* [CreateRun](docs/sdks/evals/README.md#createrun) - Create an eval run
* [ListRuns](docs/sdks/evals/README.md#listruns) - List eval runs
* [GetRun](docs/sdks/evals/README.md#getrun) - Get an eval run
* [DeleteRun](docs/sdks/evals/README.md#deleterun) - Delete an eval run
* [CancelRun](docs/sdks/evals/README.md#cancelrun) - Cancel an eval run
* [RerunFailedSamples](docs/sdks/evals/README.md#rerunfailedsamples) - Rerun failed eval samples
* [RetryFailedRun](docs/sdks/evals/README.md#retryfailedrun) - Retry an eval run
* [GetRunOverview](docs/sdks/evals/README.md#getrunoverview) - Get an eval run overview
* [ListSamples](docs/sdks/evals/README.md#listsamples) - List eval samples
* [GetSampleAudio](docs/sdks/evals/README.md#getsampleaudio) - Get eval sample audio
* [GetSampleTrajectory](docs/sdks/evals/README.md#getsampletrajectory) - Get an eval sample trajectory
* [UploadSampleTrajectory](docs/sdks/evals/README.md#uploadsampletrajectory) - Upload an eval sample trajectory
* [GetArtifacts](docs/sdks/evals/README.md#getartifacts) - Get eval run artifacts
* [ImportAgentRun](docs/sdks/evals/README.md#importagentrun) - Import a finished coding-agent run
* [AppendAgentTrials](docs/sdks/evals/README.md#appendagenttrials) - Append trials to an open coding-agent run
* [ImportHistoricalResults](docs/sdks/evals/README.md#importhistoricalresults) - Import historical eval results from Hugging Face
* [CreateSchedule](docs/sdks/evals/README.md#createschedule) - Create an eval schedule
* [ListSchedules](docs/sdks/evals/README.md#listschedules) - List eval schedules
* [GetSchedule](docs/sdks/evals/README.md#getschedule) - Get an eval schedule
* [UpdateSchedule](docs/sdks/evals/README.md#updateschedule) - Update an eval schedule
* [DeleteSchedule](docs/sdks/evals/README.md#deleteschedule) - Delete an eval schedule
* [TriggerSchedule](docs/sdks/evals/README.md#triggerschedule) - Trigger an eval schedule now
* [ListScheduleRuns](docs/sdks/evals/README.md#listscheduleruns) - List runs created by an eval schedule

### [Llm.Extract](docs/sdks/extract/README.md)

* [Extract](docs/sdks/extract/README.md#extract) - Extract structured data with inline JSON Schema
* [CreateSchema](docs/sdks/extract/README.md#createschema) - Create reusable extraction schema template
* [GetSchema](docs/sdks/extract/README.md#getschema) - Get extraction schema by ID
* [UpdateSchema](docs/sdks/extract/README.md#updateschema) - Update extraction schema by ID
* [DeleteSchema](docs/sdks/extract/README.md#deleteschema) - Delete extraction schema by ID
* [ExtractWithSchema](docs/sdks/extract/README.md#extractwithschema) - Extract data using saved schema template

### [Llm.Feedback](docs/sdks/feedback/README.md)

* [CreateCompletionFeedback](docs/sdks/feedback/README.md#createcompletionfeedback) - Submit feedback for chat completion
* [ListCompletionFeedback](docs/sdks/feedback/README.md#listcompletionfeedback) - List chat completion feedback
* [GetCompletionFeedback](docs/sdks/feedback/README.md#getcompletionfeedback) - Retrieve feedback by completion ID
* [UpdateCompletionFeedback](docs/sdks/feedback/README.md#updatecompletionfeedback) - Update existing completion feedback
* [BatchGetCompletionFeedback](docs/sdks/feedback/README.md#batchgetcompletionfeedback) - Batch retrieve feedback for multiple completions
* [CreateResponseFeedback](docs/sdks/feedback/README.md#createresponsefeedback) - Submit feedback for response
* [ListResponseFeedback](docs/sdks/feedback/README.md#listresponsefeedback) - List response feedback
* [GetResponseFeedback](docs/sdks/feedback/README.md#getresponsefeedback) - Retrieve feedback by response ID
* [UpdateResponseFeedback](docs/sdks/feedback/README.md#updateresponsefeedback) - Update existing response feedback
* [BatchGetResponseFeedback](docs/sdks/feedback/README.md#batchgetresponsefeedback) - Batch retrieve feedback for multiple responses
* [ExportCompletionFeedback](docs/sdks/feedback/README.md#exportcompletionfeedback) - Export completion feedback as CSV
* [ExportResponseFeedback](docs/sdks/feedback/README.md#exportresponsefeedback) - Export response feedback as CSV
* [StartExport](docs/sdks/feedback/README.md#startexport) - Start feedback export
* [GetExportStatus](docs/sdks/feedback/README.md#getexportstatus) - Get feedback export status

### [Llm.Files](docs/sdks/files/README.md)

* [Upload](docs/sdks/files/README.md#upload) - Upload file
* [List](docs/sdks/files/README.md#list) - List files
* [Get](docs/sdks/files/README.md#get) - Retrieve file
* [Delete](docs/sdks/files/README.md#delete) - Delete file
* [Content](docs/sdks/files/README.md#content) - Retrieve file content

### [~~Llm.FineTuning~~](docs/sdks/finetuning/README.md)

* [~~Create~~](docs/sdks/finetuning/README.md#create) - [Deprecated] Create a fine-tuning job :warning: **Deprecated**
* [~~List~~](docs/sdks/finetuning/README.md#list) - [Deprecated] List fine-tuning jobs :warning: **Deprecated**
* [~~Retrieve~~](docs/sdks/finetuning/README.md#retrieve) - [Deprecated] Retrieve a fine-tuning job :warning: **Deprecated**
* [~~Cancel~~](docs/sdks/finetuning/README.md#cancel) - [Deprecated] Cancel a fine-tuning job :warning: **Deprecated**
* [~~Pause~~](docs/sdks/finetuning/README.md#pause) - [Deprecated] Pause a fine-tuning job :warning: **Deprecated**
* [~~Resume~~](docs/sdks/finetuning/README.md#resume) - [Deprecated] Resume a fine-tuning job :warning: **Deprecated**
* [~~ListEvents~~](docs/sdks/finetuning/README.md#listevents) - [Deprecated] List fine-tuning events :warning: **Deprecated**
* [~~ListCheckpoints~~](docs/sdks/finetuning/README.md#listcheckpoints) - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**

### [Llm.Images](docs/sdks/images/README.md)

* [Create](docs/sdks/images/README.md#create) - Generate images from text descriptions

### [Llm.McpVault](docs/sdks/mcpvault/README.md)

* [CreateServer](docs/sdks/mcpvault/README.md#createserver) - Create MCP server
* [ListServers](docs/sdks/mcpvault/README.md#listservers) - List MCP servers
* [GetServer](docs/sdks/mcpvault/README.md#getserver) - Retrieve MCP server
* [UpdateServer](docs/sdks/mcpvault/README.md#updateserver) - Update MCP server
* [DeleteServer](docs/sdks/mcpvault/README.md#deleteserver) - Delete MCP server
* [CreateCredential](docs/sdks/mcpvault/README.md#createcredential) - Create MCP credential
* [ListCredentials](docs/sdks/mcpvault/README.md#listcredentials) - List MCP credentials
* [DeleteCredential](docs/sdks/mcpvault/README.md#deletecredential) - Delete MCP credential
* [TestServer](docs/sdks/mcpvault/README.md#testserver) - Test MCP server

### [Llm.MemoryStores](docs/sdks/memorystores/README.md)

* [Create](docs/sdks/memorystores/README.md#create) - Create memory store
* [List](docs/sdks/memorystores/README.md#list) - List memory stores
* [Get](docs/sdks/memorystores/README.md#get) - Retrieve memory store
* [Update](docs/sdks/memorystores/README.md#update) - Update memory store
* [Delete](docs/sdks/memorystores/README.md#delete) - Delete memory store
* [CreateEntry](docs/sdks/memorystores/README.md#createentry) - Create memory entry
* [ListEntries](docs/sdks/memorystores/README.md#listentries) - List memory entries
* [GetEntry](docs/sdks/memorystores/README.md#getentry) - Retrieve memory entry
* [UpdateEntry](docs/sdks/memorystores/README.md#updateentry) - Update memory entry
* [DeleteEntry](docs/sdks/memorystores/README.md#deleteentry) - Delete memory entry

### [Llm.Models](docs/sdks/models/README.md)

* [List](docs/sdks/models/README.md#list) - List available models
* [Get](docs/sdks/models/README.md#get) - Retrieve a model
* [ListCatalog](docs/sdks/models/README.md#listcatalog) - List the organization's model catalog
* [AddCatalogEntry](docs/sdks/models/README.md#addcatalogentry) - Define a BYO catalog model
* [UpdateCatalogEntry](docs/sdks/models/README.md#updatecatalogentry) - Update a BYO catalog model
* [DeleteCatalogEntry](docs/sdks/models/README.md#deletecatalogentry) - Remove a BYO catalog model
* [CheckCatalogHealth](docs/sdks/models/README.md#checkcataloghealth) - Check a BYO catalog model's health
* [ListCatalogOrgAccess](docs/sdks/models/README.md#listcatalogorgaccess) - List an organization's cluster model access
* [AddCatalogOrgAccess](docs/sdks/models/README.md#addcatalogorgaccess) - Add cluster model access for an organization
* [ReplaceCatalogOrgAccess](docs/sdks/models/README.md#replacecatalogorgaccess) - Replace an organization's cluster model access
* [ListCatalogModelAccess](docs/sdks/models/README.md#listcatalogmodelaccess) - List organizations with access to a cluster model
* [ListRegistry](docs/sdks/models/README.md#listregistry) - List the organization's active model registry
* [ActivateRegistryEntry](docs/sdks/models/README.md#activateregistryentry) - Activate a catalog entry
* [DeactivateRegistryEntry](docs/sdks/models/README.md#deactivateregistryentry) - Deactivate a model registry name
* [ListOrgAutoModels](docs/sdks/models/README.md#listorgautomodels) - List this org's auto-model overrides
* [PutOrgAutoModel](docs/sdks/models/README.md#putorgautomodel) - Set this org's auto policy for an endpoint
* [DeleteOrgAutoModel](docs/sdks/models/README.md#deleteorgautomodel) - Clear this org's auto-model override for an endpoint
* [GetClusterCurrency](docs/sdks/models/README.md#getclustercurrency) - Get the cluster currency
* [SetClusterCurrency](docs/sdks/models/README.md#setclustercurrency) - Set the cluster currency
* [ListClusterPrices](docs/sdks/models/README.md#listclusterprices) - List cluster-default model prices
* [SetClusterPrice](docs/sdks/models/README.md#setclusterprice) - Set a cluster-default model price
* [ClearClusterPrice](docs/sdks/models/README.md#clearclusterprice) - Clear a cluster-default model price
* [ListOrgPrices](docs/sdks/models/README.md#listorgprices) - List an org's price overrides
* [SetOrgPrice](docs/sdks/models/README.md#setorgprice) - Set an org price override
* [ClearOrgPrice](docs/sdks/models/README.md#clearorgprice) - Clear an org price override
* [ListEffectivePrices](docs/sdks/models/README.md#listeffectiveprices) - List effective prices for the caller's models

### [Llm.Prompts](docs/sdks/prompts/README.md)

* [Create](docs/sdks/prompts/README.md#create) - Create a prompt
* [List](docs/sdks/prompts/README.md#list) - List prompts
* [Get](docs/sdks/prompts/README.md#get) - Get a prompt
* [Update](docs/sdks/prompts/README.md#update) - Update a prompt
* [Delete](docs/sdks/prompts/README.md#delete) - Delete a prompt
* [CreateVersion](docs/sdks/prompts/README.md#createversion) - Create a new version
* [ListVersions](docs/sdks/prompts/README.md#listversions) - List versions
* [GetVersion](docs/sdks/prompts/README.md#getversion) - Get a specific version
* [Rollback](docs/sdks/prompts/README.md#rollback) - Rollback to a version

### [Llm.Responses](docs/sdks/responses/README.md)

* [Create](docs/sdks/responses/README.md#create) - Create an agent-powered response with tool support
* [List](docs/sdks/responses/README.md#list) - List all responses with pagination
* [Get](docs/sdks/responses/README.md#get) - Retrieve response by ID with status and results
* [Update](docs/sdks/responses/README.md#update) - Update a response
* [Delete](docs/sdks/responses/README.md#delete) - Permanently delete a response and its data
* [Cancel](docs/sdks/responses/README.md#cancel) - Cancel an in-progress background response
* [Wake](docs/sdks/responses/README.md#wake) - Wake a sleeping background response
* [ListInputItems](docs/sdks/responses/README.md#listinputitems) - List paginated input items for a response
* [Compact](docs/sdks/responses/README.md#compact) - Compact a conversation

### [Llm.Skills](docs/sdks/skills/README.md)

* [Create](docs/sdks/skills/README.md#create) - Create skill
* [List](docs/sdks/skills/README.md#list) - List skills
* [Get](docs/sdks/skills/README.md#get) - Retrieve skill
* [Update](docs/sdks/skills/README.md#update) - Update skill
* [Delete](docs/sdks/skills/README.md#delete) - Delete skill
* [Content](docs/sdks/skills/README.md#content) - Download skill content
* [CreateVersion](docs/sdks/skills/README.md#createversion) - Create skill version
* [ListVersions](docs/sdks/skills/README.md#listversions) - List skill versions
* [GetVersion](docs/sdks/skills/README.md#getversion) - Retrieve skill version
* [DeleteVersion](docs/sdks/skills/README.md#deleteversion) - Delete skill version
* [VersionContent](docs/sdks/skills/README.md#versioncontent) - Download skill version content
* [ListPreconfigured](docs/sdks/skills/README.md#listpreconfigured) - List preconfigured skills

### [Llm.Speech](docs/sdks/speech/README.md)

* [Transcribe](docs/sdks/speech/README.md#transcribe) - Speech to text transcription
* [Speak](docs/sdks/speech/README.md#speak) - Text to speech
* [SpeakStreaming](docs/sdks/speech/README.md#speakstreaming) - Streaming text to speech
* [LivekitToken](docs/sdks/speech/README.md#livekittoken) - Generate LiveKit room token
* [ListTtsHistory](docs/sdks/speech/README.md#listttshistory) - List text-to-speech history
* [GetTtsHistory](docs/sdks/speech/README.md#getttshistory) - Retrieve text-to-speech history item
* [DeleteTtsHistory](docs/sdks/speech/README.md#deletettshistory) - Delete text-to-speech history item
* [GetTtsHistoryContent](docs/sdks/speech/README.md#getttshistorycontent) - Retrieve text-to-speech audio
* [ListTranscriptionHistory](docs/sdks/speech/README.md#listtranscriptionhistory) - List speech-to-text history
* [GetTranscriptionHistory](docs/sdks/speech/README.md#gettranscriptionhistory) - Retrieve speech-to-text history item
* [DeleteTranscriptionHistory](docs/sdks/speech/README.md#deletetranscriptionhistory) - Delete speech-to-text history item
* [GetTranscriptionHistoryContent](docs/sdks/speech/README.md#gettranscriptionhistorycontent) - Retrieve speech-to-text audio

### [Llm.Usage](docs/sdks/llmusage/README.md)

* [Completions](docs/sdks/llmusage/README.md#completions) - Get completions usage
* [Responses](docs/sdks/llmusage/README.md#responses) - Get responses usage
* [Conversations](docs/sdks/llmusage/README.md#conversations) - Get conversations usage
* [Embeddings](docs/sdks/llmusage/README.md#embeddings) - Get embeddings usage
* [Extract](docs/sdks/llmusage/README.md#extract) - Get extract usage
* [Classify](docs/sdks/llmusage/README.md#classify) - Get classify usage
* [VectorStores](docs/sdks/llmusage/README.md#vectorstores) - Get vector stores usage
* [Files](docs/sdks/llmusage/README.md#files) - Get files usage
* [Costs](docs/sdks/llmusage/README.md#costs) - Get cost by model

### [Llm.VectorStores](docs/sdks/vectorstores/README.md)

* [Create](docs/sdks/vectorstores/README.md#create) - Create a vector store
* [List](docs/sdks/vectorstores/README.md#list) - List vector stores
* [Get](docs/sdks/vectorstores/README.md#get) - Retrieve a vector store
* [Update](docs/sdks/vectorstores/README.md#update) - Modify a vector store
* [Delete](docs/sdks/vectorstores/README.md#delete) - Delete a vector store
* [Search](docs/sdks/vectorstores/README.md#search) - Search a vector store
* [CreateFile](docs/sdks/vectorstores/README.md#createfile) - Add a file to a vector store
* [ListFiles](docs/sdks/vectorstores/README.md#listfiles) - List files in a vector store
* [GetFile](docs/sdks/vectorstores/README.md#getfile) - Retrieve a vector store file
* [UpdateFile](docs/sdks/vectorstores/README.md#updatefile) - Update file attributes
* [DeleteFile](docs/sdks/vectorstores/README.md#deletefile) - Remove file from vector store
* [GetFileContent](docs/sdks/vectorstores/README.md#getfilecontent) - Retrieve parsed file content
* [CreateFileBatch](docs/sdks/vectorstores/README.md#createfilebatch) - Batch add multiple files to vector store
* [GetFileBatch](docs/sdks/vectorstores/README.md#getfilebatch) - Retrieve file batch status
* [CancelFileBatch](docs/sdks/vectorstores/README.md#cancelfilebatch) - Cancel batch file processing
* [ListFilesInBatch](docs/sdks/vectorstores/README.md#listfilesinbatch) - List files in a batch

### [Permissions.Llm](docs/sdks/permissionsllm/README.md)

* [Grant](docs/sdks/permissionsllm/README.md#grant) - Grant permission to a user or make public
* [Revoke](docs/sdks/permissionsllm/README.md#revoke) - Revoke permission from a user or remove public access
* [Check](docs/sdks/permissionsllm/README.md#check) - Check user permission

### [Repos](docs/sdks/repos/README.md)

* [List](docs/sdks/repos/README.md#list) - List the caller's org's repositories
* [Create](docs/sdks/repos/README.md#create) - Create a repository
* [Delete](docs/sdks/repos/README.md#delete) - Delete a repository
* [Get](docs/sdks/repos/README.md#get) - Get a repository
* [Update](docs/sdks/repos/README.md#update) - Update a repository's labels

#### [Repos.Tags](docs/sdks/tags/README.md)

* [List](docs/sdks/tags/README.md#list) - List an image repository's tags
* [Delete](docs/sdks/tags/README.md#delete) - Delete an image tag

### [Sandbox](docs/sdks/sandbox/README.md)

* [Create](docs/sdks/sandbox/README.md#create) - Create Session
* [List](docs/sdks/sandbox/README.md#list) - List Sessions
* [Get](docs/sdks/sandbox/README.md#get) - Get Session
* [GetPricing](docs/sdks/sandbox/README.md#getpricing) - Get Sandbox Pricing
* [SetPricing](docs/sdks/sandbox/README.md#setpricing) - Set Sandbox Pricing
* [GetBrowserUrl](docs/sdks/sandbox/README.md#getbrowserurl) - Get Browser Session URL
* [~~GetUrl~~](docs/sdks/sandbox/README.md#geturl) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [GetBrowserUrl](docs/sdks/sandbox/README.md#getbrowserurl) instead.
* [ProxyBrowserPortRequest](docs/sdks/sandbox/README.md#proxybrowserportrequest) - Proxy Browser Port Request
* [RunCommand](docs/sdks/sandbox/README.md#runcommand) - Run Command
* [RunCode](docs/sdks/sandbox/README.md#runcode) - Run Code
* [Terminate](docs/sdks/sandbox/README.md#terminate) - Terminate Session
* [GetWorkspace](docs/sdks/sandbox/README.md#getworkspace) - Get Workspace Manifest
* [DownloadFile](docs/sdks/sandbox/README.md#downloadfile) - Download Workspace File
* [UploadFile](docs/sdks/sandbox/README.md#uploadfile) - Upload Workspace File
* [DownloadArchive](docs/sdks/sandbox/README.md#downloadarchive) - Download Workspace Archive
* [UploadArchive](docs/sdks/sandbox/README.md#uploadarchive) - Upload Workspace Archive

#### [Sandbox.Environments](docs/sdks/sandboxenvironments/README.md)

* [List](docs/sdks/sandboxenvironments/README.md#list) - List Environments
* [Create](docs/sdks/sandboxenvironments/README.md#create) - Create Environment
* [Get](docs/sdks/sandboxenvironments/README.md#get) - Get Environment
* [Update](docs/sdks/sandboxenvironments/README.md#update) - Update Environment
* [Delete](docs/sdks/sandboxenvironments/README.md#delete) - Delete Environment
* [RunSetup](docs/sdks/sandboxenvironments/README.md#runsetup) - Run Environment Setup

#### [Sandbox.Github](docs/sdks/github/README.md)

* [CreateAuthorizationIntent](docs/sdks/github/README.md#createauthorizationintent) - Start GitHub Authorization
* [Connect](docs/sdks/github/README.md#connect) - Connect GitHub Account
* [GetConnection](docs/sdks/github/README.md#getconnection) - Get GitHub Connection
* [Disconnect](docs/sdks/github/README.md#disconnect) - Disconnect GitHub Account
* [ListRepositories](docs/sdks/github/README.md#listrepositories) - List GitHub Repositories
* [RefreshRepositories](docs/sdks/github/README.md#refreshrepositories) - Refresh GitHub Repositories
* [ResolveReference](docs/sdks/github/README.md#resolvereference) - Resolve GitHub Reference
* [CloneRepository](docs/sdks/github/README.md#clonerepository) - Clone GitHub Repository into Session
* [ListSessionRepositories](docs/sdks/github/README.md#listsessionrepositories) - List Session Repositories
* [AddSessionRepository](docs/sdks/github/README.md#addsessionrepository) - Add Session Repository
* [DismissSessionRepository](docs/sdks/github/README.md#dismisssessionrepository) - Dismiss Failed Session Repository
* [Push](docs/sdks/github/README.md#push) - Push Session to GitHub
* [CreateOrUpdatePullRequest](docs/sdks/github/README.md#createorupdatepullrequest) - Create or Update Pull Request

### [Session](docs/sdks/session/README.md)

* [GetPendingInvitation](docs/sdks/session/README.md#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
* [ExchangeSessionToken](docs/sdks/session/README.md#exchangesessiontoken) - Exchange a live session for a delegated access token

### [Tracking.Experiments](docs/sdks/experiments/README.md)

* [Create](docs/sdks/experiments/README.md#create) - Create
* [Search](docs/sdks/experiments/README.md#search) - Search
* [Get](docs/sdks/experiments/README.md#get) - Get
* [GetByName](docs/sdks/experiments/README.md#getbyname) - GetByName
* [Delete](docs/sdks/experiments/README.md#delete) - Delete

### [Tracking.Runs](docs/sdks/runs/README.md)

* [Create](docs/sdks/runs/README.md#create) - Create
* [Get](docs/sdks/runs/README.md#get) - Get
* [Search](docs/sdks/runs/README.md#search) - Search
* [Update](docs/sdks/runs/README.md#update) - Update
* [Delete](docs/sdks/runs/README.md#delete) - Delete
* [Restore](docs/sdks/runs/README.md#restore) - Restore
* [LogMetric](docs/sdks/runs/README.md#logmetric) - LogMetric
* [LogParameter](docs/sdks/runs/README.md#logparameter) - LogParameter
* [SetTag](docs/sdks/runs/README.md#settag) - SetTag
* [DeleteTag](docs/sdks/runs/README.md#deletetag) - DeleteTag
* [LogBatch](docs/sdks/runs/README.md#logbatch) - LogBatch
* [LogInputs](docs/sdks/runs/README.md#loginputs) - LogInputs
* [GetMetricHistory](docs/sdks/runs/README.md#getmetrichistory) - GetMetricHistory

### [Usage](docs/sdks/usage/README.md)

* [Sandbox](docs/sdks/usage/README.md#sandbox) - Get Sandbox Usage
* [Costs](docs/sdks/usage/README.md#costs) - Aggregate cost by dimension

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server-sent event streaming [eventstream] -->
## Server-sent event streaming

Server-sent events (SSE) are used to stream content from certain operations. SSE is a web standard that allows a server to push data to a client over a single HTTP connection in real-time.

These operations return an instance of `EventStream`, which implements `IAsyncEnumerable<T>`, `IAsyncDisposable` and `IDisposable`. An `EventStream` can only be consumed once and cannot be replayed.

Consume the stream with `await foreach`, which reads events as they arrive and disposes the stream when enumeration ends. To cancel iteration, pass the same `CancellationToken` to the operation and to `eventStream.WithCancellation(cancellationToken)`.

```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Responses.CreateAsync(body: new ResponsesCreateRequest() {
    Model = "meetkai:functionary-urdu-mini-pak",
    Input = ResponsesCreateRequestInput.CreateStr(
        "What is the capital of France?"
    ),
});

// Handle event stream response
var eventStream = res.Object;
if (eventStream != null)
{
    await foreach (CreateResponseResponseBody eventData in eventStream)
    {
        // handle eventData
    }
}
// Handle JSON response
else if (res.ResponseObject != null)
{
    // handle JSON response
    var jsonResponse = res.ResponseObject;
}
```

For finer-grained control, you may call `Next()` until it returns `null`. `Next()` never disposes the `EventStream`, so wrap it in `using`/`await using` or dispose it explicitly.
<!-- End Server-sent event streaming [eventstream] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Permissions.Llm.GrantAsync(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    body: new GrantPermissionRequest() {
        ResourceType = LlmResourceType.Completion,
        ResourceId = "my-completion-123",
        UserId = "user-abc456",
        Role = ResourceRole.Writer,
    }
);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    bearerAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Permissions.Llm.GrantAsync(body: new GrantPermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Writer,
});

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`SDKException`](./src/MeetKai/MKA1/Types/Errors/SDKException.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `Request`     | *HttpRequestMessage*  | HTTP request object   |
| `Response`    | *HttpResponseMessage* | HTTP response object  |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Errors;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

try
{
    var res = await sdk.Llm.Files.ContentAsync(fileId: "file-abc123");

    // handle response
}
catch (SDKException ex) // all SDK exceptions inherit from SDKException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpRequestMessage request = ex.Request;
    HttpResponseMessage response = ex.Response;
    var statusCode = (int)response.StatusCode;
    var responseBody = ex.Body;

    if (ex is GetFileContentBadRequestException) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        GetFileContentBadRequestExceptionPayload payload = ex.Payload;
        BadRequestError Error = payload.Error;
        HTTPMetadata HttpMeta = payload.HttpMeta;
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (OperationCanceledException ex)
{
    // CancellationToken was cancelled
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exception:**
* [`SDKException`](./src/MeetKai/MKA1/Types/Errors/SDKException.cs): The base class for HTTP error responses.

<details><summary>Less common exceptions (306)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`SDKException`](./src/MeetKai/MKA1/Types/Errors/SDKException.cs):
  * [`HTTPValidationError`](./src/MeetKai/MKA1/Types/Errors/HTTPValidationError.cs): Validation Error. Status code `422`. Applicable to 39 of 459 methods.*
  * [`ErrorEnvelope`](./src/MeetKai/MKA1/Types/Errors/ErrorEnvelope.cs): Error response. Applicable to 27 of 459 methods.*
  * [`FeatureFlagError`](./src/MeetKai/MKA1/Types/Errors/FeatureFlagError.cs): The request is malformed or fails validation. Applicable to 22 of 459 methods.*
  * [`AnalyticsError`](./src/MeetKai/MKA1/Types/Errors/AnalyticsError.cs): Request failed. Applicable to 12 of 459 methods.*
  * [`RepoError`](./src/MeetKai/MKA1/Types/Errors/RepoError.cs): The uniform error envelope. `error` is a stable machine-readable code (never an internal reason); `correlation_id` echoes the request's `X-Correlation-ID` for log correlation. Applicable to 7 of 459 methods.*
  * [`ExchangeSessionTokenBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenBadRequestException.cs): Invalid request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetFileContentBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetFileContentBadRequestException.cs): Invalid request - File ID is required. Status code `400`. Applicable to 1 of 459 methods.*
  * [`CreateScopedApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ListScopedApiKeysBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UpdateScopedApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`RegenerateScopedApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ExchangeApiKeyTokenBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`CreateTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ListTeamsBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UpdateTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`DeleteTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`AddTeamMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ListTeamMembersBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`RemoveTeamMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`CreateServiceAccountBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountsBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetServiceAccountBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountApiKeysBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UpdateServiceAccountApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`RegenerateServiceAccountApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationBadRequestException.cs): Invalid JSON or metadata patch. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetOrgQuotaBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgQuotaBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetOrgRateLimitBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgRateLimitBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`CreateClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ListClusterInvitesBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UpdateClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`RevokeClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ListClusterOrgsBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`DeleteClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`InviteClusterOrgMembersBadRequestException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersBadRequestException.cs): Invalid body or batch size. Status code `400`. Applicable to 1 of 459 methods.*
  * [`SuspendClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`UnsuspendClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`ReissueOwnerKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetClusterInviteInfoBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 459 methods.*
  * [`AcceptClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteBadRequestException.cs): Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetJwtFromKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetJwtFromKeyBadRequestException.cs): Invalid request body. Status code `400`. Applicable to 1 of 459 methods.*
  * [`GetPendingInvitationUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetPendingInvitationUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ExchangeSessionTokenUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenUnauthorizedException.cs): Missing, invalid, revoked or expiring session. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetFileContentUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetFileContentUnauthorizedException.cs): Unauthorized - Invalid or missing authentication. Status code `401`. Applicable to 1 of 459 methods.*
  * [`CreateScopedApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ListScopedApiKeysUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UpdateScopedApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`RegenerateScopedApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ExchangeApiKeyTokenUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`CreateTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ListTeamsUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UpdateTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`DeleteTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`AddTeamMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ListTeamMembersUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`RemoveTeamMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`CreateServiceAccountUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountsUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetServiceAccountUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountApiKeysUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UpdateServiceAccountApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`RegenerateServiceAccountApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetOrgQuotaUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgQuotaUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetOrgRateLimitUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgRateLimitUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`CreateClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ListClusterInvitesUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UpdateClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`RevokeClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ListClusterOrgsUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`DeleteClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`InviteClusterOrgMembersUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`SuspendClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`UnsuspendClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`ReissueOwnerKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetClusterInviteInfoUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`AcceptClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetJwtFromKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetJwtFromKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 459 methods.*
  * [`GetPendingInvitationForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetPendingInvitationForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ExchangeSessionTokenForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenForbiddenException.cs): Active organization or team is missing or inaccessible. Status code `403`. Applicable to 1 of 459 methods.*
  * [`CreateScopedApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ListScopedApiKeysForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UpdateScopedApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`RegenerateScopedApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ExchangeApiKeyTokenForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`CreateTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ListTeamsForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UpdateTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`DeleteTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`AddTeamMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ListTeamMembersForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`RemoveTeamMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`CreateServiceAccountForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountsForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetServiceAccountForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountApiKeysForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UpdateServiceAccountApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`RegenerateServiceAccountApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetOrgQuotaForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgQuotaForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetOrgRateLimitForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgRateLimitForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`CreateClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ListClusterInvitesForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UpdateClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`RevokeClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ListClusterOrgsForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`DeleteClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`InviteClusterOrgMembersForbiddenException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`SuspendClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`UnsuspendClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`ReissueOwnerKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetClusterInviteInfoForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`AcceptClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 459 methods.*
  * [`GetFileContentNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetFileContentNotFoundException.cs): File not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`CreateScopedApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ListScopedApiKeysNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UpdateScopedApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`RegenerateScopedApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ExchangeApiKeyTokenNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`CreateTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ListTeamsNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`GetTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UpdateTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`DeleteTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`AddTeamMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ListTeamMembersNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`RemoveTeamMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`CreateServiceAccountNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountsNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`GetServiceAccountNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountApiKeysNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UpdateServiceAccountApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`RegenerateServiceAccountApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`GetOrgQuotaNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgQuotaNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`GetOrgRateLimitNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgRateLimitNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`CreateClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ListClusterInvitesNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UpdateClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`RevokeClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ListClusterOrgsNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`GetClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`DeleteClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`InviteClusterOrgMembersNotFoundException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`SuspendClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`UnsuspendClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`ReissueOwnerKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`GetClusterInviteInfoNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`AcceptClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 459 methods.*
  * [`CreateScopedApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ListScopedApiKeysConflictException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UpdateScopedApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`RegenerateScopedApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ExchangeApiKeyTokenConflictException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`CreateTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ListTeamsConflictException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`GetTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/GetTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UpdateTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`DeleteTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`AddTeamMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ListTeamMembersConflictException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`RemoveTeamMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`CreateServiceAccountConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountsConflictException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`GetServiceAccountConflictException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountApiKeysConflictException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UpdateServiceAccountApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`RegenerateServiceAccountApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdConflictException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`GetOrgQuotaConflictException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgQuotaConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`GetOrgRateLimitConflictException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgRateLimitConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`CreateClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ListClusterInvitesConflictException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UpdateClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`RevokeClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ListClusterOrgsConflictException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`GetClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`DeleteClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`InviteClusterOrgMembersConflictException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`SuspendClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`UnsuspendClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`ReissueOwnerKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`GetClusterInviteInfoConflictException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`AcceptClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 459 methods.*
  * [`CreateScopedApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ListScopedApiKeysGoneException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UpdateScopedApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`RegenerateScopedApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ExchangeApiKeyTokenGoneException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`CreateTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ListTeamsGoneException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`GetTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/GetTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UpdateTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`DeleteTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`AddTeamMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ListTeamMembersGoneException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`RemoveTeamMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`CreateServiceAccountGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountsGoneException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`GetServiceAccountGoneException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountApiKeysGoneException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UpdateServiceAccountApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`RegenerateServiceAccountApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdGoneException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`GetOrgQuotaGoneException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgQuotaGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`GetOrgRateLimitGoneException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgRateLimitGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`CreateClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ListClusterInvitesGoneException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UpdateClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`RevokeClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ListClusterOrgsGoneException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`GetClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`DeleteClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`InviteClusterOrgMembersGoneException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`SuspendClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`UnsuspendClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ReissueOwnerKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`GetClusterInviteInfoGoneException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`AcceptClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 459 methods.*
  * [`ExchangeSessionTokenRequestEntityTooLargeException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenRequestEntityTooLargeException.cs): Request body exceeds the endpoint's 4 KiB limit. Status code `413`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationRequestEntityTooLargeException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationRequestEntityTooLargeException.cs): Request or merged metadata exceeds 64 KiB. Status code `413`. Applicable to 1 of 459 methods.*
  * [`ExchangeSessionTokenTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenTooManyRequestsException.cs): Per-session or per-user mint rate exceeded. Status code `429`. Applicable to 1 of 459 methods.*
  * [`CreateScopedApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ListScopedApiKeysTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UpdateScopedApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`RegenerateScopedApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ExchangeApiKeyTokenTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`CreateTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ListTeamsTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`GetTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UpdateTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`DeleteTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`AddTeamMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ListTeamMembersTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`RemoveTeamMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`CreateServiceAccountTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountsTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`GetServiceAccountTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ListServiceAccountApiKeysTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UpdateServiceAccountApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`DeleteServiceAccountApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`RegenerateServiceAccountApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`GetOrgQuotaTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgQuotaTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`GetOrgRateLimitTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UpdateOrgRateLimitTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`CreateClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ListClusterInvitesTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UpdateClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`RevokeClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ListClusterOrgsTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`GetClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`DeleteClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`InviteClusterOrgMembersTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`SuspendClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`UnsuspendClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ReissueOwnerKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`GetClusterInviteInfoTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`AcceptClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 459 methods.*
  * [`ExchangeSessionTokenInternalServerError`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenInternalServerError.cs): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
  * [`GetFileContentInternalServerError`](./src/MeetKai/MKA1/Types/Errors/GetFileContentInternalServerError.cs): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
  * [`GetOrgByIdInternalServerError`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdInternalServerError.cs): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
  * [`UpdateOrganizationInternalServerError`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationInternalServerError.cs): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 459 methods.*
  * [`GetJwtFromKeyInternalServerError`](./src/MeetKai/MKA1/Types/Errors/GetJwtFromKeyInternalServerError.cs): Internal server error. Status code `500`. Applicable to 1 of 459 methods.*
  * [`ServiceUnavailableException`](./src/MeetKai/MKA1/Types/Errors/ServiceUnavailableException.cs): The invitation spend limit could not be confirmed. The organization and invitation claim were rolled back; retry acceptance. Status code `503`. Applicable to 1 of 459 methods.*
  * [`ResponseValidationError`](./src/MeetKai/MKA1/Types/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                   | Description                                            |
| --- | ------------------------ | ------------------------------------------------------ |
| 0   | `https://apigw.mka1.com` | MKA1 API Gateway                                       |
| 1   | `/`                      | Relative server URL (configurable via SDK constructor) |

#### Example

```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(
    serverIndex: 0,
    bearerAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Permissions.Llm.GrantAsync(body: new GrantPermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Writer,
});

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(
    serverUrl: "https://apigw.mka1.com",
    bearerAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Permissions.Llm.GrantAsync(body: new GrantPermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Writer,
});

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The C# SDK makes API calls using an `ISpeakeasyHttpClient` that wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient). This
client provides the ability to attach hooks around the request lifecycle that can be used to modify the request or handle
errors and response.

The `ISpeakeasyHttpClient` interface allows you to either use the default `SpeakeasyHttpClient` that comes with the SDK,
or provide your own custom implementation with customized configuration such as custom message handlers, timeouts,
connection pooling, and other HTTP client settings.

The following example shows how to create a custom HTTP client with request modification and error handling:

```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Create a custom HTTP client
public class CustomHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _defaultClient;

    public CustomHttpClient()
    {
        _defaultClient = new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Add custom header and timeout
        request.Headers.Add("x-custom-header", "custom value");
        request.Headers.Add("x-request-timeout", "30");
        
        try
        {
            var response = await _defaultClient.SendAsync(request, cancellationToken);
            // Log successful response
            Console.WriteLine($"Request successful: {response.StatusCode}");
            return response;
        }
        catch (Exception error)
        {
            // Log error
            Console.WriteLine($"Request failed: {error.Message}");
            throw;
        }
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
        _defaultClient?.Dispose();
    }
}

// Use the custom HTTP client with the SDK
var customHttpClient = new CustomHttpClient();
var sdk = new SDK(client: customHttpClient);
```

<details>
<summary>You can also provide a completely custom HTTP client with your own configuration:</summary>

```csharp
using MeetKai.MKA1.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Custom HTTP client with custom configuration
public class AdvancedHttpClient : ISpeakeasyHttpClient
{
    private readonly HttpClient _httpClient;

    public AdvancedHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            MaxConnectionsPerServer = 10,
            // ServerCertificateCustomValidationCallback = customCertValidation, // Custom SSL validation if needed
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        return await _httpClient.SendAsync(request, cancellationToken ?? CancellationToken.None);
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}

var sdk = SDK.Builder()
    .WithClient(new AdvancedHttpClient())
    .Build();
```
</details>

<details>
<summary>For simple debugging, you can enable request/response logging by implementing a custom client:</summary>

```csharp
public class LoggingHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _innerClient;

    public LoggingHttpClient(ISpeakeasyHttpClient innerClient = null)
    {
        _innerClient = innerClient ?? new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Log request
        Console.WriteLine($"Sending {request.Method} request to {request.RequestUri}");
        
        var response = await _innerClient.SendAsync(request, cancellationToken);
        
        // Log response
        Console.WriteLine($"Received {response.StatusCode} response");
        
        return response;
    }

    public void Dispose() => _innerClient?.Dispose();
}

var sdk = new SDK(client: new LoggingHttpClient());
```
</details>

The SDK also provides built-in hook support through the `SDKConfiguration.Hooks` system, which automatically handles
`BeforeRequestAsync`, `AfterSuccessAsync`, and `AfterErrorAsync` hooks for advanced request lifecycle management.
<!-- End Custom HTTP Client [http-client] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=mka1&utm_campaign=csharp)
