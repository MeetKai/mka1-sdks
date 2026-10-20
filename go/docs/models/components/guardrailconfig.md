# GuardrailConfig


## Supported Types

### BanWordsGuardrail

```go
guardrailConfig := components.CreateGuardrailConfigBanWords(components.BanWordsGuardrail{/* values here */})
```

### PromptInjectionGuardrail

```go
guardrailConfig := components.CreateGuardrailConfigPromptInjection(components.PromptInjectionGuardrail{/* values here */})
```

### LeakageGuardrail

```go
guardrailConfig := components.CreateGuardrailConfigLeakage(components.LeakageGuardrail{/* values here */})
```

### ClassifierGuardrail

```go
guardrailConfig := components.CreateGuardrailConfigClassifier(components.ClassifierGuardrail{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch guardrailConfig.Type {
	case components.GuardrailConfigTypeBanWords:
		// guardrailConfig.BanWordsGuardrail is populated
	case components.GuardrailConfigTypePromptInjection:
		// guardrailConfig.PromptInjectionGuardrail is populated
	case components.GuardrailConfigTypeLeakage:
		// guardrailConfig.LeakageGuardrail is populated
	case components.GuardrailConfigTypeClassifier:
		// guardrailConfig.ClassifierGuardrail is populated
	default:
		// Unknown type - use guardrailConfig.GetUnknownRaw() for raw JSON
}
```
