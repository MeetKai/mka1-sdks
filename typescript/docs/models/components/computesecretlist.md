# ComputeSecretList

## Example Usage

```typescript
import { ComputeSecretList } from "@meetkai/mka1/models/components";

let value: ComputeSecretList = {
  nextCursor: "<value>",
  total: 163191,
  data: [],
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `nextCursor`                                                           | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `total`                                                                | *number*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `data`                                                                 | [components.ComputeSecret](../../models/components/computesecret.md)[] | :heavy_check_mark:                                                     | N/A                                                                    |