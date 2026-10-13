# ComputeAccelerator

A catalogue entry. Each hardware class exposes what it has and omits what it lacks: gpu entries always carry vendor, memory_gb, gpu_counts and interconnects; cpu entries always carry vcpu and memory_gb_per_vcpu. Fields of the other class are absent, never reinterpreted.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `DisplayName`                                                  | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `GpuCounts`                                                    | List<*long*>                                                   | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |
| `HardwareClass`                                                | [HardwareClass](../../Types/Components/HardwareClass.md)       | :heavy_check_mark:                                             | N/A                                                            |
| `Interconnects`                                                | List<*string*>                                                 | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |
| `MemoryGb`                                                     | *long*                                                         | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |
| `MemoryGbPerVcpu`                                              | *long*                                                         | :heavy_minus_sign:                                             | Present on every cpu-class entry, absent on gpu-class entries. |
| `Name`                                                         | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `Vcpu`                                                         | [Vcpu](../../Types/Components/Vcpu.md)                         | :heavy_minus_sign:                                             | Present on every cpu-class entry, absent on gpu-class entries. |
| `Vendor`                                                       | [Types.Components.Vendor](../../Types/Components/Vendor.md)    | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |