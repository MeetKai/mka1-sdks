# GetInferenceMetricsRequest


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `From`                                                                              | [*time.Time](https://pkg.go.dev/time#Time)                                          | :heavy_minus_sign:                                                                  | Start of the window. Defaults to 24 hours before to.                                |
| `To`                                                                                | [*time.Time](https://pkg.go.dev/time#Time)                                          | :heavy_minus_sign:                                                                  | End of the window, exclusive. Defaults to now. The window may span at most 31 days. |
| `XOnBehalfOf`                                                                       | `*string`                                                                           | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |