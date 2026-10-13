# Connection

## Example Usage

```typescript
import { Connection } from "@meetkai/mka1/models/components";

let value: Connection = {
  githubLogin: "<value>",
  githubUserId: 422158,
  scopes: "<value>",
  syncedAt: new Date("2025-01-07T23:56:24.113Z"),
  repositories: [],
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `githubLogin`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `githubUserId`                                                                                | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `scopes`                                                                                      | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `syncedAt`                                                                                    | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `tokenInvalidAt`                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `repositories`                                                                                | [components.ConnectedRepository](../../models/components/connectedrepository.md)[]            | :heavy_check_mark:                                                                            | N/A                                                                                           |