# AgentScheduleSpec


## Supported Types

### `components.AgentScheduleSpec1`

```typescript
const value: components.AgentScheduleSpec1 = {
  type: "once",
  runAt: new Date("2025-10-03T08:36:07.015Z"),
};
```

### `components.AgentScheduleSpec2`

```typescript
const value: components.AgentScheduleSpec2 = {
  type: "interval",
  intervalSeconds: 604000,
};
```

### `components.AgentScheduleSpec3`

```typescript
const value: components.AgentScheduleSpec3 = {
  type: "cron",
  cronExpression: "<value>",
};
```

