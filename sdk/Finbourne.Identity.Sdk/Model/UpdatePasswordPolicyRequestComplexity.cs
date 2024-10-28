/*
 * FINBOURNE Identity Service API
 *
 * ### Introduction     # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"238\">238</a>|Max User Api Key Limit Reached|  | | <a name=\"239\">239</a>|API Key not found|  | | <a name=\"657\">657</a>|User does not exist|The specified user does not exist | | <a name=\"658\">658</a>|User already exists|A user with the specified identifier already exists | | <a name=\"659\">659</a>|API Key display name already in use|There is already an active API Key with the specified display name | | <a name=\"660\">660</a>|Role does not exist|The specified role does not exist | | <a name=\"661\">661</a>|Role does not exist in identity provider|One or more of the roles specified do not exist in your identity provider (Okta) | | <a name=\"662\">662</a>|Application does not exist|The specified application does not exist | | <a name=\"663\">663</a>|Token does not exist|The specified domain token does not exist | | <a name=\"679\">679</a>|Single Sign-on (SSO) Incorrectly Configured|This condition is encountered when the necessary configuration required to enable Single Sign-on (SSO) for your LUSID account is missing or not complete. To resolve this you will need to contact your LUSID administrator or LUSID Support to request that the correct configuration is applied. | | <a name=\"680\">680</a>|Identity Provider Not Found|The specified identity provider does not exist | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"705\">705</a>|User In A Deleted State|  | | <a name=\"706\">706</a>|User is not locked out|  | | <a name=\"707\">707</a>|User is already activated|  | | <a name=\"717\">717</a>|User's status is invalid for the given operation|  | | <a name=\"718\">718</a>|User's status is invalid for resetting the user's password|  | | <a name=\"719\">719</a>|User's status is invalid for expiring the user's password|  | | <a name=\"784\">784</a>|Cannot update password|  | | <a name=\"785\">785</a>|Incorrect authentication type for action|  | | <a name=\"786\">786</a>|Action not valid for user of this type|  | | <a name=\"787\">787</a>|Password validation failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"2153\">2153</a>|Invalid Authentication Token|  | | <a name=\"2154\">2154</a>|Invalid Identity Provider Access Token|  | | <a name=\"2200\">2200</a>|Tenant Scheduler Domain Job Error|  | 
 *
 * The version of the OpenAPI document: 0.0.3062
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
    /// UpdatePasswordPolicyRequestComplexity
    /// </summary>
    [DataContract(Name = "UpdatePasswordPolicyRequestComplexity")]
    public partial class UpdatePasswordPolicyRequestComplexity : IEquatable<UpdatePasswordPolicyRequestComplexity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestComplexity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePasswordPolicyRequestComplexity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestComplexity" /> class.
        /// </summary>
        /// <param name="minLength">The minimum length for a password (required).</param>
        /// <param name="excludeFirstName">Rule determining whether a user&#39;s first name should be permitted in their password (required).</param>
        /// <param name="excludeLastName">Rule determining whether a user&#39;s last name should be permitted in their password (required).</param>
        public UpdatePasswordPolicyRequestComplexity(int minLength = default(int), bool excludeFirstName = default(bool), bool excludeLastName = default(bool))
        {
            this.MinLength = minLength;
            this.ExcludeFirstName = excludeFirstName;
            this.ExcludeLastName = excludeLastName;
        }

        /// <summary>
        /// The minimum length for a password
        /// </summary>
        /// <value>The minimum length for a password</value>
        [DataMember(Name = "minLength", IsRequired = true, EmitDefaultValue = true)]
        public int MinLength { get; set; }

        /// <summary>
        /// Rule determining whether a user&#39;s first name should be permitted in their password
        /// </summary>
        /// <value>Rule determining whether a user&#39;s first name should be permitted in their password</value>
        [DataMember(Name = "excludeFirstName", IsRequired = true, EmitDefaultValue = true)]
        public bool ExcludeFirstName { get; set; }

        /// <summary>
        /// Rule determining whether a user&#39;s last name should be permitted in their password
        /// </summary>
        /// <value>Rule determining whether a user&#39;s last name should be permitted in their password</value>
        [DataMember(Name = "excludeLastName", IsRequired = true, EmitDefaultValue = true)]
        public bool ExcludeLastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordPolicyRequestComplexity {\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  ExcludeFirstName: ").Append(ExcludeFirstName).Append("\n");
            sb.Append("  ExcludeLastName: ").Append(ExcludeLastName).Append("\n");
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
            return this.Equals(input as UpdatePasswordPolicyRequestComplexity);
        }

        /// <summary>
        /// Returns true if UpdatePasswordPolicyRequestComplexity instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePasswordPolicyRequestComplexity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePasswordPolicyRequestComplexity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinLength == input.MinLength ||
                    this.MinLength.Equals(input.MinLength)
                ) && 
                (
                    this.ExcludeFirstName == input.ExcludeFirstName ||
                    this.ExcludeFirstName.Equals(input.ExcludeFirstName)
                ) && 
                (
                    this.ExcludeLastName == input.ExcludeLastName ||
                    this.ExcludeLastName.Equals(input.ExcludeLastName)
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
                hashCode = hashCode * 59 + this.MinLength.GetHashCode();
                hashCode = hashCode * 59 + this.ExcludeFirstName.GetHashCode();
                hashCode = hashCode * 59 + this.ExcludeLastName.GetHashCode();
                return hashCode;
            }
        }

    }
}
