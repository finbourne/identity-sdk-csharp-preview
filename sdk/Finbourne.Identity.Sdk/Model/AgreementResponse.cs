/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1823
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
    /// Agreement DTO
    /// </summary>
    [DataContract(Name = "AgreementResponse")]
    public partial class AgreementResponse : IEquatable<AgreementResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementResponse" /> class.
        /// </summary>
        /// <param name="name">Name of the agreement.</param>
        /// <param name="signedBy">UserID (obfuscated) of the user who signed this agreement.</param>
        /// <param name="signedAt">Datetime at which the agreement was signed.</param>
        public AgreementResponse(string name = default(string), string signedBy = default(string), DateTimeOffset signedAt = default(DateTimeOffset))
        {
            this.Name = name;
            this.SignedBy = signedBy;
            this.SignedAt = signedAt;
        }

        /// <summary>
        /// Name of the agreement
        /// </summary>
        /// <value>Name of the agreement</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// UserID (obfuscated) of the user who signed this agreement
        /// </summary>
        /// <value>UserID (obfuscated) of the user who signed this agreement</value>
        [DataMember(Name = "signedBy", EmitDefaultValue = true)]
        public string SignedBy { get; set; }

        /// <summary>
        /// Datetime at which the agreement was signed
        /// </summary>
        /// <value>Datetime at which the agreement was signed</value>
        [DataMember(Name = "signedAt", EmitDefaultValue = false)]
        public DateTimeOffset SignedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgreementResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SignedBy: ").Append(SignedBy).Append("\n");
            sb.Append("  SignedAt: ").Append(SignedAt).Append("\n");
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
            return this.Equals(input as AgreementResponse);
        }

        /// <summary>
        /// Returns true if AgreementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AgreementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgreementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SignedBy == input.SignedBy ||
                    (this.SignedBy != null &&
                    this.SignedBy.Equals(input.SignedBy))
                ) && 
                (
                    this.SignedAt == input.SignedAt ||
                    (this.SignedAt != null &&
                    this.SignedAt.Equals(input.SignedAt))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SignedBy != null)
                    hashCode = hashCode * 59 + this.SignedBy.GetHashCode();
                if (this.SignedAt != null)
                    hashCode = hashCode * 59 + this.SignedAt.GetHashCode();
                return hashCode;
            }
        }

    }
}
