# AddModelCatalogOrgAccessRequest

## Example Usage

```typescript
import { AddModelCatalogOrgAccessRequest } from "@meetkai/mka1/models/operations";

let value: AddModelCatalogOrgAccessRequest = {
  orgId: "org-acme",
  addAccessMutationRequest: {
    modelIds: [],
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `orgId`                                                                                    | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | org-acme                                                                                   |
| `addAccessMutationRequest`                                                                 | [components.AddAccessMutationRequest](../../models/components/addaccessmutationrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |