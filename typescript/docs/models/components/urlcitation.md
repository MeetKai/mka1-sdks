# URLCitation

Annotation for citing a web URL in the model's output. Used when the model references information from web sources.

## Example Usage

```typescript
import { URLCitation } from "@meetkai/mka1/models/components";

let value: URLCitation = {
  type: "url_citation",
  endIndex: 352955,
  startIndex: 669553,
  title: "<value>",
  url: "https://smug-thunderbolt.name/",
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `type`                                                         | *"url_citation"*                                               | :heavy_check_mark:                                             | The annotation type identifier for URL citations.              |
| `endIndex`                                                     | *number*                                                       | :heavy_check_mark:                                             | The character index where the cited text ends in the output.   |
| `startIndex`                                                   | *number*                                                       | :heavy_check_mark:                                             | The character index where the cited text begins in the output. |
| `title`                                                        | *string*                                                       | :heavy_check_mark:                                             | The title of the web page or resource being cited.             |
| `url`                                                          | *string*                                                       | :heavy_check_mark:                                             | The URL of the web resource being cited.                       |