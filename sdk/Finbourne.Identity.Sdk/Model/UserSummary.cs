/*
 * FINBOURNE Identity Service API
 *
 * ### Introduction     # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"238\">238</a>|Max User Api Key Limit Reached|  | | <a name=\"239\">239</a>|API Key not found|  | | <a name=\"657\">657</a>|User does not exist|The specified user does not exist | | <a name=\"658\">658</a>|User already exists|A user with the specified identifier already exists | | <a name=\"659\">659</a>|API Key display name already in use|There is already an active API Key with the specified display name | | <a name=\"660\">660</a>|Role does not exist|The specified role does not exist | | <a name=\"661\">661</a>|Role does not exist in identity provider|One or more of the roles specified do not exist in your identity provider (Okta) | | <a name=\"662\">662</a>|Application does not exist|The specified application does not exist | | <a name=\"663\">663</a>|Token does not exist|The specified domain token does not exist | | <a name=\"679\">679</a>|Single Sign-on (SSO) Incorrectly Configured|This condition is encountered when the necessary configuration required to enable Single Sign-on (SSO) for your LUSID account is missing or not complete. To resolve this you will need to contact your LUSID administrator or LUSID Support to request that the correct configuration is applied. | | <a name=\"680\">680</a>|Identity Provider Not Found|The specified identity provider does not exist | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"705\">705</a>|User In A Deleted State|  | | <a name=\"706\">706</a>|User is not locked out|  | | <a name=\"707\">707</a>|User is already activated|  | | <a name=\"717\">717</a>|User's status is invalid for the given operation|  | | <a name=\"718\">718</a>|User's status is invalid for resetting the user's password|  | | <a name=\"719\">719</a>|User's status is invalid for expiring the user's password|  | | <a name=\"784\">784</a>|Cannot update password|  | | <a name=\"785\">785</a>|Incorrect authentication type for action|  | | <a name=\"786\">786</a>|Action not valid for user of this type|  | | <a name=\"787\">787</a>|Password validation failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"2153\">2153</a>|Invalid Authentication Token|  | | <a name=\"2154\">2154</a>|Invalid Identity Provider Access Token|  | | <a name=\"2200\">2200</a>|Tenant Scheduler Domain Job Error|  | 
 *
 * The version of the OpenAPI document: 0.0.3040
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
    /// Lightweight view of an user details
    /// </summary>
    [DataContract(Name = "UserSummary")]
    public partial class UserSummary : IEquatable<UserSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSummary" /> class.
        /// </summary>
        /// <param name="id">The user id.</param>
        /// <param name="login">The user login.</param>
        /// <param name="email">The email address registered for that user.</param>
        /// <param name="secondEmail">secondEmail.</param>
        /// <param name="firstName">User&#39;s first name.</param>
        /// <param name="lastName">User&#39;s last name.</param>
        /// <param name="type">User&#39;s type (Personal, Service...).</param>
        /// <param name="alternativeUserIds">User&#39;s alternative user IDs. Only returned for the current user.</param>
        /// <param name="links">links.</param>
        public UserSummary(string id = default(string), string login = default(string), string email = default(string), string secondEmail = default(string), string firstName = default(string), string lastName = default(string), string type = default(string), Dictionary<string, string> alternativeUserIds = default(Dictionary<string, string>), List<Link> links = default(List<Link>))
        {
            this.Id = id;
            this.Login = login;
            this.Email = email;
            this.SecondEmail = secondEmail;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Type = type;
            this.AlternativeUserIds = alternativeUserIds;
            this.Links = links;
        }

        /// <summary>
        /// The user id
        /// </summary>
        /// <value>The user id</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The user login
        /// </summary>
        /// <value>The user login</value>
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The email address registered for that user
        /// </summary>
        /// <value>The email address registered for that user</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets SecondEmail
        /// </summary>
        [DataMember(Name = "secondEmail", EmitDefaultValue = true)]
        public string SecondEmail { get; set; }

        /// <summary>
        /// User&#39;s first name
        /// </summary>
        /// <value>User&#39;s first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// User&#39;s last name
        /// </summary>
        /// <value>User&#39;s last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// User&#39;s type (Personal, Service...)
        /// </summary>
        /// <value>User&#39;s type (Personal, Service...)</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// User&#39;s alternative user IDs. Only returned for the current user
        /// </summary>
        /// <value>User&#39;s alternative user IDs. Only returned for the current user</value>
        [DataMember(Name = "alternativeUserIds", EmitDefaultValue = true)]
        public Dictionary<string, string> AlternativeUserIds { get; set; }

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
            sb.Append("class UserSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SecondEmail: ").Append(SecondEmail).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AlternativeUserIds: ").Append(AlternativeUserIds).Append("\n");
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
            return this.Equals(input as UserSummary);
        }

        /// <summary>
        /// Returns true if UserSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSummary input)
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
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SecondEmail == input.SecondEmail ||
                    (this.SecondEmail != null &&
                    this.SecondEmail.Equals(input.SecondEmail))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AlternativeUserIds == input.AlternativeUserIds ||
                    this.AlternativeUserIds != null &&
                    input.AlternativeUserIds != null &&
                    this.AlternativeUserIds.SequenceEqual(input.AlternativeUserIds)
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
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.SecondEmail != null)
                    hashCode = hashCode * 59 + this.SecondEmail.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AlternativeUserIds != null)
                    hashCode = hashCode * 59 + this.AlternativeUserIds.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
