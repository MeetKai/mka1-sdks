# ComputeOfferCapabilities

## Example Usage

```typescript
import { ComputeOfferCapabilities } from "@meetkai/mka1/models/components";

let value: ComputeOfferCapabilities = {
  customImage: true,
  httpPorts: false,
  managedService: true,
  multiNode: false,
  persistentVolume: false,
  privateImage: false,
  scaleToZero: false,
  sharedVolume: false,
  ssh: true,
  standaloneVolume: false,
  tcpPorts: true,
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `customImage`                                                              | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `httpPorts`                                                                | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `managedService`                                                           | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `multiNode`                                                                | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `persistentVolume`                                                         | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `privateImage`                                                             | *boolean*                                                                  | :heavy_check_mark:                                                         | The backend can pull image with the credential named by image_pull_secret. |
| `scaleToZero`                                                              | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `sharedVolume`                                                             | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `ssh`                                                                      | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `standaloneVolume`                                                         | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |
| `tcpPorts`                                                                 | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |