# Llm.Speech

## Overview

### Available Operations

* [transcribe](#transcribe) - Speech to text transcription
* [speak](#speak) - Text to speech
* [speakStreaming](#speakstreaming) - Streaming text to speech
* [livekitToken](#livekittoken) - Generate LiveKit room token
* [listTtsHistory](#listttshistory) - List text-to-speech history
* [getTtsHistory](#getttshistory) - Retrieve text-to-speech history item
* [deleteTtsHistory](#deletettshistory) - Delete text-to-speech history item
* [getTtsHistoryContent](#getttshistorycontent) - Retrieve text-to-speech audio
* [listTranscriptionHistory](#listtranscriptionhistory) - List speech-to-text history
* [getTranscriptionHistory](#gettranscriptionhistory) - Retrieve speech-to-text history item
* [deleteTranscriptionHistory](#deletetranscriptionhistory) - Delete speech-to-text history item
* [getTranscriptionHistoryContent](#gettranscriptionhistorycontent) - Retrieve speech-to-text audio

## transcribe

Convert audio to text using advanced speech recognition.

**Complete File Upload (Standard)**
Use `Content-Type: multipart/form-data` to upload the complete audio file in one request. Maximum file size: 25MB.

Example:
```bash
curl -X POST "http://localhost:3000/api/v1/llm/speech/transcriptions?language=en" \
  -F "file=@audio.flac"
```

**Chunked Upload (Streaming)**
Use `Transfer-Encoding: chunked` header to stream audio data in chunks as it's being recorded. No need to know total file size upfront. Server buffers chunks until complete before processing. Maximum total size: 25MB.

Example:
```bash
curl -X POST "http://localhost:3000/api/v1/llm/speech/transcriptions?language=en" \
  -H "Transfer-Encoding: chunked" \
  -H "Content-Type: multipart/form-data" \
  --data-binary @audio.flac
```

**Supported Formats:** FLAC, MP3, MP4, MPEG, MPGA, M4A, OGG, WAV, WebM

**Query Parameters:**
- `model` (optional): Transcription model identifier. Defaults to 'auto'.
- `language` (optional): ISO-639-1 or BCP-47 language code (e.g., "en", "en-US"). Auto-detects if not specified.
- `prompt` (optional): Legacy prompt parameter retained for backward compatibility.
- `temperature` (optional): Legacy temperature parameter retained for backward compatibility.
- `include_speaker_data` (optional): When `true`, include speaker diarization data and require WAV/PCM input. Otherwise transcription uses the standard compatibility path.

**Response:** Returns transcribed text in JSON format.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="transcribe" method="post" path="/api/v1/llm/speech/transcriptions" -->
```typescript
import { SDK } from "@meetkai/mka1";
import { openAsBlob } from "node:fs";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.transcribe({
    language: "en",
    includeSpeakerData: true,
    prompt: "This is a technical podcast about machine learning.",
    temperature: 0.2,
    store: true,
    requestBody: {
      file: await openAsBlob("example.file"),
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechTranscribe } from "@meetkai/mka1/funcs/llmSpeechTranscribe.js";
import { openAsBlob } from "node:fs";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechTranscribe(sdk, {
    language: "en",
    includeSpeakerData: true,
    prompt: "This is a technical podcast about machine learning.",
    temperature: 0.2,
    store: true,
    requestBody: {
      file: await openAsBlob("example.file"),
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechTranscribe failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmSpeechTranscribeMutation
} from "@meetkai/mka1/react-query/llmSpeechTranscribe.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.TranscribeRequest](../../models/operations/transcriberequest.md)                                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.TranscriptionResponse](../../models/components/transcriptionresponse.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## speak

Convert text to speech with automatic language detection.

**Request Body:**
- `text`: Input text to convert to speech - required
- `language`: Language code (default: "auto") - "auto" for automatic detection, or one of the supported ISO 639-1 codes: en, zh, hi, es, ar, bn, pt, ru, ja, pa, de, ko, fr, tr, it, th, pl, nl, id, vi, ur, uk
- `model`: TTS model identifier (default: "auto") - "auto" selects the default provider; a registry-resolvable id dispatches to the matching provider

**Response:** Returns audio file in WAV format with X-Language-Code header. When `store` is `true`, the generation is persisted before the response returns and the new history record id is included in the X-Tts-Id header.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="textToSpeech" method="post" path="/api/v1/llm/speech/tts" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.speak({
    textToSpeechRequest: {
      text: "Hello, welcome to our text-to-speech service.",
      language: "en",
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechSpeak } from "@meetkai/mka1/funcs/llmSpeechSpeak.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechSpeak(sdk, {
    textToSpeechRequest: {
      text: "Hello, welcome to our text-to-speech service.",
      language: "en",
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechSpeak failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmSpeechSpeakMutation
} from "@meetkai/mka1/react-query/llmSpeechSpeak.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.TextToSpeechRequest](../../models/operations/texttospeechrequest.md)                                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.TextToSpeechResponse](../../models/operations/texttospeechresponse.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## speakStreaming

Convert text to speech with real-time streaming audio delivery.

**Key Features:**
- Low-latency audio streaming - playback can start immediately as chunks arrive
- Automatic language detection
- Multiple format support: MP3 or PCM/WAV
- High-quality audio: 24kHz sample rate, 16-bit mono

**Request Body:**
- `text`: Input text to convert to speech - required
- `language`: Language code (default: "auto") - "auto" for automatic detection, or one of the supported ISO 639-1 codes: en, zh, hi, es, ar, bn, pt, ru, ja, pa, de, ko, fr, tr, it, th, pl, nl, id, vi, ur, uk
- `format`: Audio format (default: "mp3") - "mp3" for compressed MPEG audio (96 kbps) or "pcm" for uncompressed WAV
- `model`: TTS model identifier (default: "auto") - "auto" selects the default provider; a registry-resolvable id dispatches to the matching provider (note: not all providers support `format: "mp3"`)

**Response:**
- Streams audio chunks in real-time
- Returns `X-Language-Code` header with detected/used language
- Content-Type: `audio/mpeg` (MP3) or `audio/wav` (PCM)
- When `store` is `true`, returns the `X-Tts-Id` header with the id the history record will be stored under; persistence is best-effort and completes shortly after the stream ends

**Use Cases:**
- Real-time applications requiring immediate audio playback
- Interactive voice responses
- Low-latency text-to-speech scenarios

### Example Usage

<!-- UsageSnippet language="typescript" operationID="textToSpeechStreaming" method="post" path="/api/v1/llm/speech/tts/stream" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.speakStreaming({
    textToSpeechStreamingRequest: {
      text: "Hello, welcome to our text-to-speech service.",
      language: "en",
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechSpeakStreaming } from "@meetkai/mka1/funcs/llmSpeechSpeakStreaming.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechSpeakStreaming(sdk, {
    textToSpeechStreamingRequest: {
      text: "Hello, welcome to our text-to-speech service.",
      language: "en",
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechSpeakStreaming failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmSpeechSpeakStreamingMutation
} from "@meetkai/mka1/react-query/llmSpeechSpeakStreaming.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.TextToSpeechStreamingRequest](../../models/operations/texttospeechstreamingrequest.md)                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.TextToSpeechStreamingResponse](../../models/operations/texttospeechstreamingresponse.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## livekitToken

Generates a LiveKit access token for joining a real-time voice room. The token includes encrypted credentials and model configuration for the voice agent.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="livekitToken" method="post" path="/api/v1/llm/speech/livekit/token" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.livekitToken({
    livekitTokenRequest: {
      llm: {
        model: "auto",
      },
      language: "uk",
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechLivekitToken } from "@meetkai/mka1/funcs/llmSpeechLivekitToken.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechLivekitToken(sdk, {
    livekitTokenRequest: {
      llm: {
        model: "auto",
      },
      language: "uk",
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechLivekitToken failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmSpeechLivekitTokenMutation
} from "@meetkai/mka1/react-query/llmSpeechLivekitToken.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.LivekitTokenRequest](../../models/operations/livekittokenrequest.md)                                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.LivekitTokenResponse](../../models/components/livekittokenresponse.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listTtsHistory

List stored text-to-speech generations for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.listTtsHistory({
    after: "tts_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechListTtsHistory } from "@meetkai/mka1/funcs/llmSpeechListTtsHistory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechListTtsHistory(sdk, {
    after: "tts_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechListTtsHistory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmSpeechListTtsHistory,
  useLlmSpeechListTtsHistorySuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmSpeechListTtsHistory,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmSpeechListTtsHistory,
  invalidateAllLlmSpeechListTtsHistory,
} from "@meetkai/mka1/react-query/llmSpeechListTtsHistory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListTextToSpeechHistoryRequest](../../models/operations/listtexttospeechhistoryrequest.md)                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.TextToSpeechHistoryList](../../models/components/texttospeechhistorylist.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getTtsHistory

Returns metadata for a stored text-to-speech generation.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.getTtsHistory({
    ttsId: "tts_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechGetTtsHistory } from "@meetkai/mka1/funcs/llmSpeechGetTtsHistory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechGetTtsHistory(sdk, {
    ttsId: "tts_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechGetTtsHistory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmSpeechGetTtsHistory,
  useLlmSpeechGetTtsHistorySuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmSpeechGetTtsHistory,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmSpeechGetTtsHistory,
  invalidateAllLlmSpeechGetTtsHistory,
} from "@meetkai/mka1/react-query/llmSpeechGetTtsHistory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetTextToSpeechHistoryRequest](../../models/operations/gettexttospeechhistoryrequest.md)                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.TextToSpeechHistoryObject](../../models/components/texttospeechhistoryobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## deleteTtsHistory

Deletes a stored text-to-speech generation. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteTextToSpeechHistory" method="delete" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.deleteTtsHistory({
    ttsId: "tts_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechDeleteTtsHistory } from "@meetkai/mka1/funcs/llmSpeechDeleteTtsHistory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechDeleteTtsHistory(sdk, {
    ttsId: "tts_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechDeleteTtsHistory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmSpeechDeleteTtsHistoryMutation
} from "@meetkai/mka1/react-query/llmSpeechDeleteTtsHistory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteTextToSpeechHistoryRequest](../../models/operations/deletetexttospeechhistoryrequest.md)                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.SpeechHistoryDeletionStatus](../../models/components/speechhistorydeletionstatus.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getTtsHistoryContent

Returns the stored audio for a text-to-speech generation as a binary response.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getTextToSpeechHistoryContent" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}/content" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.getTtsHistoryContent({
    ttsId: "tts_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechGetTtsHistoryContent } from "@meetkai/mka1/funcs/llmSpeechGetTtsHistoryContent.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechGetTtsHistoryContent(sdk, {
    ttsId: "tts_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechGetTtsHistoryContent failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmSpeechGetTtsHistoryContent,
  useLlmSpeechGetTtsHistoryContentSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmSpeechGetTtsHistoryContent,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmSpeechGetTtsHistoryContent,
  invalidateAllLlmSpeechGetTtsHistoryContent,
} from "@meetkai/mka1/react-query/llmSpeechGetTtsHistoryContent.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetTextToSpeechHistoryContentRequest](../../models/operations/gettexttospeechhistorycontentrequest.md)                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetTextToSpeechHistoryContentResponse](../../models/operations/gettexttospeechhistorycontentresponse.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listTranscriptionHistory

List stored transcriptions for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.listTranscriptionHistory({
    after: "tts_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechListTranscriptionHistory } from "@meetkai/mka1/funcs/llmSpeechListTranscriptionHistory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechListTranscriptionHistory(sdk, {
    after: "tts_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechListTranscriptionHistory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmSpeechListTranscriptionHistory,
  useLlmSpeechListTranscriptionHistorySuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmSpeechListTranscriptionHistory,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmSpeechListTranscriptionHistory,
  invalidateAllLlmSpeechListTranscriptionHistory,
} from "@meetkai/mka1/react-query/llmSpeechListTranscriptionHistory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListSpeechToTextHistoryRequest](../../models/operations/listspeechtotexthistoryrequest.md)                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.SpeechToTextHistoryList](../../models/components/speechtotexthistorylist.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getTranscriptionHistory

Returns metadata for a stored transcription.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.getTranscriptionHistory({
    sttId: "stt_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechGetTranscriptionHistory } from "@meetkai/mka1/funcs/llmSpeechGetTranscriptionHistory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechGetTranscriptionHistory(sdk, {
    sttId: "stt_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechGetTranscriptionHistory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmSpeechGetTranscriptionHistory,
  useLlmSpeechGetTranscriptionHistorySuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmSpeechGetTranscriptionHistory,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmSpeechGetTranscriptionHistory,
  invalidateAllLlmSpeechGetTranscriptionHistory,
} from "@meetkai/mka1/react-query/llmSpeechGetTranscriptionHistory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetSpeechToTextHistoryRequest](../../models/operations/getspeechtotexthistoryrequest.md)                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.SpeechToTextHistoryObject](../../models/components/speechtotexthistoryobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## deleteTranscriptionHistory

Deletes a stored transcription. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteSpeechToTextHistory" method="delete" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.deleteTranscriptionHistory({
    sttId: "stt_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechDeleteTranscriptionHistory } from "@meetkai/mka1/funcs/llmSpeechDeleteTranscriptionHistory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechDeleteTranscriptionHistory(sdk, {
    sttId: "stt_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechDeleteTranscriptionHistory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmSpeechDeleteTranscriptionHistoryMutation
} from "@meetkai/mka1/react-query/llmSpeechDeleteTranscriptionHistory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteSpeechToTextHistoryRequest](../../models/operations/deletespeechtotexthistoryrequest.md)                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.SpeechHistoryDeletionStatus](../../models/components/speechhistorydeletionstatus.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getTranscriptionHistoryContent

Returns the stored input audio for a transcription as a binary response.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getSpeechToTextHistoryContent" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}/content" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.speech.getTranscriptionHistoryContent({
    sttId: "stt_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmSpeechGetTranscriptionHistoryContent } from "@meetkai/mka1/funcs/llmSpeechGetTranscriptionHistoryContent.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmSpeechGetTranscriptionHistoryContent(sdk, {
    sttId: "stt_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmSpeechGetTranscriptionHistoryContent failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmSpeechGetTranscriptionHistoryContent,
  useLlmSpeechGetTranscriptionHistoryContentSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmSpeechGetTranscriptionHistoryContent,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmSpeechGetTranscriptionHistoryContent,
  invalidateAllLlmSpeechGetTranscriptionHistoryContent,
} from "@meetkai/mka1/react-query/llmSpeechGetTranscriptionHistoryContent.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetSpeechToTextHistoryContentRequest](../../models/operations/getspeechtotexthistorycontentrequest.md)                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[ReadableStream<Uint8Array>](../../models/.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |