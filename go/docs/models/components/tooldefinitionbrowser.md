# ToolDefinitionBrowser

The user's own web browser, which keeps their logins between conversations. The model opens pages, reads them and clicks or types; it runs no scripts of its own and never sees what a password field holds. When a site needs the user, for example to sign in, the model asks them to take over: in a private Telegram chat they get a button that opens a live view of the browser, and the agent carries on when they tap Done.


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `Type`                                                           | [components.TypeBrowser](../../models/components/typebrowser.md) | :heavy_check_mark:                                               | N/A                                                              |