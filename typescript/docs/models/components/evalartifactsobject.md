# EvalArtifactsObject

## Example Usage

```typescript
import { EvalArtifactsObject } from "@meetkai/mka1/models/components";

let value: EvalArtifactsObject = {
  object: "eval.artifacts",
  runId: "<id>",
  resultFileId: "<id>",
  samplesFileId: "<id>",
  artifactFileIds: [],
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `object`           | *"eval.artifacts"* | :heavy_check_mark: | N/A                |
| `runId`            | *string*           | :heavy_check_mark: | N/A                |
| `resultFileId`     | *string*           | :heavy_check_mark: | N/A                |
| `samplesFileId`    | *string*           | :heavy_check_mark: | N/A                |
| `artifactFileIds`  | *string*[]         | :heavy_check_mark: | N/A                |