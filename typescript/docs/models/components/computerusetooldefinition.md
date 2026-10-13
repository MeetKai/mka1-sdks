# ComputerUseToolDefinition

Computer use tool definition: OpenAI-compatible shape for the computer-use preview tool. Not supported by this gateway: Responses requests that include it are rejected with a 400 invalid_request_error.

## Example Usage

```typescript
import { ComputerUseToolDefinition } from "@meetkai/mka1/models/components";

let value: ComputerUseToolDefinition = {
  type: "computer_use_preview",
  displayHeight: 388527,
  displayWidth: 950446,
  environment: "<value>",
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `type`                   | *"computer_use_preview"* | :heavy_check_mark:       | N/A                      |
| `displayHeight`          | *number*                 | :heavy_check_mark:       | N/A                      |
| `displayWidth`           | *number*                 | :heavy_check_mark:       | N/A                      |
| `environment`            | *string*                 | :heavy_check_mark:       | N/A                      |