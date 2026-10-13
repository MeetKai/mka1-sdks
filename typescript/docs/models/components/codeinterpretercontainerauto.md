# CodeInterpreterContainerAuto

## Example Usage

```typescript
import { CodeInterpreterContainerAuto } from "@meetkai/mka1/models/components";

let value: CodeInterpreterContainerAuto = {
  type: "auto",
};
```

## Fields

| Field                                                                                                                 | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                                | *"auto"*                                                                                                              | :heavy_check_mark:                                                                                                    | N/A                                                                                                                   |
| `fileIds`                                                                                                             | *string*[]                                                                                                            | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |
| `memoryLimit`                                                                                                         | [components.MemoryLimit](../../models/components/memorylimit.md)                                                      | :heavy_minus_sign:                                                                                                    | Unsupported for new requests: non-null caller memory limits return a validation error. Retained for historical reads. |