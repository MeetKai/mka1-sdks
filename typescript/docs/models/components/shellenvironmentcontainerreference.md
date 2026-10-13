# ShellEnvironmentContainerReference

## Example Usage

```typescript
import { ShellEnvironmentContainerReference } from "@meetkai/mka1/models/components";

let value: ShellEnvironmentContainerReference = {
  type: "container_reference",
  containerId: "<id>",
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | *"container_reference"*                                                        | :heavy_check_mark:                                                             | N/A                                                                            |
| `containerId`                                                                  | *string*                                                                       | :heavy_check_mark:                                                             | ID of an existing container to reuse.                                          |
| `networkPolicy`                                                                | [components.ShellNetworkPolicy](../../models/components/shellnetworkpolicy.md) | :heavy_minus_sign:                                                             | N/A                                                                            |
| `skills`                                                                       | *components.SkillEntry*[]                                                      | :heavy_minus_sign:                                                             | Skills to inject into the container's /skills directory.                       |
| `memoryStores`                                                                 | [components.MemoryStoreMount](../../models/components/memorystoremount.md)[]   | :heavy_minus_sign:                                                             | Memory stores to mount into the container under /mnt/memory.                   |