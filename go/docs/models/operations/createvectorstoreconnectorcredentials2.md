# CreateVectorStoreConnectorCredentials2

The app the customer's Microsoft administrator registered in their own tenant, with read access to the site. Write-only: never returned.


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `TenantID`                                                                      | `string`                                                                        | :heavy_check_mark:                                                              | The Microsoft Entra tenant the app is registered in: its ID or its domain name. |
| `ClientID`                                                                      | `string`                                                                        | :heavy_check_mark:                                                              | N/A                                                                             |
| `ClientSecret`                                                                  | `string`                                                                        | :heavy_check_mark:                                                              | N/A                                                                             |