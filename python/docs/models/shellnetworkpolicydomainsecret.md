# ShellNetworkPolicyDomainSecret


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `domain`                                              | *str*                                                 | :heavy_check_mark:                                    | The domain to associate this secret with.             |
| `name`                                                | *str*                                                 | :heavy_check_mark:                                    | The name/placeholder for the secret (e.g., $API_KEY). |
| `value`                                               | *str*                                                 | :heavy_check_mark:                                    | The secret value to substitute.                       |