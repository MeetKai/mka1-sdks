# GetVectorStoreConnectorType

The kind of location. `s3` is a bucket on AWS S3 or S3-compatible storage. `sharepoint` is a document library of a SharePoint Online site.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetVectorStoreConnectorTypeS3

// Open enum: custom values can be created with a direct type cast
custom := operations.GetVectorStoreConnectorType("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `GetVectorStoreConnectorTypeS3`         | s3                                      |
| `GetVectorStoreConnectorTypeSharepoint` | sharepoint                              |