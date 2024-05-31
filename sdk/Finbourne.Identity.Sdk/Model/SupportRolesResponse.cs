/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2942
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
    /// SupportRolesResponse
    /// </summary>
    [DataContract(Name = "SupportRolesResponse")]
    public partial class SupportRolesResponse : IEquatable<SupportRolesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportRolesResponse" /> class.
        /// </summary>
        /// <param name="supportRoles">supportRoles.</param>
        public SupportRolesResponse(List<SupportRole> supportRoles = default(List<SupportRole>))
        {
            this.SupportRoles = supportRoles;
        }

        /// <summary>
        /// Gets or Sets SupportRoles
        /// </summary>
        [DataMember(Name = "supportRoles", EmitDefaultValue = true)]
        public List<SupportRole> SupportRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportRolesResponse {\n");
            sb.Append("  SupportRoles: ").Append(SupportRoles).Append("\n");
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
            return this.Equals(input as SupportRolesResponse);
        }

        /// <summary>
        /// Returns true if SupportRolesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportRolesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportRolesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportRoles == input.SupportRoles ||
                    this.SupportRoles != null &&
                    input.SupportRoles != null &&
                    this.SupportRoles.SequenceEqual(input.SupportRoles)
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
                if (this.SupportRoles != null)
                    hashCode = hashCode * 59 + this.SupportRoles.GetHashCode();
                return hashCode;
            }
        }

    }
}
