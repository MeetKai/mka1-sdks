# ClassifierConfig

## Example Usage

```typescript
import { ClassifierConfig } from "@meetkai/mka1/models/components";

let value: ClassifierConfig = {
  model: "Silverado",
  prompt: "<value>",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `model`                                                                              | *string*                                                                             | :heavy_check_mark:                                                                   | Exact model ID available in the caller's organization registry                       |
| `prompt`                                                                             | *string*                                                                             | :heavy_check_mark:                                                                   | Instructions defining when to block or allow content; content is supplied separately |
| `onError`                                                                            | [components.OnError](../../models/components/onerror.md)                             | :heavy_minus_sign:                                                                   | Stop the request or skip this classifier when evaluation fails                       |
| `rejectionMessage`                                                                   | *string*                                                                             | :heavy_minus_sign:                                                                   | Message returned when classification blocks content                                  |