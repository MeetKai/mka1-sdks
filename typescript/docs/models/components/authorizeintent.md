# AuthorizeIntent

## Example Usage

```typescript
import { AuthorizeIntent } from "@meetkai/mka1/models/components";

let value: AuthorizeIntent = {
  state: "North Carolina",
  authorizeUrl: "https://grizzled-instance.net/",
  expiresInSeconds: 532418,
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `state`            | *string*           | :heavy_check_mark: | N/A                |
| `authorizeUrl`     | *string*           | :heavy_check_mark: | N/A                |
| `expiresInSeconds` | *number*           | :heavy_check_mark: | N/A                |