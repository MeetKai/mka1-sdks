# Capabilities

## Example Usage

```typescript
import { Capabilities } from "@meetkai/mka1/models/components";

let value: Capabilities = {
  modalities: {
    input: [
      "image",
    ],
    output: [
      "image",
    ],
  },
  reasoning: false,
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `modalities`                                                                                               | [components.AddCatalogModelRequestModalities](../../models/components/addcatalogmodelrequestmodalities.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `reasoning`                                                                                                | *boolean*                                                                                                  | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `supportsReasoningEffort`                                                                                  | *boolean*                                                                                                  | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `supportedBase64Formats`                                                                                   | *string*[]                                                                                                 | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `supportsCompletionVideoUrlMessage`                                                                        | *boolean*                                                                                                  | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `supportsStructuredOutputs`                                                                                | *boolean*                                                                                                  | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `supportsTemperature`                                                                                      | *boolean*                                                                                                  | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `supportsTopP`                                                                                             | *boolean*                                                                                                  | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `supportsImageDetailOriginal`                                                                              | *boolean*                                                                                                  | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `maxImageResolution`                                                                                       | [components.MaxImageResolution](../../models/components/maximageresolution.md)                             | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `minImageResolution`                                                                                       | [components.MinImageResolution](../../models/components/minimageresolution.md)                             | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |