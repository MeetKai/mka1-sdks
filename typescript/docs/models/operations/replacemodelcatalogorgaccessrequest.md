# ReplaceModelCatalogOrgAccessRequest

## Example Usage

```typescript
import { ReplaceModelCatalogOrgAccessRequest } from "@meetkai/mka1/models/operations";

let value: ReplaceModelCatalogOrgAccessRequest = {
  orgId: "org-acme",
  accessMutationRequest: {
    modelIds: [
      "<value 1>",
      "<value 2>",
      "<value 3>",
    ],
  },
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          | Example                                                                              |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `orgId`                                                                              | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  | org-acme                                                                             |
| `accessMutationRequest`                                                              | [components.AccessMutationRequest](../../models/components/accessmutationrequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |                                                                                      |