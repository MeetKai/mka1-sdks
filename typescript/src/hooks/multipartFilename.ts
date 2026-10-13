import { RequestInput } from "../lib/http.js";
import { InvalidRequestError } from "../models/errors/httpclienterrors.js";
import {
  BeforeCreateRequestContext,
  BeforeCreateRequestHook,
} from "./types.js";

const FILE_FIELDS: Record<string, string> = {
  uploadFile: "file",
  extract: "file",
  extractWithSchema: "file",
  transcribe: "file",
  createSkill: "files[]",
  createSkillVersion: "files[]",
};

const PLACEHOLDER_NAME = "blob";

/**
 * Rejects multipart file uploads that carry no usable filename before any
 * network call is made. A raw `Blob` has no name, so runtimes serialize it
 * with the placeholder `filename="blob"`, which the platform rejects with a
 * misleading "Unsupported file type" error.
 */
export class MultipartFilenameHook implements BeforeCreateRequestHook {
  beforeCreateRequest(
    hookCtx: BeforeCreateRequestContext,
    input: RequestInput,
  ): RequestInput {
    const field = FILE_FIELDS[hookCtx.operationID];
    const body = input.options?.body;
    if (field == null || !(body instanceof FormData)) {
      return input;
    }

    for (const entry of body.getAll(field)) {
      if (typeof entry === "string") {
        continue;
      }
      // Bun currently returns a Blob (without File.name) for a nameless part,
      // despite FormData.getAll()'s DOM type declaring File. Other runtimes
      // return a File named "blob". Treat both representations identically.
      const rawName = Reflect.get(entry, "name");
      const normalizedName = typeof rawName === "string" ? rawName.trim() : "";
      if (!normalizedName || normalizedName === PLACEHOLDER_NAME) {
        throw new InvalidRequestError(
          `The "${field}" part of the ${hookCtx.operationID} request has no `
            + "filename and the platform requires one to detect the file type. "
            + 'Pass a File, e.g. new File([bytes], "report.pdf"), or the '
            + "{ fileName, content } object form instead of a raw Blob. (A "
            + `file literally named "${PLACEHOLDER_NAME}" is indistinguishable `
            + "from the runtime placeholder and is also rejected; include an "
            + "extension in its name.)",
        );
      }
    }

    return input;
  }
}
