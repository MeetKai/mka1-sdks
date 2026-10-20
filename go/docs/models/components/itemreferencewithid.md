# ItemReferenceWithID

Item reference item: A pointer to another response item by ID.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | `*string`                                                  | :heavy_minus_sign:                                         | N/A                                                        |
| `ID`                                                       | `string`                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `ResponseID`                                               | optionalnullable.OptionalNullable[`string`]                | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | optionalnullable.OptionalNullable[map[string]`string`]     | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |