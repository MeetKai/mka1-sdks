<!-- Start SDK Example Usage [usage] -->
```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
		ResourceType: components.LlmResourceTypeCompletion,
		ResourceID:   "my-completion-123",
		UserID:       "user-abc456",
		Role:         components.ResourceRoleWriter,
	}, nil)
	if err != nil {
		log.Fatal(err)
	}
	if res != nil {
		// handle response
	}
}

```
<!-- End SDK Example Usage [usage] -->