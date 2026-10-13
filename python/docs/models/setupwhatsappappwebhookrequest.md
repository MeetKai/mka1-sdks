# SetupWhatsAppAppWebhookRequest


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `id`                                                                           | *str*                                                                          | :heavy_check_mark:                                                             | The agent ID.                                                                  |
| `x_on_behalf_of`                                                               | *Optional[str]*                                                                | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `body`                                                                         | [models.WhatsAppWebhookSetupRequest](../models/whatsappwebhooksetuprequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |