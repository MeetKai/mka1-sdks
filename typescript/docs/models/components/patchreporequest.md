# PatchRepoRequest

A partial update. Every field is optional; an omitted field is left
unchanged.


## Example Usage

```typescript
import { PatchRepoRequest } from "@meetkai/mka1/models/components";

let value: PatchRepoRequest = {};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `description`                                                                                                          | *string*                                                                                                               | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `kind`                                                                                                                 | [components.RepoKind](../../models/components/repokind.md)                                                             | :heavy_minus_sign:                                                                                                     | Switch the repository's kind (see the operation description for<br/>the rules). Cannot be `null`: a kind is never un-set.<br/> |
| `name`                                                                                                                 | *string*                                                                                                               | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |