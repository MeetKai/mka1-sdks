# ComputeVolumeDataInput

## Example Usage

```typescript
import { ComputeVolumeDataInput } from "@meetkai/mka1/models/components";

let value: ComputeVolumeDataInput = {
  path: "/etc/ppp",
  type: "huggingface",
  url: "https://urban-pile.name/",
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `path`                                                                                         | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `revision`                                                                                     | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `type`                                                                                         | [components.ComputeVolumeDataInputType](../../models/components/computevolumedatainputtype.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `url`                                                                                          | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |