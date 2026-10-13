# ShellEnvironmentContainerAuto


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `type`                                                                 | *Literal["container_auto"]*                                            | :heavy_check_mark:                                                     | N/A                                                                    |
| `network_policy`                                                       | [Optional[models.ShellNetworkPolicy]](../models/shellnetworkpolicy.md) | :heavy_minus_sign:                                                     | N/A                                                                    |
| `skills`                                                               | List[[models.SkillEntry](../models/skillentry.md)]                     | :heavy_minus_sign:                                                     | Skills to inject into the container's /skills directory.               |
| `memory_stores`                                                        | List[[models.MemoryStoreMount](../models/memorystoremount.md)]         | :heavy_minus_sign:                                                     | Memory stores to mount into the container under /mnt/memory.           |