# ClassificationResponseMetadata

Metadata about the classification request and execution


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Model`                                                             | `string`                                                            | :heavy_check_mark:                                                  | The model that was used to perform the classification               |
| `Labels`                                                            | []`string`                                                          | :heavy_check_mark:                                                  | The array of possible labels that were provided in the request      |
| `ClassifiedAt`                                                      | [time.Time](https://pkg.go.dev/time#Time)                           | :heavy_check_mark:                                                  | ISO 8601 timestamp indicating when the classification was performed |