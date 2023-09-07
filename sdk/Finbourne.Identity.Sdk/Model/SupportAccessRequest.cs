/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2595
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
    /// A Request to grant support access to your account
    /// </summary>
    [DataContract(Name = "SupportAccessRequest")]
    public partial class SupportAccessRequest : IEquatable<SupportAccessRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportAccessRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportAccessRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportAccessRequest" /> class.
        /// </summary>
        /// <param name="duration">The duration for which access is requested (in any ISO-8601 format) (required).</param>
        /// <param name="description">The description of why the support access has been granted (i.e. support ticket numbers).</param>
        /// <param name="permittedRoles">permittedRoles.</param>
        public SupportAccessRequest(string duration = default(string), string description = default(string), List<string> permittedRoles = default(List<string>))
        {
            // to ensure "duration" is required (not null)
            this.Duration = duration ?? throw new ArgumentNullException("duration is a required property for SupportAccessRequest and cannot be null");
            this.Description = description;
            this.PermittedRoles = permittedRoles;
        }

        /// <summary>
        /// The duration for which access is requested (in any ISO-8601 format)
        /// </summary>
        /// <value>The duration for which access is requested (in any ISO-8601 format)</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// The description of why the support access has been granted (i.e. support ticket numbers)
        /// </summary>
        /// <value>The description of why the support access has been granted (i.e. support ticket numbers)</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PermittedRoles
        /// </summary>
        [DataMember(Name = "permittedRoles", EmitDefaultValue = true)]
        public List<string> PermittedRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportAccessRequest {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PermittedRoles: ").Append(PermittedRoles).Append("\n");
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
            return this.Equals(input as SupportAccessRequest);
        }

        /// <summary>
        /// Returns true if SupportAccessRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportAccessRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportAccessRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PermittedRoles == input.PermittedRoles ||
                    this.PermittedRoles != null &&
                    input.PermittedRoles != null &&
                    this.PermittedRoles.SequenceEqual(input.PermittedRoles)
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PermittedRoles != null)
                    hashCode = hashCode * 59 + this.PermittedRoles.GetHashCode();
                return hashCode;
            }
        }

    }
}
