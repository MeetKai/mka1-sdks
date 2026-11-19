# ApprovalToolDefinition

Approval tool definition: Lets the model ask the caller to approve one call of another gateway-run tool before it runs. The model names the tool, its exact arguments and a reason; the response stops with that call's tool_approval_request or mcp_approval_request, and approving it runs exactly that call.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Type`             | `string`           | :heavy_check_mark: | N/A                |