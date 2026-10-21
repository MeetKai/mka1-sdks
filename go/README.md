# MKA1 Go SDK

Official Go SDK for the MKA1 API.

Use `github.com/MeetKai/mka1-sdks/go` to call MKA1 from Go.
Set the API server URL with `mka1.WithServerURL` when creating the client.

Full product and API documentation lives at [docs.mka1.com](https://docs.mka1.com).

<!-- Start Summary [summary] -->
## Summary

MKA1 API: The MKA1 API is a RESTful API that provides access to the MKA1 platform. Learn how to get started with the API and the TypeScript SDK [here](https://mka1.apidocumentation.com/guides/getting-started).
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [MKA1 Go SDK](#mka1-go-sdk)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Server-sent event streaming](#server-sent-event-streaming)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
  * [Custom HTTP Client](#custom-http-client)
  * [Special Types](#special-types)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

To add the SDK as a dependency to your project:
```bash
go get github.com/MeetKai/mka1-sdks/go
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
		ResourceType: components.LlmResourceTypeCompletion,
		ResourceID:   "my-completion-123",
		UserID:       "user-abc456",
		Role:         components.ResourceRoleWriter,
	}, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res != nil {
		// handle response
	}
}

```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type | Scheme      |
| ------------ | ---- | ----------- |
| `BearerAuth` | http | HTTP Bearer |

You can configure it using the `WithSecurity` option when initializing the SDK client instance. For example:
```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
		ResourceType: components.LlmResourceTypeCompletion,
		ResourceID:   "my-completion-123",
		UserID:       "user-abc456",
		Role:         components.ResourceRoleWriter,
	}, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res != nil {
		// handle response
	}
}

```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New()

	res, err := s.Auth.Orgs.ListMembers(ctx, operations.ListOrgMembersSecurity{}, "<id>", nil, nil, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res.Object != nil {
		// handle response
	}
}

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
* [CancelAgentRun](docs/sdks/agentruns/README.md#cancelagentrun) - Cancel a saved-agent run
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

* [ListFunctionTools](docs/sdks/agents/README.md#listfunctiontools) - List reusable function tools
* [CreateFunctionTool](docs/sdks/agents/README.md#createfunctiontool) - Create a reusable function tool
* [GetFunctionTool](docs/sdks/agents/README.md#getfunctiontool) - Get a reusable function tool
* [UpdateFunctionTool](docs/sdks/agents/README.md#updatefunctiontool) - Replace a reusable function definition
* [DeleteFunctionTool](docs/sdks/agents/README.md#deletefunctiontool) - Delete a reusable function tool
* [ListAgents](docs/sdks/agents/README.md#listagents) - List agents
* [CreateAgent](docs/sdks/agents/README.md#createagent) - Create an agent
* [GetAgent](docs/sdks/agents/README.md#getagent) - Retrieve an agent
* [UpdateAgent](docs/sdks/agents/README.md#updateagent) - Update an agent
* [DeleteAgent](docs/sdks/agents/README.md#deleteagent) - Soft-delete an agent
* [RestoreAgent](docs/sdks/agents/README.md#restoreagent) - Restore a soft-deleted agent

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

* [ListMembers](docs/sdks/orgs/README.md#listmembers) - List organization members
* [InviteMember](docs/sdks/orgs/README.md#invitemember) - Invite an organization member
* [UpdateMember](docs/sdks/orgs/README.md#updatemember) - Change an organization member's role
* [RemoveMember](docs/sdks/orgs/README.md#removemember) - Remove an organization member
* [GetSsoPolicy](docs/sdks/orgs/README.md#getssopolicy) - Read enterprise SSO role mapping policy
* [UpdateSsoPolicy](docs/sdks/orgs/README.md#updatessopolicy) - Update enterprise SSO role mapping policy
* [GetByID](docs/sdks/orgs/README.md#getbyid) - Get basic organization details
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
* [ListAPIKeys](docs/sdks/serviceaccounts/README.md#listapikeys) - List a service account's API keys
* [UpdateAPIKey](docs/sdks/serviceaccounts/README.md#updateapikey) - Update a service-account API key
* [DeleteAPIKey](docs/sdks/serviceaccounts/README.md#deleteapikey) - Delete a service-account API key
* [RegenerateAPIKey](docs/sdks/serviceaccounts/README.md#regenerateapikey) - Rotate a service-account API key's secret

### [Auth.Teams](docs/sdks/teams/README.md)

* [GetNetworkPolicyAccess](docs/sdks/teams/README.md#getnetworkpolicyaccess) - Read current network policy management access
* [Create](docs/sdks/teams/README.md#create) - Create a team
* [List](docs/sdks/teams/README.md#list) - List teams in an org
* [Get](docs/sdks/teams/README.md#get) - Get a team
* [Update](docs/sdks/teams/README.md#update) - Rename a team
* [Delete](docs/sdks/teams/README.md#delete) - Delete a team
* [AddMember](docs/sdks/teams/README.md#addmember) - Add a team member
* [ListMembers](docs/sdks/teams/README.md#listmembers) - List team members
* [UpdateMember](docs/sdks/teams/README.md#updatemember) - Set a team member role
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
* [GetAPIKey](docs/sdks/budgets/README.md#getapikey) - List apikey budgets
* [SetAPIKey](docs/sdks/budgets/README.md#setapikey) - Set an apikey budget
* [DeleteAPIKey](docs/sdks/budgets/README.md#deleteapikey) - Delete an apikey budget
* [APIKeyEvents](docs/sdks/budgets/README.md#apikeyevents) - List apikey budget events
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
* [GetClusterDefaultGuardrails](docs/sdks/guardrails/README.md#getclusterdefaultguardrails) - Get the cluster default guardrails
* [UpdateClusterDefaultGuardrails](docs/sdks/guardrails/README.md#updateclusterdefaultguardrails) - Update the cluster default guardrails
* [ResetClusterDefaultGuardrails](docs/sdks/guardrails/README.md#resetclusterdefaultguardrails) - Reset the cluster default guardrails
* [GetClusterDefaultGuardrailsOrg](docs/sdks/guardrails/README.md#getclusterdefaultguardrailsorg) - Get an organization's cluster default enrollment
* [UpdateClusterDefaultGuardrailsOrg](docs/sdks/guardrails/README.md#updateclusterdefaultguardrailsorg) - Enroll an organization in the cluster default

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
* [ListSuiteShares](docs/sdks/evals/README.md#listsuiteshares) - List eval suite shares
* [CreateSuiteShare](docs/sdks/evals/README.md#createsuiteshare) - Share an eval suite with an org
* [DeleteSuiteShare](docs/sdks/evals/README.md#deletesuiteshare) - Unshare an eval suite from an org
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
* [GetQuota](docs/sdks/models/README.md#getquota) - Read a model's token quota
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
* [ListPermissions](docs/sdks/vectorstores/README.md#listpermissions) - List vector store permissions
* [CreatePermission](docs/sdks/vectorstores/README.md#createpermission) - Grant a vector store permission
* [GetPermission](docs/sdks/vectorstores/README.md#getpermission) - Retrieve a vector store permission
* [DeletePermission](docs/sdks/vectorstores/README.md#deletepermission) - Remove a vector store permission

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
* [GetBrowserURL](docs/sdks/sandbox/README.md#getbrowserurl) - Get Browser Session URL
* [~~GetURL~~](docs/sdks/sandbox/README.md#geturl) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [GetBrowserURL](docs/sdks/sandbox/README.md#getbrowserurl) instead.
* [ProxyBrowserPortRequest](docs/sdks/sandbox/README.md#proxybrowserportrequest) - Proxy Browser Port Request
* [RunCommand](docs/sdks/sandbox/README.md#runcommand) - Run Command
* [RunCode](docs/sdks/sandbox/README.md#runcode) - Run Code
* [Terminate](docs/sdks/sandbox/README.md#terminate) - Terminate Session
* [GetWorkspace](docs/sdks/sandbox/README.md#getworkspace) - Get Workspace Manifest
* [DownloadFile](docs/sdks/sandbox/README.md#downloadfile) - Download Workspace File
* [UploadFile](docs/sdks/sandbox/README.md#uploadfile) - Upload Workspace File
* [DownloadArchive](docs/sdks/sandbox/README.md#downloadarchive) - Download Workspace Archive
* [UploadArchive](docs/sdks/sandbox/README.md#uploadarchive) - Upload Workspace Archive

#### [Sandbox.Connectors](docs/sdks/connectors/README.md)

* [List](docs/sdks/connectors/README.md#list) - List Connectors
* [CreateAuthorizationIntent](docs/sdks/connectors/README.md#createauthorizationintent) - Start Connector Sign-In
* [Connect](docs/sdks/connectors/README.md#connect) - Finish Connector Sign-In
* [SetAPIKey](docs/sdks/connectors/README.md#setapikey) - Set Connector API Key
* [Disconnect](docs/sdks/connectors/README.md#disconnect) - Disconnect Connector
* [ListTools](docs/sdks/connectors/README.md#listtools) - List Connector Tools
* [SetTools](docs/sdks/connectors/README.md#settools) - Set Connector Tool Allowlist

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

#### [Sandbox.NetworkPolicies](docs/sdks/networkpolicies/README.md)

* [Effective](docs/sdks/networkpolicies/README.md#effective) - Get Effective Network Policy
* [Get](docs/sdks/networkpolicies/README.md#get) - Get Tenant Network Policy
* [Set](docs/sdks/networkpolicies/README.md#set) - Set Tenant Network Policy

### [Session](docs/sdks/session/README.md)

* [GetPendingInvitation](docs/sdks/session/README.md#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
* [ExchangeSessionToken](docs/sdks/session/README.md#exchangesessiontoken) - Exchange a live session for a delegated access token

### [Sessions](docs/sdks/sessions/README.md)

* [GetTenantResourcePolicy](docs/sdks/sessions/README.md#gettenantresourcepolicy) - Get
* [SetTenantResourcePolicy](docs/sdks/sessions/README.md#settenantresourcepolicy) - Save

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

[Server-sent events][mdn-sse] are used to stream content from certain
operations. These operations will expose the stream as an iterable that
can be consumed using a simple `for` loop. The loop will
terminate when the server no longer has any events to send and closes the
underlying connection.

```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Llm.Responses.Create(ctx, components.ResponsesCreateRequest{
		Model: "meetkai:functionary-urdu-mini-pak",
		Input: mka1.Pointer(components.CreateResponsesCreateRequestInputStr(
			"What is the capital of France?",
		)),
	}, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res.ResponseObject != nil {
		defer res.Object.Close()

		for res.Object.Next() {
			event := res.Object.Value()
			log.Print(event)
			// Handle the event
		}
	}
}

```

[mdn-sse]: https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events
<!-- End Server-sent event streaming [eventstream] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply provide a `retry.Config` object to the call by using the `WithRetries` option:
```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/retry"
	"log"
	"models/operations"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
		ResourceType: components.LlmResourceTypeCompletion,
		ResourceID:   "my-completion-123",
		UserID:       "user-abc456",
		Role:         components.ResourceRoleWriter,
	}, nil, operations.WithRetries(
		retry.Config{
			Strategy: "backoff",
			Backoff: &retry.BackoffStrategy{
				InitialInterval: 1,
				MaxInterval:     50,
				Exponent:        1.1,
				MaxElapsedTime:  100,
			},
			RetryConnectionErrors: false,
		}))
	if err != nil {
		log.Fatal(err)
	}
	if res != nil {
		// handle response
	}
}

```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `WithRetryConfig` option at SDK initialization:
```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/retry"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithRetryConfig(
			retry.Config{
				Strategy: "backoff",
				Backoff: &retry.BackoffStrategy{
					InitialInterval: 1,
					MaxInterval:     50,
					Exponent:        1.1,
					MaxElapsedTime:  100,
				},
				RetryConnectionErrors: false,
			}),
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
		ResourceType: components.LlmResourceTypeCompletion,
		ResourceID:   "my-completion-123",
		UserID:       "user-abc456",
		Role:         components.ResourceRoleWriter,
	}, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res != nil {
		// handle response
	}
}

```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or an error, they will never return both.

By Default, an API error will return `apierrors.APIError`. When custom error responses are specified for an operation, the SDK may also return their associated error. You can refer to respective *Errors* tables in SDK docs for more details on possible error types for each operation.

For example, the `Content` function may return the following errors:

| Error Type                                  | Status Code | Content Type     |
| ------------------------------------------- | ----------- | ---------------- |
| apierrors.GetFileContentBadRequestError     | 400         | application/json |
| apierrors.GetFileContentUnauthorizedError   | 401         | application/json |
| apierrors.GetFileContentNotFoundError       | 404         | application/json |
| apierrors.GetFileContentInternalServerError | 500         | application/json |
| apierrors.APIError                          | 4XX, 5XX    | \*/\*            |

### Example

```go
package main

import (
	"context"
	"errors"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/apierrors"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Llm.Files.Content(ctx, "file-abc123", nil)
	if err != nil {

		var e *apierrors.GetFileContentBadRequestError
		if errors.As(err, &e) {
			// handle error
			log.Fatal(e.Error())
		}

		var e *apierrors.GetFileContentUnauthorizedError
		if errors.As(err, &e) {
			// handle error
			log.Fatal(e.Error())
		}

		var e *apierrors.GetFileContentNotFoundError
		if errors.As(err, &e) {
			// handle error
			log.Fatal(e.Error())
		}

		var e *apierrors.GetFileContentInternalServerError
		if errors.As(err, &e) {
			// handle error
			log.Fatal(e.Error())
		}

		var e *apierrors.APIError
		if errors.As(err, &e) {
			// handle error
			log.Fatal(e.Error())
		}
	}
}

```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally using the `WithServerIndex(serverIndex int)` option when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                   | Description                                            |
| --- | ------------------------ | ------------------------------------------------------ |
| 0   | `https://apigw.mka1.com` | MKA1 API Gateway                                       |
| 1   | `/`                      | Relative server URL (configurable via SDK constructor) |

#### Example

```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithServerIndex(0),
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
		ResourceType: components.LlmResourceTypeCompletion,
		ResourceID:   "my-completion-123",
		UserID:       "user-abc456",
		Role:         components.ResourceRoleWriter,
	}, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res != nil {
		// handle response
	}
}

```

### Override Server URL Per-Client

The default server can also be overridden globally using the `WithServerURL(serverURL string)` option when initializing the SDK client instance. For example:
```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithServerURL("https://apigw.mka1.com"),
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
		ResourceType: components.LlmResourceTypeCompletion,
		ResourceID:   "my-completion-123",
		UserID:       "user-abc456",
		Role:         components.ResourceRoleWriter,
	}, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res != nil {
		// handle response
	}
}

```
<!-- End Server Selection [server] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The Go SDK makes API calls that wrap an internal HTTP client. The requirements for the HTTP client are very simple. It must match this interface:

```go
type HTTPClient interface {
	Do(req *http.Request) (*http.Response, error)
}
```

The built-in `net/http` client satisfies this interface and a default client based on the built-in is provided by default. To replace this default with a client of your own, you can implement this interface yourself or provide your own client configured as desired. Here's a simple example, which adds a client with a 30 second timeout.

```go
import (
	"net/http"
	"time"

	"github.com/MeetKai/mka1-sdks/go"
)

var (
	httpClient = &http.Client{Timeout: 30 * time.Second}
	sdkClient  = mka1.New(mka1.WithClient(httpClient))
)
```

This can be a convenient way to configure timeouts, cookies, proxies, custom headers, and other low-level configuration.
<!-- End Custom HTTP Client [http-client] -->

<!-- Start Special Types [types] -->
## Special Types

This SDK defines the following custom types to assist with marshalling and unmarshalling data.

### Date

`types.Date` is a wrapper around time.Time that allows for JSON marshaling a date string formatted as "2006-01-02".

#### Usage

```go
d1 := types.NewDate(time.Now()) // returns *types.Date

d2 := types.DateFromTime(time.Now()) // returns types.Date

d3, err := types.NewDateFromString("2019-01-01") // returns *types.Date, error

d4, err := types.DateFromString("2019-01-01") // returns types.Date, error

d5 := types.MustNewDateFromString("2019-01-01") // returns *types.Date and panics on error

d6 := types.MustDateFromString("2019-01-01") // returns types.Date and panics on error
```
<!-- End Special Types [types] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=mka1&utm_campaign=go)
