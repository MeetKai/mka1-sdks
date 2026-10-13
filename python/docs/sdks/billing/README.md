# Billing

## Overview

### Available Operations

* [get_organization_billing](#get_organization_billing)
* [set_organization_billing_enabled](#set_organization_billing_enabled)
* [update_organization_billing_profile](#update_organization_billing_profile)
* [create_organization_billing_setup](#create_organization_billing_setup)
* [create_organization_billing_portal](#create_organization_billing_portal)
* [list_organization_billing_invoices](#list_organization_billing_invoices)

## get_organization_billing

### Example Usage

<!-- UsageSnippet language="python" operationID="getOrganizationBilling" method="get" path="/api/v1/budgeting/billing/org" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.billing.get_organization_billing()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetOrganizationBillingResponse](../../models/getorganizationbillingresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_organization_billing_enabled

### Example Usage

<!-- UsageSnippet language="python" operationID="setOrganizationBillingEnabled" method="put" path="/api/v1/budgeting/billing/org/enabled" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.billing.set_organization_billing_enabled(org_id="<id>", enabled=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `enabled`                                                           | *bool*                                                              | :heavy_check_mark:                                                  | N/A                                                                 |
| `currency`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.SetOrganizationBillingEnabledResponse](../../models/setorganizationbillingenabledresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_organization_billing_profile

### Example Usage

<!-- UsageSnippet language="python" operationID="updateOrganizationBillingProfile" method="put" path="/api/v1/budgeting/billing/org/profile" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.billing.update_organization_billing_profile(legal_name="<value>", billing_email="Leo44@hotmail.com", address={
        "line1": "<value>",
        "city": "Strongsville",
        "postal_code": "49423-7634",
        "country": "Togo",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `legal_name`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `billing_email`                                                     | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `address`                                                           | [models.AddressRequest](../../models/addressrequest.md)             | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.UpdateOrganizationBillingProfileResponse](../../models/updateorganizationbillingprofileresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_organization_billing_setup

### Example Usage

<!-- UsageSnippet language="python" operationID="createOrganizationBillingSetup" method="post" path="/api/v1/budgeting/billing/org/setup-session" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.billing.create_organization_billing_setup(request={})

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [models.CreateOrganizationBillingSetupRequest](../../models/createorganizationbillingsetuprequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |
| `retries`                                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                      | :heavy_minus_sign:                                                                                    | Configuration to override the default retry behavior of the client.                                   |

### Response

**[models.CreateOrganizationBillingSetupResponse](../../models/createorganizationbillingsetupresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_organization_billing_portal

### Example Usage

<!-- UsageSnippet language="python" operationID="createOrganizationBillingPortal" method="post" path="/api/v1/budgeting/billing/org/portal-session" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.billing.create_organization_billing_portal(request={})

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [models.CreateOrganizationBillingPortalRequest](../../models/createorganizationbillingportalrequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `retries`                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                        | :heavy_minus_sign:                                                                                      | Configuration to override the default retry behavior of the client.                                     |

### Response

**[models.CreateOrganizationBillingPortalResponse](../../models/createorganizationbillingportalresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_organization_billing_invoices

### Example Usage

<!-- UsageSnippet language="python" operationID="listOrganizationBillingInvoices" method="get" path="/api/v1/budgeting/billing/org/invoices" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.billing.list_organization_billing_invoices()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListOrganizationBillingInvoicesResponse](../../models/listorganizationbillinginvoicesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |