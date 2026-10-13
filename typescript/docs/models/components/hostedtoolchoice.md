# HostedToolChoice

Hosted tool choice: Forces a specific built-in hosted tool type. computer_use_preview is not supported and is rejected with a 400.

## Example Usage

```typescript
import { HostedToolChoice } from "@meetkai/mka1/models/components";

let value: HostedToolChoice = {
  type: "web_search_preview",
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `type`                                                                             | [components.HostedToolChoiceType](../../models/components/hostedtoolchoicetype.md) | :heavy_check_mark:                                                                 | N/A                                                                                |