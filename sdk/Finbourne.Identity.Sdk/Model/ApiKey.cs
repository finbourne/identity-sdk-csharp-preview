/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2567
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
    /// The metadata of an API key
    /// </summary>
    [DataContract(Name = "ApiKey")]
    public partial class ApiKey : IEquatable<ApiKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="id">The unique Id of the API key (required).</param>
        /// <param name="displayName">The display name of the API key (required).</param>
        /// <param name="createdDate">The creation date of the API key (required).</param>
        /// <param name="deactivationDate">The deactivation date of the API key.</param>
        public ApiKey(string id = default(string), string displayName = default(string), DateTimeOffset createdDate = default(DateTimeOffset), DateTimeOffset? deactivationDate = default(DateTimeOffset?))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for ApiKey and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for ApiKey and cannot be null");
            this.CreatedDate = createdDate;
            this.DeactivationDate = deactivationDate;
        }

        /// <summary>
        /// The unique Id of the API key
        /// </summary>
        /// <value>The unique Id of the API key</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The display name of the API key
        /// </summary>
        /// <value>The display name of the API key</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The creation date of the API key
        /// </summary>
        /// <value>The creation date of the API key</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// The deactivation date of the API key
        /// </summary>
        /// <value>The deactivation date of the API key</value>
        [DataMember(Name = "deactivationDate", EmitDefaultValue = true)]
        public DateTimeOffset? DeactivationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKey {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(input as ApiKey);
        }

        /// <summary>
        /// Returns true if ApiKey instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.DeactivationDate != null)
                    hashCode = hashCode * 59 + this.DeactivationDate.GetHashCode();
                return hashCode;
            }
        }

    }
}
