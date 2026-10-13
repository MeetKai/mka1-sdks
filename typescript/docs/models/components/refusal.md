# Refusal

Refusal response when the model declines to answer due to safety policies, content moderation, or capability limitations.

## Example Usage

```typescript
import { Refusal } from "@meetkai/mka1/models/components";

let value: Refusal = {
  type: "refusal",
  refusal: "<value>",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `type`                                                                           | *"refusal"*                                                                      | :heavy_check_mark:                                                               | The content type identifier for refusal responses.                               |
| `refusal`                                                                        | *string*                                                                         | :heavy_check_mark:                                                               | The refusal message explaining why the model declined to respond to the request. |