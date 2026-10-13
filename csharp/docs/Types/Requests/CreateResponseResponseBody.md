# CreateResponseResponseBody

Successful response - returns either streaming events (SSE) or a complete response object (JSON) depending on the stream parameter


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Event`                                                                    | *string*                                                                   | :heavy_minus_sign:                                                         | The event type (optional in SSE)                                           |
| `Data`                                                                     | [ResponseStreamingEvent](../../Types/Components/ResponseStreamingEvent.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `Id`                                                                       | *string*                                                                   | :heavy_minus_sign:                                                         | Optional event ID for reconnection                                         |
| `Retry`                                                                    | *long*                                                                     | :heavy_minus_sign:                                                         | Optional reconnection time in milliseconds                                 |