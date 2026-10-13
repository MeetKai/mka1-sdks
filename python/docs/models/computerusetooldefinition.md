# ComputerUseToolDefinition

Computer use tool definition: OpenAI-compatible shape for the computer-use preview tool. Not supported by this gateway: Responses requests that include it are rejected with a 400 invalid_request_error.


## Fields

| Field                             | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `type`                            | *Literal["computer_use_preview"]* | :heavy_check_mark:                | N/A                               |
| `display_height`                  | *int*                             | :heavy_check_mark:                | N/A                               |
| `display_width`                   | *int*                             | :heavy_check_mark:                | N/A                               |
| `environment`                     | *str*                             | :heavy_check_mark:                | N/A                               |