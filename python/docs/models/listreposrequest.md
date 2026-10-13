# ListReposRequest


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `kind`                                                                                | [Optional[models.RepoKind]](../models/repokind.md)                                    | :heavy_minus_sign:                                                                    | Narrow the listing to one kind. Omit it for every repository,<br/>untyped ones included.<br/> |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |