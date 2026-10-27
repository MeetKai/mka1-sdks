# OutputWindow

When a streaming output check runs: whichever of max_chars and max_ms fills first


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `MaxChars`                                                                | `*int64`                                                                  | :heavy_minus_sign:                                                        | Check once this many characters of unchecked text have accumulated        |
| `MaxMs`                                                                   | `*int64`                                                                  | :heavy_minus_sign:                                                        | Check once the oldest unchecked text has been held this many milliseconds |