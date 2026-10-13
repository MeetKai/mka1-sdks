# CreateRepoRequest

## Example Usage

```typescript
import { CreateRepoRequest } from "@meetkai/mka1/models/components";

let value: CreateRepoRequest = {
  name: "my-model",
};
```

## Fields

| Field                                                                                                       | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 | Example                                                                                                     |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `description`                                                                                               | *string*                                                                                                    | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |                                                                                                             |
| `kind`                                                                                                      | [components.CreateRepoRequestKind](../../models/components/createreporequestkind.md)                        | :heavy_minus_sign:                                                                                          | What the repository will hold. Defaults to `repo`.                                                          |                                                                                                             |
| `name`                                                                                                      | *string*                                                                                                    | :heavy_check_mark:                                                                                          | The repository name. Must start with an alphanumeric character and<br/>be ≤100 characters of `[A-Za-z0-9._-]`.<br/> | my-model                                                                                                    |