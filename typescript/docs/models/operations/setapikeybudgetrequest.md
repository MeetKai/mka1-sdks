# SetApiKeyBudgetRequest

## Example Usage

```typescript
import { SetApiKeyBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetApiKeyBudgetRequest = {
  apiKeyId: "<id>",
  requestBody: {
    period: "weekly",
    limit: 2900.2,
    thresholds: [],
  },
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `apiKeyId`                                                                                     | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `requestBody`                                                                                  | [operations.SetApiKeyBudgetRequestBody](../../models/operations/setapikeybudgetrequestbody.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |