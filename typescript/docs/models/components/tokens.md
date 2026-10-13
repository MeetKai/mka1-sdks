# Tokens

Summed over the run's trials. Each field is null when no trial reported it.

## Example Usage

```typescript
import { Tokens } from "@meetkai/mka1/models/components";

let value: Tokens = {
  input: 701134,
  output: 603062,
  cached: 125595,
  reasoning: 791861,
};
```

## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `input`                                                                               | *number*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `output`                                                                              | *number*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `cached`                                                                              | *number*                                                                              | :heavy_check_mark:                                                                    | Share of `input` served from the provider's prompt cache.                             |
| `reasoning`                                                                           | *number*                                                                              | :heavy_check_mark:                                                                    | Reasoning tokens inside `output`, over the samples whose provider reported the split. |