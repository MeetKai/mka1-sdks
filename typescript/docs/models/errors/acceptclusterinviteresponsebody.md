# AcceptClusterInviteResponseBody

Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it.

## Example Usage

```typescript
import { AcceptClusterInviteResponseBody } from "@meetkai/mka1/models/errors";

// No examples available for this model
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `message`          | *string*           | :heavy_check_mark: | N/A                |
| `code`             | *string*           | :heavy_minus_sign: | N/A                |