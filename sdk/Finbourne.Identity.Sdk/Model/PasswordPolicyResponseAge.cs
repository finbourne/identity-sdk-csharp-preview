/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2816
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
    /// PasswordPolicyResponseAge
    /// </summary>
    [DataContract(Name = "PasswordPolicyResponseAge")]
    public partial class PasswordPolicyResponseAge : IEquatable<PasswordPolicyResponseAge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyResponseAge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordPolicyResponseAge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyResponseAge" /> class.
        /// </summary>
        /// <param name="maxAgeDays">The maximum age (in days) a password can be before expiring and needing to be changed (required).</param>
        /// <param name="historyCount">The number of unique passwords that need to be used before a previous password is permitted again (required).</param>
        public PasswordPolicyResponseAge(int maxAgeDays = default(int), int historyCount = default(int))
        {
            this.MaxAgeDays = maxAgeDays;
            this.HistoryCount = historyCount;
        }

        /// <summary>
        /// The maximum age (in days) a password can be before expiring and needing to be changed
        /// </summary>
        /// <value>The maximum age (in days) a password can be before expiring and needing to be changed</value>
        [DataMember(Name = "maxAgeDays", IsRequired = true, EmitDefaultValue = true)]
        public int MaxAgeDays { get; set; }

        /// <summary>
        /// The number of unique passwords that need to be used before a previous password is permitted again
        /// </summary>
        /// <value>The number of unique passwords that need to be used before a previous password is permitted again</value>
        [DataMember(Name = "historyCount", IsRequired = true, EmitDefaultValue = true)]
        public int HistoryCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordPolicyResponseAge {\n");
            sb.Append("  MaxAgeDays: ").Append(MaxAgeDays).Append("\n");
            sb.Append("  HistoryCount: ").Append(HistoryCount).Append("\n");
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
            return this.Equals(input as PasswordPolicyResponseAge);
        }

        /// <summary>
        /// Returns true if PasswordPolicyResponseAge instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyResponseAge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyResponseAge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxAgeDays == input.MaxAgeDays ||
                    this.MaxAgeDays.Equals(input.MaxAgeDays)
                ) && 
                (
                    this.HistoryCount == input.HistoryCount ||
                    this.HistoryCount.Equals(input.HistoryCount)
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
                hashCode = hashCode * 59 + this.MaxAgeDays.GetHashCode();
                hashCode = hashCode * 59 + this.HistoryCount.GetHashCode();
                return hashCode;
            }
        }

    }
}
