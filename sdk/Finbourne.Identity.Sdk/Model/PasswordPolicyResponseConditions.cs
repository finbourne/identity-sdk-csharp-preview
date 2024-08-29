/*
 * FINBOURNE Identity Service API
 *
 * ### Introduction     # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"238\">238</a>|Max User Api Key Limit Reached|  | | <a name=\"239\">239</a>|API Key not found|  | | <a name=\"657\">657</a>|User does not exist|The specified user does not exist | | <a name=\"658\">658</a>|User already exists|A user with the specified identifier already exists | | <a name=\"659\">659</a>|API Key display name already in use|There is already an active API Key with the specified display name | | <a name=\"660\">660</a>|Role does not exist|The specified role does not exist | | <a name=\"661\">661</a>|Role does not exist in identity provider|One or more of the roles specified do not exist in your identity provider (Okta) | | <a name=\"662\">662</a>|Application does not exist|The specified application does not exist | | <a name=\"663\">663</a>|Token does not exist|The specified domain token does not exist | | <a name=\"679\">679</a>|Single Sign-on (SSO) Incorrectly Configured|This condition is encountered when the necessary configuration required to enable Single Sign-on (SSO) for your LUSID account is missing or not complete. To resolve this you will need to contact your LUSID administrator or LUSID Support to request that the correct configuration is applied. | | <a name=\"680\">680</a>|Identity Provider Not Found|The specified identity provider does not exist | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"705\">705</a>|User In A Deleted State|  | | <a name=\"706\">706</a>|User is not locked out|  | | <a name=\"707\">707</a>|User is already activated|  | | <a name=\"717\">717</a>|User's status is invalid for the given operation|  | | <a name=\"718\">718</a>|User's status is invalid for resetting the user's password|  | | <a name=\"719\">719</a>|User's status is invalid for expiring the user's password|  | | <a name=\"784\">784</a>|Cannot update password|  | | <a name=\"785\">785</a>|Incorrect authentication type for action|  | | <a name=\"786\">786</a>|Action not valid for user of this type|  | | <a name=\"787\">787</a>|Password validation failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"2153\">2153</a>|Invalid Authentication Token|  | | <a name=\"2154\">2154</a>|Invalid Identity Provider Access Token|  | | <a name=\"2200\">2200</a>|Tenant Scheduler Domain Job Error|  | 
 *
 * The version of the OpenAPI document: 0.0.3024
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
    /// Password policy conditions for a password policy
    /// </summary>
    [DataContract(Name = "PasswordPolicyResponseConditions")]
    public partial class PasswordPolicyResponseConditions : IEquatable<PasswordPolicyResponseConditions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyResponseConditions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordPolicyResponseConditions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyResponseConditions" /> class.
        /// </summary>
        /// <param name="complexity">complexity (required).</param>
        /// <param name="age">age (required).</param>
        /// <param name="lockout">lockout (required).</param>
        public PasswordPolicyResponseConditions(PasswordPolicyResponseComplexity complexity = default(PasswordPolicyResponseComplexity), PasswordPolicyResponseAge age = default(PasswordPolicyResponseAge), PasswordPolicyResponseLockout lockout = default(PasswordPolicyResponseLockout))
        {
            // to ensure "complexity" is required (not null)
            this.Complexity = complexity ?? throw new ArgumentNullException("complexity is a required property for PasswordPolicyResponseConditions and cannot be null");
            // to ensure "age" is required (not null)
            this.Age = age ?? throw new ArgumentNullException("age is a required property for PasswordPolicyResponseConditions and cannot be null");
            // to ensure "lockout" is required (not null)
            this.Lockout = lockout ?? throw new ArgumentNullException("lockout is a required property for PasswordPolicyResponseConditions and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Complexity
        /// </summary>
        [DataMember(Name = "complexity", IsRequired = true, EmitDefaultValue = false)]
        public PasswordPolicyResponseComplexity Complexity { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name = "age", IsRequired = true, EmitDefaultValue = false)]
        public PasswordPolicyResponseAge Age { get; set; }

        /// <summary>
        /// Gets or Sets Lockout
        /// </summary>
        [DataMember(Name = "lockout", IsRequired = true, EmitDefaultValue = false)]
        public PasswordPolicyResponseLockout Lockout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordPolicyResponseConditions {\n");
            sb.Append("  Complexity: ").Append(Complexity).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  Lockout: ").Append(Lockout).Append("\n");
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
            return this.Equals(input as PasswordPolicyResponseConditions);
        }

        /// <summary>
        /// Returns true if PasswordPolicyResponseConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyResponseConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyResponseConditions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Complexity == input.Complexity ||
                    (this.Complexity != null &&
                    this.Complexity.Equals(input.Complexity))
                ) && 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.Lockout == input.Lockout ||
                    (this.Lockout != null &&
                    this.Lockout.Equals(input.Lockout))
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
                if (this.Complexity != null)
                    hashCode = hashCode * 59 + this.Complexity.GetHashCode();
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.Lockout != null)
                    hashCode = hashCode * 59 + this.Lockout.GetHashCode();
                return hashCode;
            }
        }

    }
}
