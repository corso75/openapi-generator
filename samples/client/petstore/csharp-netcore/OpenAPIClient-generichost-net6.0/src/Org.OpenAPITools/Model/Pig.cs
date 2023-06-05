// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Pig
    /// </summary>
    public partial class Pig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pig" /> class.
        /// </summary>
        /// <param name="basquePig"></param>
        [JsonConstructor]
        internal Pig(BasquePig basquePig)
        {
            BasquePig = basquePig;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pig" /> class.
        /// </summary>
        /// <param name="danishPig"></param>
        [JsonConstructor]
        internal Pig(DanishPig danishPig)
        {
            DanishPig = danishPig;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets BasquePig
        /// </summary>
        public BasquePig BasquePig { get; set; }

        /// <summary>
        /// Gets or Sets DanishPig
        /// </summary>
        public DanishPig DanishPig { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Pig {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Pig" />
    /// </summary>
    public class PigJsonConverter : JsonConverter<Pig>
    {
        /// <summary>
        /// Deserializes json to <see cref="Pig" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Pig Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        default:
                            break;
                    }
                }
            }

            Utf8JsonReader basquePigReader = utf8JsonReader;
            if (Client.ClientUtils.TryDeserialize<BasquePig>(ref basquePigReader, jsonSerializerOptions, out BasquePig basquePig))
                return new Pig(basquePig);

            Utf8JsonReader danishPigReader = utf8JsonReader;
            if (Client.ClientUtils.TryDeserialize<DanishPig>(ref danishPigReader, jsonSerializerOptions, out DanishPig danishPig))
                return new Pig(danishPig);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="Pig" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pig"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Pig pig, JsonSerializerOptions jsonSerializerOptions)
        {
            System.Text.Json.JsonSerializer.Serialize(writer, pig.BasquePig, jsonSerializerOptions);

            System.Text.Json.JsonSerializer.Serialize(writer, pig.DanishPig, jsonSerializerOptions);

        }
    }
}
