# CommandRequest


## Fields

| Field                        | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `SessionId`                  | *string*                     | :heavy_check_mark:           | N/A                          |
| `SessionToken`               | *string*                     | :heavy_minus_sign:           | N/A                          |
| `CommandRequestId`           | *string*                     | :heavy_minus_sign:           | N/A                          |
| `Command`                    | *string*                     | :heavy_check_mark:           | N/A                          |
| `Args`                       | List<*string*>               | :heavy_minus_sign:           | N/A                          |
| `Cwd`                        | *string*                     | :heavy_minus_sign:           | N/A                          |
| `Env`                        | Dictionary<String, *string*> | :heavy_minus_sign:           | N/A                          |
| `TimeoutSeconds`             | *long*                       | :heavy_minus_sign:           | N/A                          |