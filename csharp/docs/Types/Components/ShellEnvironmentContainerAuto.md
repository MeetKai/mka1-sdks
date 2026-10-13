# ShellEnvironmentContainerAuto


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Type`                                                               | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `NetworkPolicy`                                                      | [ShellNetworkPolicy](../../Types/Components/ShellNetworkPolicy.md)   | :heavy_minus_sign:                                                   | N/A                                                                  |
| `Skills`                                                             | List<[SkillEntry](../../Types/Components/SkillEntry.md)>             | :heavy_minus_sign:                                                   | Skills to inject into the container's /skills directory.             |
| `MemoryStores`                                                       | List<[MemoryStoreMount](../../Types/Components/MemoryStoreMount.md)> | :heavy_minus_sign:                                                   | Memory stores to mount into the container under /mnt/memory.         |