/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1785
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
    /// CreateDomainRequest
    /// </summary>
    [DataContract(Name = "CreateDomainRequest")]
    public partial class CreateDomainRequest : IEquatable<CreateDomainRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDomainRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainRequest" /> class.
        /// </summary>
        /// <param name="domain">The name LUSID domain to create (required).</param>
        /// <param name="description">Optional. Free text description of the domain..</param>
        /// <param name="companyName">The name of the company to which the domain is registered (required).</param>
        /// <param name="owner">owner (required).</param>
        /// <param name="technicalContact">technicalContact.</param>
        /// <param name="billingContact">billingContact.</param>
        /// <param name="signedAgreements">Optional. If Terms and Conditions agreements have been signed during the sign up process.</param>
        public CreateDomainRequest(string domain = default(string), string description = default(string), string companyName = default(string), CreateUserRequest owner = default(CreateUserRequest), CreateUserRequest technicalContact = default(CreateUserRequest), CreateUserRequest billingContact = default(CreateUserRequest), List<string> signedAgreements = default(List<string>))
        {
            // to ensure "domain" is required (not null)
            this.Domain = domain ?? throw new ArgumentNullException("domain is a required property for CreateDomainRequest and cannot be null");
            // to ensure "companyName" is required (not null)
            this.CompanyName = companyName ?? throw new ArgumentNullException("companyName is a required property for CreateDomainRequest and cannot be null");
            // to ensure "owner" is required (not null)
            this.Owner = owner ?? throw new ArgumentNullException("owner is a required property for CreateDomainRequest and cannot be null");
            this.Description = description;
            this.TechnicalContact = technicalContact;
            this.BillingContact = billingContact;
            this.SignedAgreements = signedAgreements;
        }

        /// <summary>
        /// The name LUSID domain to create
        /// </summary>
        /// <value>The name LUSID domain to create</value>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Optional. Free text description of the domain.
        /// </summary>
        /// <value>Optional. Free text description of the domain.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the company to which the domain is registered
        /// </summary>
        /// <value>The name of the company to which the domain is registered</value>
        [DataMember(Name = "companyName", IsRequired = true, EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = false)]
        public CreateUserRequest Owner { get; set; }

        /// <summary>
        /// Gets or Sets TechnicalContact
        /// </summary>
        [DataMember(Name = "technicalContact", EmitDefaultValue = false)]
        public CreateUserRequest TechnicalContact { get; set; }

        /// <summary>
        /// Gets or Sets BillingContact
        /// </summary>
        [DataMember(Name = "billingContact", EmitDefaultValue = false)]
        public CreateUserRequest BillingContact { get; set; }

        /// <summary>
        /// Optional. If Terms and Conditions agreements have been signed during the sign up process
        /// </summary>
        /// <value>Optional. If Terms and Conditions agreements have been signed during the sign up process</value>
        [DataMember(Name = "signedAgreements", EmitDefaultValue = true)]
        public List<string> SignedAgreements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDomainRequest {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  TechnicalContact: ").Append(TechnicalContact).Append("\n");
            sb.Append("  BillingContact: ").Append(BillingContact).Append("\n");
            sb.Append("  SignedAgreements: ").Append(SignedAgreements).Append("\n");
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
            return this.Equals(input as CreateDomainRequest);
        }

        /// <summary>
        /// Returns true if CreateDomainRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDomainRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDomainRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.TechnicalContact == input.TechnicalContact ||
                    (this.TechnicalContact != null &&
                    this.TechnicalContact.Equals(input.TechnicalContact))
                ) && 
                (
                    this.BillingContact == input.BillingContact ||
                    (this.BillingContact != null &&
                    this.BillingContact.Equals(input.BillingContact))
                ) && 
                (
                    this.SignedAgreements == input.SignedAgreements ||
                    this.SignedAgreements != null &&
                    input.SignedAgreements != null &&
                    this.SignedAgreements.SequenceEqual(input.SignedAgreements)
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.TechnicalContact != null)
                    hashCode = hashCode * 59 + this.TechnicalContact.GetHashCode();
                if (this.BillingContact != null)
                    hashCode = hashCode * 59 + this.BillingContact.GetHashCode();
                if (this.SignedAgreements != null)
                    hashCode = hashCode * 59 + this.SignedAgreements.GetHashCode();
                return hashCode;
            }
        }

    }
}
