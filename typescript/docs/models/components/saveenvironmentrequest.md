# SaveEnvironmentRequest

## Example Usage

```typescript
import { SaveEnvironmentRequest } from "@meetkai/mka1/models/components";

let value: SaveEnvironmentRequest = {
  name: "<value>",
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `name`                                                                                           | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `environmentVariables`                                                                           | Record<string, *string*>                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `setupScript`                                                                                    | *string*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `repositories`                                                                                   | [components.EnvironmentRepositoryModel](../../models/components/environmentrepositorymodel.md)[] | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `networkAccess`                                                                                  | [components.NetworkAccess](../../models/components/networkaccess.md)                             | :heavy_minus_sign:                                                                               | N/A                                                                                              |