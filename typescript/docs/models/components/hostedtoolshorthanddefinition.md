# HostedToolShorthandDefinition

Request shorthand for a hosted tool. Configuration fields must satisfy the detailed tool schema; malformed fields are rejected.

## Example Usage

```typescript
import { HostedToolShorthandDefinition } from "@meetkai/mka1/models/components";

let value: HostedToolShorthandDefinition = {
  type: "web_search_preview",
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                       | [components.HostedToolShorthandDefinitionType](../../models/components/hostedtoolshorthanddefinitiontype.md) | :heavy_check_mark:                                                                                           | N/A                                                                                                          |