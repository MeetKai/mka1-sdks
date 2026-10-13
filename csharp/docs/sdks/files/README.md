# Llm.Files

## Overview

### Available Operations

* [Upload](#upload) - Upload file
* [List](#list) - List files
* [Get](#get) - Retrieve file
* [Delete](#delete) - Delete file
* [Content](#content) - Retrieve file content

## Upload

Upload a file that can be used with Assistants, Vector Stores, and other features. Files are uploaded to S3 for durable storage.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadFile" method="post" path="/api/v1/llm/files" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Files.UploadAsync(body: new UploadFileRequestBody() {
    File = new UploadFileFile() {
        FileName = "example.file",
        Content = System.IO.File.ReadAllBytes("example.file"),
    },
    Purpose = UploadFilePurpose.Assistants,
});

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `Body`                                                                 | [UploadFileRequestBody](../../Types/Requests/UploadFileRequestBody.md) | :heavy_check_mark:                                                     | N/A                                                                    |
| `XOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |

### Response

**[UploadFileResponse](../../Types/Requests/UploadFileResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

Returns a list of files that have been uploaded.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFiles" method="get" path="/api/v1/llm/files" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListFilesRequest req = new ListFilesRequest() {
    After = "file-abc123",
    Limit = 100,
    Purpose = ListFilesPurpose.Assistants,
};

var res = await sdk.Llm.Files.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `request`                                                    | [ListFilesRequest](../../Types/Requests/ListFilesRequest.md) | :heavy_check_mark:                                           | The request object to use for the request.                   |

### Response

**[ListFilesResponse](../../Types/Requests/ListFilesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Returns information about a specific file.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFile" method="get" path="/api/v1/llm/files/{file_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Files.GetAsync(fileId: "file-abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `FileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetFileResponse](../../Types/Requests/GetFileResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a file from storage. The file is first removed from every vector store it is attached to, embeddings included, so it no longer appears in vector store search or `file_search` results. If that cannot finish, the file is kept and the request fails; retrying completes the deletion. Returns 400 `feature_unavailable` when the file is attached to a vector store while the search service is unavailable, and 409 when the file was added to a vector store during the deletion.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteFile" method="delete" path="/api/v1/llm/files/{file_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Files.DeleteAsync(fileId: "file-abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `FileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteFileResponse](../../Types/Requests/DeleteFileResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Content

Returns the raw binary contents of the specified file with appropriate Content-Type header.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFileContent" method="get" path="/api/v1/llm/files/{file_id}/content" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Files.ContentAsync(fileId: "file-abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `FileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetFileContentResponse](../../Types/Requests/GetFileContentResponse.md)**

### Errors

| Error Type                                                    | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetFileContentBadRequestException   | 400                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetFileContentUnauthorizedException | 401                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetFileContentNotFoundException     | 404                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetFileContentInternalServerError   | 500                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.APIException                        | 4XX, 5XX                                                      | \*/\*                                                         |