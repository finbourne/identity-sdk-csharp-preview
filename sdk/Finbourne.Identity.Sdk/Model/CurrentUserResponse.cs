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
    /// CurrentUserResponse
    /// </summary>
    [DataContract(Name = "CurrentUserResponse")]
    public partial class CurrentUserResponse : IEquatable<CurrentUserResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrentUserResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserResponse" /> class.
        /// </summary>
        /// <param name="id">The user&#39;s system supplied unique identifier (required).</param>
        /// <param name="emailAddress">The user&#39;s email address which may be null depending on the authentication method (required).</param>
        /// <param name="type">The type of user (e.g. Personal or Service) (required).</param>
        /// <param name="domainType">The type of domain in which the user exists.</param>
        /// <param name="links">links.</param>
        public CurrentUserResponse(string id = default(string), string emailAddress = default(string), string type = default(string), string domainType = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for CurrentUserResponse and cannot be null");
            // to ensure "emailAddress" is required (not null)
            this.EmailAddress = emailAddress ?? throw new ArgumentNullException("emailAddress is a required property for CurrentUserResponse and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CurrentUserResponse and cannot be null");
            this.DomainType = domainType;
            this.Links = links;
        }

        /// <summary>
        /// The user&#39;s system supplied unique identifier
        /// </summary>
        /// <value>The user&#39;s system supplied unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The user&#39;s email address which may be null depending on the authentication method
        /// </summary>
        /// <value>The user&#39;s email address which may be null depending on the authentication method</value>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The type of user (e.g. Personal or Service)
        /// </summary>
        /// <value>The type of user (e.g. Personal or Service)</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The type of domain in which the user exists
        /// </summary>
        /// <value>The type of domain in which the user exists</value>
        [DataMember(Name = "domainType", EmitDefaultValue = true)]
        public string DomainType { get; set; }

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
            sb.Append("class CurrentUserResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DomainType: ").Append(DomainType).Append("\n");
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
            return this.Equals(input as CurrentUserResponse);
        }

        /// <summary>
        /// Returns true if CurrentUserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentUserResponse input)
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
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DomainType == input.DomainType ||
                    (this.DomainType != null &&
                    this.DomainType.Equals(input.DomainType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DomainType != null)
                    hashCode = hashCode * 59 + this.DomainType.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
