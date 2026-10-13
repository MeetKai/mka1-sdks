# Llm.Files

## Overview

### Available Operations

* [upload](#upload) - Upload file
* [list](#list) - List files
* [get](#get) - Retrieve file
* [delete](#delete) - Delete file
* [content](#content) - Retrieve file content

## upload

Upload a file that can be used with Assistants, Vector Stores, and other features. Files are uploaded to S3 for durable storage.

### Example Usage

<!-- UsageSnippet language="python" operationID="uploadFile" method="post" path="/api/v1/llm/files" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.files.upload(file={
        "file_name": "example.file",
        "content": open("example.file", "rb"),
    }, purpose="assistants")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                          | Type                                                                                                                                               | Required                                                                                                                                           | Description                                                                                                                                        |
| -------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| `file`                                                                                                                                             | [models.UploadFileFile](../../models/uploadfilefile.md)                                                                                            | :heavy_check_mark:                                                                                                                                 | The file to upload. Multipart file parts must include a nonblank filename; the lowercase WHATWG placeholder filename "blob" is treated as missing. |
| `purpose`                                                                                                                                          | [models.UploadFilePurpose](../../models/uploadfilepurpose.md)                                                                                      | :heavy_check_mark:                                                                                                                                 | The intended purpose of the file                                                                                                                   |
| `x_on_behalf_of`                                                                                                                                   | *Optional[str]*                                                                                                                                    | :heavy_minus_sign:                                                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                                                |
| `retries`                                                                                                                                          | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                   | :heavy_minus_sign:                                                                                                                                 | Configuration to override the default retry behavior of the client.                                                                                |

### Response

**[models.File](../../models/file.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list

Returns a list of files that have been uploaded.

### Example Usage

<!-- UsageSnippet language="python" operationID="listFiles" method="get" path="/api/v1/llm/files" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.files.list(after="file-abc123", limit=100, order="desc", purpose="assistants")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           | Example                                                               |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `after`                                                               | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   | file-abc123                                                           |
| `limit`                                                               | *Optional[int]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   | 100                                                                   |
| `order`                                                               | [Optional[models.ListFilesOrder]](../../models/listfilesorder.md)     | :heavy_minus_sign:                                                    | N/A                                                                   | desc                                                                  |
| `purpose`                                                             | [Optional[models.ListFilesPurpose]](../../models/listfilespurpose.md) | :heavy_minus_sign:                                                    | N/A                                                                   | assistants                                                            |
| `x_on_behalf_of`                                                      | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | Optional external end-user identifier forwarded by the API gateway.   |                                                                       |
| `retries`                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)      | :heavy_minus_sign:                                                    | Configuration to override the default retry behavior of the client.   |                                                                       |

### Response

**[models.FileList](../../models/filelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Returns information about a specific file.

### Example Usage

<!-- UsageSnippet language="python" operationID="getFile" method="get" path="/api/v1/llm/files/{file_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.files.get(file_id="file-abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `file_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.File](../../models/file.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

Delete a file from storage. The file is first removed from every vector store it is attached to, embeddings included, so it no longer appears in vector store search or `file_search` results. If that cannot finish, the file is kept and the request fails; retrying completes the deletion. Returns 400 `feature_unavailable` when the file is attached to a vector store while the search service is unavailable, and 409 when the file was added to a vector store during the deletion.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteFile" method="delete" path="/api/v1/llm/files/{file_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.files.delete(file_id="file-abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `file_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.FileDeletionStatus](../../models/filedeletionstatus.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## content

Returns the raw binary contents of the specified file with appropriate Content-Type header.

### Example Usage

<!-- UsageSnippet language="python" operationID="getFileContent" method="get" path="/api/v1/llm/files/{file_id}/content" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.files.content(file_id="file-abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `file_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetFileContentResponse](../../models/getfilecontentresponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| errors.GetFileContentBadRequestError     | 400                                      | application/json                         |
| errors.GetFileContentUnauthorizedError   | 401                                      | application/json                         |
| errors.GetFileContentNotFoundError       | 404                                      | application/json                         |
| errors.GetFileContentInternalServerError | 500                                      | application/json                         |
| errors.SDKDefaultError                   | 4XX, 5XX                                 | \*/\*                                    |