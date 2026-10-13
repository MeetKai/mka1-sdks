# OtherChunkingStrategy

This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the chunking_strategy concept was introduced in the API.

## Example Usage

```typescript
import { OtherChunkingStrategy } from "@meetkai/mka1/models/components";

let value: OtherChunkingStrategy = {
  type: "other",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"other"*          | :heavy_check_mark: | Always 'other'.    |