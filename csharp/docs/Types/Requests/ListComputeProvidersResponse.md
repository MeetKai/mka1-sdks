# ListComputeProvidersResponse


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `HttpMeta`                                                                       | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                           | :heavy_check_mark:                                                               | N/A                                                                              |
| `ComputeProviderHealthList`                                                      | [ComputeProviderHealthList](../../Types/Components/ComputeProviderHealthList.md) | :heavy_minus_sign:                                                               | Provider poll health                                                             |
| `ComputeErrorEnvelope`                                                           | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md)           | :heavy_minus_sign:                                                               | API error                                                                        |