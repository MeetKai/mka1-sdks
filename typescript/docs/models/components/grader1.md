# Grader1


## Supported Types

### `components.One1`

```typescript
const value: components.One1 = {
  type: "string_check",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  operation: "eq",
};
```

### `components.One2`

```typescript
const value: components.One2 = {
  type: "text_similarity",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  evaluationMetric: "rouge_5",
};
```

### `components.One3`

```typescript
const value: components.One3 = {
  type: "python",
  name: "<value>",
  source: "<value>",
};
```

### `components.One4`

```typescript
const value: components.One4 = {
  type: "score_model",
  name: "<value>",
  model: "PT Cruiser",
  input: [],
};
```

### `components.One5`

```typescript
const value: components.One5 = {
  type: "label_model",
  name: "<value>",
  model: "Cruze",
  input: [
    {
      role: "<value>",
      content: "<value>",
    },
  ],
  labels: [],
  passingLabels: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

