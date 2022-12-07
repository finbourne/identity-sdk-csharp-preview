/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2007
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
    /// RoleResponse
    /// </summary>
    [DataContract(Name = "RoleResponse")]
    public partial class RoleResponse : IEquatable<RoleResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        /// <param name="id">The role&#39;s system supplied unique identifier (required).</param>
        /// <param name="roleId">roleId (required).</param>
        /// <param name="source">The source of the role (required).</param>
        /// <param name="name">The role name, which must be unique within the system. (required).</param>
        /// <param name="description">The description for this role.</param>
        public RoleResponse(string id = default(string), RoleId roleId = default(RoleId), string source = default(string), string name = default(string), string description = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for RoleResponse and cannot be null");
            // to ensure "roleId" is required (not null)
            this.RoleId = roleId ?? throw new ArgumentNullException("roleId is a required property for RoleResponse and cannot be null");
            // to ensure "source" is required (not null)
            this.Source = source ?? throw new ArgumentNullException("source is a required property for RoleResponse and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for RoleResponse and cannot be null");
            this.Description = description;
        }

        /// <summary>
        /// The role&#39;s system supplied unique identifier
        /// </summary>
        /// <value>The role&#39;s system supplied unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name = "roleId", IsRequired = true, EmitDefaultValue = false)]
        public RoleId RoleId { get; set; }

        /// <summary>
        /// The source of the role
        /// </summary>
        /// <value>The source of the role</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// The role name, which must be unique within the system.
        /// </summary>
        /// <value>The role name, which must be unique within the system.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The description for this role
        /// </summary>
        /// <value>The description for this role</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as RoleResponse);
        }

        /// <summary>
        /// Returns true if RoleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleResponse input)
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
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

    }
}
