# GetEvalSuiteVersionManifest

Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility.


## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `schema_version`      | *Optional[str]*       | :heavy_minus_sign:    | N/A                   |
| `tasks`               | List[*Nullable[Any]*] | :heavy_check_mark:    | N/A                   |
| `metadata`            | Dict[str, *Any*]      | :heavy_minus_sign:    | N/A                   |
| `__pydantic_extra__`  | Dict[str, *Any*]      | :heavy_minus_sign:    | N/A                   |