# Grader


## Supported Types

### `components.Grader1`

```typescript
const value: components.Grader1 = {
  type: "text_similarity",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  evaluationMetric: "bleu",
};
```

### `components.Grader2`

```typescript
const value: components.Grader2 = {
  type: "multi",
  name: "<value>",
  graders: {
    "key": {
      type: "score_model",
      name: "<value>",
      model: "Model Y",
      input: [],
    },
  },
  calculateOutput: "<value>",
};
```

