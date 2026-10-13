# ExchangeSessionTokenRequestBody

## Example Usage

```typescript
import { ExchangeSessionTokenRequestBody } from "@meetkai/mka1/models/operations";

let value: ExchangeSessionTokenRequestBody = {
  audience: "https://interesting-safe.info/",
};
```

## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `audience`                                                                          | *string*                                                                            | :heavy_check_mark:                                                                  | Exact configured HTTPS gateway audience that will accept the session-derived token. |