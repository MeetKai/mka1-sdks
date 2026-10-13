# LivekitTokenRequestLanguage

Optional ISO 639-1 language code (for example 'en' or 'uk') for the voice session; must be one of the languages supported by text-to-speech. Carried in the participant metadata so the voice agent uses it for speech recognition and synthesis instead of auto-detecting. Omit to let the agent auto-detect.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = LivekitTokenRequestLanguage.En;
```


## Values

| Name  | Value |
| ----- | ----- |
| `En`  | en    |
| `Zh`  | zh    |
| `Hi`  | hi    |
| `Es`  | es    |
| `Ar`  | ar    |
| `Bn`  | bn    |
| `Pt`  | pt    |
| `Ru`  | ru    |
| `Ja`  | ja    |
| `Pa`  | pa    |
| `De`  | de    |
| `Ko`  | ko    |
| `Fr`  | fr    |
| `Tr`  | tr    |
| `It`  | it    |
| `Th`  | th    |
| `Pl`  | pl    |
| `Nl`  | nl    |
| `Id`  | id    |
| `Vi`  | vi    |
| `Ur`  | ur    |
| `Uk`  | uk    |