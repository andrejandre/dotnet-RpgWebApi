using System.Text.Json.Serialization;

namespace RpgWebApi.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RpgClass
{
    Warrior = 1,
    Rogue = 2,
    Priest = 3,
    Shaman = 4,
    Paladin = 5
}
