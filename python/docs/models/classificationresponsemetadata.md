# ClassificationResponseMetadata

Metadata about the classification request and execution


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `model`                                                              | *str*                                                                | :heavy_check_mark:                                                   | The model that was used to perform the classification                |
| `labels`                                                             | List[*str*]                                                          | :heavy_check_mark:                                                   | The array of possible labels that were provided in the request       |
| `classified_at`                                                      | [date](https://docs.python.org/3/library/datetime.html#date-objects) | :heavy_check_mark:                                                   | ISO 8601 timestamp indicating when the classification was performed  |