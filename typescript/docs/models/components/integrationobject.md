# IntegrationObject

## Example Usage

```typescript
import { IntegrationObject } from "@meetkai/mka1/models/components";

let value: IntegrationObject = {
  type: "wandb",
  wandb: {
    project: "<value>",
  },
};
```

## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `type`                                               | *"wandb"*                                            | :heavy_check_mark:                                   | N/A                                                  |
| `wandb`                                              | [components.Wandb](../../models/components/wandb.md) | :heavy_check_mark:                                   | N/A                                                  |