# GetResponseResponseBody

Successful response - returns either streaming events (SSE) when stream=true or a complete response object (JSON) when stream=false or omitted


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `event`                                                              | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | The event type (optional in SSE)                                     |
| `data`                                                               | [models.ResponseStreamingEvent](../models/responsestreamingevent.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `id`                                                                 | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | Optional event ID for reconnection                                   |
| `retry`                                                              | *Optional[int]*                                                      | :heavy_minus_sign:                                                   | Optional reconnection time in milliseconds                           |