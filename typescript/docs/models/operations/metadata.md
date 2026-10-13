# Metadata

Filter conversations by metadata key-value pairs (JSON string or object). Only conversations with matching metadata will be returned.


## Supported Types

### `string`

```typescript
const value: string = "<value>";
```

### `{ [k: string]: string }`

```typescript
const value: { [k: string]: string } = {
  "user_type": "premium",
};
```

