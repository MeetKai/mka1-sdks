# SetupWhatsAppAppWebhookRequest


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `Id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | The agent ID.                                                                        |
| `XOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `Body`                                                                               | [WhatsAppWebhookSetupRequest](../../Types/Components/WhatsAppWebhookSetupRequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |