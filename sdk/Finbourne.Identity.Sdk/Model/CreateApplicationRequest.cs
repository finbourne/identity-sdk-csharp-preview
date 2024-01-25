/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2765
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
