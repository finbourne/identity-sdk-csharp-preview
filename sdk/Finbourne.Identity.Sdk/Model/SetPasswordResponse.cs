/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2996
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
    /// The result of setting a password
    /// </summary>
    [DataContract(Name = "SetPasswordResponse")]
    public partial class SetPasswordResponse : IEquatable<SetPasswordResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPasswordResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetPasswordResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPasswordResponse" /> class.
        /// </summary>
        /// <param name="updatedAt">The date and time at which the password was successfully updated (required).</param>
        /// <param name="links">links.</param>
        public SetPasswordResponse(DateTimeOffset updatedAt = default(DateTimeOffset), List<Link> links = default(List<Link>))
        {
            this.UpdatedAt = updatedAt;
            this.Links = links;
        }

        /// <summary>
        /// The date and time at which the password was successfully updated
        /// </summary>
        /// <value>The date and time at which the password was successfully updated</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPasswordResponse {\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as SetPasswordResponse);
        }

        /// <summary>
        /// Returns true if SetPasswordResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SetPasswordResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPasswordResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
