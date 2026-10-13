# GuardrailConfig


## Supported Types

### `components.BanWordsGuardrail`

```typescript
const value: components.BanWordsGuardrail = {
  mode: "ban_words",
};
```

### `components.PromptInjectionGuardrail`

```typescript
const value: components.PromptInjectionGuardrail = {
  mode: "prompt_injection",
};
```

### `components.LeakageGuardrail`

```typescript
const value: components.LeakageGuardrail = {
  mode: "leakage",
};
```

### `components.ClassifierGuardrail`

```typescript
const value: components.ClassifierGuardrail = {
  mode: "classifier",
  config: {
    model: "Colorado",
    prompt: "<value>",
  },
};
```

