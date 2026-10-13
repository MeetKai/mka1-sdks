# FeatureFlagAuditPage

## Example Usage

```typescript
import { FeatureFlagAuditPage } from "@meetkai/mka1/models/components";

let value: FeatureFlagAuditPage = {
  entries: [],
  nextBefore: 639214,
};
```

## Fields

| Field                                                                                                                         | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `entries`                                                                                                                     | [components.FeatureFlagAuditEntry](../../models/components/featureflagauditentry.md)[]                                        | :heavy_check_mark:                                                                                                            | N/A                                                                                                                           |
| `nextBefore`                                                                                                                  | *number*                                                                                                                      | :heavy_check_mark:                                                                                                            | Pass as `before` to read the next page. Null when the log is exhausted, including when this page happened to be exactly full. |