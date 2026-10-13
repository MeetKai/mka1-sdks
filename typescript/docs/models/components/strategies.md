# Strategies


## Supported Types

### `components.Strategies1`

```typescript
const value: components.Strategies1 = {
  type: "api-key",
};
```

### `components.Strategies2`

```typescript
const value: components.Strategies2 = {
  type: "custom-headers",
  headers: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
};
```

### `components.Strategies3`

```typescript
const value: components.Strategies3 = {
  type: "none",
};
```

### `components.Strategies4`

```typescript
const value: components.Strategies4 = {
  type: "composite",
  strategies: [
    {
      type: "none",
    },
  ],
};
```

