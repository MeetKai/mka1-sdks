# RateLimits

## Example Usage

```typescript
import { RateLimits } from "@meetkai/mka1/models/components";

let value: RateLimits = {
  scope: "org",
  rpm: 491713,
};
```

## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `scope`                                              | [components.Scope](../../models/components/scope.md) | :heavy_check_mark:                                   | N/A                                                  |
| `rpm`                                                | *number*                                             | :heavy_check_mark:                                   | N/A                                                  |
| `duration`                                           | *number*                                             | :heavy_minus_sign:                                   | N/A                                                  |
| `queue`                                              | [components.Queue](../../models/components/queue.md) | :heavy_minus_sign:                                   | N/A                                                  |