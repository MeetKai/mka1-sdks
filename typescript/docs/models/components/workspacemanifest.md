# WorkspaceManifest

## Example Usage

```typescript
import { WorkspaceManifest } from "@meetkai/mka1/models/components";

let value: WorkspaceManifest = {
  sessionId: "<id>",
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `sessionId`                                                            | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `files`                                                                | [components.WorkspaceFile](../../models/components/workspacefile.md)[] | :heavy_minus_sign:                                                     | N/A                                                                    |
| `paths`                                                                | *string*[]                                                             | :heavy_minus_sign:                                                     | N/A                                                                    |