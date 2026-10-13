# TerminateServiceResponse


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `HttpMeta`                                                             | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `ComputeService`                                                       | [ComputeService](../../Types/Components/ComputeService.md)             | :heavy_minus_sign:                                                     | Current service after idempotent termination request                   |
| `ComputeErrorEnvelope`                                                 | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md) | :heavy_minus_sign:                                                     | API error                                                              |