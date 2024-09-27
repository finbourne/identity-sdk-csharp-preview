/*
 * FINBOURNE Identity Service API
 *
 * ### Introduction     # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"238\">238</a>|Max User Api Key Limit Reached|  | | <a name=\"239\">239</a>|API Key not found|  | | <a name=\"657\">657</a>|User does not exist|The specified user does not exist | | <a name=\"658\">658</a>|User already exists|A user with the specified identifier already exists | | <a name=\"659\">659</a>|API Key display name already in use|There is already an active API Key with the specified display name | | <a name=\"660\">660</a>|Role does not exist|The specified role does not exist | | <a name=\"661\">661</a>|Role does not exist in identity provider|One or more of the roles specified do not exist in your identity provider (Okta) | | <a name=\"662\">662</a>|Application does not exist|The specified application does not exist | | <a name=\"663\">663</a>|Token does not exist|The specified domain token does not exist | | <a name=\"679\">679</a>|Single Sign-on (SSO) Incorrectly Configured|This condition is encountered when the necessary configuration required to enable Single Sign-on (SSO) for your LUSID account is missing or not complete. To resolve this you will need to contact your LUSID administrator or LUSID Support to request that the correct configuration is applied. | | <a name=\"680\">680</a>|Identity Provider Not Found|The specified identity provider does not exist | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"705\">705</a>|User In A Deleted State|  | | <a name=\"706\">706</a>|User is not locked out|  | | <a name=\"707\">707</a>|User is already activated|  | | <a name=\"717\">717</a>|User's status is invalid for the given operation|  | | <a name=\"718\">718</a>|User's status is invalid for resetting the user's password|  | | <a name=\"719\">719</a>|User's status is invalid for expiring the user's password|  | | <a name=\"784\">784</a>|Cannot update password|  | | <a name=\"785\">785</a>|Incorrect authentication type for action|  | | <a name=\"786\">786</a>|Action not valid for user of this type|  | | <a name=\"787\">787</a>|Password validation failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"2153\">2153</a>|Invalid Authentication Token|  | | <a name=\"2154\">2154</a>|Invalid Identity Provider Access Token|  | | <a name=\"2200\">2200</a>|Tenant Scheduler Domain Job Error|  | 
 *
 * The version of the OpenAPI document: 0.0.3048
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
        /// <param name="fallbackIssuerUrls">fallbackIssuerUrls.</param>
        /// <param name="samlIdentityProviderId">samlIdentityProviderId.</param>
        /// <param name="support">support.</param>
        /// <param name="supportAccessExpiryWithRole">supportAccessExpiryWithRole.</param>
        /// <param name="links">links.</param>
        public AuthenticationInformation(string issuerUrl = default(string), List<string> fallbackIssuerUrls = default(List<string>), string samlIdentityProviderId = default(string), SupportAccessExpiry support = default(SupportAccessExpiry), List<SupportAccessExpiryWithRole> supportAccessExpiryWithRole = default(List<SupportAccessExpiryWithRole>), List<Link> links = default(List<Link>))
        {
            // to ensure "issuerUrl" is required (not null)
            this.IssuerUrl = issuerUrl ?? throw new ArgumentNullException("issuerUrl is a required property for AuthenticationInformation and cannot be null");
            this.FallbackIssuerUrls = fallbackIssuerUrls;
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
        /// Gets or Sets FallbackIssuerUrls
        /// </summary>
        [DataMember(Name = "fallbackIssuerUrls", EmitDefaultValue = true)]
        public List<string> FallbackIssuerUrls { get; set; }

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
            sb.Append("  FallbackIssuerUrls: ").Append(FallbackIssuerUrls).Append("\n");
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
                    this.FallbackIssuerUrls == input.FallbackIssuerUrls ||
                    this.FallbackIssuerUrls != null &&
                    input.FallbackIssuerUrls != null &&
                    this.FallbackIssuerUrls.SequenceEqual(input.FallbackIssuerUrls)
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
                if (this.FallbackIssuerUrls != null)
                    hashCode = hashCode * 59 + this.FallbackIssuerUrls.GetHashCode();
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
