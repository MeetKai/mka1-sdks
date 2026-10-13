# PutOrgAutoModelRequest1

## Example Usage

```typescript
import { PutOrgAutoModelRequest1 } from "@meetkai/mka1/models/components";

let value: PutOrgAutoModelRequest1 = {
  modelId: "<id>",
};
```

## Fields

| Field                                                                                             | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `modelId`                                                                                         | *string*                                                                                          | :heavy_check_mark:                                                                                | The model id this org's `"auto"` should resolve to directly. Cannot be the literal string "auto". |