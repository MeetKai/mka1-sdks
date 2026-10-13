# ComputeAccelerator

A catalogue entry. Each hardware class exposes what it has and omits what it lacks: gpu entries always carry vendor, memory_gb, gpu_counts and interconnects; cpu entries always carry vcpu and memory_gb_per_vcpu. Fields of the other class are absent, never reinterpreted.

## Example Usage

```typescript
import { ComputeAccelerator } from "@meetkai/mka1/models/components";

let value: ComputeAccelerator = {
  displayName: "Lacey.Hintz",
  hardwareClass: "cpu",
  name: "<value>",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `displayName`                                                        | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `gpuCounts`                                                          | *number*[]                                                           | :heavy_minus_sign:                                                   | Present on every gpu-class entry, absent on cpu-class entries.       |
| `hardwareClass`                                                      | [components.HardwareClass](../../models/components/hardwareclass.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `interconnects`                                                      | *string*[]                                                           | :heavy_minus_sign:                                                   | Present on every gpu-class entry, absent on cpu-class entries.       |
| `memoryGb`                                                           | *number*                                                             | :heavy_minus_sign:                                                   | Present on every gpu-class entry, absent on cpu-class entries.       |
| `memoryGbPerVcpu`                                                    | *number*                                                             | :heavy_minus_sign:                                                   | Present on every cpu-class entry, absent on gpu-class entries.       |
| `name`                                                               | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `vcpu`                                                               | [components.Vcpu](../../models/components/vcpu.md)                   | :heavy_minus_sign:                                                   | Present on every cpu-class entry, absent on gpu-class entries.       |
| `vendor`                                                             | [components.Vendor](../../models/components/vendor.md)               | :heavy_minus_sign:                                                   | Present on every gpu-class entry, absent on cpu-class entries.       |