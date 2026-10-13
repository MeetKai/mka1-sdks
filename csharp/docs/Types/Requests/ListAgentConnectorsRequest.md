# ListAgentConnectorsRequest


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | The agent ID.                                                                |
| `Limit`                                                                      | *long*                                                                       | :heavy_minus_sign:                                                           | N/A                                                                          |
| `Order`                                                                      | [ListAgentConnectorsOrder](../../Types/Requests/ListAgentConnectorsOrder.md) | :heavy_minus_sign:                                                           | N/A                                                                          |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |