# PutOrgAutoModelRequestFallbackLanguage2

`tts` endpoint only. The ISO 639-1 language that `language: "auto"` text-to-speech uses when the text is too short or ambiguous for detection to name a language (for `/speech/tts`, `/speech/tts/stream` and Responses audio output alike), in place of the built-in `en`. Omit it to clear it: a PUT replaces the whole policy.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.PutOrgAutoModelRequestFallbackLanguage2En
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `PutOrgAutoModelRequestFallbackLanguage2En` | en                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Zh` | zh                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Hi` | hi                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Es` | es                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Ar` | ar                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Bn` | bn                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Pt` | pt                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Ru` | ru                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Ja` | ja                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Pa` | pa                                          |
| `PutOrgAutoModelRequestFallbackLanguage2De` | de                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Ko` | ko                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Fr` | fr                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Tr` | tr                                          |
| `PutOrgAutoModelRequestFallbackLanguage2It` | it                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Th` | th                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Pl` | pl                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Nl` | nl                                          |
| `PutOrgAutoModelRequestFallbackLanguage2ID` | id                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Vi` | vi                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Ur` | ur                                          |
| `PutOrgAutoModelRequestFallbackLanguage2Uk` | uk                                          |