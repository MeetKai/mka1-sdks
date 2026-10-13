# BanWordsConfig

Configuration for banned words guardrail

## Example Usage

```typescript
import { BanWordsConfig } from "@meetkai/mka1/models/components";

let value: BanWordsConfig = {};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `words`                                                | *string*[]                                             | :heavy_minus_sign:                                     | List of banned words or phrases                        |
| `rejectionMessage`                                     | *string*                                               | :heavy_minus_sign:                                     | The message to return when this guardrail is triggered |