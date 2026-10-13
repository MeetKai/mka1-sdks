# Compute

## Example Usage

```typescript
import { Compute } from "@meetkai/mka1/models/components";

let value: Compute = {
  accelerator: "<value>",
  ephemeralDiskGb: 612303,
  gpuCount: 257750,
  gpuMemoryGb: 401054,
  instanceCount: 438934,
  memoryGb: 615661,
  vcpus: 780514,
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `accelerator`      | *string*           | :heavy_check_mark: | N/A                |
| `ephemeralDiskGb`  | *number*           | :heavy_check_mark: | N/A                |
| `gpuCount`         | *number*           | :heavy_check_mark: | N/A                |
| `gpuMemoryGb`      | *number*           | :heavy_check_mark: | N/A                |
| `instanceCount`    | *number*           | :heavy_check_mark: | N/A                |
| `interconnect`     | *string*           | :heavy_minus_sign: | N/A                |
| `memoryGb`         | *number*           | :heavy_check_mark: | N/A                |
| `vcpus`            | *number*           | :heavy_check_mark: | N/A                |