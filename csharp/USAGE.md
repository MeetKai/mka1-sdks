<!-- Start SDK Example Usage [usage] -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Permissions.Llm.GrantAsync(body: new GrantPermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Writer,
});

// handle response
```
<!-- End SDK Example Usage [usage] -->