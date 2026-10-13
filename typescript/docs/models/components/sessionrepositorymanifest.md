# SessionRepositoryManifest

## Example Usage

```typescript
import { SessionRepositoryManifest } from "@meetkai/mka1/models/components";

let value: SessionRepositoryManifest = {
  repositories: [
    {
      repositoryId: 862556,
      owner: "<value>",
      repository: "<value>",
      ref: "<value>",
      baseSha: "<value>",
      checkoutAlias: "<value>",
      checkoutPath: "<value>",
      status: "ready",
      createdAt: new Date("2024-06-30T11:14:28.015Z"),
      updatedAt: new Date("2026-02-08T19:39:17.280Z"),
    },
  ],
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `maxRepositories`                                                                        | *number*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |
| `repositories`                                                                           | [components.SessionRepositoryModel](../../models/components/sessionrepositorymodel.md)[] | :heavy_check_mark:                                                                       | N/A                                                                                      |