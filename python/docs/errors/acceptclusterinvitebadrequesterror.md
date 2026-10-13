# AcceptClusterInviteBadRequestError

Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `message`          | *str*              | :heavy_check_mark: | N/A                |
| `code`             | *Optional[str]*    | :heavy_minus_sign: | N/A                |