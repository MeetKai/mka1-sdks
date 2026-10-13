# ShellNetworkPolicyDomainSecret

## Example Usage

```typescript
import { ShellNetworkPolicyDomainSecret } from "@meetkai/mka1/models/components";

let value: ShellNetworkPolicyDomainSecret = {
  domain: "elliptical-digit.info",
  name: "<value>",
  value: "<value>",
};
```

## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `domain`                                              | *string*                                              | :heavy_check_mark:                                    | The domain to associate this secret with.             |
| `name`                                                | *string*                                              | :heavy_check_mark:                                    | The name/placeholder for the secret (e.g., $API_KEY). |
| `value`                                               | *string*                                              | :heavy_check_mark:                                    | The secret value to substitute.                       |