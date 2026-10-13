# Llm.Speech

## Overview

### Available Operations

* [Transcribe](#transcribe) - Speech to text transcription
* [Speak](#speak) - Text to speech
* [SpeakStreaming](#speakstreaming) - Streaming text to speech
* [LivekitToken](#livekittoken) - Generate LiveKit room token
* [ListTtsHistory](#listttshistory) - List text-to-speech history
* [GetTtsHistory](#getttshistory) - Retrieve text-to-speech history item
* [DeleteTtsHistory](#deletettshistory) - Delete text-to-speech history item
* [GetTtsHistoryContent](#getttshistorycontent) - Retrieve text-to-speech audio
* [ListTranscriptionHistory](#listtranscriptionhistory) - List speech-to-text history
* [GetTranscriptionHistory](#gettranscriptionhistory) - Retrieve speech-to-text history item
* [DeleteTranscriptionHistory](#deletetranscriptionhistory) - Delete speech-to-text history item
* [GetTranscriptionHistoryContent](#gettranscriptionhistorycontent) - Retrieve speech-to-text audio

## Transcribe

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

<!-- UsageSnippet language="csharp" operationID="transcribe" method="post" path="/api/v1/llm/speech/transcriptions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

TranscribeRequest req = new TranscribeRequest() {
    Language = "en",
    IncludeSpeakerData = true,
    Prompt = "This is a technical podcast about machine learning.",
    Temperature = 0.2D,
    Store = true,
    Body = new TranscribeRequestBody() {
        File = new TranscribeFile() {
            FileName = "example.file",
            Content = System.IO.File.ReadAllBytes("example.file"),
        },
    },
};

var res = await sdk.Llm.Speech.TranscribeAsync(req);

// handle response
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `request`                                                      | [TranscribeRequest](../../Types/Requests/TranscribeRequest.md) | :heavy_check_mark:                                             | The request object to use for the request.                     |

### Response

**[TranscribeResponse](../../Types/Requests/TranscribeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Speak

Convert text to speech with automatic language detection.

**Request Body:**
- `text`: Input text to convert to speech - required
- `language`: Language code (default: "auto") - "auto" for automatic detection, or one of the supported ISO 639-1 codes: en, zh, hi, es, ar, bn, pt, ru, ja, pa, de, ko, fr, tr, it, th, pl, nl, id, vi, ur, uk
- `model`: TTS model identifier (default: "auto") - "auto" selects the default provider; a registry-resolvable id dispatches to the matching provider

**Response:** Returns audio file in WAV format with X-Language-Code header. When `store` is `true`, the generation is persisted before the response returns and the new history record id is included in the X-Tts-Id header.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="textToSpeech" method="post" path="/api/v1/llm/speech/tts" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.SpeakAsync(body: new MeetKai.MKA1.Types.Components.TextToSpeechRequest() {
    Text = "Hello, welcome to our text-to-speech service.",
    Language = TextToSpeechRequestLanguage.En,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Body`                                                                                | [Types.Components.TextToSpeechRequest](../../Types/Components/TextToSpeechRequest.md) | :heavy_check_mark:                                                                    | N/A                                                                                   | {<br/>"text": "Hello, welcome to our text-to-speech service.",<br/>"language": "en"<br/>} |
| `XOnBehalfOf`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |                                                                                       |

### Response

**[TextToSpeechResponse](../../Types/Requests/TextToSpeechResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SpeakStreaming

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

<!-- UsageSnippet language="csharp" operationID="textToSpeechStreaming" method="post" path="/api/v1/llm/speech/tts/stream" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.SpeakStreamingAsync(body: new MeetKai.MKA1.Types.Components.TextToSpeechStreamingRequest() {
    Text = "Hello, welcome to our text-to-speech service.",
    Language = TextToSpeechStreamingRequestLanguage.En,
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                  | [Types.Components.TextToSpeechStreamingRequest](../../Types/Components/TextToSpeechStreamingRequest.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `XOnBehalfOf`                                                                                           | *string*                                                                                                | :heavy_minus_sign:                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                     |

### Response

**[TextToSpeechStreamingResponse](../../Types/Requests/TextToSpeechStreamingResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## LivekitToken

Generates a LiveKit access token for joining a real-time voice room. The token includes encrypted credentials and model configuration for the voice agent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="livekitToken" method="post" path="/api/v1/llm/speech/livekit/token" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.LivekitTokenAsync(body: new MeetKai.MKA1.Types.Components.LivekitTokenRequest() {
    Llm = new MeetKai.MKA1.Types.Components.Llm() {
        Model = "auto",
    },
    Language = LivekitTokenRequestLanguage.Uk,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Body`                                                                                | [Types.Components.LivekitTokenRequest](../../Types/Components/LivekitTokenRequest.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `XOnBehalfOf`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |

### Response

**[Types.Requests.LivekitTokenResponse](../../Types/Requests/LivekitTokenResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListTtsHistory

List stored text-to-speech generations for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListTextToSpeechHistoryRequest req = new ListTextToSpeechHistoryRequest() {
    After = "tts_aa87e2b1112a455b8deabed784372198",
};

var res = await sdk.Llm.Speech.ListTtsHistoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `request`                                                                                | [ListTextToSpeechHistoryRequest](../../Types/Requests/ListTextToSpeechHistoryRequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |

### Response

**[ListTextToSpeechHistoryResponse](../../Types/Requests/ListTextToSpeechHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetTtsHistory

Returns metadata for a stored text-to-speech generation.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.GetTtsHistoryAsync(ttsId: "tts_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `TtsId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetTextToSpeechHistoryResponse](../../Types/Requests/GetTextToSpeechHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteTtsHistory

Deletes a stored text-to-speech generation. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteTextToSpeechHistory" method="delete" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.DeleteTtsHistoryAsync(ttsId: "tts_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `TtsId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteTextToSpeechHistoryResponse](../../Types/Requests/DeleteTextToSpeechHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetTtsHistoryContent

Returns the stored audio for a text-to-speech generation as a binary response.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTextToSpeechHistoryContent" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}/content" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.GetTtsHistoryContentAsync(ttsId: "tts_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `TtsId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetTextToSpeechHistoryContentResponse](../../Types/Requests/GetTextToSpeechHistoryContentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListTranscriptionHistory

List stored transcriptions for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListSpeechToTextHistoryRequest req = new ListSpeechToTextHistoryRequest() {
    After = "tts_aa87e2b1112a455b8deabed784372198",
};

var res = await sdk.Llm.Speech.ListTranscriptionHistoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `request`                                                                                | [ListSpeechToTextHistoryRequest](../../Types/Requests/ListSpeechToTextHistoryRequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |

### Response

**[ListSpeechToTextHistoryResponse](../../Types/Requests/ListSpeechToTextHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetTranscriptionHistory

Returns metadata for a stored transcription.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.GetTranscriptionHistoryAsync(sttId: "stt_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SttId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSpeechToTextHistoryResponse](../../Types/Requests/GetSpeechToTextHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteTranscriptionHistory

Deletes a stored transcription. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteSpeechToTextHistory" method="delete" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.DeleteTranscriptionHistoryAsync(sttId: "stt_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SttId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteSpeechToTextHistoryResponse](../../Types/Requests/DeleteSpeechToTextHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetTranscriptionHistoryContent

Returns the stored input audio for a transcription as a binary response.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSpeechToTextHistoryContent" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}/content" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Speech.GetTranscriptionHistoryContentAsync(sttId: "stt_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SttId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSpeechToTextHistoryContentResponse](../../Types/Requests/GetSpeechToTextHistoryContentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |