# GetResponseResponseBody

Successful response - returns either streaming events (SSE) when stream=true or a complete response object (JSON) when stream=false or omitted


## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Event`                                                                                | `*string`                                                                              | :heavy_minus_sign:                                                                     | The event type (optional in SSE)                                                       |
| `Data`                                                                                 | [components.ResponseStreamingEvent](../../models/components/responsestreamingevent.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `ID`                                                                                   | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional event ID for reconnection                                                     |
| `Retry`                                                                                | `*int64`                                                                               | :heavy_minus_sign:                                                                     | Optional reconnection time in milliseconds                                             |