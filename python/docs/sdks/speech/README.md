# Llm.Speech

## Overview

### Available Operations

* [transcribe](#transcribe) - Speech to text transcription
* [speak](#speak) - Text to speech
* [speak_streaming](#speak_streaming) - Streaming text to speech
* [livekit_token](#livekit_token) - Generate LiveKit room token
* [list_tts_history](#list_tts_history) - List text-to-speech history
* [get_tts_history](#get_tts_history) - Retrieve text-to-speech history item
* [delete_tts_history](#delete_tts_history) - Delete text-to-speech history item
* [get_tts_history_content](#get_tts_history_content) - Retrieve text-to-speech audio
* [list_transcription_history](#list_transcription_history) - List speech-to-text history
* [get_transcription_history](#get_transcription_history) - Retrieve speech-to-text history item
* [delete_transcription_history](#delete_transcription_history) - Delete speech-to-text history item
* [get_transcription_history_content](#get_transcription_history_content) - Retrieve speech-to-text audio

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

<!-- UsageSnippet language="python" operationID="transcribe" method="post" path="/api/v1/llm/speech/transcriptions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.transcribe(file={
        "file_name": "example.file",
        "content": open("example.file", "rb"),
    }, model="auto", language="en", include_speaker_data=True, prompt="This is a technical podcast about machine learning.", temperature=0.2, store=True)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | Example                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `file`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | [models.TranscribeFile](../../models/transcribefile.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Audio file to transcribe.<br/><br/>**File Requirements:**<br/>- Maximum size: 25MB<br/>- Supported formats: FLAC, MP3, MP4, MPEG, MPGA, M4A, OGG, WAV, WebM<br/>- Speaker diarization currently requires WAV / PCM input<br/><br/>**Upload Options:**<br/>1. Standard: Upload complete file using multipart/form-data<br/>2. Chunked: Stream file chunks using Transfer-Encoding: chunked header (useful for real-time recording)<br/><br/>**Note:** For chunked uploads, server buffers all chunks before processing. Transcription begins only after the complete file is received. |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| `model`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | *Optional[str]*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | auto                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| `language`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | *Optional[str]*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | en                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| `include_speaker_data`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | *Optional[bool]*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | true                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| `prompt`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *Optional[str]*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | This is a technical podcast about machine learning.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| `temperature`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | *Optional[float]*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | 0.2                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| `store`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | *Optional[bool]*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | true                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | *Optional[str]*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| `retries`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |

### Response

**[models.TranscriptionResponse](../../models/transcriptionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## speak

Convert text to speech with automatic language detection.

**Request Body:**
- `text`: Input text to convert to speech - required
- `language`: Language code (default: "auto") - "auto" for automatic detection, or one of the supported ISO 639-1 codes: en, zh, hi, es, ar, bn, pt, ru, ja, pa, de, ko, fr, tr, it, th, pl, nl, id, vi, ur, uk
- `model`: TTS model identifier (default: "auto") - "auto" selects the default provider; a registry-resolvable id dispatches to the matching provider

**Response:** Returns audio file in WAV format with X-Language-Code header. When `store` is `true`, the generation is persisted before the response returns and the new history record id is included in the X-Tts-Id header.

### Example Usage

<!-- UsageSnippet language="python" operationID="textToSpeech" method="post" path="/api/v1/llm/speech/tts" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.speak(text="Hello, welcome to our text-to-speech service.", language="en", model="auto", store=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                | Type                                                                                                                                     | Required                                                                                                                                 | Description                                                                                                                              | Example                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| `text`                                                                                                                                   | *str*                                                                                                                                    | :heavy_check_mark:                                                                                                                       | Input text to convert to speech                                                                                                          |                                                                                                                                          |
| `x_on_behalf_of`                                                                                                                         | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                      |                                                                                                                                          |
| `language`                                                                                                                               | [Optional[models.TextToSpeechRequestLanguage]](../../models/texttospeechrequestlanguage.md)                                              | :heavy_minus_sign:                                                                                                                       | Language code: 'auto' for automatic detection, or ISO 639-1 language codes                                                               |                                                                                                                                          |
| `model`                                                                                                                                  | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | TTS model identifier. Defaults to 'auto', which selects the default provider. Registry-resolvable ids dispatch to the matching provider. | auto                                                                                                                                     |
| `store`                                                                                                                                  | *Optional[bool]*                                                                                                                         | :heavy_minus_sign:                                                                                                                       | When true, persist this generation (input text, parameters, and the generated audio) to text-to-speech history. Defaults to false.       |                                                                                                                                          |
| `retries`                                                                                                                                | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                         | :heavy_minus_sign:                                                                                                                       | Configuration to override the default retry behavior of the client.                                                                      |                                                                                                                                          |

### Response

**[models.TextToSpeechResponse](../../models/texttospeechresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## speak_streaming

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

<!-- UsageSnippet language="python" operationID="textToSpeechStreaming" method="post" path="/api/v1/llm/speech/tts/stream" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.speak_streaming(text="Hello, welcome to our text-to-speech service.", language="en", model="auto", store=False, format_="mp3")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                | Type                                                                                                                                     | Required                                                                                                                                 | Description                                                                                                                              | Example                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| `text`                                                                                                                                   | *str*                                                                                                                                    | :heavy_check_mark:                                                                                                                       | Input text to convert to speech                                                                                                          |                                                                                                                                          |
| `x_on_behalf_of`                                                                                                                         | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                      |                                                                                                                                          |
| `language`                                                                                                                               | [Optional[models.TextToSpeechStreamingRequestLanguage]](../../models/texttospeechstreamingrequestlanguage.md)                            | :heavy_minus_sign:                                                                                                                       | Language code: 'auto' for automatic detection, or ISO 639-1 language codes                                                               |                                                                                                                                          |
| `model`                                                                                                                                  | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | TTS model identifier. Defaults to 'auto', which selects the default provider. Registry-resolvable ids dispatch to the matching provider. | auto                                                                                                                                     |
| `store`                                                                                                                                  | *Optional[bool]*                                                                                                                         | :heavy_minus_sign:                                                                                                                       | When true, persist this generation (input text, parameters, and the generated audio) to text-to-speech history. Defaults to false.       |                                                                                                                                          |
| `format_`                                                                                                                                | [Optional[models.TextToSpeechStreamingRequestFormat]](../../models/texttospeechstreamingrequestformat.md)                                | :heavy_minus_sign:                                                                                                                       | Audio output format: 'mp3' for MPEG audio (default), or 'pcm' for uncompressed PCM/WAV (24kHz, 16-bit, mono)                             |                                                                                                                                          |
| `retries`                                                                                                                                | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                         | :heavy_minus_sign:                                                                                                                       | Configuration to override the default retry behavior of the client.                                                                      |                                                                                                                                          |

### Response

**[models.TextToSpeechStreamingResponse](../../models/texttospeechstreamingresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## livekit_token

Generates a LiveKit access token for joining a real-time voice room. The token includes encrypted credentials and model configuration for the voice agent.

### Example Usage

<!-- UsageSnippet language="python" operationID="livekitToken" method="post" path="/api/v1/llm/speech/livekit/token" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.livekit_token(llm={
        "model": "auto",
    }, language="uk")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                        | Type                                                                                                                                                                                                                                                                                                                                                                                                                             | Required                                                                                                                                                                                                                                                                                                                                                                                                                         | Description                                                                                                                                                                                                                                                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `llm`                                                                                                                                                                                                                                                                                                                                                                                                                            | [models.Llm](../../models/llm.md)                                                                                                                                                                                                                                                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                               | LLM configuration for the voice session. Uses a subset of the responses create schema — fields like input, stream, background, webhooks, and store are excluded since the voice agent manages those. WARNING: This object is serialized into the LiveKit JWT metadata which is transmitted via HTTP headers. Keep payloads small — large tools arrays can exceed the ~8KB header size limit imposed by most servers and proxies. |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                                                                                                                                                                 | *Optional[str]*                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                                                                                                                              |
| `stt`                                                                                                                                                                                                                                                                                                                                                                                                                            | [Optional[models.SttConfig]](../../models/sttconfig.md)                                                                                                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                               | Optional STT (speech-to-text) VAD configuration for the voice session.                                                                                                                                                                                                                                                                                                                                                           |
| `language`                                                                                                                                                                                                                                                                                                                                                                                                                       | [Optional[models.LivekitTokenRequestLanguage]](../../models/livekittokenrequestlanguage.md)                                                                                                                                                                                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                               | Optional ISO 639-1 language code (for example 'en' or 'uk') for the voice session; must be one of the languages supported by text-to-speech. Carried in the participant metadata so the voice agent uses it for speech recognition and synthesis instead of auto-detecting. Omit to let the agent auto-detect.                                                                                                                   |
| `retries`                                                                                                                                                                                                                                                                                                                                                                                                                        | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                               | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                                                                                                                                                              |

### Response

**[models.LivekitTokenResponse](../../models/livekittokenresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_tts_history

List stored text-to-speech generations for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="python" operationID="listTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.list_tts_history(after="tts_aa87e2b1112a455b8deabed784372198", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `after`                                                                                       | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           | tts_aa87e2b1112a455b8deabed784372198                                                          |
| `limit`                                                                                       | *Optional[int]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           | 20                                                                                            |
| `order`                                                                                       | [Optional[models.ListTextToSpeechHistoryOrder]](../../models/listtexttospeechhistoryorder.md) | :heavy_minus_sign:                                                                            | Sort order by creation time. Defaults to 'desc' (newest first).                               | desc                                                                                          |
| `model`                                                                                       | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `x_on_behalf_of`                                                                              | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |                                                                                               |
| `retries`                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                              | :heavy_minus_sign:                                                                            | Configuration to override the default retry behavior of the client.                           |                                                                                               |

### Response

**[models.TextToSpeechHistoryList](../../models/texttospeechhistorylist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_tts_history

Returns metadata for a stored text-to-speech generation.

### Example Usage

<!-- UsageSnippet language="python" operationID="getTextToSpeechHistory" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.get_tts_history(tts_id="tts_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `tts_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.TextToSpeechHistoryObject](../../models/texttospeechhistoryobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_tts_history

Deletes a stored text-to-speech generation. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteTextToSpeechHistory" method="delete" path="/api/v1/llm/speech/tts/history/{tts_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.delete_tts_history(tts_id="tts_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `tts_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SpeechHistoryDeletionStatus](../../models/speechhistorydeletionstatus.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_tts_history_content

Returns the stored audio for a text-to-speech generation as a binary response.

### Example Usage

<!-- UsageSnippet language="python" operationID="getTextToSpeechHistoryContent" method="get" path="/api/v1/llm/speech/tts/history/{tts_id}/content" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.get_tts_history_content(tts_id="tts_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `tts_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | tts_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetTextToSpeechHistoryContentResponse](../../models/gettexttospeechhistorycontentresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_transcription_history

List stored transcriptions for the authenticated user, newest first by default.

### Example Usage

<!-- UsageSnippet language="python" operationID="listSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.list_transcription_history(after="tts_aa87e2b1112a455b8deabed784372198", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `after`                                                                                       | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           | tts_aa87e2b1112a455b8deabed784372198                                                          |
| `limit`                                                                                       | *Optional[int]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           | 20                                                                                            |
| `order`                                                                                       | [Optional[models.ListSpeechToTextHistoryOrder]](../../models/listspeechtotexthistoryorder.md) | :heavy_minus_sign:                                                                            | Sort order by creation time. Defaults to 'desc' (newest first).                               | desc                                                                                          |
| `model`                                                                                       | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `x_on_behalf_of`                                                                              | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |                                                                                               |
| `retries`                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                              | :heavy_minus_sign:                                                                            | Configuration to override the default retry behavior of the client.                           |                                                                                               |

### Response

**[models.SpeechToTextHistoryList](../../models/speechtotexthistorylist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_transcription_history

Returns metadata for a stored transcription.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSpeechToTextHistory" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.get_transcription_history(stt_id="stt_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `stt_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SpeechToTextHistoryObject](../../models/speechtotexthistoryobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_transcription_history

Deletes a stored transcription. The audio blob is content-addressed and may be shared, so it is left in storage.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteSpeechToTextHistory" method="delete" path="/api/v1/llm/speech/transcriptions/history/{stt_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.delete_transcription_history(stt_id="stt_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `stt_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SpeechHistoryDeletionStatus](../../models/speechhistorydeletionstatus.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_transcription_history_content

Returns the stored input audio for a transcription as a binary response.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSpeechToTextHistoryContent" method="get" path="/api/v1/llm/speech/transcriptions/history/{stt_id}/content" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.speech.get_transcription_history_content(stt_id="stt_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `stt_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | stt_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[httpx.Response](../../models/.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |