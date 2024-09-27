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
    /// A request to create an application for authenticating the source of token requests
    /// </summary>
    [DataContract(Name = "CreateApplicationRequest")]
    public partial class CreateApplicationRequest : IEquatable<CreateApplicationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateApplicationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationRequest" /> class.
        /// </summary>
        /// <param name="displayName">The Display Name of the application (required).</param>
        /// <param name="clientId">The OpenID Connect ClientId of the application (required).</param>
        /// <param name="type">The Type of the application. This must be either Native or Web (required).</param>
        /// <param name="redirectUris">A web application&#39;s acceptable list of post-login redirect URIs.</param>
        /// <param name="postLogoutRedirectUris">A web application&#39;s acceptable list of post-logout redirect URIs.</param>
        public CreateApplicationRequest(string displayName = default(string), string clientId = default(string), string type = default(string), List<string> redirectUris = default(List<string>), List<string> postLogoutRedirectUris = default(List<string>))
        {
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for CreateApplicationRequest and cannot be null");
            // to ensure "clientId" is required (not null)
            this.ClientId = clientId ?? throw new ArgumentNullException("clientId is a required property for CreateApplicationRequest and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CreateApplicationRequest and cannot be null");
            this.RedirectUris = redirectUris;
            this.PostLogoutRedirectUris = postLogoutRedirectUris;
        }

        /// <summary>
        /// The Display Name of the application
        /// </summary>
        /// <value>The Display Name of the application</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The OpenID Connect ClientId of the application
        /// </summary>
        /// <value>The OpenID Connect ClientId of the application</value>
        [DataMember(Name = "clientId", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The Type of the application. This must be either Native or Web
        /// </summary>
        /// <value>The Type of the application. This must be either Native or Web</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// A web application&#39;s acceptable list of post-login redirect URIs
        /// </summary>
        /// <value>A web application&#39;s acceptable list of post-login redirect URIs</value>
        [DataMember(Name = "redirectUris", EmitDefaultValue = true)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// A web application&#39;s acceptable list of post-logout redirect URIs
        /// </summary>
        /// <value>A web application&#39;s acceptable list of post-logout redirect URIs</value>
        [DataMember(Name = "postLogoutRedirectUris", EmitDefaultValue = true)]
        public List<string> PostLogoutRedirectUris { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("  PostLogoutRedirectUris: ").Append(PostLogoutRedirectUris).Append("\n");
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
            return this.Equals(input as CreateApplicationRequest);
        }

        /// <summary>
        /// Returns true if CreateApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.RedirectUris == input.RedirectUris ||
                    this.RedirectUris != null &&
                    input.RedirectUris != null &&
                    this.RedirectUris.SequenceEqual(input.RedirectUris)
                ) && 
                (
                    this.PostLogoutRedirectUris == input.PostLogoutRedirectUris ||
                    this.PostLogoutRedirectUris != null &&
                    input.PostLogoutRedirectUris != null &&
                    this.PostLogoutRedirectUris.SequenceEqual(input.PostLogoutRedirectUris)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RedirectUris != null)
                    hashCode = hashCode * 59 + this.RedirectUris.GetHashCode();
                if (this.PostLogoutRedirectUris != null)
                    hashCode = hashCode * 59 + this.PostLogoutRedirectUris.GetHashCode();
                return hashCode;
            }
        }

    }
}
