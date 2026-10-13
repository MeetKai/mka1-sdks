# LivekitTokenResponse

Response containing a LiveKit access token, server URL, and the generated room name.


## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Token`                                                                                | *string*                                                                               | :heavy_check_mark:                                                                     | JWT access token for authenticating with the LiveKit room                              |
| `Url`                                                                                  | *string*                                                                               | :heavy_check_mark:                                                                     | LiveKit server WebSocket URL to connect to (e.g., wss://apigw.mka1.com/api/v1/livekit) |
| `RoomName`                                                                             | *string*                                                                               | :heavy_check_mark:                                                                     | Auto-generated UUID room name assigned to this session                                 |