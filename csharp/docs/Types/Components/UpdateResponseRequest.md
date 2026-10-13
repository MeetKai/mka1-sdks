# UpdateResponseRequest

Request schema for updating a response's metadata.


## Fields

| Field                                                                                                                       | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `Metadata`                                                                                                                  | Dictionary<String, *string*>                                                                                                | :heavy_check_mark:                                                                                                          | Set of 16 key-value pairs to update. Keys must be strings up to 64 characters, values must be strings up to 512 characters. |