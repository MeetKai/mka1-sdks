# ComputePort

## Example Usage

```typescript
import { ComputePort } from "@meetkai/mka1/models/components";

let value: ComputePort = {
  containerPort: 816862,
  name: "<value>",
  protocol: "http",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `containerPort`                                            | *number*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `name`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `protocol`                                                 | [components.Protocol](../../models/components/protocol.md) | :heavy_check_mark:                                         | N/A                                                        |