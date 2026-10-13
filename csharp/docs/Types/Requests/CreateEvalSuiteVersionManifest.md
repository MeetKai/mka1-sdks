# CreateEvalSuiteVersionManifest

Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility.


## Fields

| Field                        | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `SchemaVersion`              | *string*                     | :heavy_minus_sign:           | N/A                          |
| `Tasks`                      | List<*object*>               | :heavy_check_mark:           | N/A                          |
| `Metadata`                   | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |
| `AdditionalProperties`       | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |