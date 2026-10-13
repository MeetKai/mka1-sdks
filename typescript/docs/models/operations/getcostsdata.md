# GetCostsData

## Example Usage

```typescript
import { GetCostsData } from "@meetkai/mka1/models/operations";

let value: GetCostsData = {
  service: null,
  taskType: "<value>",
  model: "Alpine",
  apiKeyId: "<id>",
  teamId: "<id>",
  userId: null,
  externalUserId: "<id>",
  orgId: "<id>",
  cost: 555.08,
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `service`          | *string*           | :heavy_check_mark: | N/A                |
| `taskType`         | *string*           | :heavy_check_mark: | N/A                |
| `model`            | *string*           | :heavy_check_mark: | N/A                |
| `apiKeyId`         | *string*           | :heavy_check_mark: | N/A                |
| `teamId`           | *string*           | :heavy_check_mark: | N/A                |
| `userId`           | *string*           | :heavy_check_mark: | N/A                |
| `externalUserId`   | *string*           | :heavy_check_mark: | N/A                |
| `orgId`            | *string*           | :heavy_check_mark: | N/A                |
| `cost`             | *number*           | :heavy_check_mark: | N/A                |