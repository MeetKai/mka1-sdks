# URLCitation

Annotation for citing a web URL in the model's output. Used when the model references information from web sources.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `Type`                                                         | *string*                                                       | :heavy_check_mark:                                             | The annotation type identifier for URL citations.              |
| `EndIndex`                                                     | *long*                                                         | :heavy_check_mark:                                             | The character index where the cited text ends in the output.   |
| `StartIndex`                                                   | *long*                                                         | :heavy_check_mark:                                             | The character index where the cited text begins in the output. |
| `Title`                                                        | *string*                                                       | :heavy_check_mark:                                             | The title of the web page or resource being cited.             |
| `Url`                                                          | *string*                                                       | :heavy_check_mark:                                             | The URL of the web resource being cited.                       |