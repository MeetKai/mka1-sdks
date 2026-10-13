# CreateSessionRequest

## Example Usage

```typescript
import { CreateSessionRequest } from "@meetkai/mka1/models/components";

let value: CreateSessionRequest = {
  sessionId: "<id>",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `sessionId`                                                                          | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `sessionKey`                                                                         | *string*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `userId`                                                                             | *string*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `sessionKind`                                                                        | [components.SessionKind](../../models/components/sessionkind.md)                     | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `resourceClass`                                                                      | [components.SandboxResourceClass](../../models/components/sandboxresourceclass.md)   | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `ttlSeconds`                                                                         | *number*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `sandboxFeatures`                                                                    | [components.SandboxFeature](../../models/components/sandboxfeature.md)[]             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `runtimeProfile`                                                                     | [components.SandboxRuntimeProfile](../../models/components/sandboxruntimeprofile.md) | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `memoryMounts`                                                                       | [components.MemoryMount](../../models/components/memorymount.md)[]                   | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `queueIfFull`                                                                        | *boolean*                                                                            | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `skipLlmCredentialExchange`                                                          | *boolean*                                                                            | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `environmentId`                                                                      | *number*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `codingHarnessSkills`                                                                | Record<string, *any*>                                                                | :heavy_minus_sign:                                                                   | N/A                                                                                  |