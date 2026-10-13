# ListBudgetsData


## Supported Types

### `operations.Data1`

```typescript
const value: operations.Data1 = {
  id: "<id>",
  scope: "external_user_default",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "org",
  period: "monthly",
  limit: 9149.87,
  thresholds: [
    {
      pct: 179014,
      action: "block",
    },
  ],
  alertWebhookUrl: "https://alarmed-technologist.biz",
  spend: {
    window: "<value>",
    costSpent: 4470.66,
    limit: 7058.14,
    pct: 911783,
    status: "blocked",
  },
};
```

### `operations.Data2`

```typescript
const value: operations.Data2 = {
  id: "<id>",
  scope: "apikey",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "org",
  period: "monthly",
  limit: 1091.83,
  thresholds: [],
  alertWebhookUrl: "https://miserly-forage.biz",
};
```

