# MKA1 C# SDK

Official C# SDK for the MKA1 API.

Use `MeetKai.MKA1` to call MKA1 from .NET applications. The SDK includes typed clients for responses, agents, files, vector stores, evals, usage, model registry operations, guardrails, sandbox APIs, and more.

Full product and API documentation lives at [docs.mka1.com](https://docs.mka1.com).

<!-- Start Summary [summary] -->
## Summary

MKA1 API: The MKA1 API is a RESTful API that provides access to the MKA1 platform. Learn how to get started with the API and the TypeScript SDK [here](https://mka1.apidocumentation.com/guides/getting-started).
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [MKA1 C# SDK](#mka1-c-sdk)
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

var res = await sdk.Auth.Orgs.ListMembersAsync(
    security: new ListOrgMembersSecurity() {

    }, orgId: "<id>"
);

// handle response
```
<!-- End Authentication [security] -->

## Available Resources and Operations

The per-operation reference, with request and response shapes and examples for every SDK, is at [docs.mka1.com/api-reference](https://docs.mka1.com/api-reference).

<!-- No Available Resources and Operations [operations] -->

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

<details><summary>Less common exceptions (376)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`SDKException`](./src/MeetKai/MKA1/Types/Errors/SDKException.cs):
  * [`HTTPValidationError`](./src/MeetKai/MKA1/Types/Errors/HTTPValidationError.cs): Validation Error. Status code `422`. Applicable to 49 of 503 methods.*
  * [`ErrorEnvelope`](./src/MeetKai/MKA1/Types/Errors/ErrorEnvelope.cs): Error response. Applicable to 29 of 503 methods.*
  * [`FeatureFlagError`](./src/MeetKai/MKA1/Types/Errors/FeatureFlagError.cs): The request is malformed or fails validation. Applicable to 22 of 503 methods.*
  * [`AnalyticsError`](./src/MeetKai/MKA1/Types/Errors/AnalyticsError.cs): Request failed. Applicable to 12 of 503 methods.*
  * [`RepoError`](./src/MeetKai/MKA1/Types/Errors/RepoError.cs): The uniform error envelope. `error` is a stable machine-readable code (never an internal reason); `correlation_id` echoes the request's `X-Correlation-ID` for log correlation. Applicable to 7 of 503 methods.*
  * [`ExchangeSessionTokenBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenBadRequestException.cs): Invalid request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetFileContentBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetFileContentBadRequestException.cs): Invalid request - File ID is required. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListOrgMembersBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListOrgMembersBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`InviteOrgMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/InviteOrgMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`RemoveOrgMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RemoveOrgMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetSsoPolicyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetSsoPolicyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateSsoPolicyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateSsoPolicyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationBadRequestException.cs): Invalid JSON or metadata patch. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetOrgQuotaBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgQuotaBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetOrgRateLimitBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgRateLimitBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetOrgInboundRulesBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetOrgInboundRulesBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgInboundRulesBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgInboundRulesBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetNetworkPolicyAccessBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetNetworkPolicyAccessBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`CreateTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListTeamsBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`DeleteTeamBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`AddTeamMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListTeamMembersBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`RemoveTeamMemberBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`CreateScopedApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListScopedApiKeysBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateScopedApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`RegenerateScopedApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ExchangeApiKeyTokenBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`CreateServiceAccountBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountsBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetServiceAccountBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountApiKeysBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateServiceAccountApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`RegenerateServiceAccountApiKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`CreateClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListClusterInvitesBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UpdateClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`RevokeClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ListClusterOrgsBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`DeleteClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`InviteClusterOrgMembersBadRequestException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersBadRequestException.cs): Invalid body or batch size. Status code `400`. Applicable to 1 of 503 methods.*
  * [`SuspendClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`UnsuspendClusterOrgBadRequestException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`ReissueOwnerKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetClusterInviteInfoBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoBadRequestException.cs): Bad request. Status code `400`. Applicable to 1 of 503 methods.*
  * [`AcceptClusterInviteBadRequestException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteBadRequestException.cs): Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetJwtFromKeyBadRequestException`](./src/MeetKai/MKA1/Types/Errors/GetJwtFromKeyBadRequestException.cs): Invalid request body. Status code `400`. Applicable to 1 of 503 methods.*
  * [`GetPendingInvitationUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetPendingInvitationUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ExchangeSessionTokenUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenUnauthorizedException.cs): Missing, invalid, revoked or expiring session. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetFileContentUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetFileContentUnauthorizedException.cs): Unauthorized - Invalid or missing authentication. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListOrgMembersUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListOrgMembersUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`InviteOrgMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/InviteOrgMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`RemoveOrgMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RemoveOrgMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetSsoPolicyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetSsoPolicyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateSsoPolicyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateSsoPolicyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetOrgQuotaUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgQuotaUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetOrgRateLimitUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgRateLimitUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetOrgInboundRulesUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetOrgInboundRulesUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgInboundRulesUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgInboundRulesUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetNetworkPolicyAccessUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetNetworkPolicyAccessUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`CreateTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListTeamsUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`DeleteTeamUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`AddTeamMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListTeamMembersUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`RemoveTeamMemberUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`CreateScopedApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListScopedApiKeysUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateScopedApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`RegenerateScopedApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ExchangeApiKeyTokenUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`CreateServiceAccountUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountsUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetServiceAccountUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountApiKeysUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateServiceAccountApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`RegenerateServiceAccountApiKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`CreateClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListClusterInvitesUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UpdateClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`RevokeClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ListClusterOrgsUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`DeleteClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`InviteClusterOrgMembersUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`SuspendClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`UnsuspendClusterOrgUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`ReissueOwnerKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetClusterInviteInfoUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`AcceptClusterInviteUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetJwtFromKeyUnauthorizedException`](./src/MeetKai/MKA1/Types/Errors/GetJwtFromKeyUnauthorizedException.cs): Unauthorized. Status code `401`. Applicable to 1 of 503 methods.*
  * [`GetPendingInvitationForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetPendingInvitationForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ExchangeSessionTokenForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenForbiddenException.cs): Active organization or team is missing or inaccessible. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListOrgMembersForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListOrgMembersForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`InviteOrgMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/InviteOrgMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`RemoveOrgMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RemoveOrgMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetSsoPolicyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetSsoPolicyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateSsoPolicyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateSsoPolicyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetOrgQuotaForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgQuotaForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetOrgRateLimitForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgRateLimitForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetOrgInboundRulesForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetOrgInboundRulesForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgInboundRulesForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgInboundRulesForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetNetworkPolicyAccessForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetNetworkPolicyAccessForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`CreateTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListTeamsForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`DeleteTeamForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`AddTeamMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListTeamMembersForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`RemoveTeamMemberForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`CreateScopedApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListScopedApiKeysForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateScopedApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`RegenerateScopedApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ExchangeApiKeyTokenForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`CreateServiceAccountForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountsForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetServiceAccountForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountApiKeysForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateServiceAccountApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`RegenerateServiceAccountApiKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`CreateClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListClusterInvitesForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UpdateClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`RevokeClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ListClusterOrgsForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`DeleteClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`InviteClusterOrgMembersForbiddenException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`SuspendClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`UnsuspendClusterOrgForbiddenException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`ReissueOwnerKeyForbiddenException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetClusterInviteInfoForbiddenException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`AcceptClusterInviteForbiddenException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteForbiddenException.cs): Forbidden. Status code `403`. Applicable to 1 of 503 methods.*
  * [`GetFileContentNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetFileContentNotFoundException.cs): File not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListOrgMembersNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListOrgMembersNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`InviteOrgMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/InviteOrgMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`RemoveOrgMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RemoveOrgMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetSsoPolicyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetSsoPolicyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateSsoPolicyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateSsoPolicyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetOrgQuotaNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgQuotaNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetOrgRateLimitNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgRateLimitNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetOrgInboundRulesNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetOrgInboundRulesNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgInboundRulesNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgInboundRulesNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetNetworkPolicyAccessNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetNetworkPolicyAccessNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`CreateTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListTeamsNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`DeleteTeamNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`AddTeamMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListTeamMembersNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`RemoveTeamMemberNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`CreateScopedApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListScopedApiKeysNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateScopedApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`RegenerateScopedApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ExchangeApiKeyTokenNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`CreateServiceAccountNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountsNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetServiceAccountNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountApiKeysNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateServiceAccountApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`RegenerateServiceAccountApiKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`CreateClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListClusterInvitesNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UpdateClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`RevokeClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListClusterOrgsNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`DeleteClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`InviteClusterOrgMembersNotFoundException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`SuspendClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`UnsuspendClusterOrgNotFoundException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ReissueOwnerKeyNotFoundException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`GetClusterInviteInfoNotFoundException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`AcceptClusterInviteNotFoundException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteNotFoundException.cs): Not found. Status code `404`. Applicable to 1 of 503 methods.*
  * [`ListOrgMembersConflictException`](./src/MeetKai/MKA1/Types/Errors/ListOrgMembersConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`InviteOrgMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/InviteOrgMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`RemoveOrgMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/RemoveOrgMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetSsoPolicyConflictException`](./src/MeetKai/MKA1/Types/Errors/GetSsoPolicyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateSsoPolicyConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateSsoPolicyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdConflictException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetOrgQuotaConflictException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgQuotaConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetOrgRateLimitConflictException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgRateLimitConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetOrgInboundRulesConflictException`](./src/MeetKai/MKA1/Types/Errors/GetOrgInboundRulesConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgInboundRulesConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgInboundRulesConflictException.cs): Conflict. `code: "inbound_rules_unavailable"` means enabling was refused because inbound rules are not enabled on this cluster; a disabled policy can still be saved. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetNetworkPolicyAccessConflictException`](./src/MeetKai/MKA1/Types/Errors/GetNetworkPolicyAccessConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`CreateTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListTeamsConflictException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/GetTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`DeleteTeamConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`AddTeamMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListTeamMembersConflictException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`RemoveTeamMemberConflictException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`CreateScopedApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListScopedApiKeysConflictException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateScopedApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`RegenerateScopedApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ExchangeApiKeyTokenConflictException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`CreateServiceAccountConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountsConflictException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetServiceAccountConflictException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountApiKeysConflictException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateServiceAccountApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`RegenerateServiceAccountApiKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`CreateClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListClusterInvitesConflictException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UpdateClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`RevokeClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListClusterOrgsConflictException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`DeleteClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`InviteClusterOrgMembersConflictException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`SuspendClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`UnsuspendClusterOrgConflictException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ReissueOwnerKeyConflictException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`GetClusterInviteInfoConflictException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`AcceptClusterInviteConflictException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteConflictException.cs): Conflict. Status code `409`. Applicable to 1 of 503 methods.*
  * [`ListOrgMembersGoneException`](./src/MeetKai/MKA1/Types/Errors/ListOrgMembersGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`InviteOrgMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/InviteOrgMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`RemoveOrgMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/RemoveOrgMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetSsoPolicyGoneException`](./src/MeetKai/MKA1/Types/Errors/GetSsoPolicyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateSsoPolicyGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateSsoPolicyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdGoneException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetOrgQuotaGoneException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgQuotaGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetOrgRateLimitGoneException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgRateLimitGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetOrgInboundRulesGoneException`](./src/MeetKai/MKA1/Types/Errors/GetOrgInboundRulesGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgInboundRulesGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgInboundRulesGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetNetworkPolicyAccessGoneException`](./src/MeetKai/MKA1/Types/Errors/GetNetworkPolicyAccessGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`CreateTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ListTeamsGoneException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/GetTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`DeleteTeamGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`AddTeamMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ListTeamMembersGoneException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`RemoveTeamMemberGoneException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`CreateScopedApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ListScopedApiKeysGoneException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateScopedApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`RegenerateScopedApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ExchangeApiKeyTokenGoneException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`CreateServiceAccountGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountsGoneException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetServiceAccountGoneException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountApiKeysGoneException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateServiceAccountApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`RegenerateServiceAccountApiKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`CreateClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ListClusterInvitesGoneException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UpdateClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`RevokeClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ListClusterOrgsGoneException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`DeleteClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`InviteClusterOrgMembersGoneException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`SuspendClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`UnsuspendClusterOrgGoneException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ReissueOwnerKeyGoneException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`GetClusterInviteInfoGoneException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`AcceptClusterInviteGoneException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteGoneException.cs): Gone. Status code `410`. Applicable to 1 of 503 methods.*
  * [`ExchangeSessionTokenRequestEntityTooLargeException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenRequestEntityTooLargeException.cs): Request body exceeds the endpoint's 4 KiB limit. Status code `413`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationRequestEntityTooLargeException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationRequestEntityTooLargeException.cs): Request or merged metadata exceeds 64 KiB. Status code `413`. Applicable to 1 of 503 methods.*
  * [`ExchangeSessionTokenTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenTooManyRequestsException.cs): Per-session or per-user mint rate exceeded. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListOrgMembersTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListOrgMembersTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`InviteOrgMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/InviteOrgMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`RemoveOrgMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RemoveOrgMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetSsoPolicyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetSsoPolicyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateSsoPolicyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateSsoPolicyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetOrgQuotaTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetOrgQuotaTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgQuotaTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgQuotaTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetOrgRateLimitTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetOrgRateLimitTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgRateLimitTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgRateLimitTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetOrgInboundRulesTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetOrgInboundRulesTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateOrgInboundRulesTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateOrgInboundRulesTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetNetworkPolicyAccessTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetNetworkPolicyAccessTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`CreateTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListTeamsTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListTeamsTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`DeleteTeamTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteTeamTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`AddTeamMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/AddTeamMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListTeamMembersTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListTeamMembersTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateTeamMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateTeamMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`RemoveTeamMemberTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RemoveTeamMemberTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`CreateScopedApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateScopedApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListScopedApiKeysTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListScopedApiKeysTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateScopedApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateScopedApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`RegenerateScopedApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RegenerateScopedApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ExchangeApiKeyTokenTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ExchangeApiKeyTokenTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`CreateServiceAccountTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateServiceAccountTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountsTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountsTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetServiceAccountTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetServiceAccountTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListServiceAccountApiKeysTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListServiceAccountApiKeysTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateServiceAccountApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateServiceAccountApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`DeleteServiceAccountApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteServiceAccountApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`RegenerateServiceAccountApiKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RegenerateServiceAccountApiKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`CreateClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/CreateClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListClusterInvitesTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListClusterInvitesTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UpdateClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UpdateClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`RevokeClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/RevokeClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ListClusterOrgsTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ListClusterOrgsTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`DeleteClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/DeleteClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`InviteClusterOrgMembersTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/InviteClusterOrgMembersTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`SuspendClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/SuspendClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`UnsuspendClusterOrgTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/UnsuspendClusterOrgTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ReissueOwnerKeyTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/ReissueOwnerKeyTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`GetClusterInviteInfoTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/GetClusterInviteInfoTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`AcceptClusterInviteTooManyRequestsException`](./src/MeetKai/MKA1/Types/Errors/AcceptClusterInviteTooManyRequestsException.cs): Rate limited. Status code `429`. Applicable to 1 of 503 methods.*
  * [`ExchangeSessionTokenInternalServerError`](./src/MeetKai/MKA1/Types/Errors/ExchangeSessionTokenInternalServerError.cs): Internal server error. Status code `500`. Applicable to 1 of 503 methods.*
  * [`GetFileContentInternalServerError`](./src/MeetKai/MKA1/Types/Errors/GetFileContentInternalServerError.cs): Internal server error. Status code `500`. Applicable to 1 of 503 methods.*
  * [`GetOrgByIdInternalServerError`](./src/MeetKai/MKA1/Types/Errors/GetOrgByIdInternalServerError.cs): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 503 methods.*
  * [`UpdateOrganizationInternalServerError`](./src/MeetKai/MKA1/Types/Errors/UpdateOrganizationInternalServerError.cs): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 503 methods.*
  * [`GetJwtFromKeyInternalServerError`](./src/MeetKai/MKA1/Types/Errors/GetJwtFromKeyInternalServerError.cs): Internal server error. Status code `500`. Applicable to 1 of 503 methods.*
  * [`ServiceUnavailableException`](./src/MeetKai/MKA1/Types/Errors/ServiceUnavailableException.cs): The invitation spend limit could not be confirmed. The organization and invitation claim were rolled back; retry acceptance. Status code `503`. Applicable to 1 of 503 methods.*
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
