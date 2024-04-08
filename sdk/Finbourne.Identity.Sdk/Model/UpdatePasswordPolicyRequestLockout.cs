/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2850
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
    /// UpdatePasswordPolicyRequestLockout
    /// </summary>
    [DataContract(Name = "UpdatePasswordPolicyRequestLockout")]
    public partial class UpdatePasswordPolicyRequestLockout : IEquatable<UpdatePasswordPolicyRequestLockout>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestLockout" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePasswordPolicyRequestLockout() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestLockout" /> class.
        /// </summary>
        /// <param name="maxAttempts">The maximum number of unsuccessful attempts before the user is locked out of their account.  0 indicates no limit (required).</param>
        public UpdatePasswordPolicyRequestLockout(int maxAttempts = default(int))
        {
            this.MaxAttempts = maxAttempts;
        }

        /// <summary>
        /// The maximum number of unsuccessful attempts before the user is locked out of their account.  0 indicates no limit
        /// </summary>
        /// <value>The maximum number of unsuccessful attempts before the user is locked out of their account.  0 indicates no limit</value>
        [DataMember(Name = "maxAttempts", IsRequired = true, EmitDefaultValue = true)]
        public int MaxAttempts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordPolicyRequestLockout {\n");
            sb.Append("  MaxAttempts: ").Append(MaxAttempts).Append("\n");
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
            return this.Equals(input as UpdatePasswordPolicyRequestLockout);
        }

        /// <summary>
        /// Returns true if UpdatePasswordPolicyRequestLockout instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePasswordPolicyRequestLockout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePasswordPolicyRequestLockout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxAttempts == input.MaxAttempts ||
                    this.MaxAttempts.Equals(input.MaxAttempts)
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
                hashCode = hashCode * 59 + this.MaxAttempts.GetHashCode();
                return hashCode;
            }
        }

    }
}
