# CreateResponseResponseBody

Successful response - returns either streaming events (SSE) or a complete response object (JSON) depending on the stream parameter


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `event`                                                              | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | The event type (optional in SSE)                                     |
| `data`                                                               | [models.ResponseStreamingEvent](../models/responsestreamingevent.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `id`                                                                 | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | Optional event ID for reconnection                                   |
| `retry`                                                              | *Optional[int]*                                                      | :heavy_minus_sign:                                                   | Optional reconnection time in milliseconds                           |