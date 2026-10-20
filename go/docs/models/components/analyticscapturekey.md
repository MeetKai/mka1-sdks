# AnalyticsCaptureKey


## Fields

| Field                                      | Type                                       | Required                                   | Description                                | Example                                    |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `ID`                                       | `string`                                   | :heavy_check_mark:                         | N/A                                        |                                            |
| `ProjectID`                                | `string`                                   | :heavy_check_mark:                         | N/A                                        |                                            |
| `Name`                                     | `string`                                   | :heavy_check_mark:                         | N/A                                        |                                            |
| `Prefix`                                   | `string`                                   | :heavy_check_mark:                         | N/A                                        |                                            |
| `CreatedAt`                                | [time.Time](https://pkg.go.dev/time#Time)  | :heavy_check_mark:                         | When the capture key was created, in UTC.  | 2026-09-01T12:30:00Z                       |
| `RevokedAt`                                | [*time.Time](https://pkg.go.dev/time#Time) | :heavy_check_mark:                         | N/A                                        | 2026-09-02T12:30:00Z                       |