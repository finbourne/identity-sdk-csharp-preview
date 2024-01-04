/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2735
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
    /// Lightweight view of an user details
    /// </summary>
    [DataContract(Name = "UserSummary")]
    public partial class UserSummary : IEquatable<UserSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSummary" /> class.
        /// </summary>
        /// <param name="id">The user id.</param>
        /// <param name="login">The user login.</param>
        /// <param name="email">The email address registered for that user.</param>
        /// <param name="secondEmail">secondEmail.</param>
        /// <param name="firstName">User&#39;s first name.</param>
        /// <param name="lastName">User&#39;s last name.</param>
        /// <param name="type">User&#39;s type (Personal, Service...).</param>
        /// <param name="links">links.</param>
        public UserSummary(string id = default(string), string login = default(string), string email = default(string), string secondEmail = default(string), string firstName = default(string), string lastName = default(string), string type = default(string), List<Link> links = default(List<Link>))
        {
            this.Id = id;
            this.Login = login;
            this.Email = email;
            this.SecondEmail = secondEmail;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Type = type;
            this.Links = links;
        }

        /// <summary>
        /// The user id
        /// </summary>
        /// <value>The user id</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The user login
        /// </summary>
        /// <value>The user login</value>
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The email address registered for that user
        /// </summary>
        /// <value>The email address registered for that user</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets SecondEmail
        /// </summary>
        [DataMember(Name = "secondEmail", EmitDefaultValue = true)]
        public string SecondEmail { get; set; }

        /// <summary>
        /// User&#39;s first name
        /// </summary>
        /// <value>User&#39;s first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// User&#39;s last name
        /// </summary>
        /// <value>User&#39;s last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// User&#39;s type (Personal, Service...)
        /// </summary>
        /// <value>User&#39;s type (Personal, Service...)</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

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
            sb.Append("class UserSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SecondEmail: ").Append(SecondEmail).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as UserSummary);
        }

        /// <summary>
        /// Returns true if UserSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSummary input)
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
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SecondEmail == input.SecondEmail ||
                    (this.SecondEmail != null &&
                    this.SecondEmail.Equals(input.SecondEmail))
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.SecondEmail != null)
                    hashCode = hashCode * 59 + this.SecondEmail.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
