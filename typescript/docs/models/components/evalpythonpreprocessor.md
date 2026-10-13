# EvalPythonPreprocessor

## Example Usage

```typescript
import { EvalPythonPreprocessor } from "@meetkai/mka1/models/components";

let value: EvalPythonPreprocessor = {
  type: "python",
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `type`                                                                     | *"python"*                                                                 | :heavy_check_mark:                                                         | N/A                                                                        |
| `contract`                                                                 | [components.Contract](../../models/components/contract.md)                 | :heavy_minus_sign:                                                         | Run transform(row) per row or transform_batch(rows) once.                  |
| `source`                                                                   | *string*                                                                   | :heavy_minus_sign:                                                         | Inline Python source that transforms dataset rows before prompt rendering. |
| `fileId`                                                                   | *string*                                                                   | :heavy_minus_sign:                                                         | File ID for a Python preprocessor uploaded with purpose 'evals'.           |
| `timeoutSeconds`                                                           | *number*                                                                   | :heavy_minus_sign:                                                         | N/A                                                                        |