# ActivateAgentConnectorRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ID`                                                                | `string`                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `ConnectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |