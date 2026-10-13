# AllowedTools

Allowed tools tool choice: Restricts tool use to a provided list and sets whether tool use is optional (auto) or mandatory (required).

## Example Usage

```typescript
import { AllowedTools } from "@meetkai/mka1/models/components";

let value: AllowedTools = {
  type: "allowed_tools",
  mode: "auto",
  tools: [
    {
      type: "<value>",
    },
  ],
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | *"allowed_tools"*                                                              | :heavy_check_mark:                                                             | N/A                                                                            |
| `mode`                                                                         | [components.Mode](../../models/components/mode.md)                             | :heavy_check_mark:                                                             | N/A                                                                            |
| `tools`                                                                        | [components.AllowedToolsTools](../../models/components/allowedtoolstools.md)[] | :heavy_check_mark:                                                             | N/A                                                                            |