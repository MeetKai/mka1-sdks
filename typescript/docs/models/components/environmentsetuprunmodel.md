# EnvironmentSetupRunModel

## Example Usage

```typescript
import { EnvironmentSetupRunModel } from "@meetkai/mka1/models/components";

let value: EnvironmentSetupRunModel = {
  sessionId: "<id>",
  status: "succeeded",
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `sessionId`                                                                                            | *string*                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `status`                                                                                               | [components.EnvironmentSetupRunModelStatus](../../models/components/environmentsetuprunmodelstatus.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `exitCode`                                                                                             | *number*                                                                                               | :heavy_minus_sign:                                                                                     | N/A                                                                                                    |
| `detail`                                                                                               | *string*                                                                                               | :heavy_minus_sign:                                                                                     | N/A                                                                                                    |