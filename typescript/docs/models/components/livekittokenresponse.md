# LivekitTokenResponse

Response containing a LiveKit access token, server URL, and the generated room name.

## Example Usage

```typescript
import { LivekitTokenResponse } from "@meetkai/mka1/models/components";

let value: LivekitTokenResponse = {
  token: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  url: "wss://apigw.mka1.com/api/v1/livekit",
  roomName: "550e8400-e29b-41d4-a716-446655440000",
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `token`                                                                                | *string*                                                                               | :heavy_check_mark:                                                                     | JWT access token for authenticating with the LiveKit room                              |
| `url`                                                                                  | *string*                                                                               | :heavy_check_mark:                                                                     | LiveKit server WebSocket URL to connect to (e.g., wss://apigw.mka1.com/api/v1/livekit) |
| `roomName`                                                                             | *string*                                                                               | :heavy_check_mark:                                                                     | Auto-generated UUID room name assigned to this session                                 |