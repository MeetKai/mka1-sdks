# BrowserToolDefinition

Browser tool definition: Gives the model the caller's own web browser in the sandbox, which keeps their logins between conversations. The model opens pages, reads them as an accessibility outline and clicks or types by ref; it runs no JavaScript of its own and never sees password field values. When a page needs the user, such as a sign-in, it asks them to take over (request_takeover), and its function_call_output (type browser_takeover_request) tells the caller to send them a way to open the browser.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Type`             | `string`           | :heavy_check_mark: | N/A                |