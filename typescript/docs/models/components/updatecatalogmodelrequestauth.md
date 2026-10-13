# UpdateCatalogModelRequestAuth


## Supported Types

### `components.UpdateCatalogModelRequestAuth1`

```typescript
const value: components.UpdateCatalogModelRequestAuth1 = {
  type: "api-key",
};
```

### `components.UpdateCatalogModelRequestAuth2`

```typescript
const value: components.UpdateCatalogModelRequestAuth2 = {
  type: "custom-headers",
  headers: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
};
```

### `components.UpdateCatalogModelRequestAuth3`

```typescript
const value: components.UpdateCatalogModelRequestAuth3 = {
  type: "none",
};
```

### `components.UpdateCatalogModelRequestAuth4`

```typescript
const value: components.UpdateCatalogModelRequestAuth4 = {
  type: "composite",
  strategies: [
    {
      type: "composite",
      strategies: [],
    },
  ],
};
```

