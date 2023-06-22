// <auto-generated>
/*
 * Example
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
    /// A representation of a child
    /// </summary>
    public partial class Child : Person, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Child" /> class.
        /// </summary>
        /// <param name="age">age</param>
        /// <param name="firstName">firstName</param>
        /// <param name="lastName">lastName</param>
        /// <param name="type">type</param>
        /// <param name="boosterSeat">boosterSeat</param>
        [JsonConstructor]
        public Child(int age, string firstName, string lastName, string type, bool boosterSeat) : base(firstName, lastName, type)
        {
            Age = age;
            BoosterSeat = boosterSeat;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [JsonPropertyName("age")]
        public int Age { get; set; }

        /// <summary>
        /// Gets or Sets BoosterSeat
        /// </summary>
        [JsonPropertyName("boosterSeat")]
        public bool BoosterSeat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Child {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  BoosterSeat: ").Append(BoosterSeat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Child" />
    /// </summary>
    public class ChildJsonConverter : JsonConverter<Child>
    {
        /// <summary>
        /// Deserializes json to <see cref="Child" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Child Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            int? age = default;
            string? firstName = default;
            string? lastName = default;
            string? type = default;
            bool? boosterSeat = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "age":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                age = utf8JsonReader.GetInt32();
                            break;
                        case "firstName":
                            firstName = utf8JsonReader.GetString();
                            break;
                        case "lastName":
                            lastName = utf8JsonReader.GetString();
                            break;
                        case "$_type":
                            type = utf8JsonReader.GetString();
                            break;
                        case "boosterSeat":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                boosterSeat = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (age == null)
                throw new ArgumentNullException(nameof(age), "Property is required for class Child.");

            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName), "Property is required for class Child.");

            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName), "Property is required for class Child.");

            if (type == null)
                throw new ArgumentNullException(nameof(type), "Property is required for class Child.");

            if (boosterSeat == null)
                throw new ArgumentNullException(nameof(boosterSeat), "Property is required for class Child.");

            return new Child(age.Value, firstName, lastName, type, boosterSeat.Value);
        }

        /// <summary>
        /// Serializes a <see cref="Child" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="child"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Child child, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteNumber("age", child.Age);
            writer.WriteString("firstName", child.FirstName);
            writer.WriteString("lastName", child.LastName);
            writer.WriteString("$_type", child.Type);
            writer.WriteBoolean("boosterSeat", child.BoosterSeat);

            writer.WriteEndObject();
        }
    }
}
