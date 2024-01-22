/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2759
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
    [DataContract(Name = "PasswordPolicyConditionsDto")]
    public partial class PasswordPolicyConditionsDto : IEquatable<PasswordPolicyConditionsDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyConditionsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordPolicyConditionsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyConditionsDto" /> class.
        /// </summary>
        /// <param name="complexity">complexity (required).</param>
        /// <param name="age">age (required).</param>
        /// <param name="lockout">lockout (required).</param>
        public PasswordPolicyConditionsDto(PasswordPolicyComplexityDto complexity = default(PasswordPolicyComplexityDto), PasswordPolicyAgeDto age = default(PasswordPolicyAgeDto), PasswordPolicyLockoutDto lockout = default(PasswordPolicyLockoutDto))
        {
            // to ensure "complexity" is required (not null)
            this.Complexity = complexity ?? throw new ArgumentNullException("complexity is a required property for PasswordPolicyConditionsDto and cannot be null");
            // to ensure "age" is required (not null)
            this.Age = age ?? throw new ArgumentNullException("age is a required property for PasswordPolicyConditionsDto and cannot be null");
            // to ensure "lockout" is required (not null)
            this.Lockout = lockout ?? throw new ArgumentNullException("lockout is a required property for PasswordPolicyConditionsDto and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Complexity
        /// </summary>
        [DataMember(Name = "complexity", IsRequired = true, EmitDefaultValue = false)]
        public PasswordPolicyComplexityDto Complexity { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name = "age", IsRequired = true, EmitDefaultValue = false)]
        public PasswordPolicyAgeDto Age { get; set; }

        /// <summary>
        /// Gets or Sets Lockout
        /// </summary>
        [DataMember(Name = "lockout", IsRequired = true, EmitDefaultValue = false)]
        public PasswordPolicyLockoutDto Lockout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordPolicyConditionsDto {\n");
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
            return this.Equals(input as PasswordPolicyConditionsDto);
        }

        /// <summary>
        /// Returns true if PasswordPolicyConditionsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyConditionsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyConditionsDto input)
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
