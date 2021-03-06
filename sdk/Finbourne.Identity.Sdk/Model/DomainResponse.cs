/*
 * FINBOURNE Identity Service API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1795
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
    /// DomainResponse
    /// </summary>
    [DataContract(Name = "DomainResponse")]
    public partial class DomainResponse : IEquatable<DomainResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">A description of the domain.</param>
        /// <param name="companyName">The company name for the domain.</param>
        /// <param name="owner">owner.</param>
        /// <param name="billingContact">billingContact.</param>
        /// <param name="technicalContact">technicalContact.</param>
        /// <param name="created">The.</param>
        /// <param name="links">links.</param>
        public DomainResponse(DomainId id = default(DomainId), string description = default(string), string companyName = default(string), UserId owner = default(UserId), UserId billingContact = default(UserId), UserId technicalContact = default(UserId), DateTimeOffset created = default(DateTimeOffset), List<Link> links = default(List<Link>))
        {
            this.Id = id;
            this.Description = description;
            this.CompanyName = companyName;
            this.Owner = owner;
            this.BillingContact = billingContact;
            this.TechnicalContact = technicalContact;
            this.Created = created;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public DomainId Id { get; set; }

        /// <summary>
        /// A description of the domain
        /// </summary>
        /// <value>A description of the domain</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The company name for the domain
        /// </summary>
        /// <value>The company name for the domain</value>
        [DataMember(Name = "companyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public UserId Owner { get; set; }

        /// <summary>
        /// Gets or Sets BillingContact
        /// </summary>
        [DataMember(Name = "billingContact", EmitDefaultValue = false)]
        public UserId BillingContact { get; set; }

        /// <summary>
        /// Gets or Sets TechnicalContact
        /// </summary>
        [DataMember(Name = "technicalContact", EmitDefaultValue = false)]
        public UserId TechnicalContact { get; set; }

        /// <summary>
        /// The
        /// </summary>
        /// <value>The</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTimeOffset Created { get; set; }

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
            sb.Append("class DomainResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  BillingContact: ").Append(BillingContact).Append("\n");
            sb.Append("  TechnicalContact: ").Append(TechnicalContact).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(input as DomainResponse);
        }

        /// <summary>
        /// Returns true if DomainResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainResponse input)
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
                    this.BillingContact == input.BillingContact ||
                    (this.BillingContact != null &&
                    this.BillingContact.Equals(input.BillingContact))
                ) && 
                (
                    this.TechnicalContact == input.TechnicalContact ||
                    (this.TechnicalContact != null &&
                    this.TechnicalContact.Equals(input.TechnicalContact))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.BillingContact != null)
                    hashCode = hashCode * 59 + this.BillingContact.GetHashCode();
                if (this.TechnicalContact != null)
                    hashCode = hashCode * 59 + this.TechnicalContact.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
