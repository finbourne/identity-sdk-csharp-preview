/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2940
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
    /// TemporaryPassword
    /// </summary>
    [DataContract(Name = "TemporaryPassword")]
    public partial class TemporaryPassword : IEquatable<TemporaryPassword>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryPassword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemporaryPassword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryPassword" /> class.
        /// </summary>
        /// <param name="password">The user&#39;s temporary password (required).</param>
        public TemporaryPassword(string password = default(string))
        {
            // to ensure "password" is required (not null)
            this.Password = password ?? throw new ArgumentNullException("password is a required property for TemporaryPassword and cannot be null");
        }

        /// <summary>
        /// The user&#39;s temporary password
        /// </summary>
        /// <value>The user&#39;s temporary password</value>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemporaryPassword {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as TemporaryPassword);
        }

        /// <summary>
        /// Returns true if TemporaryPassword instances are equal
        /// </summary>
        /// <param name="input">Instance of TemporaryPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemporaryPassword input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }

    }
}
