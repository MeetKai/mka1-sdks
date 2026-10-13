# Resources

The Job's resource request (§3.2). Kubernetes quantity strings, passed through verbatim.

## Example Usage

```typescript
import { Resources } from "@meetkai/mka1/models/components";

let value: Resources = {};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `cpu`              | *string*           | :heavy_minus_sign: | N/A                |
| `memory`           | *string*           | :heavy_minus_sign: | N/A                |
| `ephemeralStorage` | *string*           | :heavy_minus_sign: | N/A                |