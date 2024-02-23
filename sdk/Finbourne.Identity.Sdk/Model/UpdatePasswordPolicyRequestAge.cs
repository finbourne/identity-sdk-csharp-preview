/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2802
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
    /// UpdatePasswordPolicyRequestAge
    /// </summary>
    [DataContract(Name = "UpdatePasswordPolicyRequestAge")]
    public partial class UpdatePasswordPolicyRequestAge : IEquatable<UpdatePasswordPolicyRequestAge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestAge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePasswordPolicyRequestAge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequestAge" /> class.
        /// </summary>
        /// <param name="maxAgeDays">The maximum age (in days) a password can be before expiring and needing to be changed.  0 indicates no limit (required).</param>
        /// <param name="historyCount">The number of unique passwords that need to be used before a previous password is permitted again.  0 indicates none (required).</param>
        public UpdatePasswordPolicyRequestAge(int maxAgeDays = default(int), int historyCount = default(int))
        {
            this.MaxAgeDays = maxAgeDays;
            this.HistoryCount = historyCount;
        }

        /// <summary>
        /// The maximum age (in days) a password can be before expiring and needing to be changed.  0 indicates no limit
        /// </summary>
        /// <value>The maximum age (in days) a password can be before expiring and needing to be changed.  0 indicates no limit</value>
        [DataMember(Name = "maxAgeDays", IsRequired = true, EmitDefaultValue = true)]
        public int MaxAgeDays { get; set; }

        /// <summary>
        /// The number of unique passwords that need to be used before a previous password is permitted again.  0 indicates none
        /// </summary>
        /// <value>The number of unique passwords that need to be used before a previous password is permitted again.  0 indicates none</value>
        [DataMember(Name = "historyCount", IsRequired = true, EmitDefaultValue = true)]
        public int HistoryCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordPolicyRequestAge {\n");
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
            return this.Equals(input as UpdatePasswordPolicyRequestAge);
        }

        /// <summary>
        /// Returns true if UpdatePasswordPolicyRequestAge instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePasswordPolicyRequestAge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePasswordPolicyRequestAge input)
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