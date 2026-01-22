using System.Text.Json;

namespace AXHelper.Extensions;

public static class ObjectExtensions
{
    extension<T>(T? o)
    {
        public string Serialize()
        {
            return JsonSerializer.Serialize(o, new JsonSerializerOptions { WriteIndented = true,  }); 
        }
    }
}