using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImFlagger
{
    public sealed class HexStringJsonConverter : JsonConverter<uint>
    {
        public override uint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetString();
            if (str == null || !str.StartsWith("0x") )
                throw new JsonException($"Invalid hex string {str}");
            try
            {
                return Convert.ToUInt32(str, 16);
            }
            catch (OverflowException ex)
            {
                throw new JsonException($"Too big hex number '{str}'");
            }
            catch (Exception ex)
            {
                throw new JsonException($"Invalid hex string '{str}'");
            }
        }

        public override void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"0x{value:X2}");
        }
    }
}
