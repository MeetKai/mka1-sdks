# ResponsesCreateRequestInput

The user input to send to the agent. Can be a simple text string for basic queries, or an array of item objects containing text, images, files, or audio for multimodal interactions. This is the main content the agent will respond to.


## Supported Types

### `string`

```typescript
const value: string = "<value>";
```

### `components.Item[]`

```typescript
const value: components.Item[] = [
  {
    type: "compaction",
    id: "<id>",
    content: "<value>",
  },
];
```

