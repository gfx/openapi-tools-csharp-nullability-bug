/*
 * FastAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// HelloWorldResponse
    /// </summary>
    [DataContract(Name = "HelloWorldResponse")]
    public partial class HelloWorldResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HelloWorldResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HelloWorldResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HelloWorldResponse" /> class.
        /// </summary>
        /// <param name="message1">message1 (required).</param>
        /// <param name="message2">message2.</param>
        /// <param name="message3">message3 (required).</param>
        /// <param name="message4">message4.</param>
        public HelloWorldResponse(string message1 = default(string), string message2 = default(string), string message3 = default(string), string message4 = default(string))
        {
            // to ensure "message1" is required (not null)
            if (message1 == null)
            {
                throw new ArgumentNullException("message1 is a required property for HelloWorldResponse and cannot be null");
            }
            this.Message1 = message1;
            // to ensure "message3" is required (not null)
            if (message3 == null)
            {
                throw new ArgumentNullException("message3 is a required property for HelloWorldResponse and cannot be null");
            }
            this.Message3 = message3;
            this.Message2 = message2;
            this.Message4 = message4;
        }

        /// <summary>
        /// Gets or Sets Message1
        /// </summary>
        [DataMember(Name = "message1", IsRequired = true, EmitDefaultValue = true)]
        public string Message1 { get; set; }

        /// <summary>
        /// Gets or Sets Message2
        /// </summary>
        [DataMember(Name = "message2", EmitDefaultValue = true)]
        public string Message2 { get; set; }

        /// <summary>
        /// Gets or Sets Message3
        /// </summary>
        [DataMember(Name = "message3", IsRequired = true, EmitDefaultValue = true)]
        public string Message3 { get; set; }

        /// <summary>
        /// Gets or Sets Message4
        /// </summary>
        [DataMember(Name = "message4", EmitDefaultValue = true)]
        public string Message4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HelloWorldResponse {\n");
            sb.Append("  Message1: ").Append(Message1).Append("\n");
            sb.Append("  Message2: ").Append(Message2).Append("\n");
            sb.Append("  Message3: ").Append(Message3).Append("\n");
            sb.Append("  Message4: ").Append(Message4).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
