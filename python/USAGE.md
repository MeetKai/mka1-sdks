<!-- Start SDK Example Usage [usage] -->
```python
# Synchronous Example
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.permissions.llm.grant(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

    # Use the SDK ...
```

</br>

The same SDK client can also be used to make asynchronous requests by importing asyncio.

```python
# Asynchronous Example
import asyncio
from meetkai_mka1 import SDK

async def main():

    async with SDK(
        bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
    ) as sdk:

        await sdk.permissions.llm.grant_async(resource_type="completion", resource_id="my-completion-123", user_id="user-abc456", role="writer")

        # Use the SDK ...

asyncio.run(main())
```
<!-- End SDK Example Usage [usage] -->