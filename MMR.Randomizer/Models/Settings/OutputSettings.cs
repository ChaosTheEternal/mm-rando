﻿using System.IO;
using System.Text.Json.Serialization;

namespace MMR.Randomizer.Models.Settings
{

    public class OutputSettings
    {
        /// <summary>
        ///  Outputs n64 rom if true (default: true)
        /// </summary>
        public bool GenerateROM { get; set; } = true;

        /// <summary>
        ///  Outputs virtual channel if true
        /// </summary>
        public bool OutputVC { get; set; }

        /// <summary>
        /// Filepath to the input ROM
        /// </summary>
        public string InputROMFilename { get; set; }

        /// <summary>
        /// Filepath to the input patch file
        /// </summary>
        [JsonIgnore]
        public string InputPatchFilename { get; set; }

        [JsonIgnore]
        public string OutputROMFilename { get; set; }

        /// <summary>
        /// Generate spoiler log on randomizing
        /// </summary>
        public bool GenerateSpoilerLog { get; set; } = true;

        /// <summary>
        /// Generate HTML spoiler log on randomizing
        /// </summary>
        public bool GenerateHTMLLog { get; set; } = true;

        /// <summary>
        /// Generate patch file
        /// </summary>
        public bool GeneratePatch { get; set; }

        /// <summary>
        /// Web Service domain for uploading the tracker and where the tracker syncs updates
        /// </summary>
        public string WebServiceDN { get; set; }

        /// <summary>
        /// Web Service Authorization Key to specify who we are and allow uploads
        /// </summary>
        public string WebAuthKey { get; set; }

        /// <summary>
        /// Web Service Password to confirm authorization, this is not used by the generator, but is stored for convenience
        /// </summary>
        public string WebPassword { get; set; }

        public string Validate()
        {
            if (!GenerateROM && !OutputVC && (InputPatchFilename != null || (!GeneratePatch && !GenerateSpoilerLog && !GenerateHTMLLog)))
            {
                return "No output selected.";
            }
            if ((GenerateROM || GeneratePatch || OutputVC) && !File.Exists(InputROMFilename))
            {
                return "Input ROM not found, cannot generate output.";
            }
            if (InputPatchFilename != null && string.IsNullOrWhiteSpace(InputPatchFilename))
            {
                return "No patch selected.";
            }
            return null;
        }
    }
}
