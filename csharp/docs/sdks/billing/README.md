# Billing

## Overview

### Available Operations

* [GetOrganizationBilling](#getorganizationbilling)
* [SetOrganizationBillingEnabled](#setorganizationbillingenabled)
* [UpdateOrganizationBillingProfile](#updateorganizationbillingprofile)
* [CreateOrganizationBillingSetup](#createorganizationbillingsetup)
* [CreateOrganizationBillingPortal](#createorganizationbillingportal)
* [ListOrganizationBillingInvoices](#listorganizationbillinginvoices)

## GetOrganizationBilling

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrganizationBilling" method="get" path="/api/v1/budgeting/billing/org" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Billing.GetOrganizationBillingAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetOrganizationBillingResponse](../../Types/Requests/GetOrganizationBillingResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetOrganizationBillingEnabled

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setOrganizationBillingEnabled" method="put" path="/api/v1/budgeting/billing/org/enabled" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Billing.SetOrganizationBillingEnabledAsync(
    orgId: "<id>",
    body: new SetOrganizationBillingEnabledRequestBody() {
        Enabled = false,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `OrgId`                                                                                                      | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `Body`                                                                                                       | [SetOrganizationBillingEnabledRequestBody](../../Types/Requests/SetOrganizationBillingEnabledRequestBody.md) | :heavy_check_mark:                                                                                           | N/A                                                                                                          |

### Response

**[SetOrganizationBillingEnabledResponse](../../Types/Requests/SetOrganizationBillingEnabledResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateOrganizationBillingProfile

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateOrganizationBillingProfile" method="put" path="/api/v1/budgeting/billing/org/profile" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

UpdateOrganizationBillingProfileRequest req = new UpdateOrganizationBillingProfileRequest() {
    LegalName = "<value>",
    BillingEmail = "Leo44@hotmail.com",
    Address = new AddressRequest() {
        Line1 = "<value>",
        City = "Strongsville",
        PostalCode = "49423-7634",
        Country = "Togo",
    },
};

var res = await sdk.Billing.UpdateOrganizationBillingProfileAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                  | [UpdateOrganizationBillingProfileRequest](../../Types/Requests/UpdateOrganizationBillingProfileRequest.md) | :heavy_check_mark:                                                                                         | The request object to use for the request.                                                                 |

### Response

**[UpdateOrganizationBillingProfileResponse](../../Types/Requests/UpdateOrganizationBillingProfileResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateOrganizationBillingSetup

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createOrganizationBillingSetup" method="post" path="/api/v1/budgeting/billing/org/setup-session" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

CreateOrganizationBillingSetupRequest req = new CreateOrganizationBillingSetupRequest() {};

var res = await sdk.Billing.CreateOrganizationBillingSetupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `request`                                                                                              | [CreateOrganizationBillingSetupRequest](../../Types/Requests/CreateOrganizationBillingSetupRequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |

### Response

**[CreateOrganizationBillingSetupResponse](../../Types/Requests/CreateOrganizationBillingSetupResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateOrganizationBillingPortal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createOrganizationBillingPortal" method="post" path="/api/v1/budgeting/billing/org/portal-session" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

CreateOrganizationBillingPortalRequest req = new CreateOrganizationBillingPortalRequest() {};

var res = await sdk.Billing.CreateOrganizationBillingPortalAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                | [CreateOrganizationBillingPortalRequest](../../Types/Requests/CreateOrganizationBillingPortalRequest.md) | :heavy_check_mark:                                                                                       | The request object to use for the request.                                                               |

### Response

**[CreateOrganizationBillingPortalResponse](../../Types/Requests/CreateOrganizationBillingPortalResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListOrganizationBillingInvoices

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listOrganizationBillingInvoices" method="get" path="/api/v1/budgeting/billing/org/invoices" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Billing.ListOrganizationBillingInvoicesAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListOrganizationBillingInvoicesResponse](../../Types/Requests/ListOrganizationBillingInvoicesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |