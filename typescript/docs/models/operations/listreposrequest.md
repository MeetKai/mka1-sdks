# ListReposRequest

## Example Usage

```typescript
import { ListReposRequest } from "@meetkai/mka1/models/operations";

let value: ListReposRequest = {};
```

## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `kind`                                                                                | [components.RepoKind](../../models/components/repokind.md)                            | :heavy_minus_sign:                                                                    | Narrow the listing to one kind. Omit it for every repository,<br/>untyped ones included.<br/> |
| `xOnBehalfOf`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |