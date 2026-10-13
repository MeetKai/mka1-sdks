# OrganizationCodeConfig

## Example Usage

```typescript
import { OrganizationCodeConfig } from "@meetkai/mka1/models/components";

let value: OrganizationCodeConfig = {
  releaseManifestUrl: "https://passionate-thorn.net",
};
```

## Fields

| Field                                                                                                                                                                                     | Type                                                                                                                                                                                      | Required                                                                                                                                                                                  | Description                                                                                                                                                                               |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `releaseManifestUrl`                                                                                                                                                                      | *string*                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                        | Canonical public HTTPS URL ending in /latest/manifest.json. Credentials, non-default ports, queries, fragments, path-normalization spellings, and private or reserved hosts are rejected. |