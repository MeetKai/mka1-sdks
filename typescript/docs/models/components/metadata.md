# Metadata

Metadata about the classification request and execution

## Example Usage

```typescript
import { Metadata } from "@meetkai/mka1/models/components";

let value: Metadata = {
  model: "Grand Cherokee",
  labels: [
    "<value 1>",
  ],
  classifiedAt: new Date("2025-03-31T12:57:35.637Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `model`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | The model that was used to perform the classification                                         |
| `labels`                                                                                      | *string*[]                                                                                    | :heavy_check_mark:                                                                            | The array of possible labels that were provided in the request                                |
| `classifiedAt`                                                                                | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | ISO 8601 timestamp indicating when the classification was performed                           |