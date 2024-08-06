/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2994
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
    [DataContract(Name = "UpdatePasswordPolicyRequestConditions")]
    public partial class UpdatePasswordPolicyRequestConditions : IEquatable<UpdatePasswordPolicyRequestConditions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestConditions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePasswordPolicyRequestConditions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestConditions" /> class.
        /// </summary>
        /// <param name="complexity">complexity (required).</param>
        /// <param name="age">age (required).</param>
        /// <param name="lockout">lockout (required).</param>
        public UpdatePasswordPolicyRequestConditions(UpdatePasswordPolicyRequestComplexity complexity = default(UpdatePasswordPolicyRequestComplexity), UpdatePasswordPolicyRequestAge age = default(UpdatePasswordPolicyRequestAge), UpdatePasswordPolicyRequestLockout lockout = default(UpdatePasswordPolicyRequestLockout))
        {
            // to ensure "complexity" is required (not null)
            this.Complexity = complexity ?? throw new ArgumentNullException("complexity is a required property for UpdatePasswordPolicyRequestConditions and cannot be null");
            // to ensure "age" is required (not null)
            this.Age = age ?? throw new ArgumentNullException("age is a required property for UpdatePasswordPolicyRequestConditions and cannot be null");
            // to ensure "lockout" is required (not null)
            this.Lockout = lockout ?? throw new ArgumentNullException("lockout is a required property for UpdatePasswordPolicyRequestConditions and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Complexity
        /// </summary>
        [DataMember(Name = "complexity", IsRequired = true, EmitDefaultValue = false)]
        public UpdatePasswordPolicyRequestComplexity Complexity { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name = "age", IsRequired = true, EmitDefaultValue = false)]
        public UpdatePasswordPolicyRequestAge Age { get; set; }

        /// <summary>
        /// Gets or Sets Lockout
        /// </summary>
        [DataMember(Name = "lockout", IsRequired = true, EmitDefaultValue = false)]
        public UpdatePasswordPolicyRequestLockout Lockout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordPolicyRequestConditions {\n");
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
            return this.Equals(input as UpdatePasswordPolicyRequestConditions);
        }

        /// <summary>
        /// Returns true if UpdatePasswordPolicyRequestConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePasswordPolicyRequestConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePasswordPolicyRequestConditions input)
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
