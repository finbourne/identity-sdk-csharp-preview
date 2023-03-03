/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2305
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
    /// Details necessary for creating a new user
    /// </summary>
    [DataContract(Name = "CreateUserRequest")]
    public partial class CreateUserRequest : IEquatable<CreateUserRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        /// <param name="firstName">The first name of the user (required).</param>
        /// <param name="lastName">The last name of the user (required).</param>
        /// <param name="emailAddress">The user&#39;s email address - to which the account validation email will be sent. For user accounts  this should exactly match the Login. (required).</param>
        /// <param name="secondEmailAddress">The user&#39;s second email address. Only allowed for Service users.</param>
        /// <param name="login">The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address. (required).</param>
        /// <param name="roles">Optional. Any known roles the user should be created with..</param>
        /// <param name="type">The type of user (e.g. Personal or Service) (required).</param>
        public CreateUserRequest(string firstName = default(string), string lastName = default(string), string emailAddress = default(string), string secondEmailAddress = default(string), string login = default(string), List<RoleId> roles = default(List<RoleId>), string type = default(string))
        {
            // to ensure "firstName" is required (not null)
            this.FirstName = firstName ?? throw new ArgumentNullException("firstName is a required property for CreateUserRequest and cannot be null");
            // to ensure "lastName" is required (not null)
            this.LastName = lastName ?? throw new ArgumentNullException("lastName is a required property for CreateUserRequest and cannot be null");
            // to ensure "emailAddress" is required (not null)
            this.EmailAddress = emailAddress ?? throw new ArgumentNullException("emailAddress is a required property for CreateUserRequest and cannot be null");
            // to ensure "login" is required (not null)
            this.Login = login ?? throw new ArgumentNullException("login is a required property for CreateUserRequest and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CreateUserRequest and cannot be null");
            this.SecondEmailAddress = secondEmailAddress;
            this.Roles = roles;
        }

        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The user&#39;s email address - to which the account validation email will be sent. For user accounts  this should exactly match the Login.
        /// </summary>
        /// <value>The user&#39;s email address - to which the account validation email will be sent. For user accounts  this should exactly match the Login.</value>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s second email address. Only allowed for Service users
        /// </summary>
        /// <value>The user&#39;s second email address. Only allowed for Service users</value>
        [DataMember(Name = "secondEmailAddress", EmitDefaultValue = true)]
        public string SecondEmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address.</value>
        [DataMember(Name = "login", IsRequired = true, EmitDefaultValue = false)]
        public string Login { get; set; }

        /// <summary>
        /// Optional. Any known roles the user should be created with.
        /// </summary>
        /// <value>Optional. Any known roles the user should be created with.</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<RoleId> Roles { get; set; }

        /// <summary>
        /// The type of user (e.g. Personal or Service)
        /// </summary>
        /// <value>The type of user (e.g. Personal or Service)</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserRequest {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  SecondEmailAddress: ").Append(SecondEmailAddress).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateUserRequest);
        }

        /// <summary>
        /// Returns true if CreateUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.SecondEmailAddress == input.SecondEmailAddress ||
                    (this.SecondEmailAddress != null &&
                    this.SecondEmailAddress.Equals(input.SecondEmailAddress))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.SecondEmailAddress != null)
                    hashCode = hashCode * 59 + this.SecondEmailAddress.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }
}
