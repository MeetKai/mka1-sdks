# Annotations


## Supported Types

### `components.FileCitation`

```typescript
const value: components.FileCitation = {
  type: "file_citation",
  fileId: "<id>",
  filename: "example.file",
  index: 975429,
};
```

### `components.URLCitation`

```typescript
const value: components.URLCitation = {
  type: "url_citation",
  endIndex: 352955,
  startIndex: 669553,
  title: "<value>",
  url: "https://smug-thunderbolt.name/",
};
```

### `components.ContainerFileCitation`

```typescript
const value: components.ContainerFileCitation = {
  type: "container_file_citation",
  containerId: "<id>",
  endIndex: 175953,
  fileId: "<id>",
  filename: "example.file",
  startIndex: 741088,
};
```

### `components.FilePath`

```typescript
const value: components.FilePath = {
  type: "file_path",
  fileId: "<id>",
  index: 436278,
};
```

