# Span


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `Kind`                                               | [operations.Kind](../../models/operations/kind.md)   | :heavy_check_mark:                                   | A model invocation or a tool call                    |
| `Name`                                               | `*string`                                            | :heavy_check_mark:                                   | Model that served the invocation, or the tool's name |
| `CallID`                                             | `*string`                                            | :heavy_check_mark:                                   | Tool call ID; null for model invocations             |
| `Step`                                               | `*float64`                                           | :heavy_check_mark:                                   | Agent loop step of a model invocation                |
| `Attempt`                                            | `*float64`                                           | :heavy_check_mark:                                   | Attempt within the step (retries and failover)       |
| `Status`                                             | `*string`                                            | :heavy_check_mark:                                   | N/A                                                  |
| `StartedAt`                                          | [*time.Time](https://pkg.go.dev/time#Time)           | :heavy_check_mark:                                   | N/A                                                  |
| `CompletedAt`                                        | [*time.Time](https://pkg.go.dev/time#Time)           | :heavy_check_mark:                                   | Null while the span is still running                 |
| `DurationMs`                                         | `*float64`                                           | :heavy_check_mark:                                   | N/A                                                  |