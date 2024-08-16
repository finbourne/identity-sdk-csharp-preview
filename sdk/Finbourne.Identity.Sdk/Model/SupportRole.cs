/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.3002
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
    /// SupportRole
    /// </summary>
    [DataContract(Name = "SupportRole")]
    public partial class SupportRole : IEquatable<SupportRole>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportRole" /> class.
        /// </summary>
        /// <param name="label">label.</param>
        /// <param name="description">description.</param>
        /// <param name="roleIdentifier">roleIdentifier.</param>
        /// <param name="internalIdentifier">internalIdentifier.</param>
        public SupportRole(string label = default(string), string description = default(string), Dictionary<string, string> roleIdentifier = default(Dictionary<string, string>), string internalIdentifier = default(string))
        {
            this.Label = label;
            this.Description = description;
            this.RoleIdentifier = roleIdentifier;
            this.InternalIdentifier = internalIdentifier;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RoleIdentifier
        /// </summary>
        [DataMember(Name = "roleIdentifier", EmitDefaultValue = true)]
        public Dictionary<string, string> RoleIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets InternalIdentifier
        /// </summary>
        [DataMember(Name = "internalIdentifier", EmitDefaultValue = true)]
        public string InternalIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportRole {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RoleIdentifier: ").Append(RoleIdentifier).Append("\n");
            sb.Append("  InternalIdentifier: ").Append(InternalIdentifier).Append("\n");
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
            return this.Equals(input as SupportRole);
        }

        /// <summary>
        /// Returns true if SupportRole instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportRole input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RoleIdentifier == input.RoleIdentifier ||
                    this.RoleIdentifier != null &&
                    input.RoleIdentifier != null &&
                    this.RoleIdentifier.SequenceEqual(input.RoleIdentifier)
                ) && 
                (
                    this.InternalIdentifier == input.InternalIdentifier ||
                    (this.InternalIdentifier != null &&
                    this.InternalIdentifier.Equals(input.InternalIdentifier))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RoleIdentifier != null)
                    hashCode = hashCode * 59 + this.RoleIdentifier.GetHashCode();
                if (this.InternalIdentifier != null)
                    hashCode = hashCode * 59 + this.InternalIdentifier.GetHashCode();
                return hashCode;
            }
        }

    }
}
