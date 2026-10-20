# GetEvalSuiteVersionManifest

Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility.


## Fields

| Field                  | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `SchemaVersion`        | `*string`              | :heavy_minus_sign:     | N/A                    |
| `Tasks`                | []`any`                | :heavy_check_mark:     | N/A                    |
| `Metadata`             | map[string]`any`       | :heavy_minus_sign:     | N/A                    |
| `AdditionalProperties` | map[string]`any`       | :heavy_minus_sign:     | N/A                    |