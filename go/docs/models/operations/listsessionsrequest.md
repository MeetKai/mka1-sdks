# ListSessionsRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionKey`                                                        | optionalnullable.OptionalNullable[`string`]                         | :heavy_minus_sign:                                                  | Only sessions created with this session_key.                        |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |