# WakeResponseResponseBody

The sleeping response was signalled to wake.

## Example Usage

```typescript
import { WakeResponseResponseBody } from "@meetkai/mka1/models/operations";

let value: WakeResponseResponseBody = {
  object: "response.sleep_wake",
  responseId: "<id>",
  createdAt: new Date("2024-10-30T15:59:44.603Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `object`                                                                                      | [operations.ObjectT](../../models/operations/objectt.md)                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `responseId`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |