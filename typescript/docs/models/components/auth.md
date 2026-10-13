# Auth


## Supported Types

### `components.Auth1`

```typescript
const value: components.Auth1 = {
  type: "api-key",
};
```

### `components.Auth2`

```typescript
const value: components.Auth2 = {
  type: "custom-headers",
  headers: {
    "key": "<value>",
  },
};
```

### `components.Auth3`

```typescript
const value: components.Auth3 = {
  type: "none",
};
```

### `components.Auth4`

```typescript
const value: components.Auth4 = {
  type: "composite",
  strategies: [
    {
      type: "custom-headers",
      headers: {
        "key": "<value>",
        "key1": "<value>",
      },
    },
  ],
};
```

