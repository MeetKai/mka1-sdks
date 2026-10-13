# ShellNetworkPolicy

## Example Usage

```typescript
import { ShellNetworkPolicy } from "@meetkai/mka1/models/components";

let value: ShellNetworkPolicy = {
  type: "allowlist",
};
```

## Fields

| Field                                                                                                                                          | Type                                                                                                                                           | Required                                                                                                                                       | Description                                                                                                                                    |
| ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                                                         | *"allowlist"*                                                                                                                                  | :heavy_check_mark:                                                                                                                             | N/A                                                                                                                                            |
| `allowedDomains`                                                                                                                               | *string*[]                                                                                                                                     | :heavy_minus_sign:                                                                                                                             | Allowed hostnames and their subdomains. An empty or omitted list denies all outbound access. Intersects with tenant and operator restrictions. |
| `domainSecrets`                                                                                                                                | [components.ShellNetworkPolicyDomainSecret](../../models/components/shellnetworkpolicydomainsecret.md)[]                                       | :heavy_minus_sign:                                                                                                                             | Secrets injected per domain.                                                                                                                   |