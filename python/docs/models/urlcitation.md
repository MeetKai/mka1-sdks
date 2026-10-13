# URLCitation

Annotation for citing a web URL in the model's output. Used when the model references information from web sources.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `type`                                                         | *Literal["url_citation"]*                                      | :heavy_check_mark:                                             | The annotation type identifier for URL citations.              |
| `end_index`                                                    | *int*                                                          | :heavy_check_mark:                                             | The character index where the cited text ends in the output.   |
| `start_index`                                                  | *int*                                                          | :heavy_check_mark:                                             | The character index where the cited text begins in the output. |
| `title`                                                        | *str*                                                          | :heavy_check_mark:                                             | The title of the web page or resource being cited.             |
| `url`                                                          | *str*                                                          | :heavy_check_mark:                                             | The URL of the web resource being cited.                       |