# ShellNetworkPolicyDomainSecret


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `Domain`                                              | `string`                                              | :heavy_check_mark:                                    | The domain to associate this secret with.             |
| `Name`                                                | `string`                                              | :heavy_check_mark:                                    | The name/placeholder for the secret (e.g., $API_KEY). |
| `Value`                                               | `string`                                              | :heavy_check_mark:                                    | The secret value to substitute.                       |