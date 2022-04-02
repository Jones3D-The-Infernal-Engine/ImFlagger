using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImFlagger
{
    public sealed class PresetFlagEntry
    {
        [JsonConverter(typeof(HexStringJsonConverter))]
        public uint flag
        {
            get
            {
                return flagValue;
            }
            set
            {
                if (!IsPowerOfTwo(value)) throw new ArgumentException($"flag 0x'{value:X2}' is not power of 2");
                flagValue = value;
            }
        }
        private uint flagValue;
        public string name { get; set; }
        public string description { get; set; }
        public bool enabled { get; set; }

        public PresetFlagEntry(uint flag, string name, string description = "", bool enabled = true)
        {
            this.flag = flag;
            this.name = name;
            this.description = description;
            this.enabled = enabled;
        }

        static bool IsPowerOfTwo(uint n)
        {
            return (n > 0 && ((n & (n - 1)) == 0));
        }

        public uint GetBitPosition()
        {
            return (uint)Math.Round(((Math.Log10(flag & -flag))
                / Math.Log10(2)) + 1) - 1;
        }
    }

    public class Preset
    {
        public string name { get; set; } = "";
        public string description { get; set; } = "";
        public List<PresetFlagEntry> flags { get; set; } = new ();

        public Preset() {}
        public Preset(string name, string description, List<PresetFlagEntry>? flags)
        {
            this.name = name;
            this.description = description;
            if (flags != null)
                this.flags = flags;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
