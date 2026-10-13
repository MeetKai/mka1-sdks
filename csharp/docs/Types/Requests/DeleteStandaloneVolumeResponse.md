# DeleteStandaloneVolumeResponse


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `HttpMeta`                                                                   | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                       | :heavy_check_mark:                                                           | N/A                                                                          |
| `ComputeStandaloneVolume`                                                    | [ComputeStandaloneVolume](../../Types/Components/ComputeStandaloneVolume.md) | :heavy_minus_sign:                                                           | Volume was already deleted                                                   |
| `ComputeErrorEnvelope`                                                       | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md)       | :heavy_minus_sign:                                                           | API error                                                                    |