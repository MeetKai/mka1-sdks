# ListStandaloneVolumesResponse


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `HttpMeta`                                                                           | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                               | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `ComputeStandaloneVolumeList`                                                        | [ComputeStandaloneVolumeList](../../Types/Components/ComputeStandaloneVolumeList.md) | :heavy_minus_sign:                                                                   | Organization-owned standalone volumes                                                |
| `ComputeErrorEnvelope`                                                               | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md)               | :heavy_minus_sign:                                                                   | API error                                                                            |