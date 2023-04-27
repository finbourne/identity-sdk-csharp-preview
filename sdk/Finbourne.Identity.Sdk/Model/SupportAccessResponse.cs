/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2421
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
    /// Timestamped successful response to grant access to your account
    /// </summary>
    [DataContract(Name = "SupportAccessResponse")]
    public partial class SupportAccessResponse : IEquatable<SupportAccessResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportAccessResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportAccessResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportAccessResponse" /> class.
        /// </summary>
        /// <param name="id">ID of the support access request (required).</param>
        /// <param name="duration">The duration for which access is requested (in any ISO-8601 format) (required).</param>
        /// <param name="description">The description of why the support access has been granted (i.e. support ticket numbers).</param>
        /// <param name="createdAt">DateTimeOffset at which the access was granted (required).</param>
        /// <param name="expiry">DateTimeOffset at which the access will be revoked (required).</param>
        /// <param name="createdBy">Obfuscated UserId of the user who granted the support access (required).</param>
        /// <param name="terminated">Whether or not that access has been invalidated.</param>
        /// <param name="terminatedAt">DateTimeOffset at which the access was invalidated.</param>
        /// <param name="terminatedBy">Obfuscated UserId of the user who revoked the access.</param>
        /// <param name="permittedRoles">A list of permitted roles, valid for support staff to assume, for the duration of the access request.</param>
        public SupportAccessResponse(string id = default(string), string duration = default(string), string description = default(string), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset expiry = default(DateTimeOffset), string createdBy = default(string), bool terminated = default(bool), DateTimeOffset? terminatedAt = default(DateTimeOffset?), string terminatedBy = default(string), List<string> permittedRoles = default(List<string>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for SupportAccessResponse and cannot be null");
            // to ensure "duration" is required (not null)
            this.Duration = duration ?? throw new ArgumentNullException("duration is a required property for SupportAccessResponse and cannot be null");
            this.CreatedAt = createdAt;
            this.Expiry = expiry;
            // to ensure "createdBy" is required (not null)
            this.CreatedBy = createdBy ?? throw new ArgumentNullException("createdBy is a required property for SupportAccessResponse and cannot be null");
            this.Description = description;
            this.Terminated = terminated;
            this.TerminatedAt = terminatedAt;
            this.TerminatedBy = terminatedBy;
            this.PermittedRoles = permittedRoles;
        }

        /// <summary>
        /// ID of the support access request
        /// </summary>
        /// <value>ID of the support access request</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

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
        /// DateTimeOffset at which the access was granted
        /// </summary>
        /// <value>DateTimeOffset at which the access was granted</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// DateTimeOffset at which the access will be revoked
        /// </summary>
        /// <value>DateTimeOffset at which the access will be revoked</value>
        [DataMember(Name = "expiry", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Expiry { get; set; }

        /// <summary>
        /// Obfuscated UserId of the user who granted the support access
        /// </summary>
        /// <value>Obfuscated UserId of the user who granted the support access</value>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Whether or not that access has been invalidated
        /// </summary>
        /// <value>Whether or not that access has been invalidated</value>
        [DataMember(Name = "terminated", EmitDefaultValue = true)]
        public bool Terminated { get; set; }

        /// <summary>
        /// DateTimeOffset at which the access was invalidated
        /// </summary>
        /// <value>DateTimeOffset at which the access was invalidated</value>
        [DataMember(Name = "terminatedAt", EmitDefaultValue = true)]
        public DateTimeOffset? TerminatedAt { get; set; }

        /// <summary>
        /// Obfuscated UserId of the user who revoked the access
        /// </summary>
        /// <value>Obfuscated UserId of the user who revoked the access</value>
        [DataMember(Name = "terminatedBy", EmitDefaultValue = true)]
        public string TerminatedBy { get; set; }

        /// <summary>
        /// A list of permitted roles, valid for support staff to assume, for the duration of the access request
        /// </summary>
        /// <value>A list of permitted roles, valid for support staff to assume, for the duration of the access request</value>
        [DataMember(Name = "permittedRoles", EmitDefaultValue = true)]
        public List<string> PermittedRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportAccessResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Terminated: ").Append(Terminated).Append("\n");
            sb.Append("  TerminatedAt: ").Append(TerminatedAt).Append("\n");
            sb.Append("  TerminatedBy: ").Append(TerminatedBy).Append("\n");
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
            return this.Equals(input as SupportAccessResponse);
        }

        /// <summary>
        /// Returns true if SupportAccessResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportAccessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportAccessResponse input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Terminated == input.Terminated ||
                    this.Terminated.Equals(input.Terminated)
                ) && 
                (
                    this.TerminatedAt == input.TerminatedAt ||
                    (this.TerminatedAt != null &&
                    this.TerminatedAt.Equals(input.TerminatedAt))
                ) && 
                (
                    this.TerminatedBy == input.TerminatedBy ||
                    (this.TerminatedBy != null &&
                    this.TerminatedBy.Equals(input.TerminatedBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Expiry != null)
                    hashCode = hashCode * 59 + this.Expiry.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.Terminated.GetHashCode();
                if (this.TerminatedAt != null)
                    hashCode = hashCode * 59 + this.TerminatedAt.GetHashCode();
                if (this.TerminatedBy != null)
                    hashCode = hashCode * 59 + this.TerminatedBy.GetHashCode();
                if (this.PermittedRoles != null)
                    hashCode = hashCode * 59 + this.PermittedRoles.GetHashCode();
                return hashCode;
            }
        }

    }
}
