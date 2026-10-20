# AnalyticsProject


## Fields

| Field                                      | Type                                       | Required                                   | Description                                | Example                                    |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `ID`                                       | `string`                                   | :heavy_check_mark:                         | N/A                                        |                                            |
| `OrgID`                                    | `string`                                   | :heavy_check_mark:                         | N/A                                        |                                            |
| `TeamID`                                   | `*string`                                  | :heavy_check_mark:                         | N/A                                        |                                            |
| `Name`                                     | `string`                                   | :heavy_check_mark:                         | N/A                                        |                                            |
| `CreatedAt`                                | [time.Time](https://pkg.go.dev/time#Time)  | :heavy_check_mark:                         | When the project was created, in UTC.      | 2026-09-01T12:30:00Z                       |
| `UpdatedAt`                                | [time.Time](https://pkg.go.dev/time#Time)  | :heavy_check_mark:                         | When the project was last updated, in UTC. | 2026-09-01T12:30:00Z                       |
| `ArchivedAt`                               | [*time.Time](https://pkg.go.dev/time#Time) | :heavy_check_mark:                         | N/A                                        | 2026-09-02T12:30:00Z                       |