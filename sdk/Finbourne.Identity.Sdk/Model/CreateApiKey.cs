/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2788
 * Contact: info@finbourne.com
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
using OpenAPIDateConverter = Finbourne.Identity.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Identity.Sdk.Model
{
    /// <summary>
    /// Create an API key
    /// </summary>
    [DataContract(Name = "CreateApiKey")]
    public partial class CreateApiKey : IEquatable<CreateApiKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateApiKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKey" /> class.
        /// </summary>
        /// <param name="displayName">The display name for the API key (required).</param>
        /// <param name="deactivationDate">The optional date at which the key should deactivate.</param>
        public CreateApiKey(string displayName = default(string), DateTimeOffset? deactivationDate = default(DateTimeOffset?))
        {
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for CreateApiKey and cannot be null");
            this.DeactivationDate = deactivationDate;
        }

        /// <summary>
        /// The display name for the API key
        /// </summary>
        /// <value>The display name for the API key</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The optional date at which the key should deactivate
        /// </summary>
        /// <value>The optional date at which the key should deactivate</value>
        [DataMember(Name = "deactivationDate", EmitDefaultValue = true)]
        public DateTimeOffset? DeactivationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApiKey {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DeactivationDate: ").Append(DeactivationDate).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApiKey);
        }

        /// <summary>
        /// Returns true if CreateApiKey instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateApiKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateApiKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DeactivationDate == input.DeactivationDate ||
                    (this.DeactivationDate != null &&
                    this.DeactivationDate.Equals(input.DeactivationDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DeactivationDate != null)
                    hashCode = hashCode * 59 + this.DeactivationDate.GetHashCode();
                return hashCode;
            }
        }

    }
}
