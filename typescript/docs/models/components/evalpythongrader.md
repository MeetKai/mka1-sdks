# EvalPythonGrader

## Example Usage

```typescript
import { EvalPythonGrader } from "@meetkai/mka1/models/components";

let value: EvalPythonGrader = {
  type: "python",
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `type`                                                                                           | *"python"*                                                                                       | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `contract`                                                                                       | [components.EvalPythonGraderContract](../../models/components/evalpythongradercontract.md)       | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `execution`                                                                                      | [components.EvalPythonGraderExecution](../../models/components/evalpythongraderexecution.md)     | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `modelAccess`                                                                                    | [components.EvalPythonGraderModelAccess](../../models/components/evalpythongradermodelaccess.md) | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `metricId`                                                                                       | *string*                                                                                         | :heavy_minus_sign:                                                                               | Default metric key used when grade returns a single float.                                       |
| `source`                                                                                         | *string*                                                                                         | :heavy_minus_sign:                                                                               | Inline Python source that defines a supported eval grading contract.                             |
| `fileId`                                                                                         | *string*                                                                                         | :heavy_minus_sign:                                                                               | File ID for a Python grader uploaded with purpose 'evals'.                                       |
| `timeoutSeconds`                                                                                 | *number*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `maxModelCalls`                                                                                  | *number*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |