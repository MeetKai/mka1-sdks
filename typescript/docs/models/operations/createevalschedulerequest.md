# CreateEvalScheduleRequest

## Example Usage

```typescript
import { CreateEvalScheduleRequest } from "@meetkai/mka1/models/operations";

let value: CreateEvalScheduleRequest = {
  createEvalScheduleRequest: {
    name: "<value>",
    suiteId: "<id>",
    run: {
      models: [],
    },
  },
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |
| `createEvalScheduleRequest`                                                                  | [components.CreateEvalScheduleRequest](../../models/components/createevalschedulerequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |