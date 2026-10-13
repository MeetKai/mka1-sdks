# OrgAutoModel


## Supported Types

### `components.DirectOrgAutoModel`

```typescript
const value: components.DirectOrgAutoModel = {
  endpoint: "responses",
  setBy: "<value>",
  setAt: new Date("2024-04-08T06:37:59.183Z"),
  mode: "direct",
  modelId: "<id>",
  resolvable: false,
};
```

### `components.BalancedOrgAutoModel`

```typescript
const value: components.BalancedOrgAutoModel = {
  endpoint: "responses",
  setBy: "<value>",
  setAt: new Date("2026-06-21T10:23:14.034Z"),
  judgeModelId: "<id>",
  candidateModelIds: [
    "<value 1>",
    "<value 2>",
  ],
  judgeResolvable: true,
  resolvableCandidateModelIds: [],
  mode: "balanced",
};
```

### `components.PriceOrgAutoModel`

```typescript
const value: components.PriceOrgAutoModel = {
  endpoint: "responses",
  setBy: "<value>",
  setAt: new Date("2026-04-10T00:14:24.433Z"),
  judgeModelId: "<id>",
  candidateModelIds: [],
  judgeResolvable: false,
  resolvableCandidateModelIds: [
    "<value 1>",
    "<value 2>",
  ],
  mode: "price",
};
```

### `components.QualityOrgAutoModel`

```typescript
const value: components.QualityOrgAutoModel = {
  endpoint: "responses",
  setBy: "<value>",
  setAt: new Date("2025-08-09T01:08:05.879Z"),
  judgeModelId: "<id>",
  candidateModelIds: [
    "<value 1>",
    "<value 2>",
  ],
  judgeResolvable: false,
  resolvableCandidateModelIds: [],
  mode: "quality",
};
```

### `components.SpeedOrgAutoModel`

```typescript
const value: components.SpeedOrgAutoModel = {
  endpoint: "responses",
  setBy: "<value>",
  setAt: new Date("2026-11-12T22:27:32.425Z"),
  judgeModelId: "<id>",
  candidateModelIds: [
    "<value 1>",
    "<value 2>",
  ],
  judgeResolvable: false,
  resolvableCandidateModelIds: [],
  mode: "speed",
};
```

