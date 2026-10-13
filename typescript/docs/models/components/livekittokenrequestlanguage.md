# LivekitTokenRequestLanguage

Optional ISO 639-1 language code (for example 'en' or 'uk') for the voice session; must be one of the languages supported by text-to-speech. Carried in the participant metadata so the voice agent uses it for speech recognition and synthesis instead of auto-detecting. Omit to let the agent auto-detect.

## Example Usage

```typescript
import { LivekitTokenRequestLanguage } from "@meetkai/mka1/models/components";

let value: LivekitTokenRequestLanguage = "zh";
```

## Values

```typescript
"en" | "zh" | "hi" | "es" | "ar" | "bn" | "pt" | "ru" | "ja" | "pa" | "de" | "ko" | "fr" | "tr" | "it" | "th" | "pl" | "nl" | "id" | "vi" | "ur" | "uk"
```