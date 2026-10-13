# ShellEnvironmentContainerAuto

## Example Usage

```typescript
import { ShellEnvironmentContainerAuto } from "@meetkai/mka1/models/components";

let value: ShellEnvironmentContainerAuto = {
  type: "container_auto",
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | *"container_auto"*                                                             | :heavy_check_mark:                                                             | N/A                                                                            |
| `networkPolicy`                                                                | [components.ShellNetworkPolicy](../../models/components/shellnetworkpolicy.md) | :heavy_minus_sign:                                                             | N/A                                                                            |
| `skills`                                                                       | *components.SkillEntry*[]                                                      | :heavy_minus_sign:                                                             | Skills to inject into the container's /skills directory.                       |
| `memoryStores`                                                                 | [components.MemoryStoreMount](../../models/components/memorystoremount.md)[]   | :heavy_minus_sign:                                                             | Memory stores to mount into the container under /mnt/memory.                   |