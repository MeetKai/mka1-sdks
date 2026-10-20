# ResponseFormatEnum

The format in which the generated images are returned. 'url' returns a URL to the image, 'b64_json' returns the image as a base64-encoded JSON string. Defaults to 'url'.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ResponseFormatEnumURL
```


## Values

| Name                        | Value                       |
| --------------------------- | --------------------------- |
| `ResponseFormatEnumURL`     | url                         |
| `ResponseFormatEnumB64JSON` | b64_json                    |