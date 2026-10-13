# Graders


## Supported Types

### `components.Graders1`

```typescript
const value: components.Graders1 = {
  type: "string_check",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  operation: "eq",
};
```

### `components.Graders2`

```typescript
const value: components.Graders2 = {
  type: "text_similarity",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  evaluationMetric: "rouge_3",
};
```

### `components.Graders3`

```typescript
const value: components.Graders3 = {
  type: "python",
  name: "<value>",
  source: "<value>",
};
```

### `components.Graders4`

```typescript
const value: components.Graders4 = {
  type: "score_model",
  name: "<value>",
  model: "El Camino",
  input: [],
};
```

### `components.Graders5`

```typescript
const value: components.Graders5 = {
  type: "label_model",
  name: "<value>",
  model: "Roadster",
  input: [],
  labels: [],
  passingLabels: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

