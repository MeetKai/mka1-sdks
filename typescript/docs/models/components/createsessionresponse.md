# CreateSessionResponse

## Example Usage

```typescript
import { CreateSessionResponse } from "@meetkai/mka1/models/components";

let value: CreateSessionResponse = {
  session: {
    sessionId: "<id>",
    userId: "<id>",
  },
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `session`                                                                | [components.SessionRecord](../../models/components/sessionrecord.md)     | :heavy_check_mark:                                                       | N/A                                                                      |
| `sessionToken`                                                           | *string*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |
| `provider`                                                               | [components.SandboxProvider](../../models/components/sandboxprovider.md) | :heavy_minus_sign:                                                       | N/A                                                                      |