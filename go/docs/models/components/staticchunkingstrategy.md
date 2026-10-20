# StaticChunkingStrategy

Customize your own chunking strategy by setting chunk size and chunk overlap. Sizes are counted in tokens.


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `Type`                                                 | `string`                                               | :heavy_check_mark:                                     | Always 'static'.                                       |
| `Static`                                               | [components.Static](../../models/components/static.md) | :heavy_check_mark:                                     | N/A                                                    |