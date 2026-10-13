# RepoError

The uniform error envelope. `error` is a stable machine-readable code
(never an internal reason); `correlation_id` echoes the request's
`X-Correlation-ID` for log correlation.



## Fields

| Field              | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `correlation_id`   | *str*              | :heavy_check_mark: | N/A                |                    |
| `error`            | *str*              | :heavy_check_mark: | N/A                | not_found          |