# RepoTagList

## Example Usage

```typescript
import { RepoTagList } from "@meetkai/mka1/models/components";

let value: RepoTagList = {
  tags: [],
  truncated: true,
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `tags`                                                                                           | [components.RepoTag](../../models/components/repotag.md)[]                                       | :heavy_check_mark:                                                                               | Newest-moved first.                                                                              |
| `truncated`                                                                                      | *boolean*                                                                                        | :heavy_check_mark:                                                                               | `true` when the repository holds more tags than this one page<br/>(1000) shows. Never silently cut.<br/> |