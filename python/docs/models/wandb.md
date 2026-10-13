# Wandb


## Fields

| Field                   | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `project`               | *str*                   | :heavy_check_mark:      | W&B project name        |
| `entity`                | *OptionalNullable[str]* | :heavy_minus_sign:      | W&B entity/team         |
| `name`                  | *OptionalNullable[str]* | :heavy_minus_sign:      | Run display name        |
| `tags`                  | List[*str*]             | :heavy_minus_sign:      | Tags for the run        |