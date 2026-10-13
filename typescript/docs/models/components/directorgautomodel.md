# DirectOrgAutoModel

## Example Usage

```typescript
import { DirectOrgAutoModel } from "@meetkai/mka1/models/components";

let value: DirectOrgAutoModel = {
  endpoint: "responses",
  setBy: "<value>",
  setAt: new Date("2024-04-08T06:37:59.183Z"),
  mode: "direct",
  modelId: "<id>",
  resolvable: false,
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `endpoint`                                                                                    | [components.AutoEndpoint](../../models/components/autoendpoint.md)                            | :heavy_check_mark:                                                                            | N/A                                                                                           | responses                                                                                     |
| `setBy`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `setAt`                                                                                       | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `mode`                                                                                        | *"direct"*                                                                                    | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `modelId`                                                                                     | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `resolvable`                                                                                  | *boolean*                                                                                     | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |