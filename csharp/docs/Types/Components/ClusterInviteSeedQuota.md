# ClusterInviteSeedQuota

API request quota to apply when the invitation is accepted. All fields are required when seedQuota is supplied. Enabling requires non-null period and max; when disabled, period and max must either both be null or both be valid.


## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Enabled`                                                                              | *bool*                                                                                 | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `Period`                                                                               | [ClusterInviteSeedQuotaPeriod](../../Types/Components/ClusterInviteSeedQuotaPeriod.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `Max`                                                                                  | *long*                                                                                 | :heavy_check_mark:                                                                     | N/A                                                                                    |