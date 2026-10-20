# PutOrgAutoModelRequestFallbackLanguage1

`tts` endpoint only. The ISO 639-1 language that `language: "auto"` text-to-speech uses when the text is too short or ambiguous for detection to name a language (for `/speech/tts`, `/speech/tts/stream` and Responses audio output alike), in place of the built-in `en`. Omit it to clear it: a PUT replaces the whole policy.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.PutOrgAutoModelRequestFallbackLanguage1En
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `PutOrgAutoModelRequestFallbackLanguage1En` | en                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Zh` | zh                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Hi` | hi                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Es` | es                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Ar` | ar                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Bn` | bn                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Pt` | pt                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Ru` | ru                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Ja` | ja                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Pa` | pa                                          |
| `PutOrgAutoModelRequestFallbackLanguage1De` | de                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Ko` | ko                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Fr` | fr                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Tr` | tr                                          |
| `PutOrgAutoModelRequestFallbackLanguage1It` | it                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Th` | th                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Pl` | pl                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Nl` | nl                                          |
| `PutOrgAutoModelRequestFallbackLanguage1ID` | id                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Vi` | vi                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Ur` | ur                                          |
| `PutOrgAutoModelRequestFallbackLanguage1Uk` | uk                                          |