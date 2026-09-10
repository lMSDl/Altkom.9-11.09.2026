using System.Text.Json;

namespace DesignPatterns.Structural.Facade.I
{
    internal class SerializeFacade
    {
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
            IgnoreReadOnlyProperties = true,
        };

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, options);
        }
    }
}
