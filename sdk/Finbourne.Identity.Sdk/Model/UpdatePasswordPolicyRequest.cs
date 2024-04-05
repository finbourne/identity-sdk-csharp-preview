/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2848
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
    /// UpdatePasswordPolicyRequest
    /// </summary>
    [DataContract(Name = "UpdatePasswordPolicyRequest")]
    public partial class UpdatePasswordPolicyRequest : IEquatable<UpdatePasswordPolicyRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePasswordPolicyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePasswordPolicyRequest" /> class.
        /// </summary>
        /// <param name="conditions">conditions (required).</param>
        public UpdatePasswordPolicyRequest(UpdatePasswordPolicyRequestConditions conditions = default(UpdatePasswordPolicyRequestConditions))
        {
            // to ensure "conditions" is required (not null)
            this.Conditions = conditions ?? throw new ArgumentNullException("conditions is a required property for UpdatePasswordPolicyRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", IsRequired = true, EmitDefaultValue = false)]
        public UpdatePasswordPolicyRequestConditions Conditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordPolicyRequest {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(input as UpdatePasswordPolicyRequest);
        }

        /// <summary>
        /// Returns true if UpdatePasswordPolicyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePasswordPolicyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePasswordPolicyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Conditions == input.Conditions ||
                    (this.Conditions != null &&
                    this.Conditions.Equals(input.Conditions))
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
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                return hashCode;
            }
        }

    }
}
