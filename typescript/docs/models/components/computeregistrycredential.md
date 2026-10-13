# ComputeRegistryCredential

A registry username and password supplied inline on the create request instead of naming a stored secret (a token is accepted as the password). Write-only: it is sealed at admission, presented to the registry named by image at provider handoff, never returned by any read, list, event or quote, and discarded when the resource reaches a terminal state. Use it when the caller must not be able to read the credential back through its own tenant secrets. When set, image must be a fully-qualified OCI reference with an explicit registry host; the registry is read from image, never from the credential. Mutually exclusive with image_pull_secret. Not accepted on quotes: quote the same shape with image_pull_secret set to any non-blank id.

## Example Usage

```typescript
import { ComputeRegistryCredential } from "@meetkai/mka1/models/components";

let value: ComputeRegistryCredential = {
  password: "2Qumuz30mg0ZY58",
  username: "Marley62",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `password`         | *string*           | :heavy_check_mark: | N/A                |
| `username`         | *string*           | :heavy_check_mark: | N/A                |