<!-- Start SDK Example Usage [usage] -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.audit.getRequestTrace({
    requestId: "3f6c1b2e-8d4a-4c1e-9b7f-2a5d6e8f9c01#12",
  });

  console.log(result);
}

run();

```
<!-- End SDK Example Usage [usage] -->