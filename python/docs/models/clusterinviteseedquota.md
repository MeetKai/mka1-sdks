# ClusterInviteSeedQuota

API request quota to apply when the invitation is accepted. All fields are required when seedQuota is supplied. Enabling requires non-null period and max; when disabled, period and max must either both be null or both be valid.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `enabled`                                                                                  | *bool*                                                                                     | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `period`                                                                                   | [Nullable[models.ClusterInviteSeedQuotaPeriod]](../models/clusterinviteseedquotaperiod.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `max`                                                                                      | *Nullable[int]*                                                                            | :heavy_check_mark:                                                                         | N/A                                                                                        |