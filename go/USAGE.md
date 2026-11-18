<!-- Start SDK Example Usage [usage] -->
```go
package main

import (
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
	ctx := context.Background()

	s := mka1.New(
		mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
	)

	res, err := s.Llm.Audit.GetRequestTrace(ctx, "3f6c1b2e-8d4a-4c1e-9b7f-2a5d6e8f9c01#12")
	if err != nil {
		log.Fatal(err)
	}
	if res.Object != nil {
		// handle response
	}
}

```
<!-- End SDK Example Usage [usage] -->