# ResponseReadFileCallInProgressEvent

## Example Usage

```typescript
import { ResponseReadFileCallInProgressEvent } from "@meetkai/mka1/models/components";

let value: ResponseReadFileCallInProgressEvent = {
  type: "response.read_file_call.in_progress",
  sequenceNumber: 196559,
  itemId: "<id>",
  outputIndex: 230753,
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                                   | *"response.read_file_call.in_progress"*                                                                                  | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `sequenceNumber`                                                                                                         | *number*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `itemId`                                                                                                                 | *string*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `outputIndex`                                                                                                            | *number*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `args`                                                                                                                   | [components.ResponseReadFileCallInProgressEventArgs](../../models/components/responsereadfilecallinprogresseventargs.md) | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |