# ClickAction

## Example Usage

```typescript
import { ClickAction } from "@meetkai/mka1/models/components";

let value: ClickAction = {
  type: "click",
  button: "forward",
  x: 129071,
  y: 439025,
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `type`                                                 | *"click"*                                              | :heavy_check_mark:                                     | N/A                                                    |
| `button`                                               | [components.Button](../../models/components/button.md) | :heavy_check_mark:                                     | N/A                                                    |
| `x`                                                    | *number*                                               | :heavy_check_mark:                                     | N/A                                                    |
| `y`                                                    | *number*                                               | :heavy_check_mark:                                     | N/A                                                    |