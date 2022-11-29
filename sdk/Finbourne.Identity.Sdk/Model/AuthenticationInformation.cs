/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1989
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
    /// AuthenticationInformation
    /// </summary>
    [DataContract(Name = "AuthenticationInformation")]
    public partial class AuthenticationInformation : IEquatable<AuthenticationInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticationInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationInformation" /> class.
        /// </summary>
        /// <param name="issuerUrl">issuerUrl (required).</param>
        /// <param name="samlIdentityProviderId">samlIdentityProviderId.</param>
        /// <param name="support">support.</param>
        /// <param name="supportAccessExpiryWithRole">supportAccessExpiryWithRole.</param>
        /// <param name="links">links.</param>
        public AuthenticationInformation(string issuerUrl = default(string), string samlIdentityProviderId = default(string), SupportAccessExpiry support = default(SupportAccessExpiry), List<SupportAccessExpiryWithRole> supportAccessExpiryWithRole = default(List<SupportAccessExpiryWithRole>), List<Link> links = default(List<Link>))
        {
            // to ensure "issuerUrl" is required (not null)
            this.IssuerUrl = issuerUrl ?? throw new ArgumentNullException("issuerUrl is a required property for AuthenticationInformation and cannot be null");
            this.SamlIdentityProviderId = samlIdentityProviderId;
            this.Support = support;
            this.SupportAccessExpiryWithRole = supportAccessExpiryWithRole;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets IssuerUrl
        /// </summary>
        [DataMember(Name = "issuerUrl", IsRequired = true, EmitDefaultValue = false)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// Gets or Sets SamlIdentityProviderId
        /// </summary>
        [DataMember(Name = "samlIdentityProviderId", EmitDefaultValue = true)]
        public string SamlIdentityProviderId { get; set; }

        /// <summary>
        /// Gets or Sets Support
        /// </summary>
        [DataMember(Name = "support", EmitDefaultValue = false)]
        public SupportAccessExpiry Support { get; set; }

        /// <summary>
        /// Gets or Sets SupportAccessExpiryWithRole
        /// </summary>
        [DataMember(Name = "supportAccessExpiryWithRole", EmitDefaultValue = true)]
        public List<SupportAccessExpiryWithRole> SupportAccessExpiryWithRole { get; set; }

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
            sb.Append("class AuthenticationInformation {\n");
            sb.Append("  IssuerUrl: ").Append(IssuerUrl).Append("\n");
            sb.Append("  SamlIdentityProviderId: ").Append(SamlIdentityProviderId).Append("\n");
            sb.Append("  Support: ").Append(Support).Append("\n");
            sb.Append("  SupportAccessExpiryWithRole: ").Append(SupportAccessExpiryWithRole).Append("\n");
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
            return this.Equals(input as AuthenticationInformation);
        }

        /// <summary>
        /// Returns true if AuthenticationInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssuerUrl == input.IssuerUrl ||
                    (this.IssuerUrl != null &&
                    this.IssuerUrl.Equals(input.IssuerUrl))
                ) && 
                (
                    this.SamlIdentityProviderId == input.SamlIdentityProviderId ||
                    (this.SamlIdentityProviderId != null &&
                    this.SamlIdentityProviderId.Equals(input.SamlIdentityProviderId))
                ) && 
                (
                    this.Support == input.Support ||
                    (this.Support != null &&
                    this.Support.Equals(input.Support))
                ) && 
                (
                    this.SupportAccessExpiryWithRole == input.SupportAccessExpiryWithRole ||
                    this.SupportAccessExpiryWithRole != null &&
                    input.SupportAccessExpiryWithRole != null &&
                    this.SupportAccessExpiryWithRole.SequenceEqual(input.SupportAccessExpiryWithRole)
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
                if (this.IssuerUrl != null)
                    hashCode = hashCode * 59 + this.IssuerUrl.GetHashCode();
                if (this.SamlIdentityProviderId != null)
                    hashCode = hashCode * 59 + this.SamlIdentityProviderId.GetHashCode();
                if (this.Support != null)
                    hashCode = hashCode * 59 + this.Support.GetHashCode();
                if (this.SupportAccessExpiryWithRole != null)
                    hashCode = hashCode * 59 + this.SupportAccessExpiryWithRole.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
