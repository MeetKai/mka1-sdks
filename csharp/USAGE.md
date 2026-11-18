<!-- Start SDK Example Usage [usage] -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Audit.GetRequestTraceAsync(requestId: "3f6c1b2e-8d4a-4c1e-9b7f-2a5d6e8f9c01#12");

// handle response
```
<!-- End SDK Example Usage [usage] -->