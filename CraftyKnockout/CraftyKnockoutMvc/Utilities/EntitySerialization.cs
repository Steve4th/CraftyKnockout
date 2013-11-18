namespace CraftyKnockoutMvc.Utilities
{
    /// <summary>
    /// Entity Serialization and de-serialization methods
    /// </summary>
    /// <remarks>
    /// We are using the Newtonsoft JSON.NET library to do the de-serialization as this is able to cope with populating read-only collections. 
    /// See http://json.codeplex.com/ for details of this library. 
    /// The JSON.NET library has been added via a NuGet package.
    /// </remarks>
    public static class EntitySerialization
    {
        /// <summary>
        /// De-serializes JSON to an object
        /// </summary>
        /// <param name="serializedJson">The serialized JSON.</param>
        /// <typeparam name="T">A serialisable object</typeparam>
        public static T JsonDeserialize<T>(string serializedJson)
        {
            var deserialisedObject = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(serializedJson);
            return deserialisedObject;
        }

        /// <summary>
        /// Serializes the object to JSON
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize.</param>
        /// <typeparam name="T">A serialisable object</typeparam>
        public static string JsonSerialize<T>(this T objectToSerialize)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(objectToSerialize);
            return json;
        }
    }
}