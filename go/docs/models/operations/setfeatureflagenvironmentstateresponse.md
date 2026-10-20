# SetFeatureFlagEnvironmentStateResponse


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `HTTPMeta`                                                                  | [components.HTTPMetadata](../../models/components/httpmetadata.md)          | :heavy_check_mark:                                                          | N/A                                                                         |
| `FeatureFlagState`                                                          | [*components.FeatureFlagState](../../models/components/featureflagstate.md) | :heavy_minus_sign:                                                          | Saved state                                                                 |
| `Headers`                                                                   | map[string][]`string`                                                       | :heavy_check_mark:                                                          | N/A                                                                         |