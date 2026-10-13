<!-- Start SDK Example Usage [usage] -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```
<!-- End SDK Example Usage [usage] -->