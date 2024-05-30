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
    /// UserResponse
    /// </summary>
    [DataContract(Name = "UserResponse")]
    public partial class UserResponse : IEquatable<UserResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        /// <param name="id">The user&#39;s system supplied unique identifier (required).</param>
        /// <param name="emailAddress">The user&#39;s emailAddress address, which must be unique within the system (required).</param>
        /// <param name="secondEmailAddress">The user&#39;s second email address. Only allowed for service users..</param>
        /// <param name="login">login (required).</param>
        /// <param name="firstName">The user&#39;s first name (required).</param>
        /// <param name="lastName">The user&#39;s last name (required).</param>
        /// <param name="roles">The roles that the user has..</param>
        /// <param name="type">The type of user (e.g. Personal or Service) (required).</param>
        /// <param name="status">The status of the user (required).</param>
        /// <param name="external">Whether or not the user originates from an external identity system (required).</param>
        /// <param name="links">links.</param>
        public UserResponse(string id = default(string), string emailAddress = default(string), string secondEmailAddress = default(string), string login = default(string), string firstName = default(string), string lastName = default(string), List<RoleResponse> roles = default(List<RoleResponse>), string type = default(string), string status = default(string), bool external = default(bool), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for UserResponse and cannot be null");
            // to ensure "emailAddress" is required (not null)
            this.EmailAddress = emailAddress ?? throw new ArgumentNullException("emailAddress is a required property for UserResponse and cannot be null");
            // to ensure "login" is required (not null)
            this.Login = login ?? throw new ArgumentNullException("login is a required property for UserResponse and cannot be null");
            // to ensure "firstName" is required (not null)
            this.FirstName = firstName ?? throw new ArgumentNullException("firstName is a required property for UserResponse and cannot be null");
            // to ensure "lastName" is required (not null)
            this.LastName = lastName ?? throw new ArgumentNullException("lastName is a required property for UserResponse and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for UserResponse and cannot be null");
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for UserResponse and cannot be null");
            this.External = external;
            this.SecondEmailAddress = secondEmailAddress;
            this.Roles = roles;
            this.Links = links;
        }

        /// <summary>
        /// The user&#39;s system supplied unique identifier
        /// </summary>
        /// <value>The user&#39;s system supplied unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The user&#39;s emailAddress address, which must be unique within the system
        /// </summary>
        /// <value>The user&#39;s emailAddress address, which must be unique within the system</value>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s second email address. Only allowed for service users.
        /// </summary>
        /// <value>The user&#39;s second email address. Only allowed for service users.</value>
        [DataMember(Name = "secondEmailAddress", EmitDefaultValue = true)]
        public string SecondEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name = "login", IsRequired = true, EmitDefaultValue = false)]
        public string Login { get; set; }

        /// <summary>
        /// The user&#39;s first name
        /// </summary>
        /// <value>The user&#39;s first name</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user&#39;s last name
        /// </summary>
        /// <value>The user&#39;s last name</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The roles that the user has.
        /// </summary>
        /// <value>The roles that the user has.</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<RoleResponse> Roles { get; set; }

        /// <summary>
        /// The type of user (e.g. Personal or Service)
        /// </summary>
        /// <value>The type of user (e.g. Personal or Service)</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The status of the user
        /// </summary>
        /// <value>The status of the user</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Whether or not the user originates from an external identity system
        /// </summary>
        /// <value>Whether or not the user originates from an external identity system</value>
        [DataMember(Name = "external", IsRequired = true, EmitDefaultValue = true)]
        public bool External { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  SecondEmailAddress: ").Append(SecondEmailAddress).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as UserResponse);
        }

        /// <summary>
        /// Returns true if UserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.External == input.External ||
                    this.External.Equals(input.External)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.SecondEmailAddress != null)
                    hashCode = hashCode * 59 + this.SecondEmailAddress.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.External.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
