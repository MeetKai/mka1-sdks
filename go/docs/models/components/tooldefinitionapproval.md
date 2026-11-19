# ToolDefinitionApproval

Lets the model ask for approval of one call of another of its tools before that call runs, when it judges the call risky. The run stops with that call in pending_approvals, carrying the model's reason; approving it runs exactly that call.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Type`                                                             | [components.TypeApproval](../../models/components/typeapproval.md) | :heavy_check_mark:                                                 | N/A                                                                |