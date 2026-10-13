# UpdateServiceScalingResponse


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `HttpMeta`                                                             | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `ComputeService`                                                       | [ComputeService](../../Types/Components/ComputeService.md)             | :heavy_minus_sign:                                                     | Scaling policy accepted for asynchronous reconciliation                |
| `ComputeErrorEnvelope`                                                 | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md) | :heavy_minus_sign:                                                     | API error                                                              |
| `Headers`                                                              | Dictionary<String, List<*string*>>                                     | :heavy_check_mark:                                                     | N/A                                                                    |