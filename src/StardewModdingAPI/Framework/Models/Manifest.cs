﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StardewModdingAPI.Framework.Serialisation;

namespace StardewModdingAPI.Framework.Models
{
    /// <summary>A manifest which describes a mod for SMAPI.</summary>
    internal class Manifest : IManifest
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The mod name.</summary>
        public string Name { get; set; }

        /// <summary>A brief description of the mod.</summary>
        public string Description { get; set; }

        /// <summary>The mod author's name.</summary>
        public string Author { get; set; }

        /// <summary>The mod version.</summary>
        [JsonConverter(typeof(SemanticVersionConverter))]
        public ISemanticVersion Version { get; set; }

        /// <summary>The minimum SMAPI version required by this mod, if any.</summary>
        public string MinimumApiVersion { get; set; }

        /// <summary>The name of the DLL in the directory that has the <see cref="Mod.Entry"/> method.</summary>
        public string EntryDll { get; set; }

        /// <summary>The unique mod ID.</summary>
        public string UniqueID { get; set; }

        /// <summary>Whether the mod uses per-save config files.</summary>
        [Obsolete("Use " + nameof(Mod) + "." + nameof(Mod.Helper) + "." + nameof(IModHelper.ReadConfig) + " instead")]
        public bool PerSaveConfigs { get; set; }

        /// <summary>Any manifest fields which didn't match a valid field.</summary>
        [JsonExtensionData]
        public IDictionary<string, object> ExtraFields { get; set; }
    }
}
