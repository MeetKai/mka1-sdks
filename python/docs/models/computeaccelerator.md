# ComputeAccelerator

A catalogue entry. Each hardware class exposes what it has and omits what it lacks: gpu entries always carry vendor, memory_gb, gpu_counts and interconnects; cpu entries always carry vcpu and memory_gb_per_vcpu. Fields of the other class are absent, never reinterpreted.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `display_name`                                                 | *str*                                                          | :heavy_check_mark:                                             | N/A                                                            |
| `gpu_counts`                                                   | List[*int*]                                                    | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |
| `hardware_class`                                               | [models.HardwareClass](../models/hardwareclass.md)             | :heavy_check_mark:                                             | N/A                                                            |
| `interconnects`                                                | List[*str*]                                                    | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |
| `memory_gb`                                                    | *Optional[int]*                                                | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |
| `memory_gb_per_vcpu`                                           | *Optional[int]*                                                | :heavy_minus_sign:                                             | Present on every cpu-class entry, absent on gpu-class entries. |
| `name`                                                         | *str*                                                          | :heavy_check_mark:                                             | N/A                                                            |
| `vcpu`                                                         | [Optional[models.Vcpu]](../models/vcpu.md)                     | :heavy_minus_sign:                                             | Present on every cpu-class entry, absent on gpu-class entries. |
| `vendor`                                                       | [Optional[models.Vendor]](../models/vendor.md)                 | :heavy_minus_sign:                                             | Present on every gpu-class entry, absent on cpu-class entries. |