/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2882
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
    /// Time at which the support access granted for a role expires
    /// </summary>
    [DataContract(Name = "SupportAccessExpiryWithRole")]
    public partial class SupportAccessExpiryWithRole : IEquatable<SupportAccessExpiryWithRole>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportAccessExpiryWithRole" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportAccessExpiryWithRole() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportAccessExpiryWithRole" /> class.
        /// </summary>
        /// <param name="expiry">DateTimeOffset at which the access will be revoked (required).</param>
        /// <param name="permittedRole">Unique identifier for permitted role.   Use GET /identity/api/authentication/support-roles to lookup role label/code from identifier. (required).</param>
        public SupportAccessExpiryWithRole(DateTimeOffset expiry = default(DateTimeOffset), string permittedRole = default(string))
        {
            this.Expiry = expiry;
            // to ensure "permittedRole" is required (not null)
            this.PermittedRole = permittedRole ?? throw new ArgumentNullException("permittedRole is a required property for SupportAccessExpiryWithRole and cannot be null");
        }

        /// <summary>
        /// DateTimeOffset at which the access will be revoked
        /// </summary>
        /// <value>DateTimeOffset at which the access will be revoked</value>
        [DataMember(Name = "expiry", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Expiry { get; set; }

        /// <summary>
        /// Unique identifier for permitted role.   Use GET /identity/api/authentication/support-roles to lookup role label/code from identifier.
        /// </summary>
        /// <value>Unique identifier for permitted role.   Use GET /identity/api/authentication/support-roles to lookup role label/code from identifier.</value>
        [DataMember(Name = "permittedRole", IsRequired = true, EmitDefaultValue = false)]
        public string PermittedRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportAccessExpiryWithRole {\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  PermittedRole: ").Append(PermittedRole).Append("\n");
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
            return this.Equals(input as SupportAccessExpiryWithRole);
        }

        /// <summary>
        /// Returns true if SupportAccessExpiryWithRole instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportAccessExpiryWithRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportAccessExpiryWithRole input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
                ) && 
                (
                    this.PermittedRole == input.PermittedRole ||
                    (this.PermittedRole != null &&
                    this.PermittedRole.Equals(input.PermittedRole))
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
                if (this.Expiry != null)
                    hashCode = hashCode * 59 + this.Expiry.GetHashCode();
                if (this.PermittedRole != null)
                    hashCode = hashCode * 59 + this.PermittedRole.GetHashCode();
                return hashCode;
            }
        }

    }
}
