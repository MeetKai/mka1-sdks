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

<!-- UsageSnippet language="go" operationID="transcribe" method="post" path="/api/v1/llm/speech/transcriptions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"os"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    example, fileErr := os.Open("example.file")
    if fileErr != nil {
        panic(fileErr)
    }

    res, err := s.Llm.Speech.Transcribe(ctx, operations.TranscribeRequest{
        Language: mka1.Pointer("en"),
        IncludeSpeakerData: mka1.Pointer(true),
        Prompt: mka1.Pointer("This is a technical podcast about machine learning."),
        Temperature: mka1.Pointer[float64](0.2),
        Store: mka1.Pointer(true),
        Body: operations.TranscribeRequestBody{
            File: operations.TranscribeFile{
                FileName: "example.file",
                Content: example,
            },
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.TranscriptionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `ctx`                                                                        | [context.Context](https://pkg.go.dev/context#Context)                        | :heavy_check_mark:                                                           | The context to use for the request.                                          |
| `request`                                                                    | [operations.TranscribeRequest](../../models/operations/transcriberequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |
| `opts`                                                                       | [][operations.Option](../../models/operations/option.md)                     | :heavy_minus_sign:                                                           | The options for this request.                                                |

### Response

**[*operations.TranscribeResponse](../../models/operations/transcriberesponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Speak

Convert text to speech with automatic language detection.

**Request Body:**
- `text`: Input text to convert to speech - required
- `language`: Language code (default: "auto") - "auto" for automatic detection, or one of the supported ISO 639-1 codes: en, zh, hi, es, ar, bn, pt, ru, ja, pa, de, ko, fr, tr, it, th, pl, nl, id, vi, ur, uk
- `model`: TTS model identifier (default: "auto") - "auto" selects the default provider; a registry-resolvable id dispatches to the matching provider

**Response:** Returns audio file in WAV format with X-Language-Code header. When `store` is `true`, the generation is persisted before the response returns and the new history record id is included in the X-Tts-Id header.

### Example Usage

<!-- UsageSnippet language="go" operationID="textToSpeech" method="post" path="/api/v1/llm/speech/tts" -->
```go
package main

import(
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

    res, err := s.Llm.Speech.Speak(ctx, components.TextToSpeechRequest{
        Text: "Hello, welcome to our text-to-speech service.",
        Language: components.TextToSpeechRequestLanguageEn.ToPointer(),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      | Example                                                                          |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |                                                                                  |
| `body`                                                                           | [components.TextToSpeechRequest](../../models/components/texttospeechrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              | {<br/>"text": "Hello, welcome to our text-to-speech service.",<br/>"language": "en"<br/>} |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |                                                                                  |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |                                                                                  |

### Response

**[*operations.TextToSpeechResponse](../../models/operations/texttospeechresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

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

<!-- UsageSnippet language="go" operationID="textToSpeechStreaming" method="post" path="/api/v1/llm/speech/tts/stream" -->
```go
package main

import(
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

    res, err := s.Llm.Speech.SpeakStreaming(ctx, components.TextToSpeechStreamingRequest{
        Text: "Hello, welcome to our text-to-speech service.",
        Language: components.TextToSpeechStreamingRequestLanguageEn.ToPointer(),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TwoHundredAudioMpegResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `body`                                                                                             | [components.TextToSpeechStreamingRequest](../../models/components/texttospeechstreamingrequest.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.TextToSpeechStreamingResponse](../../models/operations/texttospeechstreamingresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## LivekitToken

Generates a LiveKit access token for joining a real-time voice room. The token includes encrypted credentials and model configuration for the voice agent.

### Example Usage

<!-- UsageSnippet language="go" operationID="livekitToken" method="post" path="/api/v1/llm/speech/livekit/token" -->
```go
package main

import(
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

    res, err := s.Llm.Speech.LivekitToken(ctx, components.LivekitTokenRequest{
        Llm: components.Llm{
            Model: "auto",
        },
        Language: components.LivekitTokenRequestLanguageUk.ToPointer(),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.LivekitTokenResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |
| `body`                                                                           | [components.LivekitTokenRequest](../../models/components/livekittokenrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |

### Response

**[*operations.LivekitTokenResponse](../../models/operations/livekittokenresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListTtsHistory

List stored text-to-speech generations for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="go" operationID="listTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.ListTtsHistory(ctx, operations.ListTextToSpeechHistoryRequest{
        After: mka1.Pointer("tts_aa87e2b1112a455b8deabed784372198"),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.TextToSpeechHistoryList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `request`                                                                                              | [operations.ListTextToSpeechHistoryRequest](../../models/operations/listtexttospeechhistoryrequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.ListTextToSpeechHistoryResponse](../../models/operations/listtexttospeechhistoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetTtsHistory

Returns metadata for a stored text-to-speech generation.

### Example Usage

<!-- UsageSnippet language="go" operationID="getTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.GetTtsHistory(ctx, "tts_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TextToSpeechHistoryObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `ttsID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetTextToSpeechHistoryResponse](../../models/operations/gettexttospeechhistoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteTtsHistory

Deletes a stored text-to-speech generation. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteTextToSpeechHistory" method="delete" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.DeleteTtsHistory(ctx, "tts_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SpeechHistoryDeletionStatus != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `ttsID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteTextToSpeechHistoryResponse](../../models/operations/deletetexttospeechhistoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetTtsHistoryContent

Returns the stored audio for a text-to-speech generation as a binary response.

### Example Usage

<!-- UsageSnippet language="go" operationID="getTextToSpeechHistoryContent" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}/content" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.GetTtsHistoryContent(ctx, "tts_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TwoHundredAudioWavResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `ttsID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetTextToSpeechHistoryContentResponse](../../models/operations/gettexttospeechhistorycontentresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListTranscriptionHistory

List stored transcriptions for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.ListTranscriptionHistory(ctx, operations.ListSpeechToTextHistoryRequest{
        After: mka1.Pointer("tts_aa87e2b1112a455b8deabed784372198"),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.SpeechToTextHistoryList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `request`                                                                                              | [operations.ListSpeechToTextHistoryRequest](../../models/operations/listspeechtotexthistoryrequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.ListSpeechToTextHistoryResponse](../../models/operations/listspeechtotexthistoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetTranscriptionHistory

Returns metadata for a stored transcription.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.GetTranscriptionHistory(ctx, "stt_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SpeechToTextHistoryObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sttID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSpeechToTextHistoryResponse](../../models/operations/getspeechtotexthistoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteTranscriptionHistory

Deletes a stored transcription. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteSpeechToTextHistory" method="delete" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.DeleteTranscriptionHistory(ctx, "stt_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SpeechHistoryDeletionStatus != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sttID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteSpeechToTextHistoryResponse](../../models/operations/deletespeechtotexthistoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetTranscriptionHistoryContent

Returns the stored input audio for a transcription as a binary response.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSpeechToTextHistoryContent" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}/content" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Speech.GetTranscriptionHistoryContent(ctx, "stt_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sttID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSpeechToTextHistoryContentResponse](../../models/operations/getspeechtotexthistorycontentresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |