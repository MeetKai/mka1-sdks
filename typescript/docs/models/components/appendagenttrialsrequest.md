# AppendAgentTrialsRequest

## Example Usage

```typescript
import { AppendAgentTrialsRequest } from "@meetkai/mka1/models/components";

let value: AppendAgentTrialsRequest = {};
```

## Fields

| Field                                                                                                                                                                  | Type                                                                                                                                                                   | Required                                                                                                                                                               | Description                                                                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `trials`                                                                                                                                                               | [components.AppendAgentTrialsRequestTrials](../../models/components/appendagenttrialsrequesttrials.md)[]                                                               | :heavy_minus_sign:                                                                                                                                                     | Each trial pins its own `sample_index` (unique per task and model): re-sending a batch replaces the same rows instead of duplicating them, so a retried batch is safe. |
| `finalize`                                                                                                                                                             | *boolean*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                     | Marks the run completed once these trials land — the last call of a streaming job sends this, usually with an empty `trials`.                                          |