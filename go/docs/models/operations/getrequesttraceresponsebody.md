# GetRequestTraceResponseBody

End-to-end trace of one API request


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Object`                                                              | `string`                                                              | :heavy_check_mark:                                                    | N/A                                                                   |
| `RequestID`                                                           | `string`                                                              | :heavy_check_mark:                                                    | The ID that was looked up                                             |
| `Truncated`                                                           | `bool`                                                                | :heavy_check_mark:                                                    | True when more gateway records or responses matched than are returned |
| `Gateway`                                                             | [][operations.Gateway](../../models/operations/gateway.md)            | :heavy_check_mark:                                                    | Edge records for the request                                          |
| `Responses`                                                           | [][operations.Response](../../models/operations/response.md)          | :heavy_check_mark:                                                    | Responses the request created, including agents it called             |