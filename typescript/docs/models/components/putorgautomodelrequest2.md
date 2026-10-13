# PutOrgAutoModelRequest2

## Example Usage

```typescript
import { PutOrgAutoModelRequest2 } from "@meetkai/mka1/models/components";

let value: PutOrgAutoModelRequest2 = {
  judgeModelId: "<id>",
  candidateModelIds: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `policy`                                                                                           | [components.Policy](../../models/components/policy.md)                                             | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `judgeModelId`                                                                                     | *string*                                                                                           | :heavy_check_mark:                                                                                 | An active, non-reasoning text LLM used only to select among eligible candidates.                   |
| `candidateModelIds`                                                                                | *string*[]                                                                                         | :heavy_check_mark:                                                                                 | One to 16 active models compatible with this endpoint. Revoked models are ignored at request time. |