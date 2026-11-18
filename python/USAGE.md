<!-- Start SDK Example Usage [usage] -->
```python
# Synchronous Example
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.audit.get_request_trace(request_id="3f6c1b2e-8d4a-4c1e-9b7f-2a5d6e8f9c01#12")

    # Handle response
    print(res)
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

        res = await sdk.llm.audit.get_request_trace_async(request_id="3f6c1b2e-8d4a-4c1e-9b7f-2a5d6e8f9c01#12")

        # Handle response
        print(res)

asyncio.run(main())
```
<!-- End SDK Example Usage [usage] -->