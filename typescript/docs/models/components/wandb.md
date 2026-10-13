# Wandb

## Example Usage

```typescript
import { Wandb } from "@meetkai/mka1/models/components";

let value: Wandb = {
  project: "<value>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `project`          | *string*           | :heavy_check_mark: | W&B project name   |
| `entity`           | *string*           | :heavy_minus_sign: | W&B entity/team    |
| `name`             | *string*           | :heavy_minus_sign: | Run display name   |
| `tags`             | *string*[]         | :heavy_minus_sign: | Tags for the run   |