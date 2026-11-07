# ExportAuditCasesFormat

json returns a JSON array of rows; csv returns a header row and one line per row.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ExportAuditCasesFormatJSON
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `ExportAuditCasesFormatJSON` | json                         |
| `ExportAuditCasesFormatCsv`  | csv                          |