# GetComputeUsageResponse


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `HttpMeta`                                                              | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                  | :heavy_check_mark:                                                      | N/A                                                                     |
| `ComputeUsage`                                                          | [Types.Components.ComputeUsage](../../Types/Components/ComputeUsage.md) | :heavy_minus_sign:                                                      | Usage in the half-open requested window                                 |
| `ComputeErrorEnvelope`                                                  | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md)  | :heavy_minus_sign:                                                      | API error                                                               |