# AuthStrategies


## Supported Types

### `components.UpdateCatalogModelRequestStrategies1`

```typescript
const value: components.UpdateCatalogModelRequestStrategies1 = {
  type: "api-key",
};
```

### `components.UpdateCatalogModelRequestStrategies2`

```typescript
const value: components.UpdateCatalogModelRequestStrategies2 = {
  type: "custom-headers",
  headers: {
    "key": "<value>",
  },
};
```

### `components.UpdateCatalogModelRequestStrategies3`

```typescript
const value: components.UpdateCatalogModelRequestStrategies3 = {
  type: "none",
};
```

### `components.UpdateCatalogModelRequestStrategies4`

```typescript
const value: components.UpdateCatalogModelRequestStrategies4 = {
  type: "composite",
  strategies: [
    {
      type: "none",
    },
  ],
};
```

